/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ArticuloFarmaciaId object for NHibernate mapped table 'articulo_farmacia'.
	/// </summary>
	[Serializable]
	public class ArticuloFarmaciaId
	{
		#region Member Variables
        protected Articulo _articulo;
 
		#endregion
		#region Constructors
			
		public ArticuloFarmaciaId() {}

        public ArticuloFarmaciaId(Articulo articulo) 
		{
			this._articulo= articulo;        
		}

		#endregion
		#region Public Properties
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
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
			ArticuloFarmaciaId castObj = (ArticuloFarmaciaId)obj;
			return ( castObj != null ) &&
            this._articulo.Equals(castObj.Articulo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _articulo.GetHashCode();     
			return hash;
		}
		#endregion
		
	}
}
