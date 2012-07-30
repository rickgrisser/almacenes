/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CabmCodigo object for NHibernate mapped table 'cabm_codigo'.
	/// </summary>
	[Serializable]
	public class CabmCodigo
	{
		#region Member Variables
		protected CabmCodigoId _id;
		protected string _descodigo;
		protected IList<Cabms> _cabms;
        //add row
        protected CabmSubclase _cabmsubclase;

		#endregion
		#region Constructors
			
		public CabmCodigo() {}
					
		public CabmCodigo(CabmCodigoId id, string descodigo, CabmSubclase cabmsubclase) 
		{
			this._id= id;
			this._descodigo= descodigo;
            //add row
            this._cabmsubclase = cabmsubclase;
		}

        public CabmCodigo(CabmCodigoId id, CabmSubclase cabmsubclase)
		{
			this._id= id;
            //add row
            this._cabmsubclase = cabmsubclase;
		}
		
		#endregion
		#region Public Properties
		public  virtual CabmCodigoId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesCodigo
		{
			get { return _descodigo; }
			set {_descodigo= value; }
		}
		public  virtual IList<Cabms> Cabms
		{
			get { return _cabms; }
			set {_cabms= value; }
		}
        //add block
        public virtual CabmSubclase CabmSubclase
        {
            get { return _cabmsubclase; }
            set { _cabmsubclase = value; }
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
			CabmCodigo castObj = (CabmCodigo)obj;
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
