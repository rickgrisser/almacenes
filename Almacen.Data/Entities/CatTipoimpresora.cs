/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipoimpresora object for NHibernate mapped table 'cat_tipoimpresora'.
	/// </summary>
	[Serializable]
	public class CatTipoimpresora
	{
		#region Member Variables
		protected int _idtipoimpresora;
		protected string _destipoimpresora;
		protected IList<Consumible> _consumible;
		//protected IList<Impresora> _impresora;
		#endregion
		#region Constructors
			
		public CatTipoimpresora() {}
					
		public CatTipoimpresora(int idtipoimpresora, string destipoimpresora) 
		{
			this._idtipoimpresora= idtipoimpresora;
			this._destipoimpresora= destipoimpresora;
		}

		public CatTipoimpresora(int idtipoimpresora)
		{
			this._idtipoimpresora= idtipoimpresora;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipoimpresora
		{
			get { return _idtipoimpresora; }
			set {_idtipoimpresora= value; }
		}
		public  virtual string DesTipoimpresora
		{
			get { return _destipoimpresora; }
			set {_destipoimpresora= value; }
		}
		public  virtual IList<Consumible> Consumible
		{
			get { return _consumible; }
			set {_consumible= value; }
		}
        //public  virtual IList<Impresora> Impresora
        //{
        //    get { return _impresora; }
        //    set {_impresora= value; }
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
			CatTipoimpresora castObj = (CatTipoimpresora)obj;
			return ( castObj != null ) &&
			this._idtipoimpresora == castObj.IdTipoimpresora;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipoimpresora.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
