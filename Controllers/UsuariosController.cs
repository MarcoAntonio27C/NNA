using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Modelos.Acceso;
using NNAContext;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Modelos.Data;
using Modelos;
using NNA.Models.Forms;

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
            //var usuarios = await _Context.Usuario
            //    .Join(_Context.Roles, usuario => usuario.IdRol, rol => rol.Id, (usuario, rol) => new { usuario, rol })
            //    .Join(_Context.Fiscalias, join1 => join1.usuario.IdFiscalia, fiscalia => fiscalia.Id, (join1, fiscalia) => new DataUsuario
            //    {
            //        Id = join1.usuario.Id.ToString(),
            //        NombreCompleto = join1.usuario.Nombre + " " + join1.usuario.ApellidoPaterno + " " + join1.usuario.ApellidoMaterno,
            //        Correo = join1.usuario.Correo,
            //        Rol = join1.rol.Nombre,
            //        Fiscalia = fiscalia.Acronimo,
            //        Estatus = join1.usuario.Estatus.ToString()
            //    }).ToListAsync();


            var usuarios = await _Context.Usuario
                .Join(_Context.Roles, usuario => usuario.IdRol, rol => rol.Id, (usuario, rol) => new { usuario, rol })
                .Join(_Context.Fiscalias, join1 => join1.usuario.IdFiscalia, fiscalia => fiscalia.Id, (join1, fiscalia) => new { join1, fiscalia })
                .Join(_Context.Unidades, join2 => join2.join1.usuario.IdUnidad, unidades => unidades.Id, (join2, unidades) => new DataUsuario
                {
                    Id = join2.join1.usuario.Id.ToString(),
                    NombreCompleto = join2.join1.usuario.Nombre + " " + join2.join1.usuario.ApellidoPaterno + " " + join2.join1.usuario.ApellidoMaterno,
                    Correo = join2.join1.usuario.Correo,
                    Rol = join2.join1.rol.Nombre,
                    Fiscalia = join2.fiscalia.Acronimo,
                    Estatus = join2.join1.usuario.Estatus.ToString(),
                    Unidad = unidades.Nombre
                }).ToListAsync();


            ViewData["usuarios"] = usuarios;
            return View();
        }



        // GET: UsuariosController/Create
        public async Task<ActionResult> CreateAsync()
        {
            List<Roles> roles = await _Context.Roles.OrderBy(x => x.Nombre).ToListAsync();
            List<Fiscalias> fiscalias = await _Context.Fiscalias.Where(x => x.Estatus.Equals(true)).OrderBy(x => x.Nombre).ToListAsync();
            ViewData["roles"] = roles;
            ViewData["fiscalias"] = fiscalias;
            return View();
        }

        [HttpPost]
        public async Task<string> CreateAsync(FormUser form)
        {
            if (await _Context.Usuario.Where(x => x.Correo.Equals(form.Correo)).CountAsync() == 0) {

                Usuario usuario = new Usuario
                {   // Solo Administrador
                    Id = Guid.NewGuid(),
                    Nombre = form.Nombre,
                    ApellidoPaterno = form.ApellidoPaterno,
                    ApellidoMaterno = form.ApellidoMaterno,
                    Correo = form.Correo,
                    Contraseña = form.Password,
                    Estatus = true,
                    IdRol = Guid.Parse(form.Rol),
                    IdFiscalia = Guid.Parse("F54FD0D9-BE76-4C38-B7ED-EDEB6F4C9939"),
                    IdUnidad = Guid.Parse("1D02EDA0-A6B8-4C08-9888-E61DB604ECF0")
                };

                // MP O TITULAR
                if (Guid.Parse(form.Rol).Equals(Guid.Parse("6F1BE536-C224-4F31-914E-C9D00CCE1EB9"))){ // Agente del Ministerio Publico
                    usuario.IdFiscalia = Guid.Parse(form.Fiscalia);
                    usuario.IdUnidad = Guid.Parse(form.Unidad);

                    MP mp = new MP
                    {
                        Nombre = usuario.Nombre,
                        ApellidoPaterno = usuario.ApellidoPaterno,
                        ApellidoMaterno = usuario.ApellidoMaterno,
                        AltaSistema = DateTime.Now,
                        Estatus = true,
                        IdUnidad = Guid.Parse(form.Unidad),
                        IdUsuario = usuario.Id
                    };

                    _Context.MP.Add(mp);
                }
                else if (Guid.Parse(form.Rol).Equals(Guid.Parse("AEC4592C-FE97-47D0-97D2-1933FD2DA4B9"))) // Titular de Unidad
                { // Agente del Ministerio Publico
                    usuario.IdFiscalia = Guid.Parse(form.Fiscalia);
                    usuario.IdUnidad = Guid.Parse(form.Unidad);
                }
                else if (Guid.Parse(form.Rol).Equals(Guid.Parse("49ECFEE1-61F3-4E38-A28A-FE74C1BCB02C"))) // Admin Fiscalia Especializada
                {
                    usuario.IdFiscalia = Guid.Parse(form.Fiscalia);
                    usuario.IdUnidad = Guid.Parse("1D02EDA0-A6B8-4C08-9888-E61DB604ECF0");
                }
                
                _Context.Usuario.Add(usuario);
                var add = await _Context.SaveChangesAsync();
                return add.ToString();
            }

            return "duplicate";

        }

        public async Task<ActionResult<IEnumerable<Unidades>>> GetUnidades(string IdFiscalia)
        {
            var unidades = await _Context.Unidades.Where(x => x.IdFiscalia.Equals(Guid.Parse(IdFiscalia)) && x.Estatus.Equals(true)).ToListAsync();
            return unidades;
        }


    }
}
