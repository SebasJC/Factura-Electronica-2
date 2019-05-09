using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Identificacion
    {

        string Tipo;

        public string Tipo_publico
        {
            get { return Tipo; }
            set { Tipo = value; }
        }
        string Numero;

        public string Numero_publico
        {
            get { return Numero; }
            set { Numero = value; }
        }

        public Identificacion()             //Explicado en Ubicacion.cs
        {

        }

    }
}