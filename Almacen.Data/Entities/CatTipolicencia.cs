/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipolicencia object for NHibernate mapped table 'cat_tipolicencia'.
	/// </summary>
	[Serializable]
	public class CatTipolicencia
	{
		#region Member Variables
		protected int _idtipolicencia;
		protected string _destipolicencia;
		protected IList<CatSoftware> _catsoftware;
		#endregion
		#region Constructors
			
		public CatTipolicencia() {}
					
		public CatTipolicencia(int idtipolicencia, string destipolicencia) 
		{
			this._idtipolicencia= idtipolicencia;
			this._destipolicencia= destipolicencia;
		}

		public CatTipolicencia(int idtipolicencia)
		{
			this._idtipolicencia= idtipolicencia;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipolicencia
		{
			get { return _idtipolicencia; }
			set {_idtipolicencia= value; }
		}
		public  virtual string DesTipolicencia
		{
			get { return _destipolicencia; }
			set {_destipolicencia= value; }
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
			CatTipolicencia castObj = (CatTipolicencia)obj;
			return ( castObj != null ) &&
			this._idtipolicencia == castObj.IdTipolicencia;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipolicencia.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
