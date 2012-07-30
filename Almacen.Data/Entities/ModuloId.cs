/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ModuloId object for NHibernate mapped table 'modulo'.
	/// </summary>
	[Serializable]
	public class ModuloId
	{
		#region Member Variables
		protected string _idmodulo;
		protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public ModuloId() {}
					
		public ModuloId(string idmodulo, Almacen almacen) 
		{
			this._idmodulo= idmodulo;
			this._almacen= almacen;
		}

		#endregion
		#region Public Properties
		public  virtual string IdModulo
		{
			get { return _idmodulo; }
			set {_idmodulo= value; }
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
			ModuloId castObj = (ModuloId)obj;
			return ( castObj != null ) &&
			this._idmodulo == castObj.IdModulo &&
			this._almacen.Equals( castObj.Almacen);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idmodulo.GetHashCode();
			hash = 27 * hash * _almacen.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
