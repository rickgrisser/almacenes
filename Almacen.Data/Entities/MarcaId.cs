/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// MarcaId object for NHibernate mapped table 'marca'.
	/// </summary>
	[Serializable]
	public class MarcaId
	{
		#region Member Variables
		protected int _idmarca;
		protected Cabms _cabms;
		#endregion
		#region Constructors
			
		public MarcaId() {}
					
		public MarcaId(int idmarca, Cabms cabms) 
		{
			this._idmarca= idmarca;
			this._cabms= cabms;
		}

		#endregion
		#region Public Properties
		public  virtual int IdMarca
		{
			get { return _idmarca; }
			set {_idmarca= value; }
		}
		public  virtual Cabms Cabms
		{
			get { return _cabms; }
			set {_cabms= value; }
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
			MarcaId castObj = (MarcaId)obj;
			return ( castObj != null ) &&
			this._idmarca == castObj.IdMarca &&
			this._cabms.Equals( castObj.Cabms);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idmarca.GetHashCode();
			hash = 27 * hash * _cabms.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
