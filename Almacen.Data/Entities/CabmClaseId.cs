/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmClaseId object for NHibernate mapped table 'cabm_clase'.
	/// </summary>
	[Serializable]
	public class CabmClaseId
	{
		#region Member Variables
		protected string _idclase;
		protected CabmSubgrupo _cabmsubgrupo;
		#endregion
		#region Constructors
			
		public CabmClaseId() {}
					
		public CabmClaseId(string idclase, CabmSubgrupo cabmsubgrupo) 
		{
			this._idclase= idclase;
			this._cabmsubgrupo= cabmsubgrupo;
		}

		#endregion
		#region Public Properties
		public  virtual string IdClase
		{
			get { return _idclase; }
			set {_idclase= value; }
		}
		public  virtual CabmSubgrupo CabmSubgrupo
		{
			get { return _cabmsubgrupo; }
			set {_cabmsubgrupo= value; }
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
			CabmClaseId castObj = (CabmClaseId)obj;
			return ( castObj != null ) &&
			this._idclase == castObj.IdClase &&
			this._cabmsubgrupo.Equals( castObj.CabmSubgrupo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idclase.GetHashCode();
			hash = 27 * hash * _cabmsubgrupo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
