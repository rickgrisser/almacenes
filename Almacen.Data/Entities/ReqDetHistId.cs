/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReqDetHistId object for NHibernate mapped table 'req_det_hist'.
	/// </summary>
	[Serializable]
	public class ReqDetHistId
	{
		#region Member Variables
		protected RequisicionHist _requisicionhist;
		protected short _renglon;
		#endregion
		#region Constructors
			
		public ReqDetHistId() {}
					
		public ReqDetHistId(RequisicionHist requisicionhist, short renglon) 
		{
			this._requisicionhist= requisicionhist;
			this._renglon= renglon;
		}

		#endregion
		#region Public Properties
		public  virtual RequisicionHist RequisicionHist
		{
			get { return _requisicionhist; }
			set {_requisicionhist= value; }
		}
		public  virtual short Renglon
		{
			get { return _renglon; }
			set {_renglon= value; }
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
			ReqDetHistId castObj = (ReqDetHistId)obj;
			return ( castObj != null ) &&
			this._requisicionhist.Equals( castObj.RequisicionHist) &&
			this._renglon == castObj.Renglon;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _requisicionhist.GetHashCode();
			hash = 27 * hash * _renglon.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
