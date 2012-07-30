/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CotizacionHistId object for NHibernate mapped table 'cotizacion_hist'.
	/// </summary>
	[Serializable]
	public class CotizacionHistId
	{
		#region Member Variables
		protected int _idcotizacion;
		protected AnexoHist _anexohist;
		#endregion
		#region Constructors
			
		public CotizacionHistId() {}
					
		public CotizacionHistId(int idcotizacion, AnexoHist anexohist) 
		{
			this._idcotizacion= idcotizacion;
			this._anexohist= anexohist;
		}

		#endregion
		#region Public Properties
		public  virtual int IdCotizacion
		{
			get { return _idcotizacion; }
			set {_idcotizacion= value; }
		}
		public  virtual AnexoHist AnexoHist
		{
			get { return _anexohist; }
			set {_anexohist= value; }
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
			CotizacionHistId castObj = (CotizacionHistId)obj;
			return ( castObj != null ) &&
			this._idcotizacion == castObj.IdCotizacion &&
			this._anexohist.Equals( castObj.AnexoHist);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcotizacion.GetHashCode();
			hash = 27 * hash * _anexohist.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
