/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntregaHistId object for NHibernate mapped table 'resguardo_entrega_hist'.
	/// </summary>
	[Serializable]
	public class ResguardoEntregaHistId
	{
		#region Member Variables
		protected int _identrada;
		protected int _renglonentrada;
		protected int _idresguardo;
		protected int _modresguardo;
		#endregion
		#region Constructors
			
		public ResguardoEntregaHistId() {}
					
		public ResguardoEntregaHistId(int identrada, int renglonentrada, int idresguardo, int modresguardo) 
		{
			this._identrada= identrada;
			this._renglonentrada= renglonentrada;
			this._idresguardo= idresguardo;
			this._modresguardo= modresguardo;
		}

		#endregion
		#region Public Properties
		public  virtual int IdEntrada
		{
			get { return _identrada; }
			set {_identrada= value; }
		}
		public  virtual int RenglonEntrada
		{
			get { return _renglonentrada; }
			set {_renglonentrada= value; }
		}
		public  virtual int IdResguardo
		{
			get { return _idresguardo; }
			set {_idresguardo= value; }
		}
		public  virtual int ModResguardo
		{
			get { return _modresguardo; }
			set {_modresguardo= value; }
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
			ResguardoEntregaHistId castObj = (ResguardoEntregaHistId)obj;
			return ( castObj != null ) &&
			this._identrada == castObj.IdEntrada &&
			this._renglonentrada == castObj.RenglonEntrada &&
			this._idresguardo == castObj.IdResguardo &&
			this._modresguardo == castObj.ModResguardo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _identrada.GetHashCode();
			hash = 27 * hash * _renglonentrada.GetHashCode();
			hash = 27 * hash * _idresguardo.GetHashCode();
			hash = 27 * hash * _modresguardo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
