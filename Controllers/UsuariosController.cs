﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Acceso;
using NNAContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Data;

namespace NNA.Controllers
{
    public class UsuariosController : Controller
    {
        private readonly NNA_Context _Context;

        public UsuariosController(NNA_Context context)
        {
            _Context = context;
        }

        // GET: UsuariosController
        public async Task<ActionResult> IndexAsync()
        {
            var usuarios = await _Context.Usuario
                .Join(_Context.Roles, usuario => usuario.IdRol, rol => rol.Id, (usuario, rol) => new { usuario, rol })
                .Join(_Context.Fiscalias, join1 => join1.usuario.IdFiscalia, fiscalia => fiscalia.Id, (join1, fiscalia) => new DataUsuario
                {
                    Id = join1.usuario.Id.ToString(),
                    NombreCompleto = join1.usuario.Nombre + " " + join1.usuario.ApellidoPaterno + " " + join1.usuario.ApellidoMaterno,
                    Correo = join1.usuario.Correo,
                    Rol = join1.rol.Nombre,
                    Fiscalia = fiscalia.Acronimo,
                    Estatus = join1.usuario.Estatus.ToString()
                }).ToListAsync();

            ViewData["usuarios"] = usuarios;
            return View();
        }

        // GET: UsuariosController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: UsuariosController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: UsuariosController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: UsuariosController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }

        // GET: UsuariosController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: UsuariosController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(IndexAsync));
            }
            catch
            {
                return View();
            }
        }
    }
}