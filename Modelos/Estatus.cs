﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
  //  [Table("Estatus", Schema = "Catalogo")]
    public class Estatus
    {
        public int Id { get; set; }
        public string Nombre { get; set; }
        public bool Status { get; set; }
    }
}
