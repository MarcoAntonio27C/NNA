using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    public class Denuncia
    {
        public Guid Id { get; set; }
        public string Expediente { get; set; }
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Folio { get; set; }
        public DateTime  Fecha { get; set; }
        public string  Nombre { get; set; }
        public string  NombreRecord { get; set; }
        public string  Edad { get; set; }
        public string  EdadRecord { get; set; }
        public byte[] Photo { get; set; }
        public string ParentsName { get; set; }
        public string ParentsRecord { get; set; }
        public string Casa { get; set; }
        public string Escuela { get; set; }
        public string Telefono { get; set; }
        public string SomeDataRecord { get; set; }
        public string Latitud { get; set; }
        public string Longitud { get; set; }
        public string PlaceName { get; set; }
        public string Municipio { get; set; }
        public string Evento { get; set; }
        public string EventoRecord { get; set; }
        public bool Asignada { get; set; }
        public int IdEmotion { get; set; }
        public int IdAction { get; set; }
        public int IdCaso { get; set; }
        public Guid IdMp { get; set; }
        public Guid IdFiscalia { get; set; }
    }
}
