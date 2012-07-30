/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmGrupo object for NHibernate mapped table 'cabm_grupo'.
	/// </summary>
	[Serializable]
	public class CabmGrupo
	{
		#region Member Variables
		protected string _idgrupo;
		protected string _desgrupo;
		protected IList<CabmSubgrupo> _cabmsubgrupo;
		#endregion
		#region Constructors
			
		public CabmGrupo() {}
					
		public CabmGrupo(string idgrupo, string desgrupo) 
		{
			this._idgrupo= idgrupo;
			this._desgrupo= desgrupo;
		}

		public CabmGrupo(string idgrupo)
		{
			this._idgrupo= idgrupo;
		}
		
		#endregion
		#region Public Properties
		public  virtual string IdGrupo
		{
			get { return _idgrupo; }
			set {_idgrupo= value; }
		}
		public  virtual string DesGrupo
		{
			get { return _desgrupo; }
			set {_desgrupo= value; }
		}
		public  virtual IList<CabmSubgrupo> CabmSubgrupo
		{
			get { return _cabmsubgrupo; }
			set {_cabmsubgrupo= value; }
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
			CabmGrupo castObj = (CabmGrupo)obj;
			return ( castObj != null ) &&
			this._idgrupo == castObj.IdGrupo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idgrupo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
