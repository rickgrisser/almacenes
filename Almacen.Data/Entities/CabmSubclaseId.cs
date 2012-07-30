/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmSubclaseId object for NHibernate mapped table 'cabm_subclase'.
	/// </summary>
	[Serializable]
	public class CabmSubclaseId
	{
		#region Member Variables
		protected string _idsubclase;
		protected CabmClase _cabmclase;
		#endregion
		#region Constructors
			
		public CabmSubclaseId() {}
					
		public CabmSubclaseId(string idsubclase, CabmClase cabmclase) 
		{
			this._idsubclase= idsubclase;
			this._cabmclase= cabmclase;
		}

		#endregion
		#region Public Properties
		public  virtual string IdSubclase
		{
			get { return _idsubclase; }
			set {_idsubclase= value; }
		}
		public  virtual CabmClase CabmClase
		{
			get { return _cabmclase; }
			set {_cabmclase= value; }
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
			CabmSubclaseId castObj = (CabmSubclaseId)obj;
			return ( castObj != null ) &&
			this._idsubclase == castObj.IdSubclase &&
			this._cabmclase.Equals( castObj.CabmClase);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idsubclase.GetHashCode();
			hash = 27 * hash * _cabmclase.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
