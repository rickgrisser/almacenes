/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipocomputadora object for NHibernate mapped table 'cat_tipocomputadora'.
	/// </summary>
	[Serializable]
	public class CatTipocomputadora
	{
		#region Member Variables
		protected int _idtipocomputadora;
		protected string _destipocomputadora;
		protected IList<Cpu> _cpu;
		#endregion
		#region Constructors
			
		public CatTipocomputadora() {}
					
		public CatTipocomputadora(int idtipocomputadora, string destipocomputadora) 
		{
			this._idtipocomputadora= idtipocomputadora;
			this._destipocomputadora= destipocomputadora;
		}

		public CatTipocomputadora(int idtipocomputadora)
		{
			this._idtipocomputadora= idtipocomputadora;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipocomputadora
		{
			get { return _idtipocomputadora; }
			set {_idtipocomputadora= value; }
		}
		public  virtual string DesTipocomputadora
		{
			get { return _destipocomputadora; }
			set {_destipocomputadora= value; }
		}
		public  virtual IList<Cpu> Cpu
		{
			get { return _cpu; }
			set {_cpu= value; }
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
			CatTipocomputadora castObj = (CatTipocomputadora)obj;
			return ( castObj != null ) &&
			this._idtipocomputadora == castObj.IdTipocomputadora;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipocomputadora.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
