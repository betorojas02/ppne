using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace pruebanexos.Models
{
    public class factura
    {

        public int id_factura { get; set; }
        public int id_cliente { get; set; }
        public int id_camarero { get; set; }
        public int id_mesa { get; set; }
        public DateTime fecha_factura { get; set; }


    }
}
