using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mundo_veg.Models;

namespace mundo_veg.Controllers
{
    public class ProdutosController : Controller
    {
        private readonly ApplicationDbContext _context;
        private string _filePath;

        public ProdutosController(ApplicationDbContext context, IWebHostEnvironment env)
        {
            _filePath = env.WebRootPath;
            _context = context;
        }

        // GET: Produtos
        public async Task<IActionResult> Index(string searchString)
        {
            var produtos = await _context.Produtos.Include(a => a.Estabelecimento).ToListAsync();
            if (!String.IsNullOrEmpty(searchString))
            {
                produtos = produtos.Where(s=>s.Nome.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)||s.Descricao.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
              return View(produtos);
        }

        // GET: Produtos/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // GET: Produtos/Create
        public IActionResult Create()
        {
            var user = HttpContext.User;
            if (user != null)
            {
                var userRole = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;
                if (userRole == "pj")
                {
                    return View();
                }
                else
                {
                    return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // POST: Produtos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Nome,Quantidade,Descricao,Preco,Categoria,Imagem")] Produto produto, IFormFile anexo)
        {
            var user = HttpContext.User;
            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid).Value;
            produto.EstabelecimentoId = int.Parse(userId);
            if (ModelState.IsValid)
            {
                if (!ValidaImagem(anexo))
                    return View(produto);
                var nomeImg = SalvarArquivo(anexo);
                produto.Imagem = nomeImg;

                _context.Add(produto);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }else
            {
                ViewBag.Message = "Erro ao cadastrar produto!";
            }
            return View(produto);
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

        // GET: Produtos/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos.FindAsync(id);
            if (produto == null)
            {
                return NotFound();
            }
            return View(produto);
        }

        // POST: Produtos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Quantidade,Ingredientes,Preco,Categoria,Imagem")] Produto produto, IFormFile anexo)
        {
            if (id != produto.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    if (!ValidaImagemEdit(anexo))
                        return View(produto);
                    var nomeImg = SalvarArquivo(anexo);
                    produto.Imagem = nomeImg;
                

                    _context.Update(produto);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!ProdutoExists(produto.Id))
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
            return View(produto);
        }
        public bool ValidaImagemEdit(IFormFile anexo)
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
        public string SalvarArquivoEdit(IFormFile anexo)
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

        // GET: Produtos/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.Produtos == null)
            {
                return NotFound();
            }

            var produto = await _context.Produtos
                .FirstOrDefaultAsync(m => m.Id == id);
            if (produto == null)
            {
                return NotFound();
            }

            return View(produto);
        }

        // POST: Produtos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var produto = await _context.Produtos.FindAsync(id);
            string filePathName = _filePath + "\\imagens\\" + produto.Imagem;


            if (System.IO.File.Exists(filePathName))
                System.IO.File.Delete(filePathName);
            _context.Produtos.Remove(produto);
            
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool ProdutoExists(int id)
        {
          return _context.Produtos.Any(e => e.Id == id);
        }
    }
}
