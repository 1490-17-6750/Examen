using System;
using System.Collections.Generic;

#nullable disable

namespace Agexport.Tablas
{
    public partial class Detalle
    {
        public long IdDetalle { get; set; }
        public long IdFactura { get; set; }
        public string IdProducto { get; set; }
        public int Unidades { get; set; }
        public decimal Precio { get; set; }
        public decimal SubTotal { get; set; }

        public virtual Factura IdFacturaNavigation { get; set; }
        public virtual Producto IdProductoNavigation { get; set; }
    }
}
