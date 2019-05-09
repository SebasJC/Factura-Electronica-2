using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Factura_Electronica_2.Models
{
    public class ResumenFactura
    {

        string CodigoMoneda;

        public string CodigoMoneda_publico
        {
            get { return CodigoMoneda; }
            set { CodigoMoneda = value; }
        }

        string TipoCambio;

        public string TipoCambio_publico
        {
            get { return TipoCambio; }
            set { TipoCambio = value; }
        }

        string TotalServGravados;

        public string TotalServGravados_publico
        {
            get { return TotalServGravados; }
            set { TotalServGravados = value; }
        }

        string TotalServExentos;

        public string TotalServExentos_publico
        {
            get { return TotalServExentos; }
            set { TotalServExentos = value; }
        }

        string TotalMercanciasGravadas;

        public string TotalMercanciasGravadas_publico
        {
            get { return TotalMercanciasGravadas; }
            set { TotalMercanciasGravadas = value; }
        }

        string TotalMercanciasExentas;

        public string TotalMercanciasExentas_publico
        {
            get { return TotalMercanciasExentas; }
            set { TotalMercanciasExentas = value; }
        }

        string TotalGravado;

        public string TotalGravado_publico
        {
            get { return TotalGravado; }
            set { TotalGravado = value; }
        }

        string TotalExento;

        public string TotalExento_publico
        {
            get { return TotalExento; }
            set { TotalExento = value; }
        }

        string TotalVenta;

        public string TotalVenta_publico
        {
            get { return TotalVenta; }
            set { TotalVenta = value; }
        }

        string TotalDescuentos;

        public string TotalDescuentos_publico
        {
            get { return TotalDescuentos; }
            set { TotalDescuentos = value; }
        }

        string TotalVentaNeta;

        public string TotalVentaNeta_publico
        {
            get { return TotalVentaNeta; }
            set { TotalVentaNeta = value; }
        }

        string TotalImpuesto;

        public string TotalImpuesto_publico
        {
            get { return TotalImpuesto; }
            set { TotalImpuesto = value; }
        }

        string TotalComprobante;

        public string TotalComprobante_publico
        {
            get { return TotalComprobante; }
            set { TotalComprobante = value; }
        }

        public ResumenFactura()
        {

        }

    }
}