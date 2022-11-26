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
            string emocion = "";
            string action = "";

            if (denuncia.IdCaso.Equals(1))
            {
                var x = await _Context.Emotion.FindAsync(denuncia.IdEmotion);
                emocion = x.Nombre;
                var y = await _Context.Action.FindAsync(denuncia.IdAction);
                action = y.Descripcion;
            }
           
            var audio = GetAudio(denuncia);
            ViewData["denuncia"] = denuncia;
            ViewData["emocion"] = emocion;
            ViewData["action"] = action;
            ViewData["audio"] = audio;

            return View();
        }


        public string GetAudio(Denuncia denuncia)
        {

            if(denuncia.EventoRecord != null)
            {
                //var routeFTP = "ftp://10.24.1.13/2022/2/4/fe27d57e-bf9d-49e4-8928-d3f8ed58fb24/video.txt";
                //var routeFTP = "ftp://10.24.1.29/audio.txt";
                var routeFTP = denuncia.EventoRecord;
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
    }
}
