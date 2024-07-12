using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Carrito
    {
        public int id { get; set; }

        public Cliente ocliente { get; set; }

        public Producto oproducto { get; set; }
        public int cantidad { get; set; }


    }
}
