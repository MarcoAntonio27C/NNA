using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Unidades", Schema = "Catalogo")]
    public class Unidades
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public bool Estatus { get; set; }
        public Guid IdFiscalia { get; set; }
    }
}
