/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatGarantia object for NHibernate mapped table 'cat_garantia'.
	/// </summary>
	[Serializable]
	public class CatGarantia
	{
		#region Member Variables
		protected int _idgarantia;
		protected string _desgarantia;
		protected IList<CatSoftware> _catsoftware;
        protected IList<Cpu> _cpu;
        protected IList<Dispositivo> _dispositivo;
        protected IList<Impresora> _impresora;
        //protected IList<Ups> _ups;
		#endregion
		#region Constructors
			
		public CatGarantia() {}
					
		public CatGarantia(int idgarantia, string desgarantia) 
		{
			this._idgarantia= idgarantia;
			this._desgarantia= desgarantia;
		}

		public CatGarantia(int idgarantia)
		{
			this._idgarantia= idgarantia;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdGarantia
		{
			get { return _idgarantia; }
			set {_idgarantia= value; }
		}
		public  virtual string DesGarantia
		{
			get { return _desgarantia; }
			set {_desgarantia= value; }
		}
		public  virtual IList<CatSoftware> CatSoftware
		{
			get { return _catsoftware; }
			set {_catsoftware= value; }
        }
        public virtual IList<Cpu> Cpu
        {
            get { return _cpu; }
            set { _cpu = value; }
        }
        public virtual IList<Dispositivo> Dispositivo
        {
            get { return _dispositivo; }
            set { _dispositivo = value; }
        }
        public virtual IList<Impresora> Impresora
        {
            get { return _impresora; }
            set { _impresora = value; }
        }
        //public  virtual IList<Ups> Ups
        //{
        //    get { return _ups; }
        //    set {_ups= value; }
        //}
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			CatGarantia castObj = (CatGarantia)obj;
			return ( castObj != null ) &&
			this._idgarantia == castObj.IdGarantia;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idgarantia.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
