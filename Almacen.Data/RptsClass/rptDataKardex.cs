using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataKardex
    {
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected char _es;
        protected string _cvepartida;
        protected string _despartida;
        protected int _cveart;
        protected string _desarticulo;
        protected string _unidad;
        protected string _presentacion;
        protected string _presentacioncant;
        protected string _presentacionunid;
        protected DateTime _fecha;
        protected int _pedido;
        protected int _folio;
        protected double _cantentrada;
        protected double _cantsalida;
        protected double _existencia;
        protected double _precioentrada;
        protected double _preciosalida;
        protected double _debe;
        protected double _haber;
        protected double _saldo;
        protected string _area;
        protected int _tipopedido;

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

        public virtual char Es
        {
            get { return _es; }
            set { _es = value; }
        }

        public virtual string CvePartida
        {
            get { return _cvepartida; }
            set { _cvepartida = value; }
        }

        public virtual string DesPartida
        {
            get { return _despartida; }
            set { _despartida = value; }
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

        public virtual string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public virtual string Presentacion
        {
            get { return _presentacion; }
            set { _presentacion = value; }
        }

        public virtual string PresentacionCant
        {
            get { return _presentacioncant; }
            set { _presentacioncant = value; }
        }

        public virtual string PresentacionUnid
        {
            get { return _presentacionunid; }
            set { _presentacionunid = value; }
        }

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual int Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }

        public virtual int Folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        public virtual double CantEntrada
        {
            get { return _cantentrada; }
            set { _cantentrada = value; }
        }

        public virtual double CantSalida
        {
            get { return _cantsalida; }
            set { _cantsalida = value; }
        }

        public virtual double Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }

        public virtual double PrecioEntrada
        {
            get { return _precioentrada; }
            set { _precioentrada = value; }
        }

        public virtual double PrecioSalida
        {
            get { return _preciosalida; }
            set { _preciosalida = value; }
        }

        public virtual double Debe
        {
            get { return _debe; }
            set { _debe = value; }
        }

        public virtual double Haber
        {
            get { return _haber; }
            set { _haber = value; }
        }

        public virtual double Saldo
        {
            get { return _saldo; }
            set { _saldo = value; }
        }

        public virtual string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public virtual int TipoPedido
        {
            get { return _tipopedido; }
            set { _tipopedido = value; }
        }
    }
}
