using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Acceso
{
    public class Usuario
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public bool Estatus { get; set; }
        public Guid IdRol { get; set; }
        public Guid IdFiscalia { get; set; }
        public Guid IdUnidad { get; set; }
    }
}
