/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatClasificacion object for NHibernate mapped table 'cat_clasificacion'.
	/// </summary>
	[Serializable]
	public class CatClasificacion
	{
		#region Member Variables
		protected int _idclasificacion;
		protected string _desclasificacion;
		protected IList<Cpu> _cpu;
        protected IList<Dispositivo> _dispositivo;
        protected IList<Impresora> _impresora;
        protected IList<Ups> _ups;
		#endregion
		#region Constructors
			
		public CatClasificacion() {}
					
		public CatClasificacion(int idclasificacion, string desclasificacion) 
		{
			this._idclasificacion= idclasificacion;
			this._desclasificacion= desclasificacion;
		}

		public CatClasificacion(int idclasificacion)
		{
			this._idclasificacion= idclasificacion;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdClasificacion
		{
			get { return _idclasificacion; }
			set {_idclasificacion= value; }
		}
		public  virtual string DesClasificacion
		{
			get { return _desclasificacion; }
			set {_desclasificacion= value; }
		}
		public  virtual IList<Cpu> Cpu
		{
			get { return _cpu; }
			set {_cpu= value; }
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
        public virtual IList<Ups> Ups
        {
            get { return _ups; }
            set { _ups = value; }
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
			CatClasificacion castObj = (CatClasificacion)obj;
			return ( castObj != null ) &&
			this._idclasificacion == castObj.IdClasificacion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idclasificacion.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
