/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ViaAdministracion object for NHibernate mapped table 'via_administracion'.
	/// </summary>
	[Serializable]
	public class ViaAdministracion
	{
		#region Member Variables
		protected int _idadministracion;
		protected string _desadministracion;
        protected IList<ArticuloFarmacia> _articulofarmacia;
		protected IList<Articulo> _articulo;
		#endregion
		#region Constructors
			
		public ViaAdministracion() {}
					
		public ViaAdministracion(int idadministracion, string desadministracion) 
		{
			this._idadministracion= idadministracion;
			this._desadministracion= desadministracion;
		}

		public ViaAdministracion(int idadministracion)
		{
			this._idadministracion= idadministracion;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdAdministracion
		{
			get { return _idadministracion; }
			set {_idadministracion= value; }
		}
		public  virtual string DesAdministracion
		{
			get { return _desadministracion; }
			set {_desadministracion= value; }
		}
        public virtual IList<ArticuloFarmacia> ArticuloFarmacia
        {
            get { return _articulofarmacia; }
            set { _articulofarmacia = value; }
        }
        public virtual IList<Articulo> Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
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
			ViaAdministracion castObj = (ViaAdministracion)obj;
			return ( castObj != null ) &&
			this._idadministracion == castObj.IdAdministracion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idadministracion.GetHashCode();
			return hash;
		}
		#endregion
        public override string ToString()
        {
            return DesAdministracion;
        }
	}
}
