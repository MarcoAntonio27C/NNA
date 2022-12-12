﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelos
{
    [Table("Municipio", Schema = "Catalogo")]
    public class Municipio
    {
       public int Id { get; set; }
       public string Nombre { get; set; }
    }
}
