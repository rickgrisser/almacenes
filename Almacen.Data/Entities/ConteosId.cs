/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ConteosId object for NHibernate mapped table 'conteos'.
	/// </summary>
	[Serializable]
	public class ConteosId
	{
		#region Member Variables
		protected Marbete _marbete;
		protected Articulo _articulo;
		#endregion
		#region Constructors
			
		public ConteosId() {}
					
		public ConteosId(Marbete marbete, Articulo articulo) 
		{
			this._marbete= marbete;
			this._articulo= articulo;
		}

		#endregion
		#region Public Properties
		public  virtual Marbete Marbete
		{
			get { return _marbete; }
			set {_marbete= value; }
		}
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
			ConteosId castObj = (ConteosId)obj;
			return ( castObj != null ) &&
			this._marbete.Equals( castObj.Marbete) &&
			this._articulo.Equals( castObj.Articulo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _marbete.GetHashCode();
			hash = 27 * hash * _articulo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
