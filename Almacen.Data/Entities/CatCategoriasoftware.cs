/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatCategoriasoftware object for NHibernate mapped table 'cat_categoriasoftware'.
	/// </summary>
	[Serializable]
	public class CatCategoriasoftware
	{
		#region Member Variables
		protected int _idtiposoftware;
		protected string _destiposoftware;
		protected IList<CatSoftware> _catsoftware;
		#endregion
		#region Constructors
			
		public CatCategoriasoftware() {}
					
		public CatCategoriasoftware(int idtiposoftware, string destiposoftware) 
		{
			this._idtiposoftware= idtiposoftware;
			this._destiposoftware= destiposoftware;
		}

		public CatCategoriasoftware(int idtiposoftware)
		{
			this._idtiposoftware= idtiposoftware;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTiposoftware
		{
			get { return _idtiposoftware; }
			set {_idtiposoftware= value; }
		}
		public  virtual string DesTiposoftware
		{
			get { return _destiposoftware; }
			set {_destiposoftware= value; }
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
			CatCategoriasoftware castObj = (CatCategoriasoftware)obj;
			return ( castObj != null ) &&
			this._idtiposoftware == castObj.IdTiposoftware;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtiposoftware.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
