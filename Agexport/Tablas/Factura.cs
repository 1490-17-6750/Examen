using System;
using System.Collections.Generic;

#nullable disable

namespace Agexport.Tablas
{
    public partial class Factura
    {
        public Factura()
        {
            Detalles = new HashSet<Detalle>();
        }

        public long IdFactura { get; set; }
        public DateTime Fecha { get; set; }
        public decimal Total { get; set; }
        public long Nit { get; set; }

        public virtual Cliente NitNavigation { get; set; }
        public virtual ICollection<Detalle> Detalles { get; set; }
    }
}
