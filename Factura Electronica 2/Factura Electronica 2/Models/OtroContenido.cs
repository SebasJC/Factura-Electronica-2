using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class OtroContenido
    {

        string Codigo;

        public string Codigo_publico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public OtroContenido()
        {

        }
    }
}