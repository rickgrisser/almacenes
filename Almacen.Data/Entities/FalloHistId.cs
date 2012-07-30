/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// FalloHistId object for NHibernate mapped table 'fallo_hist'.
	/// </summary>
	[Serializable]
	public class FalloHistId
	{
		#region Member Variables
		protected int _idfallo;
		protected int _modfallo;
		#endregion
		#region Constructors
			
		public FalloHistId() {}
					
		public FalloHistId(int idfallo, int modfallo) 
		{
			this._idfallo= idfallo;
			this._modfallo= modfallo;
		}

		#endregion
		#region Public Properties
		public  virtual int IdFallo
		{
			get { return _idfallo; }
			set {_idfallo= value; }
		}
		public  virtual int ModFallo
		{
			get { return _modfallo; }
			set {_modfallo= value; }
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
			FalloHistId castObj = (FalloHistId)obj;
			return ( castObj != null ) &&
			this._idfallo == castObj.IdFallo &&
			this._modfallo == castObj.ModFallo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idfallo.GetHashCode();
			hash = 27 * hash * _modfallo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
