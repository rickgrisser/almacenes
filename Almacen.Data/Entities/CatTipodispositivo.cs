/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipodispositivo object for NHibernate mapped table 'cat_tipodispositivo'.
	/// </summary>
	[Serializable]
	public class CatTipodispositivo
	{
		#region Member Variables
		protected int _idtipodispositivo;
		protected string _desdispositivo;
		protected IList<Dispositivo> _dispositivo;
		#endregion
		#region Constructors
			
		public CatTipodispositivo() {}
					
		public CatTipodispositivo(int idtipodispositivo, string desdispositivo) 
		{
			this._idtipodispositivo= idtipodispositivo;
			this._desdispositivo= desdispositivo;
		}

		public CatTipodispositivo(int idtipodispositivo)
		{
			this._idtipodispositivo= idtipodispositivo;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipodispositivo
		{
			get { return _idtipodispositivo; }
			set {_idtipodispositivo= value; }
		}
		public  virtual string DesDispositivo
		{
			get { return _desdispositivo; }
			set {_desdispositivo= value; }
		}
		public  virtual IList<Dispositivo> Dispositivo
		{
			get { return _dispositivo; }
			set {_dispositivo= value; }
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
			CatTipodispositivo castObj = (CatTipodispositivo)obj;
			return ( castObj != null ) &&
			this._idtipodispositivo == castObj.IdTipodispositivo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipodispositivo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
