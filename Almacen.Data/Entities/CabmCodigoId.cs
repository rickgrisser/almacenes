/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmCodigoId object for NHibernate mapped table 'cabm_codigo'.
	/// </summary>
	[Serializable]
	public class CabmCodigoId
	{
		#region Member Variables
		protected string _idcodigo;
		protected CabmSubclase _cabmsubclase;
		#endregion
		#region Constructors
			
		public CabmCodigoId() {}
					
		public CabmCodigoId(string idcodigo, CabmSubclase cabmsubclase) 
		{
			this._idcodigo= idcodigo;
			this._cabmsubclase= cabmsubclase;
		}

		#endregion
		#region Public Properties
		public  virtual string IdCodigo
		{
			get { return _idcodigo; }
			set {_idcodigo= value; }
		}
		public  virtual CabmSubclase CabmSubclase
		{
			get { return _cabmsubclase; }
			set {_cabmsubclase= value; }
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
			CabmCodigoId castObj = (CabmCodigoId)obj;
			return ( castObj != null ) &&
			this._idcodigo == castObj.IdCodigo &&
			this._cabmsubclase.Equals( castObj.CabmSubclase);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcodigo.GetHashCode();
			hash = 27 * hash * _cabmsubclase.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
