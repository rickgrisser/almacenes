/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// DiscoManualId object for NHibernate mapped table 'disco_manual'.
	/// </summary>
	[Serializable]
	public class DiscoManualId
	{
		#region Member Variables
		protected int _iddiscomanual;
		protected CatSoftware _catsoftware;
		#endregion
		#region Constructors
			
		public DiscoManualId() {}
					
		public DiscoManualId(int iddiscomanual, CatSoftware catsoftware) 
		{
			this._iddiscomanual= iddiscomanual;
			this._catsoftware= catsoftware;
		}

		#endregion
		#region Public Properties
		public  virtual int IdDiscomanual
		{
			get { return _iddiscomanual; }
			set {_iddiscomanual= value; }
		}
		public  virtual CatSoftware CatSoftware
		{
			get { return _catsoftware; }
			set {_catsoftware= value; }
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
			DiscoManualId castObj = (DiscoManualId)obj;
			return ( castObj != null ) &&
			this._iddiscomanual == castObj.IdDiscomanual &&
			this._catsoftware.Equals( castObj.CatSoftware);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _iddiscomanual.GetHashCode();
			hash = 27 * hash * _catsoftware.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
