/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmSubclase object for NHibernate mapped table 'cabm_subclase'.
	/// </summary>
	[Serializable]
	public class CabmSubclase
	{
		#region Member Variables
		protected CabmSubclaseId _id;
		protected string _dessubclase;
		protected IList<CabmCodigo> _cabmcodigo;
        //add row
        //add row
        protected CabmClase _cabmclase;
		#endregion
		#region Constructors
			
		public CabmSubclase() {}
					
		public CabmSubclase(CabmSubclaseId id, string dessubclase, CabmClase cabmclase) 
		{
			this._id= id;
			this._dessubclase= dessubclase;
            // add row
            this._cabmclase = cabmclase;
		}

        public CabmSubclase(CabmSubclaseId id, CabmClase cabmclase)
		{
			this._id= id;
            this._cabmclase = cabmclase;
		}
		
		#endregion
		#region Public Properties
		public  virtual CabmSubclaseId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesSubclase
		{
			get { return _dessubclase; }
			set {_dessubclase= value; }
		}
		public  virtual IList<CabmCodigo> CabmCodigo
		{
			get { return _cabmcodigo; }
			set {_cabmcodigo= value; }
		}
        //add block
        public virtual CabmClase CabmClase
        {
            get { return _cabmclase; }
            set { _cabmclase = value; }
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
			CabmSubclase castObj = (CabmSubclase)obj;
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
