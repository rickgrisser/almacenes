/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// FalloDetalleHistId object for NHibernate mapped table 'fallo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class FalloDetalleHistId
	{
		#region Member Variables
		protected FalloHist _fallohist;
		protected short _renglonanexo;
		#endregion
		#region Constructors
			
		public FalloDetalleHistId() {}
					
		public FalloDetalleHistId(FalloHist fallohist, short renglonanexo) 
		{
			this._fallohist= fallohist;
			this._renglonanexo= renglonanexo;
		}

		#endregion
		#region Public Properties
		public  virtual FalloHist FalloHist
		{
			get { return _fallohist; }
			set {_fallohist= value; }
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
			FalloDetalleHistId castObj = (FalloDetalleHistId)obj;
			return ( castObj != null ) &&
			this._fallohist.Equals( castObj.FalloHist) &&
			this._renglonanexo == castObj.RenglonAnexo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _fallohist.GetHashCode();
			hash = 27 * hash * _renglonanexo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
