using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Codigo
    {

        string Tipo;

        public string Tipo_publico
        {
            get { return Tipo; }
            set { Tipo = value; }
        }

        string codigon;   //Codigo

        public string codigon_publico //Codigo
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        public Codigo()
        {

        }

    }
}