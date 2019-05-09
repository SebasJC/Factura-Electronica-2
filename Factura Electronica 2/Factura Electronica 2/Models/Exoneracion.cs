using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Exoneracion
    {

        string TipoDocumento;

        public string TipoDocumento_publico
        {
            get { return TipoDocumento; }
            set { TipoDocumento = value; }
        }

        string NumDocumento;

        public string NumDocumento_publico
        {
            get { return NumDocumento; }
            set { NumDocumento = value; }
        }

        string NombreInstitucion;

        public string NombreInstitucion_publico
        {
            get { return NombreInstitucion; }
            set { NombreInstitucion = value; }
        }

        DateTime FechaEmision;

        public DateTime FechaEmision_publico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }

        string MontoImpuesto;

        public string MontoImpuesto_publico
        {
            get { return MontoImpuesto; }
            set { MontoImpuesto = value; }
        }

        string PorcentageCompra;

        public string PorcentageCompra_publico
        {
            get { return PorcentageCompra; }
            set { PorcentageCompra = value; }
        }

        public Exoneracion()
        {

        }

    }
}