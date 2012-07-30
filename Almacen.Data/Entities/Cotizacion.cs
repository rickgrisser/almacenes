/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Cotizacion object for NHibernate mapped table 'cotizacion'.
	/// </summary>
	[Serializable]
	public class Cotizacion
	{
		#region Member Variables
		protected long _idcotizacion;
	    protected Anexo _anexo;
		protected Proveedor _proveedor;
		protected DateTime? _fechacotizacion;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<CotizacionDetalle> _cotizaciondetalle;
		protected IList<Fallo> _fallo;
		
		#endregion
		#region Constructors
			
		public Cotizacion() {}
					
		public Cotizacion(long idcotizacion, DateTime? fechacotizacion, DateTime? fechamodificacion, string ipterminal, int modificacion)//, Anexo anexo) 
		{
            this._idcotizacion = idcotizacion;
			this._fechacotizacion= fechacotizacion;
            this._fechamodificacion = fechamodificacion;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
			//this._anexo= anexo;
		}

        public Cotizacion(long idcotizacion)//, Anexo anexo)
		{
            this._idcotizacion = idcotizacion;
			//this._anexo= anexo;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdCotizacion
		{
            get { return _idcotizacion; }
            set { _idcotizacion = value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual DateTime? FechaCotizacion
		{
			get { return _fechacotizacion; }
			set {_fechacotizacion= value; }
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
        public virtual DateTime? FechaModificacion
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
		public  virtual IList<CotizacionDetalle> CotizacionDetalle
		{
			get { return _cotizaciondetalle; }
			set {_cotizaciondetalle= value; }
		}
		public  virtual IList<Fallo> Fallo
		{
			get { return _fallo; }
			set {_fallo= value; }
		}
        public virtual Anexo Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
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
            //Cotizacion castObj = (Cotizacion)obj;
            //return ( castObj != null ) &&
            //this._id.Equals( castObj.Id);
		    return false;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
