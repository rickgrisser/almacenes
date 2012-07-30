using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaFolio
    {
        protected string _es;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected int _folioentrada;
        protected DateTime _fecha;
        protected string _proveedor;
        protected string _factura;
        protected int _foliopedido;
        protected string _tipopedido;
        protected double _total;

        public virtual string ES
        {
            get { return _es; }
            set { _es = value; }
        }

        public virtual DateTime FechaIni
        {
            get { return _fechaini; }
            set { _fechaini = value; }
        }

        public virtual DateTime FechaFin
        {
            get { return _fechafin; }
            set { _fechafin = value; }
        }

        public virtual int FolioEntrada
        {
            get { return _folioentrada; }
            set { _folioentrada = value; }
        }

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }

        public virtual string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public virtual int FolioPedido
        {
            get { return _foliopedido; }
            set { _foliopedido = value; }
        }

        public virtual string TipoPedido
        {
            get { return _tipopedido; }
            set { _tipopedido = value; }
        }

        public virtual double Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
