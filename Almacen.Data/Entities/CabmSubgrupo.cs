/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmSubgrupo object for NHibernate mapped table 'cabm_subgrupo'.
	/// </summary>
	[Serializable]
	public class CabmSubgrupo
	{
		#region Member Variables
		protected CabmSubgrupoId _id;
		protected string _dessubgrupo;
		protected IList<CabmClase> _cabmclase;
		protected CabmGrupo _cabmgrupo;
		#endregion
		#region Constructors
			
		public CabmSubgrupo() {}
					
		public CabmSubgrupo(CabmSubgrupoId id, string dessubgrupo, CabmGrupo cabmgrupo) 
		{
			this._id= id;
			this._dessubgrupo= dessubgrupo;
			this._cabmgrupo= cabmgrupo;
		}

		public CabmSubgrupo(CabmSubgrupoId id, CabmGrupo cabmgrupo)
		{
			this._id= id;
			this._cabmgrupo= cabmgrupo;
		}
		
		#endregion
		#region Public Properties
		public  virtual CabmSubgrupoId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesSubgrupo
		{
			get { return _dessubgrupo; }
			set {_dessubgrupo= value; }
		}
		public  virtual IList<CabmClase> CabmClase
		{
			get { return _cabmclase; }
			set {_cabmclase= value; }
		}
        public virtual CabmGrupo CabmGrupo
        {
            get { return _cabmgrupo; }
            set { _cabmgrupo = value; }
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
			CabmSubgrupo castObj = (CabmSubgrupo)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
