/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Modulo object for NHibernate mapped table 'modulo'.
	/// </summary>
	[Serializable]
	public class Modulo
	{
		#region Member Variables
		protected ModuloId _id;
		protected string _desmodulo;
		protected string _estatus;
		protected string _tipo;
		protected IList<UsuarioModulo> _usuariomodulo;
		//protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public Modulo() {}
					
		public Modulo(ModuloId id, string desmodulo, string estatus, string tipo)//, Almacen almacen) 
		{
			this._id= id;
			this._desmodulo= desmodulo;
			this._estatus= estatus;
			this._tipo= tipo;
			//this._almacen= almacen;
		}

		public Modulo(ModuloId id, Almacen almacen)
		{
			this._id= id;
			//this._almacen= almacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual ModuloId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesModulo
		{
			get { return _desmodulo; }
			set {_desmodulo= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual string Tipo
		{
			get { return _tipo; }
			set {_tipo= value; }
		}
		public  virtual IList<UsuarioModulo> UsuarioModulo
		{
			get { return _usuariomodulo; }
			set {_usuariomodulo= value; }
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
			Modulo castObj = (Modulo)obj;
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
