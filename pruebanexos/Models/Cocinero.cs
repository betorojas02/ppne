using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace pruebanexos.Models
{
    public class Cocinero
    {
        [Key]
        public int id_cliente { get; set; }
        public String nombre { get; set; }
        public String apellido1 { get; set; }
        public String apellido2 { get; set; }
        public String observaciones { get; set; }

    }
}
