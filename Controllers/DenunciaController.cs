using Microsoft.AspNetCore.Mvc;
using NNAContext;
using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using System.Security.Claims;
using Modelos;
using System.Net;
using System.Text;
using System.IO;
using Microsoft.AspNetCore.Authorization;
using Modelos.Data;

namespace NNA.Controllers
{
    [Authorize]
    public class DenunciaController : Controller
    {
        private readonly NNA_Context _Context;

        public DenunciaController(NNA_Context context)
        {
            _Context = context;
        }

        public async Task<IActionResult> IndexAsync(string id)
        {
            var denuncia = await _Context.Denuncia.FindAsync(Guid.Parse(id));
            var mp = await GetAgentesAsync();
            var estatus = await _Context.Estatus.Where(x => x.Status.Equals(true)).ToListAsync();
            string emocion = "";
            string action = "";

            if (denuncia.IdCaso.Equals(1))
            {
                var x = await _Context.Emotion.FindAsync(denuncia.IdEmotion);
                emocion = x.Nombre;
                var y = await _Context.Action.FindAsync(denuncia.IdAction);
                action = y.Descripcion;
            }
           

            var audioNombre = GetAudio(denuncia.NombreRecord);
            var audioEdad = GetAudio(denuncia.EdadRecord);
            var audioParents = GetAudio(denuncia.ParentsRecord);
            var audioSomeData = GetAudio(denuncia.SomeDataRecord);
            var audioRelato = GetAudio(denuncia.EventoRecord);

            ViewData["denuncia"] = denuncia;
            ViewData["emocion"] = emocion;
            ViewData["estatus"] = estatus;
            ViewData["action"] = action;
            ViewData["audioNombre"] = audioNombre;
            ViewData["audioEdad"] = audioEdad;
            ViewData["audioParents"] = audioParents;
            ViewData["audioSomeData"] = audioSomeData;
            ViewData["audioRelato"] = audioRelato;
            ViewData["mp"] = mp;

            return View();
        }

        public async Task<List<DataMP>> GetAgentesAsync()
        {
            List<DataMP> agentes = await _Context.MP.Where(x => x.Estatus.Equals(true))
                .Join(_Context.Unidades, agente => agente.IdUnidad, unidad => unidad.Id, (agente, unidad) => new { agente, unidad })
                .Join(_Context.Fiscalias, join1 => join1.unidad.IdFiscalia, fiscalia => fiscalia.Id, (join1, fiscalia) => new DataMP
                {
                    Id = join1.agente.Id.ToString(),
                    Unidad = join1.unidad.Nombre,
                    NombreCompleto = join1.agente.ApellidoPaterno+" "+join1.agente.ApellidoMaterno + " " + join1.agente.Nombre+ " - "+ join1.unidad.Nombre,
                    Fiscalia = fiscalia.Acronimo,
                    Estatus = join1.agente.Estatus.ToString(),
                }).ToListAsync();

            return agentes;
        }

        public async Task<FileResult> Download(string IdDenuncia, string audio )
        {
            var denuncia = await _Context.Denuncia.FindAsync(Guid.Parse(IdDenuncia));

            if (audio.Equals("1")) { // Descargar Audio de Nombre
               
                byte[] bytes = Convert.FromBase64String(GetAudio(denuncia.NombreRecord));
                Stream stream = new MemoryStream(bytes);
                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, denuncia.Expediente + "-Nombre.acc");


            }else if (audio.Equals("2")) // Audio Edad
            {
                byte[] bytes = Convert.FromBase64String(GetAudio(denuncia.EdadRecord));
                Stream stream = new MemoryStream(bytes);
                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet,denuncia.Expediente+"-Edad.acc");
            }
            else if (audio.Equals("3")) // Audio Nombre Familiares
            {
                byte[] bytes = Convert.FromBase64String(GetAudio(denuncia.ParentsRecord)); // Nombre de sus Papas
                Stream stream = new MemoryStream(bytes);
                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, denuncia.Expediente + "-NombresFamiliares.acc");
            }
            else if (audio.Equals("4")) // Audio Medio de Contacto
            {
                byte[] bytes = Convert.FromBase64String(GetAudio(denuncia.SomeDataRecord)); // Nombre de sus Papas
                Stream stream = new MemoryStream(bytes);
                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, denuncia.Expediente + "-MedioDeContacto.acc");
            }
            else // Audio Medio de Contacto
            {
                byte[] bytes = Convert.FromBase64String(GetAudio(denuncia.EventoRecord)); // Nombre de sus Papas
                Stream stream = new MemoryStream(bytes);
                return File(bytes, System.Net.Mime.MediaTypeNames.Application.Octet, denuncia.Expediente + "-Relato.acc");
            }

        }
        public string GetAudio(string path)
        {

            if(path != null)
            {

                var routeFTP = path;
                var response = "";

                WebClient request = new();

                request.Credentials = new NetworkCredential("anonymous", "elihu.cortes@fiscalia.puebla.gob.mx");

                try
                {
                    var newFileData = request.DownloadData(new Uri(routeFTP));
                    response = Encoding.UTF8.GetString(newFileData);
                }
                catch (WebException e)
                {

                }

                return response;
            }

            return "";

        }

        public async Task<string> Asignar(string mp, string IdDenuncia)
        {
            var denuncia = await _Context.Denuncia.FindAsync(Guid.Parse(IdDenuncia));
            denuncia.Asignada = true;
            denuncia.IdMp = Guid.Parse(mp);
            _Context.Entry(denuncia).State = EntityState.Modified;
            var x = await _Context.SaveChangesAsync();
            return x.ToString();
        }
        //public async Task<string> Estatus(int estatus, string IdDenuncia)
        //{
        //    var denuncia = await _Context.Denuncia.FindAsync(Guid.Parse(IdDenuncia));
        //    denuncia.Estatus = estatus;
        //    _Context.Entry(denuncia).State = EntityState.Modified;
        //    var x = await _Context.SaveChangesAsync();
        //    return x.ToString();
        //}


        public async Task<IActionResult> DenunciasMP(string id)
        {
            var denuncia = await _Context.Denuncia.FindAsync(Guid.Parse(id));
            var mp = await GetAgentesAsync();
            string emocion = "";
            string action = "";

            if (denuncia.IdCaso.Equals(1))
            {
                var x = await _Context.Emotion.FindAsync(denuncia.IdEmotion);
                emocion = x.Nombre;
                var y = await _Context.Action.FindAsync(denuncia.IdAction);
                action = y.Descripcion;
            }


            var audio = GetAudio(denuncia.EventoRecord);
            ViewData["denuncia"] = denuncia;
            ViewData["emocion"] = emocion;
            ViewData["action"] = action;
            ViewData["audio"] = audio;
            ViewData["mp"] = mp;

            return View();
        }

    }
}
