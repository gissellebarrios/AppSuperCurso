using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{

    public class Producto
    {
        public int id { get; set; }
        public string descripcion { get; set; }
        public Marca omarca { get; set; }
        public Categoria ocategoria { get; set; }
        public decimal precio { get; set; }
        public int stock { get; set; }
        public string rutaimagen { get; set; }
        public string nombreimagen { get; set; }
        public bool activo { get; set; }

    }
}
