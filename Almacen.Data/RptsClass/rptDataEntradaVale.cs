using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
	[Serializable]
	public class rptDataEntradaVale
	{
		#region Member Variables
        protected DateTime _fecha;
	    protected int _folio;
        protected string _factura;
	    protected int _tipopedido;
        protected int _pedido;
        protected string _proveedor;
        protected int _cveart;
        protected string _desart;
        protected string _unidad;
	    protected double _pedida;
        protected double _recibida;
        protected double _preciounitario;
        protected string _marca;
        protected string _lote;
        protected DateTime _caducidad;
        protected double _descuento;
        protected int _iva;
        protected string _recibio;
        protected string _superviso;
        protected string _capturo;
		#endregion
		
		#region Public Properties

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

        public virtual int TipoPedido
        {
            get { return _tipopedido; }
            set { _tipopedido = value; }
        }

        public virtual int Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
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

        public virtual string DesArt
        {
            get { return _desart; }
            set { _desart = value; }
        }

        public virtual string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public virtual double Pedida
        {
            get { return _pedida; }
            set { _pedida = value; }
        }

        public virtual double Recibida
        {
            get { return _recibida; }
            set { _recibida = value; }
        }

        public virtual double PrecioUnitario
        {
            get { return _preciounitario; }
            set { _preciounitario = value; }
        }

       public virtual string Marca
        {
            get { return _marca; }
            set { _marca = value; }
        }

        public virtual string Lote
        {
            get { return _lote; }
            set { _lote = value; }
        }

        public virtual DateTime Caducidad
        {
            get { return _caducidad; }
            set { _caducidad = value; }
        }

        public virtual double Descuento
        {
            get { return _descuento; }
            set { _descuento = value; }
        }

        public virtual int Iva
        {
            get { return _iva; }
            set { _iva = value; }
        }

        public virtual string Recibio
        {
            get { return _recibio; }
            set { _recibio = value; }
        }

        public virtual string Superviso
        {
            get { return _superviso; }
            set { _superviso = value; }
        }

        public virtual string Capturo
        {
            get { return _capturo; }
            set { _capturo = value; }
        }
        #endregion
		
		
	}
}
