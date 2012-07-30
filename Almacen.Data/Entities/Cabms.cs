/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Cabms object for NHibernate mapped table 'cabms'.
	/// </summary>
	[Serializable]
	public class Cabms
	{
		#region Member Variables
		protected int _idcabms;
		protected CabmCodigo _cabmcodigo;
		protected IList<Marca> _marca;
		#endregion
		#region Constructors
			
		public Cabms() {}
					
		public Cabms(int idcabms) 
		{
			this._idcabms= idcabms;
		}

		#endregion
		#region Public Properties
		public  virtual int IdCabms
		{
			get { return _idcabms; }
			set {_idcabms= value; }
		}
		public  virtual CabmCodigo CabmCodigo
		{
			get { return _cabmcodigo; }
			set {_cabmcodigo= value; }
		}
		public  virtual IList<Marca> Marca
		{
			get { return _marca; }
			set {_marca= value; }
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
			Cabms castObj = (Cabms)obj;
			return ( castObj != null ) &&
			this._idcabms == castObj.IdCabms;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcabms.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
