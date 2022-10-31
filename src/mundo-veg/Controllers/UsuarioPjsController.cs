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

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] UsuarioPj usuario)
        {
            var user = await _context.UsuarioPjs
                .FirstOrDefaultAsync(m => m.Email == usuario.Email);

            if (user == null)
            {
                ViewBag.Message = "Usuário e/ou senha inválidos!";
                return View();
            }

            bool isSenhaOk = BCrypt.Net.BCrypt.Verify(usuario.Senha, user.Senha);

            if (isSenhaOk)
            {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, user.Nome),
                    new Claim(ClaimTypes.NameIdentifier, user.Nome),
                };

                var userPjIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userPjIdentity);

                var props = new AuthenticationProperties
                {
                    AllowRefresh = true,
                    ExpiresUtc = DateTime.Now.ToLocalTime().AddDays(7),
                    IsPersistent = true
                };

                await HttpContext.SignInAsync(principal, props);

                return Redirect("/");
            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "UsuarioPjs");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
        }



        // GET: UsuarioPjs
        public async Task<IActionResult> Index()
        {
            return View(await _context.UsuarioPjs.ToListAsync());
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
        public async Task<IActionResult> Create([Bind("Id,CNPJ,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Horario_funcionamento,Faz_entrega,Tempo_entrega,Descricao,Senha")] UsuarioPj usuarioPj)
        {
            if (ModelState.IsValid)
            {
                usuarioPj.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioPj.Senha);
                _context.Add(usuarioPj);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
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
         public async Task<IActionResult> Edit(int id, [Bind("Id,CNPJ,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Horario_funcionamento,Faz_entrega,Tempo_entrega,Descricao,Senha")] UsuarioPj usuarioPj)
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
                return RedirectToAction(nameof(Index));
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
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioPjExists(int id)
        {
            return _context.UsuarioPjs.Any(e => e.Id == id);
        }
    }
}
