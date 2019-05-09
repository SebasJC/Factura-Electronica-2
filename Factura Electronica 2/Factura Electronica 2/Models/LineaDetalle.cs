using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class LineaDetalle
    {

        string NumeroLinea;

        public string NumeroLinea_publico
        {
            get { return NumeroLinea; }
            set { NumeroLinea = value; }
        }

        Codigo Codigo;

        public Codigo Codigo_publico
        {
            get { return Codigo; }
            set { Codigo = value; }
        }

        string Cantidad;

        public string Cantidad_publico
        {
            get { return Cantidad; }
            set { Cantidad = value; }
        }

        string UnidadMedida;

        public string UnidadMedida_publico
        {
            get { return UnidadMedida; }
            set { UnidadMedida = value; }
        }

        string UnidadMedidaComercial;

        public string UnidadMedidaComercial_publico
        {
            get { return UnidadMedidaComercial; }
            set { UnidadMedidaComercial = value; }
        }

        string Detalle;

        public string Detalle_publico
        {
            get { return Detalle; }
            set { Detalle = value; }
        }

        string PrecioUnitario;

        public string PrecioUnitario_publico
        {
            get { return PrecioUnitario; }
            set { PrecioUnitario = value; }
        }

        string MontoTotal;

        public string MontoTotal_publico
        {
            get { return MontoTotal; }
            set { MontoTotal = value; }
        }

        string MontoDescuento;

        public string MontoDescuento_publico
        {
            get { return MontoDescuento; }
            set { MontoDescuento = value; }
        }

        string NaturalezaDescuento;

        public string NaturalezaDescuento_publico
        {
            get { return NaturalezaDescuento; }
            set { NaturalezaDescuento = value; }
        }

        string Subtotal;

        public string Subtotal_publico
        {
            get { return Subtotal; }
            set { Subtotal = value; }
        }

        Impuesto Impuesto;

        public Impuesto Impuesto_publico
        {
            get { return Impuesto; }
            set { Impuesto = value; }
        }

        string MontoTotalLinea;

        public string MontoTotalLinea_publico
        {
            get { return MontoTotalLinea; }
            set { MontoTotalLinea = value; }
        }

        public LineaDetalle()
        {

        }

    }
}