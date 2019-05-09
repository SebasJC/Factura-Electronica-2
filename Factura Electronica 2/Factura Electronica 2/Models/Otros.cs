using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Otros
    {

        OtroTexto OtroTexto;

        public OtroTexto OtroTexto_publico
        {
            get { return OtroTexto; }
            set { OtroTexto = value; }
        }

        OtroContenido OtroContenido;

        public OtroContenido OtroContenido_publico
        {
            get { return OtroContenido; }
            set { OtroContenido = value; }
        }

        public Otros()
        {

        }

    }
}