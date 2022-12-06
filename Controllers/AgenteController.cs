using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using NNAContext;

namespace NNA.Controllers
{
    [Authorize]
    public class AgenteController : Controller
    {
        private readonly NNA_Context _Context;

        public AgenteController(NNA_Context context)
        {
            _Context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<ActionResult> Denuncias()
        {
            var user = await _Context.Usuario.Where(x => x.Correo.Equals(User.Identity.Name)).FirstAsync();
            var mp = await _Context.MP.Where(x => x.IdUsuario.Equals(user.Id)).FirstAsync();
            var estatus = await _Context.Estatus.ToListAsync();
            var denuncias = await _Context.Denuncia.Where(x => x.IdMp.Equals(mp.Id)).ToListAsync();
            ViewData["denuncias"] = denuncias;
            ViewData["estatus"] = estatus;
            return View();
        }


    }
}
