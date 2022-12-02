using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using NNA.Models;
using Microsoft.AspNetCore.Authorization;

namespace NNA.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            if(User.IsInRole(("49ecfee1-61f3-4e38-a28a-fe74c1bcb02c").ToString().ToUpper())){
                return RedirectToAction("Index", "Fiscalia");
            }
            if (User.IsInRole(("73e08b06-a8c8-4960-9708-d77d4f938f0c").ToString().ToUpper()))
            {
                return RedirectToAction("Index", "Administrador");
            }
            if (User.IsInRole(("6F1BE536-C224-4F31-914E-C9D00CCE1EB9").ToString().ToUpper()))
            {
                return RedirectToAction("Index", "Agente");
            }
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
