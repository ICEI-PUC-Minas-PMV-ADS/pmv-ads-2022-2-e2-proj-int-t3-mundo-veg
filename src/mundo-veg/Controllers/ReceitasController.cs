using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mundo_veg.Models;

namespace mundo_veg.Controllers
{
    public class ReceitasController : Controller
    {
        private readonly ApplicationDbContext _context;
        private string _filePath;
        public ReceitasController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            _context = context;
        }

        // GET: Receitas
        public async Task<IActionResult> Index(string searchString)

        {
            var receitas = await _context.Receitas.ToListAsync();
            if(!String.IsNullOrEmpty(searchString))
            {
                receitas = receitas.Where(s=>s.Nome.Contains(searchString, StringComparison.CurrentCultureIgnoreCase) || s.Ingredientes.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
            return View(receitas);
        }

        // GET: Receitas/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // GET: Receitas/Create
        public IActionResult Create()
        {
            var user = HttpContext.User;
            var userRole = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;
            if (userRole == "pf")
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
          
        }

        // POST: Receitas/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Ingredientes,Modo_Preparo,Rendimento,Dificuldade,Tempo_Preparo,Categoria,Imagem")] Receita receita, IFormFile anexo)
        {
            var user = HttpContext.User;
            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid).Value;
            receita.ClienteId = int.Parse(userId);
            if (ModelState.IsValid)
            {

                if (!ValidaImagem(anexo))
                    return View(receita);
                var nomeImg = SalvarArquivo(anexo);
                receita.Imagem = nomeImg;

                _context.Add(receita);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }else
            {
                ViewBag.Message = "Erro ao cadastrar produto!";
            }
            return View(receita);

        }
        public bool ValidaImagem(IFormFile anexo)
        {
            switch (anexo.ContentType)
            {
                case "image/jpg":
                    return true;
                case "image/jpeg":
                    return true;
                case "image/bmp":
                    return true;
                case "image/png":
                    return true;
                default:
                    return false;
                    break;

            }
        }
        public string SalvarArquivo(IFormFile anexo)
        {
            var nome = Guid.NewGuid().ToString() + anexo.FileName;

            var filePath = _filePath + "\\imagens";

            if (!Directory.Exists(filePath)) ;
            {
                Directory.CreateDirectory(filePath);
            }

            using (var stream = System.IO.File.Create(filePath + "\\" + nome))
            {
                anexo.CopyToAsync(stream);
            }
            return nome;

        }
        // GET: Receitas/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas.FindAsync(id);
            if (receita == null)
            {
                return NotFound();
            }
            return View(receita);
        }
        
              

        // POST: Receitas/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Ingredientes,Modo_Preparo,Rendimento,Dificuldade,Tempo_Preparo,Categoria,Imagem")] Receita receita)
        {
            if (id != receita.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(receita);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ReceitaExists(receita.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(receita);
        }

        // GET: Receitas/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Receitas == null)
            {
                return NotFound();
            }

            var receita = await _context.Receitas
                .FirstOrDefaultAsync(m => m.Id == id);
            if (receita == null)
            {
                return NotFound();
            }

            return View(receita);
        }

        // POST: Receitas/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
           
            var receita = await _context.Receitas.FindAsync(id);
            string filePathName = _filePath + "\\imagens\\" + receita.Imagem;

          
            if (System.IO.File.Exists(filePathName))
                System.IO.File.Delete(filePathName);  

               _context.Receitas.Remove(receita);

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ReceitaExists(int id)
        {
            return _context.Receitas.Any(e => e.Id == id);
        }

    }

}