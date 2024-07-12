﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Venta
    {
        public int id {  get; set; }
        public int idcliente { get; set; }
        public int totalproducto { get; set; }

        public decimal montototal { get; set; }
        public string contacto { get; set; }
        public string iddistrito { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
        public string idtransaccion { get; set; }
        public string fechaventa { get; set; }


        public List<DetalleVenta>oDetalleVenta { get; set; }

    }
}


