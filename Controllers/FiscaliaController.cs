using Microsoft.AspNetCore.Mvc;
using NNAContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Data;

namespace NNA.Controllers
{
    public class FiscaliaController : Controller
    {
        private readonly NNA_Context _Context;

        public FiscaliaController(NNA_Context context)
        {
            _Context = context;
        }
        public IActionResult Index()
        {
            return View();
        }


        public async Task<IActionResult> Denuncias()
        {
            var denuncias = await _Context.Denuncia.Where(x => x.Asignada.Equals(false)).OrderBy(x => x.Folio).ToListAsync();
            ViewData["denuncias"] = denuncias;
            return View();
        }


        public async Task<IActionResult> DenunciasMP(Guid IdMp)
        {
            var denuncias = await _Context.Denuncia.Where(x => x.IdMp.Equals(IdMp))
                .Join(_Context.MP, denuncia => denuncia.IdMp, mp => mp.Id, (denuncia, mp) => new { denuncia, mp })
                .Join(_Context.Estatus, DenunciaMp => DenunciaMp.denuncia.Estatus, estatus => estatus.Id, (DenunciaMp, estatus) => new DataAsignada
                {
                    Id = DenunciaMp.denuncia.Id,
                    Expediente = DenunciaMp.denuncia.Expediente,
                    Folio = DenunciaMp.denuncia.Folio,
                    Fecha = DenunciaMp.denuncia.Fecha,
                    Nombre = DenunciaMp.denuncia.Nombre,
                    Edad = DenunciaMp.denuncia.Edad,
                    Asignada = DenunciaMp.denuncia.Asignada,
                    IdCaso = DenunciaMp.denuncia.IdCaso,
                    IdEstatus = DenunciaMp.denuncia.Estatus,
                    NombreEstatus = estatus.Nombre,
                    IdMp = DenunciaMp.denuncia.IdMp,
                    NombreMP = DenunciaMp.mp.Nombre + " " + DenunciaMp.mp.ApellidoPaterno
                }).ToListAsync();
            ViewData["denuncias"] = denuncias;
            return View();
        }

        public async Task<IActionResult> MP()
        {
            List<DataMP> agentes = await _Context.MP.Where(x => x.Estatus.Equals(true))
                .Join(_Context.Unidades, agente => agente.IdUnidad, unidad => unidad.Id, (agente, unidad) => new { agente, unidad })
                .Join(_Context.Fiscalias, join1 => join1.unidad.IdFiscalia, fiscalia => fiscalia.Id, (join1, fiscalia) => new DataMP
                {
                    Id = join1.agente.Id.ToString(),
                    Unidad = join1.unidad.Nombre,
                    NombreCompleto =join1.agente.Nombre+" " + join1.agente.ApellidoPaterno + " " + join1.agente.ApellidoMaterno,
                    Fiscalia = fiscalia.Acronimo,
                    Estatus = join1.agente.Estatus.ToString(),
                }).ToListAsync();

            ViewData["agentes"] = agentes;
            return View();
        }

        public async Task<IActionResult> Asignadas()
        {
            var denuncias = await _Context.Denuncia
                .Join(_Context.MP, denuncia => denuncia.IdMp, mp => mp.Id, (denuncia, mp) => new { denuncia, mp })
                .Join(_Context.Estatus, DenunciaMp => DenunciaMp.denuncia.Estatus, estatus => estatus.Id, (DenunciaMp, estatus) => new DataAsignada
                {
                    Id = DenunciaMp.denuncia.Id,
                    Expediente = DenunciaMp.denuncia.Expediente,
                    Folio = DenunciaMp.denuncia.Folio,
                    Fecha = DenunciaMp.denuncia.Fecha,
                    Nombre = DenunciaMp.denuncia.Nombre,
                    Edad = DenunciaMp.denuncia.Edad,
                    Asignada = DenunciaMp.denuncia.Asignada,
                    IdCaso = DenunciaMp.denuncia.IdCaso,
                    IdEstatus = DenunciaMp.denuncia.Estatus,
                    NombreEstatus = estatus.Nombre,
                    IdMp = DenunciaMp.denuncia.IdMp,
                    NombreMP = DenunciaMp.mp.Nombre + " " + DenunciaMp.mp.ApellidoPaterno
                }).ToListAsync();
            ViewData["denuncias"] = denuncias;
            return View();
        }
    }

}
