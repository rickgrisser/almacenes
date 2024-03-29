/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CostoPromedioId object for NHibernate mapped table 'costo_promedio'.
	/// </summary>
	[Serializable]
	public class CostoPromedioId
	{
		#region Member Variables
		protected Articulo _articulo;
        //protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public CostoPromedioId() {}
					
		public CostoPromedioId(Articulo articulo)//, Almacen almacen) 
		{
			this._articulo= articulo;
			//this._almacen= almacen;
		}

		#endregion
		#region Public Properties
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
        //public  virtual Almacen Almacen
        //{
        //    get { return _almacen; }
        //    set {_almacen= value; }
        //}
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			CostoPromedioId castObj = (CostoPromedioId)obj;
            return (castObj != null) &&
            this._articulo.Equals(castObj.Articulo); //&&
            //this._almacen.Equals( castObj.Almacen);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _articulo.GetHashCode();
			//hash = 27 * hash * _almacen.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
