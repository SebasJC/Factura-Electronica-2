using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Ubicacion
    {
        Int16 Provincia;

        public Int16 Provincia_publico
        {
            get { return Provincia; }
            set { Provincia = value; }
        }
        Int16 Canton;

        public Int16 Canton_publico
        {
            get { return Canton; }
            set { Canton = value; }
        }
        Int16 Distrito;

        public Int16 Distrito_publico
        {
            get { return Distrito; }
            set { Distrito = value; }
        }
        Int16 Barrio;

        public Int16 Barrio_publico
        {
            get { return Barrio; }
            set { Barrio = value; }
        }
        string OtrasSenas;

        public string OtrasSenas_publico
        {
            get { return OtrasSenas; }
            set { OtrasSenas = value; }
        }

        public Ubicacion()              //Vacio porque vamos a llenar los atributos una vez instanciada la clase.
        {

        }

    }
}