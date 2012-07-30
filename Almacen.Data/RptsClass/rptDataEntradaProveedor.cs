using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaProveedor
    {
        protected string _es;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected int _intfoliopedido;
        protected string _strtipopedido;
        protected int _intfolioentrada;
        protected DateTime _fechaentrada;
        protected int _cveart;
        protected string _strdesarticulo;
        protected string _strunidad;
        protected double _cantidad;
        protected double _costounit;
        protected string _proveedor;

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

        public virtual int intFolioPedido
        {
            get { return _intfoliopedido; }
            set { _intfoliopedido = value; }
        }

        public virtual string strTipoPedido
        {
            get { return _strtipopedido; }
            set { _strtipopedido = value; }
        }

        public virtual int intFolioEntrada
        {
            get { return _intfolioentrada; }
            set { _intfolioentrada = value; }
        }

        public virtual DateTime FechaEntrada
        {
            get { return _fechaentrada; }
            set { _fechaentrada = value; }
        }

        public virtual int CveArt
        {
            get { return _cveart; }
            set { _cveart = value; }
        }

        public virtual string DesArticulo
        {
            get { return _strdesarticulo; }
            set { _strdesarticulo = value; }
        }

        public virtual string Unidad
        {
            get { return _strunidad; }
            set { _strunidad = value; }
        }

        public virtual double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public virtual double CostoUnit
        {
            get { return _costounit; }
            set { _costounit = value; }
        }

        public virtual string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
        }
    }
}
