using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Fiscalias", Schema = "Catalogo")]
    public class Fiscalias
    {
        public Guid Id { get; set; }
        public string Nombre { get; set; }
        public string Acronimo { get; set; }
        public bool Estatus { get; set; }
    }
}
