/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// IvaId object for NHibernate mapped table 'iva'.
	/// </summary>
	[Serializable]
	public class IvaId
	{
		#region Member Variables
		protected int _idiva;
		protected short _porcentaje;
		#endregion
		#region Constructors
			
		public IvaId() {}
					
		public IvaId(int idiva, short porcentaje) 
		{
			this._idiva= idiva;
			this._porcentaje= porcentaje;
		}

		#endregion
		#region Public Properties
		public  virtual int IdIva
		{
			get { return _idiva; }
			set {_idiva= value; }
		}
		public  virtual short Porcentaje
		{
			get { return _porcentaje; }
			set {_porcentaje= value; }
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
			IvaId castObj = (IvaId)obj;
			return ( castObj != null ) &&
			this._idiva == castObj.IdIva &&
			this._porcentaje == castObj.Porcentaje;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idiva.GetHashCode();
			hash = 27 * hash * _porcentaje.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
