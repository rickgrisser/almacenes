/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// UsuarioModulo object for NHibernate mapped table 'usuario_modulo'.
	/// </summary>
	[Serializable]
	public class UsuarioModulo
	{
		#region Member Variables
		protected UsuarioModuloId _id;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		//protected Usuario _usuario;
		#endregion
		#region Constructors
			
		public UsuarioModulo() {}
					
		public UsuarioModulo(UsuarioModuloId id, DateTime? fechaalta, DateTime? fechabaja, string estatus)//, Usuario usuario) 
		{
			this._id= id;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			//this._usuario= usuario;
		}

		public UsuarioModulo(UsuarioModuloId id, Usuario usuario)
		{
			this._id= id;
			//this._usuario= usuario;
		}
		
		#endregion
		#region Public Properties
		public  virtual UsuarioModuloId Id
		{
			get { return _id; }
			set {_id= value; }
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
        //public  virtual Usuario Usuario
        //{
        //    get { return _usuario; }
        //    set {_usuario= value; }
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
			UsuarioModulo castObj = (UsuarioModulo)obj;
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
