/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoDetalle object for NHibernate mapped table 'pedido_detalle'.
	/// </summary>
	[Serializable]
	public class PedidoDetalle
	{
		#region Member Variables
		//protected PedidoDetalleId _id;
        protected long _idpedidodetalle;
        protected Pedido _pedido = new Pedido();
        protected short _renglonpedido;
		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _cantidad;
		protected decimal? _preciounitario;
		protected IList<PedidoEntrega> _pedidoentrega;
		#endregion
		#region Constructors
			
		public PedidoDetalle() {}
					
		public PedidoDetalle(long idpedidodetalle, string marca, decimal? cantidad, decimal? preciounitario)//, Pedido pedido) 
		{
            this._idpedidodetalle = idpedidodetalle;
			this._marca= marca;
			this._cantidad= cantidad;
			this._preciounitario= preciounitario;
			//this._pedido= pedido;
		}

        public PedidoDetalle(long idpedidodetalle, Pedido pedido)
		{
            this._idpedidodetalle = idpedidodetalle;
			this._pedido= pedido;
		}
		
		#endregion
		#region Public Properties
        public virtual long IdPedidoDetalle
		{
            get { return _idpedidodetalle; }
            set { _idpedidodetalle = value; }
		}
        public virtual Pedido Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }
        public virtual short RenglonPedido
        {
            get { return _renglonpedido; }
            set { _renglonpedido = value; }
        }
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Marca
		{
			get { return _marca; }
			set {_marca= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual decimal? PrecioUnitario
		{
			get { return _preciounitario; }
			set {_preciounitario= value; }
		}
		public  virtual IList<PedidoEntrega> PedidoEntrega
		{
			get { return _pedidoentrega; }
			set {_pedidoentrega= value; }
		}
       
		#endregion

        #region Bindeo
        private int _clave;

        public int Clave
        {
            get { return _clave; }
            set { _clave = value; }
        }

        private string _descripcion;

        public string Descripcion
        {
            get { return _descripcion; }
            set { _descripcion = value; }
        }

        private decimal _xentregar;

        public decimal XEntregar
        {
            get { return _xentregar; }
            set { _xentregar = value; }
        }

        private decimal _recibida;

        public decimal Recibida
        {
            get { return _recibida; }
            set { _recibida = value; }
        }

        private decimal _cantidadtotal;

        public decimal CantidadTotal
        {
            get { return _cantidadtotal; }
            set { _cantidadtotal = value; }
        }

        private decimal _costopromedio;

        public decimal CostoPromedio
        {
            get { return _costopromedio; }
            set { _costopromedio = value; }
        }

        #endregion

		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            //PedidoDetalle castObj = (PedidoDetalle)obj;
            //return ( castObj != null ) &&
            //this._idpedidodetalle.Equals( castObj.Id);
            return false;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
            hash = 27 * hash * _idpedidodetalle.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
