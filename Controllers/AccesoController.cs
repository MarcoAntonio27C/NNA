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
using System.Security.Cryptography;
using Microsoft.AspNetCore.Identity;

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
            //var x = await _Context.Usuario.Where(x => x.Correo.Equals(model.correo) && x.Contraseña.Equals(model.password)).ToListAsync();
            var x = await _Context.Usuario.Where(x => x.Correo.Equals(model.correo) && x.Contraseña.Equals(GetSHA256(model.password))).ToListAsync();
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

        public static string GetSHA256(string pass)
        {
            SHA256 sha256 = SHA256Managed.Create();
            ASCIIEncoding encoding = new ASCIIEncoding();
            byte[] stream = null;
            StringBuilder sb = new StringBuilder();
            stream = sha256.ComputeHash(encoding.GetBytes(pass));
            for (int i = 0; i < stream.Length; i++) sb.AppendFormat("{0:x2}", stream[i]);
            return sb.ToString();

        }

        [HttpGet]
        public IActionResult Password()
        {
            return View();
        }

        [HttpPost]
        public async Task<string> SetPassword(string password) {

            var user = await _Context.Usuario.Where(x => x.Correo.Equals(User.Identity.Name)).FirstAsync() ;
            user.Contraseña = GetSHA256(password);
            _Context.Entry(user).State = EntityState.Modified;
            var result = await _Context.SaveChangesAsync();
            return result.ToString(); ;
        }


        public async Task<IActionResult> Restablecer(Guid Iduser)
        {
            var user = await _Context.Usuario.FindAsync(Iduser);
            user.Contraseña = GetSHA256("123456789");
            _Context.Entry(user).State = EntityState.Modified;
            var result = await _Context.SaveChangesAsync();
            return RedirectToAction("Index", "Usuarios");
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
