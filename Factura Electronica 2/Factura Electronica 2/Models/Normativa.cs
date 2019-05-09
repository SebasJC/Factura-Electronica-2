using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Normativa
    {

        string NumResolucion;

        public string NumResolucion_publico
        {
            get { return NumResolucion; }
            set { NumResolucion = value; }
        }

        DateTime FechaResolucion;

        public DateTime FechaResolucion_publico
        {
            get { return FechaResolucion; }
            set { FechaResolucion = value; }
        }

        public Normativa()
        {

        }

    }
}