/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipoanexotecnico object for NHibernate mapped table 'cat_tipoanexotecnico'.
	/// </summary>
	[Serializable]
	public class CatTipoanexotecnico
	{
		#region Member Variables
		protected int _idtipoanexotecnico;
		protected string _destipoanexotecnico;
		#endregion
		#region Constructors
			
		public CatTipoanexotecnico() {}
					
		public CatTipoanexotecnico(int idtipoanexotecnico, string destipoanexotecnico) 
		{
			this._idtipoanexotecnico= idtipoanexotecnico;
			this._destipoanexotecnico= destipoanexotecnico;
		}

		public CatTipoanexotecnico(int idtipoanexotecnico)
		{
			this._idtipoanexotecnico= idtipoanexotecnico;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipoanexotecnico
		{
			get { return _idtipoanexotecnico; }
			set {_idtipoanexotecnico= value; }
		}
		public  virtual string DesTipoanexotecnico
		{
			get { return _destipoanexotecnico; }
			set {_destipoanexotecnico= value; }
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
			CatTipoanexotecnico castObj = (CatTipoanexotecnico)obj;
			return ( castObj != null ) &&
			this._idtipoanexotecnico == castObj.IdTipoanexotecnico;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipoanexotecnico.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
