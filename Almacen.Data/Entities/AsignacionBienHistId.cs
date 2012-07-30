/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// AsignacionBienHistId object for NHibernate mapped table 'asignacion_bien_hist'.
	/// </summary>
	[Serializable]
	public class AsignacionBienHistId
	{
		#region Member Variables
		protected int _idasignacion;
		protected int _modasignacion;
		#endregion
		#region Constructors
			
		public AsignacionBienHistId() {}
					
		public AsignacionBienHistId(int idasignacion, int modasignacion) 
		{
			this._idasignacion= idasignacion;
			this._modasignacion= modasignacion;
		}

		#endregion
		#region Public Properties
		public  virtual int IdAsignacion
		{
			get { return _idasignacion; }
			set {_idasignacion= value; }
		}
		public  virtual int ModAsignacion
		{
			get { return _modasignacion; }
			set {_modasignacion= value; }
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
			AsignacionBienHistId castObj = (AsignacionBienHistId)obj;
			return ( castObj != null ) &&
			this._idasignacion == castObj.IdAsignacion &&
			this._modasignacion == castObj.ModAsignacion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idasignacion.GetHashCode();
			hash = 27 * hash * _modasignacion.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
