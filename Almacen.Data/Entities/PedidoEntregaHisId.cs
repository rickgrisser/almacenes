/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoEntregaHisId object for NHibernate mapped table 'pedido_entrega_his'.
	/// </summary>
	[Serializable]
	public class PedidoEntregaHisId
	{
		#region Member Variables
		protected PedidoDetalleHis _pedidodetallehis;
		protected int _entrega;
		#endregion
		#region Constructors
			
		public PedidoEntregaHisId() {}
					
		public PedidoEntregaHisId(PedidoDetalleHis pedidodetallehis, int entrega) 
		{
			this._pedidodetallehis= pedidodetallehis;
			this._entrega= entrega;
		}

		#endregion
		#region Public Properties
		public  virtual PedidoDetalleHis PedidoDetalleHis
		{
			get { return _pedidodetallehis; }
			set {_pedidodetallehis= value; }
		}
		public  virtual int Entrega
		{
			get { return _entrega; }
			set {_entrega= value; }
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
			PedidoEntregaHisId castObj = (PedidoEntregaHisId)obj;
			return ( castObj != null ) &&
			this._pedidodetallehis.Equals( castObj.PedidoDetalleHis) &&
			this._entrega == castObj.Entrega;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _pedidodetallehis.GetHashCode();
			hash = 27 * hash * _entrega.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
