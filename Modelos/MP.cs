using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class MP
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string ApellidoPaterno { get; set; }
        public string ApellidoMaterno { get; set; }
        public DateTime AltaSistema { get; set; }
        public bool Estatus { get; set; }
        public Guid IdUnidad { get; set; }
        public Guid IdUsuario { get; set; }
    }
}
