/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// AnexoDetalleHistId object for NHibernate mapped table 'anexo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class AnexoDetalleHistId
	{
		#region Member Variables
		protected AnexoHist _anexohist;
		protected short _renglonanexo;
		#endregion
		#region Constructors
			
		public AnexoDetalleHistId() {}
					
		public AnexoDetalleHistId(AnexoHist anexohist, short renglonanexo) 
		{
			this._anexohist= anexohist;
			this._renglonanexo= renglonanexo;
		}

		#endregion
		#region Public Properties
		public  virtual AnexoHist AnexoHist
		{
			get { return _anexohist; }
			set {_anexohist= value; }
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
			AnexoDetalleHistId castObj = (AnexoDetalleHistId)obj;
			return ( castObj != null ) &&
			this._anexohist.Equals( castObj.AnexoHist) &&
			this._renglonanexo == castObj.RenglonAnexo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _anexohist.GetHashCode();
			hash = 27 * hash * _renglonanexo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
