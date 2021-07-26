using System;
using System.Collections.Generic;

#nullable disable

namespace Agexport.Tablas
{
    public partial class Producto
    {
        public Producto()
        {
            Detalles = new HashSet<Detalle>();
        }

        public string IdProducto { get; set; }
        public string Nombre { get; set; }
        public decimal PrecioVenta { get; set; }
        public decimal PrecioCompra { get; set; }

        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
