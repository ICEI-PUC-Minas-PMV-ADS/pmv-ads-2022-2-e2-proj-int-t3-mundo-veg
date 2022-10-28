using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using mundo_veg.Models;
using System.Security.Claims;

namespace mundo_veg.Controllers
{
    public class LoginController : Controller
    {
        private readonly ApplicationDbContext _context;

        public LoginController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Login(string email, string senha)
        {
            bool isSenhaOk;
            var userPf = await _context.UsuarioPfs
                .FirstOrDefaultAsync(m => m.Email == email);

            if (userPf == null)
            {
                var userPj = await _context.UsuarioPjs
                    .FirstOrDefaultAsync(m => m.Email == email);
                if (userPj == null)
                {
                    ViewBag.Message = "Usuário e/ou senha inválidos!";
                    return View();
                }
                else
                {
                    isSenhaOk = BCrypt.Net.BCrypt.Verify(senha, userPj.Senha);

                    if (isSenhaOk)
                    {
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, userPj.Nome),
                            new Claim(ClaimTypes.NameIdentifier, userPj.Nome),
                            new Claim(ClaimTypes.Sid, userPj.Id.ToString()),
                            new Claim(ClaimTypes.Role, "pj")
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
                }

            }
            else
            {
                isSenhaOk = BCrypt.Net.BCrypt.Verify(senha, userPf.Senha);
                if (isSenhaOk)
                {
                    var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, userPf.Nome),
                            new Claim(ClaimTypes.NameIdentifier, userPf.Nome),
                            new Claim(ClaimTypes.Sid, userPf.Id.ToString()),
                            new Claim(ClaimTypes.Role, "pf")
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
            }

            ViewBag.Message = "Usuário e/ou Senha inválidos!";
            return View();
        }

        [AllowAnonymous]
        public async Task<IActionResult> Logout()
        {
            await HttpContext.SignOutAsync();
            return RedirectToAction("Login", "Login");
        }

        public IActionResult Perfil()
        {
            var user = HttpContext.User;
            var userRole = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Role).Value;
            var userId = user.Claims.FirstOrDefault(c => c.Type == ClaimTypes.Sid).Value;

            if(userRole == "pj")
            {
                return RedirectToAction("Details", "UsuarioPjs", new { id = userId });
            }else
            {
                return RedirectToAction("Details", "UsuarioPfs", new { id = userId });
            }
            
        }
    }
}
