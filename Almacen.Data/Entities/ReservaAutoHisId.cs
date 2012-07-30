/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReservaAutoHisId object for NHibernate mapped table 'reserva_auto_his'.
	/// </summary>
	[Serializable]
	public class ReservaAutoHisId
	{
		#region Member Variables
		protected int _idreservaautoriza;
		protected int _modificacionreser;
		#endregion
		#region Constructors
			
		public ReservaAutoHisId() {}
					
		public ReservaAutoHisId(int idreservaautoriza, int modificacionreser) 
		{
			this._idreservaautoriza= idreservaautoriza;
			this._modificacionreser= modificacionreser;
		}

		#endregion
		#region Public Properties
		public  virtual int IdReservaautoriza
		{
			get { return _idreservaautoriza; }
			set {_idreservaautoriza= value; }
		}
		public  virtual int ModificacionReser
		{
			get { return _modificacionreser; }
			set {_modificacionreser= value; }
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
			ReservaAutoHisId castObj = (ReservaAutoHisId)obj;
			return ( castObj != null ) &&
			this._idreservaautoriza == castObj.IdReservaautoriza &&
			this._modificacionreser == castObj.ModificacionReser;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idreservaautoriza.GetHashCode();
			hash = 27 * hash * _modificacionreser.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
