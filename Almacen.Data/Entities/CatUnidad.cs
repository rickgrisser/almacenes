/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatUnidad object for NHibernate mapped table 'cat_unidad'.
	/// </summary>
	[Serializable]
	public class CatUnidad
	{
		#region Member Variables
		protected string _unidad;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _ipterminal;
		protected Usuario _usuario;
		protected IList<Articulo> _articulo;
		#endregion
		#region Constructors
			
		public CatUnidad() {}
					
		public CatUnidad(string unidad, DateTime? fechaalta, DateTime? fechabaja, string estatus, string ipterminal) 
		{
			this._unidad= unidad;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._ipterminal= ipterminal;
		}

		public CatUnidad(string unidad)
		{
			this._unidad= unidad;
		}
		
		#endregion
		#region Public Properties
		public  virtual string Unidad
		{
			get { return _unidad; }
			set {_unidad= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual IList<Articulo> Articulo
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
			CatUnidad castObj = (CatUnidad)obj;
			return ( castObj != null ) &&
			this._unidad == castObj.Unidad;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _unidad.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
