using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using mundo_veg.Models;

namespace mundo_veg.Controllers
{
    public class UsuarioPjsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public UsuarioPjsController(ApplicationDbContext context)
        {
            _context = context;
        }

     

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }



        // GET: UsuarioPjs
        public async Task<IActionResult> Index(string searchString)
        {
            var estabelecimentos = await _context.UsuarioPjs.ToListAsync();

            if (!String.IsNullOrEmpty(searchString))
            {
                estabelecimentos = estabelecimentos.Where(s => s.Nome.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)
                                       || s.Bairro.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)
                                       || s.Rua.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)
                                       || s.Cidade.Contains(searchString, StringComparison.CurrentCultureIgnoreCase)).ToList();
            }
            return View(estabelecimentos);
        }

        // GET: UsuarioPjs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UsuarioPjs == null)
            {
                return NotFound();
            }

            var usuarioPj = await _context.UsuarioPjs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPj == null)
            {
                return NotFound();
            }

            return View(usuarioPj);
        }

        // GET: UsuarioPjs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioPjs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CNPJ,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Horario_funcionamento,Faz_entrega,Tempo_entrega,Descricao,Contato,Senha")] UsuarioPj usuarioPj)
        {
            if (ModelState.IsValid)
            {
                var userPj = await _context.UsuarioPjs
                   .FirstOrDefaultAsync(m => m.Email == usuarioPj.Email);
                if (userPj != null)
                {
                    ViewBag.Message = "Esse email já foi cadastrado!";
                    return View(usuarioPj);
                }
                else
                {
                 var userPf = await _context.UsuarioPfs.FirstOrDefaultAsync(m=>m.Email == usuarioPj.Email);
                    if(userPf != null)
                    {
                        ViewBag.Message = "Esse email já foi cadastrado!";
                        return View(usuarioPj);
                    }
                }
                
                usuarioPj.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioPj.Senha);
                _context.Add(usuarioPj);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login","Login");
            }
            return View(usuarioPj);
        }

        // GET: UsuarioPjs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UsuarioPjs == null)
            {
                return NotFound();
            }

            var usuarioPj = await _context.UsuarioPjs.FindAsync(id);
            if (usuarioPj == null)
            {
                return NotFound();
            }
            return View(usuarioPj);
        }

        // POST: UsuarioPjs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
         public async Task<IActionResult> Edit(int id, [Bind("Id,CNPJ,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Horario_funcionamento,Faz_entrega,Tempo_entrega,Descricao,Contato,Senha")] UsuarioPj usuarioPj)
        {
            if (id != usuarioPj.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuarioPj.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioPj.Senha);

                    _context.Update(usuarioPj);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioPjExists(usuarioPj.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "UsuarioPjs", new { id = usuarioPj.Id });
            }
            return View(usuarioPj);

        }
        // GET: UsuarioPjs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UsuarioPjs == null)
            {
                return NotFound();
            }

            var usuarioPj = await _context.UsuarioPjs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPj == null)
            {
                return NotFound();
            }

            return View(usuarioPj);
        }

        // POST: UsuarioPjs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UsuarioPjs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UsuarioPjs'  is null.");
            }
            var usuarioPj = await _context.UsuarioPjs.FindAsync(id);

            if (usuarioPj != null)
            {
                _context.UsuarioPjs.Remove(usuarioPj);
            }

            await _context.SaveChangesAsync();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Index");
        }

        private bool UsuarioPjExists(int id)
        {
            return _context.UsuarioPjs.Any(e => e.Id == id);
        }
    }
}
