/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoDetalleHisId object for NHibernate mapped table 'pedido_detalle_his'.
	/// </summary>
	[Serializable]
	public class PedidoDetalleHisId
	{
		#region Member Variables
		protected PedidoHist _pedidohist;
		protected int _renglonpedido;
		#endregion
		#region Constructors
			
		public PedidoDetalleHisId() {}
					
		public PedidoDetalleHisId(PedidoHist pedidohist, int renglonpedido) 
		{
			this._pedidohist= pedidohist;
			this._renglonpedido= renglonpedido;
		}

		#endregion
		#region Public Properties
		public  virtual PedidoHist PedidoHist
		{
			get { return _pedidohist; }
			set {_pedidohist= value; }
		}
		public  virtual int RenglonPedido
		{
			get { return _renglonpedido; }
			set {_renglonpedido= value; }
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
			PedidoDetalleHisId castObj = (PedidoDetalleHisId)obj;
			return ( castObj != null ) &&
			this._pedidohist.Equals( castObj.PedidoHist) &&
			this._renglonpedido == castObj.RenglonPedido;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _pedidohist.GetHashCode();
			hash = 27 * hash * _renglonpedido.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
