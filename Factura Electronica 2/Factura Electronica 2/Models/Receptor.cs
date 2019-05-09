using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Receptor:Emisor
    {
        string IdentificacionExtranjero;

        public string IdentificacionExtranjero_publico
        {
            get { return IdentificacionExtranjero; }
            set { IdentificacionExtranjero = value; }
        }


    }
}