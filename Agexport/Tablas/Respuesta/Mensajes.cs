using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Agexport.Tablas.Respuesta
{
    public class Mensajes
    {
        public int Exito { get; set; }
        public string Mensaje { get; set; }
        public object  Data { get; set; }
        public Mensajes()
        {
            this.Exito = 0;
        }
    }
}
