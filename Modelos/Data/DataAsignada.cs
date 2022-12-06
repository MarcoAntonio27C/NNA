using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos.Data
{
    public class DataAsignada
    {
        public Guid Id { get; set; }
        public string Expediente { get; set; }
        public int Folio { get; set; }
        public DateTime Fecha { get; set; }
        public string Nombre { get; set; }
        public string Edad { get; set; }
        public bool Asignada { get; set; }
        public int IdCaso { get; set; }
        public int IdEstatus { get; set; }
        public string NombreEstatus { get; set; }
        public Guid IdMp { get; set; }
        public string NombreMP { get; set; }
    }
}
