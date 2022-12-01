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
    public class UsuarioPfsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioPfsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login([Bind("Email,Senha")] UsuarioPf usuario)
        {
            var user = await _context.UsuarioPfs
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

                var userPfIdentity = new ClaimsIdentity(claims, "login");

                ClaimsPrincipal principal = new ClaimsPrincipal(userPfIdentity);

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
            return RedirectToAction("Login", "UsuarioPfs");
        }

        [AllowAnonymous]
        public IActionResult AccessDenied()
        {
            return View();
    }
    


        // GET: UsuarioPfs
        public async Task<IActionResult> Index()
        {
              return View(await _context.UsuarioPfs.ToListAsync());
        }

        // GET: UsuarioPfs/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.UsuarioPfs == null)
            {
                return NotFound();
            }

            var usuarioPf = await _context.UsuarioPfs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPf == null)
            {
                return NotFound();
            }

            return View(usuarioPf);
        }

        // GET: UsuarioPfs/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuarioPfs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,CPF,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Categoria,Senha")] UsuarioPf usuarioPf)
        {
            if (ModelState.IsValid)
            {

                var userPj = await _context.UsuarioPjs
                   .FirstOrDefaultAsync(m => m.Email == usuarioPf.Email);
                if (userPj != null)
                {
                    ViewBag.Message = "Esse email já foi cadastrado!";
                    return View(usuarioPf);
                }
                else
                {
                    var userPf = await _context.UsuarioPfs.FirstOrDefaultAsync(m => m.Email == usuarioPf.Email);
                    if (userPf != null)
                    {
                        ViewBag.Message = "Esse email já foi cadastrado!";
                        return View(usuarioPf);
                    }
                }
                usuarioPf.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioPf.Senha);
                _context.Add(usuarioPf);
                await _context.SaveChangesAsync();
                return RedirectToAction("Login", "Login");
            }
            return View(usuarioPf);
        }

        // GET: UsuarioPfs/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null || _context.UsuarioPfs == null)
            {
                return NotFound();
            }

            var usuarioPf = await _context.UsuarioPfs.FindAsync(id);
            if (usuarioPf == null)
            {
                return NotFound();
            }
            return View(usuarioPf);
        }

        // POST: UsuarioPfs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,CPF,Nome,Email,Telefone,Rua,Numero,Bairro,Cidade,Estado,CEP,Categoria,Senha")] UsuarioPf usuarioPf)
        {
            if (id != usuarioPf.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    usuarioPf.Senha = BCrypt.Net.BCrypt.HashPassword(usuarioPf.Senha);
                    _context.Update(usuarioPf);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioPfExists(usuarioPf.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction("Details", "UsuarioPfs", new { id = usuarioPf.Id });
            }
            return View(usuarioPf);
        }

        // GET: UsuarioPfs/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null || _context.UsuarioPfs == null)
            {
                return NotFound();
            }

            var usuarioPf = await _context.UsuarioPfs
                .FirstOrDefaultAsync(m => m.Id == id);
            if (usuarioPf == null)
            {
                return NotFound();
            }

            return View(usuarioPf);
        }

        // POST: UsuarioPfs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            if (_context.UsuarioPfs == null)
            {
                return Problem("Entity set 'ApplicationDbContext.UsuarioPfs'  is null.");
            }
            var usuarioPf = await _context.UsuarioPfs.FindAsync(id);
            if (usuarioPf != null)
            {
                _context.UsuarioPfs.Remove(usuarioPf);
            }
            
            await _context.SaveChangesAsync();
            await HttpContext.SignOutAsync();
            return RedirectToAction("Create"); ;
        }

        private bool UsuarioPfExists(int id)
        {
          return _context.UsuarioPfs.Any(e => e.Id == id);
        }
    }
}
