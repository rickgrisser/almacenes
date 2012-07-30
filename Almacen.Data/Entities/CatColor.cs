/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatColor object for NHibernate mapped table 'cat_color'.
	/// </summary>
	[Serializable]
	public class CatColor
	{
		#region Member Variables
		protected int _idcolor;
		protected string _descolor;
		protected IList<Consumible> _consumible;
		#endregion
		#region Constructors
			
		public CatColor() {}
					
		public CatColor(int idcolor, string descolor) 
		{
			this._idcolor= idcolor;
			this._descolor= descolor;
		}

		#endregion
		#region Public Properties
		public  virtual int IdColor
		{
			get { return _idcolor; }
			set {_idcolor= value; }
		}
		public  virtual string DesColor
		{
			get { return _descolor; }
			set {_descolor= value; }
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
			CatColor castObj = (CatColor)obj;
			return ( castObj != null ) &&
			this._idcolor == castObj.IdColor;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcolor.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
