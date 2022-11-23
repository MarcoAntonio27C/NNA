using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Data
{
    public class DataUsuario
    {
        public string Id { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public string Rol { get; set; }
        public string Fiscalia { get; set; }
        public string Estatus { get; set; }
    }
}
