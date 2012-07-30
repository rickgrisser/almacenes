/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Inventario object for NHibernate mapped table 'inventario'.
	/// </summary>
	[Serializable]
	public class Inventario
	{
		#region Member Variables
		protected InventarioId _id;
		protected DateTime? _fechaalta;
		protected string _estatus;
		protected IList<Marbete> _marbete;
		protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public Inventario() {}
					
		public Inventario(InventarioId id, DateTime? fechaalta, string estatus, Almacen almacen) 
		{
			this._id= id;
			this._fechaalta= fechaalta;
			this._estatus= estatus;
			this._almacen= almacen;
		}

		public Inventario(InventarioId id, Almacen almacen)
		{
			this._id= id;
			this._almacen= almacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual InventarioId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual IList<Marbete> Marbete
		{
			get { return _marbete; }
			set {_marbete= value; }
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
			Inventario castObj = (Inventario)obj;
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
