/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReqDetHist object for NHibernate mapped table 'req_det_hist'.
	/// </summary>
	[Serializable]
	public class ReqDetHist
	{
		#region Member Variables
		protected ReqDetHistId _id;
		protected Articulo _articulo;
		protected decimal? _cantidad;
		#endregion
		#region Constructors
			
		public ReqDetHist() {}
					
		public ReqDetHist(ReqDetHistId id, decimal? cantidad) 
		{
			this._id= id;
			this._cantidad= cantidad;
		}

		public ReqDetHist(ReqDetHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ReqDetHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
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
			ReqDetHist castObj = (ReqDetHist)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
