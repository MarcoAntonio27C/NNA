using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using NNAContext;

namespace NNA.Controllers
{
    public class AccesoController : Controller
    {
        private readonly  NNA_Context _Context;

        public AccesoController(NNA_Context context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> ValidarAsync(Model model)
        {
            var x = await _Context.Usuario.Where(x => x.Correo.Equals(model.correo) && x.Contraseña.Equals(model.password)).ToListAsync();
            if (x.Count() == 1) {
                var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name,  x.First().Correo),
                    new Claim(ClaimTypes.Role,x.First().IdRol.ToString().ToUpper())
            };

                var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
                await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, new ClaimsPrincipal(claimsIdentity));
                return "true";
            } 
            return "false";
        }


        public async Task<IActionResult> Salir()
        {
            await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
            return RedirectToAction("Index", "Acceso");
        }
    }




    public class Model
    {
        public string correo { get; set; }
        public string password { get; set; }
    }
}
