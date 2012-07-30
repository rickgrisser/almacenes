/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoHistId object for NHibernate mapped table 'pedido_hist'.
	/// </summary>
	[Serializable]
	public class PedidoHistId
	{
		#region Member Variables
		protected int _idpedido;
		protected int _modpedhist;
		#endregion
		#region Constructors
			
		public PedidoHistId() {}
					
		public PedidoHistId(int idpedido, int modpedhist) 
		{
			this._idpedido= idpedido;
			this._modpedhist= modpedhist;
		}

		#endregion
		#region Public Properties
		public  virtual int IdPedido
		{
			get { return _idpedido; }
			set {_idpedido= value; }
		}
		public  virtual int ModPedHist
		{
			get { return _modpedhist; }
			set {_modpedhist= value; }
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
			PedidoHistId castObj = (PedidoHistId)obj;
			return ( castObj != null ) &&
			this._idpedido == castObj.IdPedido &&
			this._modpedhist == castObj.ModPedHist;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idpedido.GetHashCode();
			hash = 27 * hash * _modpedhist.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
