using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Emisor
    {

        string Nombre;

        public string Nombre_publico
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        Identificacion Identificacion;

        public Identificacion Identificacion_publico
        {
            get { return Identificacion; }
            set { Identificacion = value; }
        }
        string NombreComercial;

        public string NombreComercial_publico
        {
            get { return NombreComercial; }
            set { NombreComercial = value; }
        }

        Ubicacion Ubicacion;

        public Ubicacion Ubicacion_publico
        {
            get { return Ubicacion; }
            set { Ubicacion = value; }
        }

        Telefono Telefono;

        public Telefono Telefono_publico
        {
            get { return Telefono; }
            set { Telefono = value; }
        }

        Fax Fax;

        public Fax Fax_publico
        {
            get { return Fax; }
            set { Fax = value; }
        }

        string Correoelctronico;

        public string Correoelctronico_publico
        {
            get { return Correoelctronico; }
            set { Correoelctronico = value; }
        }

        public Emisor()
        {

        }

    }
}