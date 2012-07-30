using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaIFAI
    {
        protected string _cvepartida;
        protected string _despartida;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected string _cuadrobasico;
        protected int _cveart;
        protected string _desarticulo;
        protected string _unidad;
        protected double _cantidad;
        protected double _preciounitario;
        protected string _desproveedor;
        protected string _tipoadquisicion;
        protected string _licitacion;
        protected string _factura;
        protected long _numpedido;

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

        public virtual string CuadroBasico
        {
            get { return _cuadrobasico; }
            set { _cuadrobasico = value; }
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

        public virtual double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public virtual double PrecioUnitario
        {
            get { return _preciounitario; }
            set { _preciounitario = value; }
        }

        public virtual string DesProveedor
        {
            get { return _desproveedor; }
            set { _desproveedor = value; }
        }

        public virtual string TipoAdquisicion
        {
            get { return _tipoadquisicion; }
            set { _tipoadquisicion = value; }
        }

        public virtual string Licitacion
        {
            get { return _licitacion; }
            set { _licitacion = value; }
        }

        public virtual string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public virtual long NumPedido
        {
            get { return _numpedido; }
            set { _numpedido = value; }
        }
    }
}
