/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatRecurso object for NHibernate mapped table 'cat_recurso'.
	/// </summary>
	[Serializable]
	public class CatRecurso
	{
		#region Member Variables
		protected string _idrecurso;
		protected string _desrecurso;
		#endregion
		#region Constructors
			
		public CatRecurso() {}
					
		public CatRecurso(string idrecurso, string desrecurso) 
		{
			this._idrecurso= idrecurso;
			this._desrecurso= desrecurso;
		}

		public CatRecurso(string idrecurso)
		{
			this._idrecurso= idrecurso;
		}
		
		#endregion
		#region Public Properties
		public  virtual string IdRecurso
		{
			get { return _idrecurso; }
			set {_idrecurso= value; }
		}
		public  virtual string DesRecurso
		{
			get { return _desrecurso; }
			set {_desrecurso= value; }
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
			CatRecurso castObj = (CatRecurso)obj;
			return ( castObj != null ) &&
			this._idrecurso == castObj.IdRecurso;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idrecurso.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
