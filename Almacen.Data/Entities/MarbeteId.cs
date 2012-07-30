/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// MarbeteId object for NHibernate mapped table 'marbete'.
	/// </summary>
	[Serializable]
	public class MarbeteId
	{
		#region Member Variables
		protected int _numeromarbete;
		protected Inventario _inventario;
		protected Articulo _articulo;
		#endregion
		#region Constructors
			
		public MarbeteId() {}
					
		public MarbeteId(int numeromarbete, Inventario inventario, Articulo articulo) 
		{
			this._numeromarbete= numeromarbete;
			this._inventario= inventario;
			this._articulo= articulo;
		}

		#endregion
		#region Public Properties
		public  virtual int NumeroMarbete
		{
			get { return _numeromarbete; }
			set {_numeromarbete= value; }
		}
		public  virtual Inventario Inventario
		{
			get { return _inventario; }
			set {_inventario= value; }
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
			MarbeteId castObj = (MarbeteId)obj;
			return ( castObj != null ) &&
			this._numeromarbete == castObj.NumeroMarbete &&
			this._inventario.Equals( castObj.Inventario) &&
			this._articulo.Equals( castObj.Articulo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _numeromarbete.GetHashCode();
			hash = 27 * hash * _inventario.GetHashCode();
			hash = 27 * hash * _articulo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
