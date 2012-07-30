/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// SalidaHistId object for NHibernate mapped table 'salida_hist'.
	/// </summary>
	[Serializable]
	public class SalidaHistId
	{
		#region Member Variables
		protected int _idsalida;
		protected int _modsalida;
		#endregion
		#region Constructors
			
		public SalidaHistId() {}
					
		public SalidaHistId(int idsalida, int modsalida) 
		{
			this._idsalida= idsalida;
			this._modsalida= modsalida;
		}

		#endregion
		#region Public Properties
		public  virtual int IdSalida
		{
			get { return _idsalida; }
			set {_idsalida= value; }
		}
		public  virtual int ModSalida
		{
			get { return _modsalida; }
			set {_modsalida= value; }
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
			SalidaHistId castObj = (SalidaHistId)obj;
			return ( castObj != null ) &&
			this._idsalida == castObj.IdSalida &&
			this._modsalida == castObj.ModSalida;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idsalida.GetHashCode();
			hash = 27 * hash * _modsalida.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
