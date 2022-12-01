using Microsoft.AspNetCore.Mvc;
using NNAContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NNA.Controllers
{
    public class FiscaliaController : Controller
    {
        private readonly NNA_Context _Context;

        public FiscaliaController(NNA_Context context)
        {
            _Context = context;
        }
        public async Task<IActionResult> IndexAsync()
        {
            var denuncias = await _Context.Denuncia.Where(x => x.Asignada.Equals(false)).OrderBy(x => x.Folio).ToListAsync();
            ViewData["denuncias"] = denuncias;
            return View();
        }
    }

}
