/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipopuerto object for NHibernate mapped table 'cat_tipopuerto'.
	/// </summary>
	[Serializable]
	public class CatTipopuerto
	{
		#region Member Variables
		protected int _idpuerto;
		protected string _destipopuerto;
        //protected IList<Impresora> _impresora;
        //protected IList<Mouse> _mouse;
		protected IList<Teclado> _teclado;
		#endregion
		#region Constructors
			
		public CatTipopuerto() {}
					
		public CatTipopuerto(int idpuerto, string destipopuerto) 
		{
			this._idpuerto= idpuerto;
			this._destipopuerto= destipopuerto;
		}

		public CatTipopuerto(int idpuerto)
		{
			this._idpuerto= idpuerto;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdPuerto
		{
			get { return _idpuerto; }
			set {_idpuerto= value; }
		}
		public  virtual string DesTipopuerto
		{
			get { return _destipopuerto; }
			set {_destipopuerto= value; }
		}
        //public  virtual IList<Impresora> Impresora
        //{
        //    get { return _impresora; }
        //    set {_impresora= value; }
        //}
        //public  virtual IList<Mouse> Mouse
        //{
        //    get { return _mouse; }
        //    set {_mouse= value; }
        //}
		public  virtual IList<Teclado> Teclado
		{
			get { return _teclado; }
			set {_teclado= value; }
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
			CatTipopuerto castObj = (CatTipopuerto)obj;
			return ( castObj != null ) &&
			this._idpuerto == castObj.IdPuerto;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idpuerto.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
