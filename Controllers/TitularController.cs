using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NNA.Controllers
{
    public class TitularController : Controller
    {
        // GET: TitularController
        public ActionResult Index()
        {
            return View();
        }

        // GET: TitularController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: TitularController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: TitularController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TitularController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: TitularController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: TitularController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: TitularController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
