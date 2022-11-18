using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NNA.Controllers
{
    public class DenunciaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
