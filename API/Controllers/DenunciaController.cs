using Microsoft.AspNetCore.Mvc;
using Modelos;
using NNAContext;
using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;


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
            Guid Id = Guid.NewGuid();
            denuncia.Id = Id;
            denuncia.Fecha = DateTime.Now;
            Stream ftpStream = null;
            FtpWebRequest request;

            if (denuncia.IdCaso == 1)
            {
                if (denuncia.NombreRecord != null)
                {
                    //Se inserta namerecord
                    request = (FtpWebRequest)WebRequest.Create("ftp://10.24.1.13/NNA/" + denuncia.Id + "namerecord.txt");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("anonymous", "luis_cruz.jimenez@fiscalia.puebla.gob.mx");
                    var filecontent = Encoding.ASCII.GetBytes(denuncia.NombreRecord);
                    request.ContentLength = filecontent.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(filecontent, 0, filecontent.Length);
                    }

                    FtpWebResponse response = (FtpWebResponse)request.GetResponse();
                    ftpStream = response.GetResponseStream();
                    ftpStream.Close();
                    response.Close();
                    denuncia.NombreRecord = "ftp://10.24.1.13/NNA/" + denuncia.Id + "namerecord.txt";
                }

                if (denuncia.EdadRecord != null)
                {
                    //Se inserta edadrecord
                    request = (FtpWebRequest)WebRequest.Create("ftp://10.24.1.13/NNA/" + denuncia.Id + "edadrecord.txt");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("anonymous", "luis_cruz.jimenez@fiscalia.puebla.gob.mx");
                    var filecontent2 = Encoding.ASCII.GetBytes(denuncia.EdadRecord);
                    request.ContentLength = filecontent2.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(filecontent2, 0, filecontent2.Length);
                    }

                    FtpWebResponse response2 = (FtpWebResponse)request.GetResponse();
                    ftpStream = response2.GetResponseStream();
                    ftpStream.Close();
                    response2.Close();
                    denuncia.EdadRecord = "ftp://10.24.1.13/NNA/" + denuncia.Id + "edadrecord.txt";
                }

                if (denuncia.ParentsRecord != null)
                {
                    //Se inserta parentsrecord
                    request = (FtpWebRequest)WebRequest.Create("ftp://10.24.1.29/NNA/" + denuncia.Id + "parentsrecord.txt");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("anonymous", "luis_cruz.jimenez@fiscalia.puebla.gob.mx");
                    var filecontent3 = Encoding.ASCII.GetBytes(denuncia.ParentsRecord);
                    request.ContentLength = filecontent3.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(filecontent3, 0, filecontent3.Length);
                    }

                    FtpWebResponse response3 = (FtpWebResponse)request.GetResponse();
                    ftpStream = response3.GetResponseStream();
                    ftpStream.Close();
                    response3.Close();
                    denuncia.ParentsRecord = "ftp://10.24.1.13/NNA/" + denuncia.Id + "parentsrecord.txt";
                }

                if (denuncia.SomeDataRecord != null)
                {
                    //Se inserta someonerecord
                    request = (FtpWebRequest)WebRequest.Create("ftp://10.24.1.13/NNA/" + denuncia.Id + "someonerecord.txt");
                    request.Method = WebRequestMethods.Ftp.UploadFile;
                    request.Credentials = new NetworkCredential("anonymous", "luis_cruz.jimenez@fiscalia.puebla.gob.mx");
                    var filecontent4 = Encoding.ASCII.GetBytes(denuncia.SomeDataRecord);
                    request.ContentLength = filecontent4.Length;

                    using (Stream requestStream = request.GetRequestStream())
                    {
                        requestStream.Write(filecontent4, 0, filecontent4.Length);
                    }

                    FtpWebResponse response4 = (FtpWebResponse)request.GetResponse();
                    ftpStream = response4.GetResponseStream();
                    ftpStream.Close();
                    response4.Close();
                    denuncia.SomeDataRecord = "ftp://10.24.1.13/NNA/" + denuncia.Id + "someonerecord.txt";
                }

            }

            if (denuncia.EventoRecord != null)
            {
                //Se inserta eventrecord
                request = (FtpWebRequest)WebRequest.Create("ftp://10.24.1.13/NNA/" + denuncia.Id + "eventrecord.txt");
                request.Method = WebRequestMethods.Ftp.UploadFile;
                request.Credentials = new NetworkCredential("anonymous", "luis_cruz.jimenez@fiscalia.puebla.gob.mx");
                var filecontent5 = Encoding.ASCII.GetBytes(denuncia.EventoRecord);
                request.ContentLength = filecontent5.Length;

                using (Stream requestStream = request.GetRequestStream())
                {
                    requestStream.Write(filecontent5, 0, filecontent5.Length);
                }

                FtpWebResponse response5 = (FtpWebResponse)request.GetResponse();
                ftpStream = response5.GetResponseStream();
                ftpStream.Close();
                response5.Close();
                denuncia.EventoRecord = "ftp://10.24.1.13/NNA/" + denuncia.Id + "eventrecord.txt";
            }


            _context.Denuncia.Add(denuncia);
            var x = await _context.SaveChangesAsync();



            if (x > 0)
            {
                return "{\"respuesta\":\"200\"}";
            }
            return "{\"respuesta\":\"9999\"}";
        }
    }
}
