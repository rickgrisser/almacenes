/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// DiscoManual object for NHibernate mapped table 'disco_manual'.
	/// </summary>
	[Serializable]
	public class DiscoManual
	{
		#region Member Variables
		protected DiscoManualId _id;
		protected string _desdiscomanual;
		protected int? _cantidad;
		protected CatSoftware _catsoftware;
		#endregion
		#region Constructors
			
		public DiscoManual() {}
					
		public DiscoManual(DiscoManualId id, string desdiscomanual, int? cantidad, CatSoftware catsoftware) 
		{
			this._id= id;
			this._desdiscomanual= desdiscomanual;
			this._cantidad= cantidad;
			this._catsoftware= catsoftware;
		}

		public DiscoManual(DiscoManualId id, CatSoftware catsoftware)
		{
			this._id= id;
			this._catsoftware= catsoftware;
		}
		
		#endregion
		#region Public Properties
		public  virtual DiscoManualId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesDiscomanual
		{
			get { return _desdiscomanual; }
			set {_desdiscomanual= value; }
		}
		public  virtual int? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual CatSoftware CatSoftware
		{
			get { return _catsoftware; }
			set {_catsoftware= value; }
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
			DiscoManual castObj = (DiscoManual)obj;
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
