using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NNA.Models.Forms
{
    public class FormUser
    {
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public string Fiscalia { get; set; }
        public string Unidad { get; set; }
        public string Password { get; set; }
    }
}
