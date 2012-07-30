/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// RequisicionHistId object for NHibernate mapped table 'requisicion_hist'.
	/// </summary>
	[Serializable]
	public class RequisicionHistId
	{
		#region Member Variables
		protected int _idrequisicion;
		protected int _modrequisicion;
		#endregion
		#region Constructors
			
		public RequisicionHistId() {}
					
		public RequisicionHistId(int idrequisicion, int modrequisicion) 
		{
			this._idrequisicion= idrequisicion;
			this._modrequisicion= modrequisicion;
		}

		#endregion
		#region Public Properties
		public  virtual int IdRequisicion
		{
			get { return _idrequisicion; }
			set {_idrequisicion= value; }
		}
		public  virtual int ModRequisicion
		{
			get { return _modrequisicion; }
			set {_modrequisicion= value; }
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
			RequisicionHistId castObj = (RequisicionHistId)obj;
			return ( castObj != null ) &&
			this._idrequisicion == castObj.IdRequisicion &&
			this._modrequisicion == castObj.ModRequisicion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idrequisicion.GetHashCode();
			hash = 27 * hash * _modrequisicion.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
