/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ArticuloId object for NHibernate mapped table 'articulo'.
	/// </summary>
	[Serializable]
	public class ArticuloId
	{
		#region Member Variables
		protected int _cveart;
		protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public ArticuloId() {}
					
		public ArticuloId(int cveart, Almacen almacen) 
		{
			this._cveart= cveart;
			this._almacen= almacen;
		}

		#endregion
		#region Public Properties
		public  virtual int CveArt
		{
			get { return _cveart; }
			set {_cveart= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
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
			ArticuloId castObj = (ArticuloId)obj;
			return ( castObj != null ) &&
			this._cveart == castObj.CveArt &&
			this._almacen.Equals( castObj.Almacen);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
            //hash = 27 * hash * _cveart.GetHashCode();
            //hash = 27 * hash * _almacen.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
