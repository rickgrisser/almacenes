/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmClase object for NHibernate mapped table 'cabm_clase'.
	/// </summary>
	[Serializable]
	public class CabmClase
	{
		#region Member Variables
		protected CabmClaseId _id;
		protected string _desclase;
		protected IList<CabmSubclase> _cabmsubclase;
        //add row
        protected CabmSubgrupo _cabmsubgrupo;
       	#endregion
		#region Constructors
			
		public CabmClase() {}

        public CabmClase(CabmClaseId id, string desclase, CabmSubgrupo cabmsubgrupo) 
		{
			this._id= id;
			this._desclase= desclase;
            this._cabmsubgrupo = cabmsubgrupo;
		}

        public CabmClase(CabmClaseId id, CabmSubgrupo cabmsubgrupo)
		{
            this._id = id;
            this._cabmsubgrupo = cabmsubgrupo;
		}
		
		#endregion
		#region Public Properties
		public  virtual CabmClaseId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesClase
		{
			get { return _desclase; }
			set {_desclase= value; }
		}
		public  virtual IList<CabmSubclase> CabmSubclase
		{
			get { return _cabmsubclase; }
			set {_cabmsubclase= value; }
		}
        //Add block
        public virtual CabmSubgrupo CabmSubgrupo
        {
            get { return _cabmsubgrupo; }
            set { _cabmsubgrupo = value; }
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
			CabmClase castObj = (CabmClase)obj;
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
