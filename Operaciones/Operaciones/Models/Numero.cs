using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Operaciones.Models
{
    public class Numero
    {
        [Key]
        public int numero { get; set; }
        public string mensaje { get; set; }
    }
}