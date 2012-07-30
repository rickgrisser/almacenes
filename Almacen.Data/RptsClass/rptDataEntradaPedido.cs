using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaPedido
    {
        protected string _infopedido;
        protected string _proveedor;
        protected int _cveart;
        protected string _desarticulo;
        protected string _unidad;
        protected DateTime _fechaentrada;
        protected int _folioentrada;
        protected string _factura;
        protected double _cantidadpedida;
        protected double _cantidadrecibida;
        protected double _cantidadxrecibir;
        protected double _costounitario;

        public virtual string InfoPedido
        {
            get { return _infopedido; }
            set { _infopedido = value; }
        }

        public virtual string Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
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

        public virtual DateTime FechaEntrada
        {
            get { return _fechaentrada; }
            set { _fechaentrada = value; }
        }

        public virtual int FolioEntrada
        {
            get { return _folioentrada; }
            set { _folioentrada = value; }
        }

        public virtual string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public virtual double CantidadPedida
        {
            get { return _cantidadpedida; }
            set { _cantidadpedida = value; }
        }

        public virtual double CantidadRecibida
        {
            get { return _cantidadrecibida; }
            set { _cantidadrecibida = value; }
        }

        public virtual double CantidadxRecibir
        {
            get { return _cantidadxrecibir; }
            set { _cantidadxrecibir = value; }
        }

        public virtual double CostoUnitario
        {
            get { return _costounitario; }
            set { _costounitario = value; }
        }
    }
}
