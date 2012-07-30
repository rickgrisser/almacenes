/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoDetalleHis object for NHibernate mapped table 'pedido_detalle_his'.
	/// </summary>
	[Serializable]
	public class PedidoDetalleHis
	{
		#region Member Variables
		protected PedidoDetalleHisId _id;
		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _cantidad;
		protected decimal? _preciounitario;
		protected IList<PedidoEntregaHis> _pedidoentregahis;
		#endregion
		#region Constructors
			
		public PedidoDetalleHis() {}
					
		public PedidoDetalleHis(PedidoDetalleHisId id, string marca, decimal? cantidad, decimal? preciounitario) 
		{
			this._id= id;
			this._marca= marca;
			this._cantidad= cantidad;
			this._preciounitario= preciounitario;
		}

		public PedidoDetalleHis(PedidoDetalleHisId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual PedidoDetalleHisId Id
		{
			get { return _id; }
			set {_id= value; }
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
		public  virtual IList<PedidoEntregaHis> PedidoEntregaHis
		{
			get { return _pedidoentregahis; }
			set {_pedidoentregahis= value; }
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
			PedidoDetalleHis castObj = (PedidoDetalleHis)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
