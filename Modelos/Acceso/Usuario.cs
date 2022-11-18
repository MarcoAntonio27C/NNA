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
        public string Correo { get; set; }
        public string Contraseña { get; set; }
        public Guid IdRol { get; set; }
        public bool Estatus { get; set; }
    }
}
