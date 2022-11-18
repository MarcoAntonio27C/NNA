using Microsoft.AspNetCore.Mvc;
using Modelos;
using NNAContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace API.Controllers
{
    [Route("Api/[controller]")]
    [ApiController]
    public class DenunciaController : Controller
    {
        private readonly NNA_Context _context;

        public DenunciaController(NNA_Context dbContext)
        {
            _context = dbContext;
        }

        [HttpPost]

        public async Task<string> AddDenuncia(Denuncia denuncia)
        {
            Guid Id = new Guid();
            denuncia.Id = Id;
            denuncia.Fecha = DateTime.Now;

            _context.Denuncia.Add(denuncia);
            var x = await _context.SaveChangesAsync();

            if (x > 0)
            {
                return "{\"respuesta\":\"200\"}";
            }
            return "{\"respuesta\":\"9999\"}";
        }
    }
}
