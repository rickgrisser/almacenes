/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmSubgrupoId object for NHibernate mapped table 'cabm_subgrupo'.
	/// </summary>
	[Serializable]
	public class CabmSubgrupoId
	{
		#region Member Variables
		protected string _idsubgrupo;
		protected CabmGrupo _cabmgrupo;
		#endregion
		#region Constructors
			
		public CabmSubgrupoId() {}
					
		public CabmSubgrupoId(string idsubgrupo, CabmGrupo cabmgrupo) 
		{
			this._idsubgrupo= idsubgrupo;
			this._cabmgrupo= cabmgrupo;
		}

		#endregion
		#region Public Properties
		public  virtual string IdSubgrupo
		{
			get { return _idsubgrupo; }
			set {_idsubgrupo= value; }
		}
		public  virtual CabmGrupo CabmGrupo
		{
			get { return _cabmgrupo; }
			set {_cabmgrupo= value; }
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
			CabmSubgrupoId castObj = (CabmSubgrupoId)obj;
			return ( castObj != null ) &&
			this._idsubgrupo == castObj.IdSubgrupo &&
			this._cabmgrupo.Equals( castObj.CabmGrupo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idsubgrupo.GetHashCode();
			hash = 27 * hash * _cabmgrupo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
