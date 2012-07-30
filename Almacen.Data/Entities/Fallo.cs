/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Fallo object for NHibernate mapped table 'fallo'.
	/// </summary>
	[Serializable]
	public class Fallo
	{
		#region Member Variables
		protected long _idfallo;
		protected Cotizacion _cotizacion;
        protected Anexo _anexo;
		protected Proveedor _proveedor;
		protected DateTime? _fechafallo;
		protected string _estado;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<FalloDetalle> _fallodetalle;
        
		#endregion
		#region Constructors
			
		public Fallo() {}

        public Fallo(long idfallo, DateTime? fechafallo, string estado, DateTime? fechamodificacion, string ipterminal, int modificacion) 
		{
			this._idfallo= idfallo;
			this._fechafallo= fechafallo;
			this._estado= estado;
            this._fechamodificacion = fechamodificacion;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

		public Fallo(long idfallo)
		{
			this._idfallo= idfallo;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdFallo
		{
			get { return _idfallo; }
			set {_idfallo= value; }
		}
		public  virtual Cotizacion Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
        public virtual Anexo Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
        }
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual DateTime? FechaFallo
		{
			get { return _fechafallo; }
			set {_fechafallo= value; }
		}
		public  virtual string Estado
		{
			get { return _estado; }
			set {_estado= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
		}
		public  virtual DateTime? FechaModificacion
		{
			get { return _fechamodificacion; }
            set { _fechamodificacion = value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual int Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
		}
		public  virtual IList<FalloDetalle> FalloDetalle
		{
			get { return _fallodetalle; }
			set {_fallodetalle= value; }
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
			Fallo castObj = (Fallo)obj;
			return ( castObj != null ) &&
			this._idfallo == castObj.IdFallo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idfallo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
