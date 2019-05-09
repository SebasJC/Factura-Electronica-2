using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Telefonopadre
    {

        string CodigoPais;

        public string CodigoPais_publico
        {
            get { return CodigoPais; }
            set { CodigoPais = value; }
        }
        string NumTelefono;

        public string NumTelefono_publico
        {
            get { return NumTelefono; }
            set { NumTelefono = value; }
        }
        public Telefonopadre()
        {

        }

    }
}