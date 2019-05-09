using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Impuesto
    {

        string Codigo;

        public string Codigo_publico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        string Tarifa;

        public string Tarifa_publico
        {
            get { return Tarifa; }
            set { Tarifa = value; }
        }

        string Monto;

        public string Monto_publico
        {
            get { return Monto; }
            set { Monto = value; }
        }

        Exoneracion Exoneracion;

        public Exoneracion Exoneracion_publico
        {
            get { return Exoneracion; }
            set { Exoneracion = value; }
        }


        public Impuesto()
        {

        }

    }
}