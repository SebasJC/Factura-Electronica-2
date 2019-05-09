using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class InformacionReferencia
    {


        string TipoDoc;

        public string TipoDoc_publico
        {
            get { return TipoDoc; }
            set { TipoDoc = value; }
        }

        string Numero;

        public string Numero_publico
        {
            get { return Numero; }
            set { Numero = value; }
        }

        DateTime FechaEmision;

        public DateTime FechaEmision_publico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }

        string Codigo;

        public string Codigo_publico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        string Razon;

        public string Razon_publico
        {
            get { return Razon; }
            set { Razon = value; }
        }

        public InformacionReferencia()
        {

        }   

    }
}