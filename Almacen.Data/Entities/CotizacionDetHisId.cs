/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CotizacionDetHisId object for NHibernate mapped table 'cotizacion_det_his'.
	/// </summary>
	[Serializable]
	public class CotizacionDetHisId
	{
		#region Member Variables
		protected CotizacionHist _cotizacionhist;
		protected short _renglonanexo;
		#endregion
		#region Constructors
			
		public CotizacionDetHisId() {}
					
		public CotizacionDetHisId(CotizacionHist cotizacionhist, short renglonanexo) 
		{
			this._cotizacionhist= cotizacionhist;
			this._renglonanexo= renglonanexo;
		}

		#endregion
		#region Public Properties
		public  virtual CotizacionHist CotizacionHist
		{
			get { return _cotizacionhist; }
			set {_cotizacionhist= value; }
		}
		public  virtual short RenglonAnexo
		{
			get { return _renglonanexo; }
			set {_renglonanexo= value; }
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
			CotizacionDetHisId castObj = (CotizacionDetHisId)obj;
			return ( castObj != null ) &&
			this._cotizacionhist.Equals( castObj.CotizacionHist) &&
			this._renglonanexo == castObj.RenglonAnexo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _cotizacionhist.GetHashCode();
			hash = 27 * hash * _renglonanexo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
