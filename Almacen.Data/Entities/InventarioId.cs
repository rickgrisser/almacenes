/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// InventarioId object for NHibernate mapped table 'inventario'.
	/// </summary>
	[Serializable]
	public class InventarioId
	{
		#region Member Variables
		protected DateTime _fechainventario;
		protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public InventarioId() {}
					
		public InventarioId(DateTime fechainventario, Almacen almacen) 
		{
			this._fechainventario= fechainventario;
			this._almacen= almacen;
		}

		#endregion
		#region Public Properties
		public  virtual DateTime FechaInventario
		{
			get { return _fechainventario; }
			set {_fechainventario= value; }
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
			InventarioId castObj = (InventarioId)obj;
			return ( castObj != null ) &&
			this._fechainventario == castObj.FechaInventario &&
			this._almacen.Equals( castObj.Almacen);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _fechainventario.GetHashCode();
			hash = 27 * hash * _almacen.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
