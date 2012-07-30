/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Marbete object for NHibernate mapped table 'marbete'.
	/// </summary>
	[Serializable]
	public class Marbete
	{
		#region Member Variables
		protected MarbeteId _id;
		protected Articulo _articulo;
		protected DateTime? _fechaalta;
		protected Usuario _usuario;
		protected IList<Conteos> _conteos;
		#endregion
		#region Constructors
			
		public Marbete() {}
					
		public Marbete(MarbeteId id, Articulo articulo, DateTime? fechaalta) 
		{
			this._id= id;
			this._articulo= articulo;
			this._fechaalta= fechaalta;
		}

		public Marbete(MarbeteId id, Articulo articulo)
		{
			this._id= id;
			this._articulo= articulo;
		}
		
		#endregion
		#region Public Properties
		public  virtual MarbeteId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual IList<Conteos> Conteos
		{
			get { return _conteos; }
			set {_conteos= value; }
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
			Marbete castObj = (Marbete)obj;
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
