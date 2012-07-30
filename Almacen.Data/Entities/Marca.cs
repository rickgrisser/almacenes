/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Marca object for NHibernate mapped table 'marca'.
	/// </summary>
	[Serializable]
	public class Marca
	{
		#region Member Variables
		protected MarcaId _id;
		protected string _desmarca;
		protected IList<Modelo> _modelo;
        protected Cabms _cabms;
		#endregion
		#region Constructors
			
		public Marca() {}
					
		public Marca(MarcaId id, string desmarca,Cabms cabms) 
		{
			this._id= id;
			this._desmarca= desmarca;
            this._cabms = cabms;
		}

		public Marca(MarcaId id,Cabms cabms)
		{
			this._id= id;
            this._cabms= cabms;
		}
		
		#endregion
		#region Public Properties
		public  virtual MarcaId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesMarca
		{
			get { return _desmarca; }
			set {_desmarca= value; }
		}
		public  virtual IList<Modelo> Modelo
		{
			get { return _modelo; }
			set {_modelo= value; }
		}
        public virtual Cabms Cabms
        {
            get { return _cabms; }
            set { _cabms = value; }
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
			Marca castObj = (Marca)obj;
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
