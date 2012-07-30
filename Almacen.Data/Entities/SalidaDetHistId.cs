/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// SalidaDetHistId object for NHibernate mapped table 'salida_det_hist'.
	/// </summary>
	[Serializable]
	public class SalidaDetHistId
	{
		#region Member Variables
		protected SalidaHist _salidahist;
		protected int _renglonsalida;
		#endregion
		#region Constructors
			
		public SalidaDetHistId() {}
					
		public SalidaDetHistId(SalidaHist salidahist, int renglonsalida) 
		{
			this._salidahist= salidahist;
			this._renglonsalida= renglonsalida;
		}

		#endregion
		#region Public Properties
		public  virtual SalidaHist SalidaHist
		{
			get { return _salidahist; }
			set {_salidahist= value; }
		}
		public  virtual int RenglonSalida
		{
			get { return _renglonsalida; }
			set {_renglonsalida= value; }
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
			SalidaDetHistId castObj = (SalidaDetHistId)obj;
			return ( castObj != null ) &&
			this._salidahist.Equals( castObj.SalidaHist) &&
			this._renglonsalida == castObj.RenglonSalida;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _salidahist.GetHashCode();
			hash = 27 * hash * _renglonsalida.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
