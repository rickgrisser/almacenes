/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// UsuarioModuloId object for NHibernate mapped table 'usuario_modulo'.
	/// </summary>
	[Serializable]
	public class UsuarioModuloId
	{
		#region Member Variables
		protected Usuario _usuario;
		protected Modulo _modulo;
		#endregion
		#region Constructors
			
		public UsuarioModuloId() {}
					
		public UsuarioModuloId(Usuario usuario, Modulo modulo) 
		{
			this._usuario= usuario;
			this._modulo= modulo;
		}

		#endregion
		#region Public Properties
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual Modulo Modulo
		{
			get { return _modulo; }
			set {_modulo= value; }
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
			UsuarioModuloId castObj = (UsuarioModuloId)obj;
			return ( castObj != null ) &&
			this._usuario.Equals( castObj.Usuario) &&
			this._modulo.Equals( castObj.Modulo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _usuario.GetHashCode();
			hash = 27 * hash * _modulo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
