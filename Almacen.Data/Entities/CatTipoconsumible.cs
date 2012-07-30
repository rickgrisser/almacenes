/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipoconsumible object for NHibernate mapped table 'cat_tipoconsumible'.
	/// </summary>
	[Serializable]
	public class CatTipoconsumible
	{
		#region Member Variables
		protected int _idtipoconsumible;
		protected string _destipoconsumible;
		protected IList<Consumible> _consumible;
		#endregion
		#region Constructors
			
		public CatTipoconsumible() {}
					
		public CatTipoconsumible(int idtipoconsumible, string destipoconsumible) 
		{
			this._idtipoconsumible= idtipoconsumible;
			this._destipoconsumible= destipoconsumible;
		}

		public CatTipoconsumible(int idtipoconsumible)
		{
			this._idtipoconsumible= idtipoconsumible;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipoconsumible
		{
			get { return _idtipoconsumible; }
			set {_idtipoconsumible= value; }
		}
		public  virtual string DesTipoconsumible
		{
			get { return _destipoconsumible; }
			set {_destipoconsumible= value; }
		}
		public  virtual IList<Consumible> Consumible
		{
			get { return _consumible; }
			set {_consumible= value; }
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
			CatTipoconsumible castObj = (CatTipoconsumible)obj;
			return ( castObj != null ) &&
			this._idtipoconsumible == castObj.IdTipoconsumible;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipoconsumible.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
