using Microsoft.AspNetCore.Mvc;
using Modelos;
using NNAContext;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
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

            //var insert = await _context.Denuncia.FindAsync(denuncia.Id);
            //insert.NumeroDenuncia = "FGE/AppNNA/" + insert.Folio.ToString("D6") + "/" + DateTime.Now.Year;
            //_context.Entry(insert).State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            //x = await _context.SaveChangesAsync();

            if (x > 0)
            {
                return "{\"respuesta\":\"200\"}";
            }
            return "{\"respuesta\":\"9999\"}";
        }
    }
}
