/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// AnexoHistId object for NHibernate mapped table 'anexo_hist'.
	/// </summary>
	[Serializable]
	public class AnexoHistId
	{
		#region Member Variables
		protected int _idanexo;
		protected int _modanexo;
		#endregion
		#region Constructors
			
		public AnexoHistId() {}
					
		public AnexoHistId(int idanexo, int modanexo) 
		{
			this._idanexo= idanexo;
			this._modanexo= modanexo;
		}

		#endregion
		#region Public Properties
		public  virtual int IdAnexo
		{
			get { return _idanexo; }
			set {_idanexo= value; }
		}
		public  virtual int ModAnexo
		{
			get { return _modanexo; }
			set {_modanexo= value; }
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
			AnexoHistId castObj = (AnexoHistId)obj;
			return ( castObj != null ) &&
			this._idanexo == castObj.IdAnexo &&
			this._modanexo == castObj.ModAnexo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idanexo.GetHashCode();
			hash = 27 * hash * _modanexo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
