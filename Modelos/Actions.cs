using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Modelos
{

    [Table("Actions", Schema = "Catalogo")]
    public class Actions
    {
        public int Id { get; set; }
        public string Descripcion { get; set; }
    }
}
