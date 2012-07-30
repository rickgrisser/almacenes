using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaDetallado
    {
        protected string _es;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected DateTime _fecha;
        protected int _folio;
        protected string _factura;
        protected string _tipopedido;
        protected DateTime _fechapedido;
        protected int _numpedido;
        protected int _cveart;
        protected string _desarticulo;
        protected string _marca;
        protected decimal _cantidad;
        protected decimal _precio;
        protected DateTime _caducidad;
        protected string _lote;
        protected decimal _descuento;
        protected int _iva;
        protected string _status;

        public virtual string Es
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

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual int Folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        public virtual string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public virtual string TipoPedido
        {
            get { return _tipopedido; }
            set { _tipopedido = value; }
        }

        public virtual DateTime FechaPedido
        {
            get { return _fechapedido; }
            set { _fechapedido = value; }
        }

        public virtual int NumPedido
        {
            get { return _numpedido; }
            set { _numpedido = value; }
        }

        public virtual int CveArt
        {
            get { return _cveart; }
            set { _cveart = value; }
        }

        public virtual string DesArticulo
        {
            get { return _desarticulo; }
            set { _desarticulo = value; }
        }

        public virtual string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public virtual decimal Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public virtual decimal Precio
        {
            get { return _precio; }
            set { _precio = value; }
        }

        public virtual DateTime Caducidad
        {
            get { return _caducidad; }
            set { _caducidad = value; }
        }

        public virtual string Lote
        {
            get { return _lote; }
            set { _lote = value; }
        }

        public virtual decimal Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public virtual int Iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        public virtual string Status
        {
            get { return _status; }
            set { _status = value; }
        }
    }
}
