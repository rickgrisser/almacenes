/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReservaSolicHistId object for NHibernate mapped table 'reserva_solic_hist'.
	/// </summary>
	[Serializable]
	public class ReservaSolicHistId
	{
		#region Member Variables
		protected int _idreserva;
		protected int _modreservasolicit;
		#endregion
		#region Constructors
			
		public ReservaSolicHistId() {}
					
		public ReservaSolicHistId(int idreserva, int modreservasolicit) 
		{
			this._idreserva= idreserva;
			this._modreservasolicit= modreservasolicit;
		}

		#endregion
		#region Public Properties
		public  virtual int IdReserva
		{
			get { return _idreserva; }
			set {_idreserva= value; }
		}
		public  virtual int ModReservasolicit
		{
			get { return _modreservasolicit; }
			set {_modreservasolicit= value; }
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
			ReservaSolicHistId castObj = (ReservaSolicHistId)obj;
			return ( castObj != null ) &&
			this._idreserva == castObj.IdReserva &&
			this._modreservasolicit == castObj.ModReservasolicit;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idreserva.GetHashCode();
			hash = 27 * hash * _modreservasolicit.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
