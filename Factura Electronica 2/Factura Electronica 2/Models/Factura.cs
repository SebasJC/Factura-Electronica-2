using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class Factura
    {

        string Clave;

        public string Clave_publico
        {
            get { return Clave; }
            set { Clave = value; }
        }

        string NumConsecutivo;

        public string NumConsecutivo_publico
        {
            get { return NumConsecutivo; }
            set { NumConsecutivo = value; }
        }

        DateTime FechaEmision;

        public DateTime FechaEmision_publico
        {
            get { return FechaEmision; }
            set { FechaEmision = value; }
        }

        Emisor Emisor;

        public Emisor Emisor_publico
        {
            get { return Emisor; }
            set { Emisor = value; }
        }

        Receptor Receptor;

        public Receptor Receptor_publico
        {
            get { return Receptor; }
            set { Receptor = value; }
        }

        string CondicionVenta;

        public string CondicionVenta_publico
        {
            get { return CondicionVenta; }
            set { CondicionVenta = value; }
        }

        string PlazoCredito;

        public string PlazoCredito_publico
        {
            get { return PlazoCredito; }
            set { PlazoCredito = value; }
        }

        string MedioPago;

        public string MedioPago_publico
        {
            get { return MedioPago; }
            set { MedioPago = value; }
        }

        List<LineaDetalle> DetalleServicio;

        public List<LineaDetalle> DetalleServicio_publico
        {
            get { return DetalleServicio; }
            set { DetalleServicio = value; }
        }

        ResumenFactura ResumenFactura;

        public ResumenFactura ResumenFactura_publico
        {
            get { return ResumenFactura; }
            set { ResumenFactura = value; }
        }

        InformacionReferencia InformacionReferencia;

        public InformacionReferencia InformacionReferencia_publico
        {
            get { return InformacionReferencia; }
            set { InformacionReferencia = value; }
        }

        Normativa Normativa;

        public Normativa Normativa_publico
        {
            get { return Normativa; }
            set { Normativa = value; }
        }

        Otros Otros;

        public Otros Otros_publico
        {
            get { return Otros; }
            set { Otros = value; }
        }

        public Factura()
        {

        }

    }
}