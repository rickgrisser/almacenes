/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatFabricantesoft object for NHibernate mapped table 'cat_fabricantesoft'.
	/// </summary>
	[Serializable]
	public class CatFabricantesoft
	{
		#region Member Variables
		protected int _idfabricantesoft;
		protected string _desfabricantesoft;
		protected IList<CatSoftware> _catsoftware;
		#endregion
		#region Constructors
			
		public CatFabricantesoft() {}
					
		public CatFabricantesoft(int idfabricantesoft, string desfabricantesoft) 
		{
			this._idfabricantesoft= idfabricantesoft;
			this._desfabricantesoft= desfabricantesoft;
		}

		public CatFabricantesoft(int idfabricantesoft)
		{
			this._idfabricantesoft= idfabricantesoft;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdFabricantesoft
		{
			get { return _idfabricantesoft; }
			set {_idfabricantesoft= value; }
		}
		public  virtual string DesFabricantesoft
		{
			get { return _desfabricantesoft; }
			set {_desfabricantesoft= value; }
		}
		public  virtual IList<CatSoftware> CatSoftware
		{
			get { return _catsoftware; }
			set {_catsoftware= value; }
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
			CatFabricantesoft castObj = (CatFabricantesoft)obj;
			return ( castObj != null ) &&
			this._idfabricantesoft == castObj.IdFabricantesoft;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idfabricantesoft.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
