/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Usuario object for NHibernate mapped table 'usuario'.
	/// </summary>
	[Serializable]
	public class Usuario
	{
		#region Member Variables
		protected int _idusuario;
		protected string _rfc;
		protected string _nombre;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _password;
        protected IList<Requisicion> _requisicion;
        protected IList<RequisicionHist> _requisicionhist;
        protected IList<ReservaAutoHis> _reservaautohis;
        protected IList<ReservaAutorizada> _reservaautorizada;
        protected IList<AnexoHist> _anexohist;
        protected IList<ReservaSolicHist> _reservasolichist;
        protected IList<ReservaSolicitud> _reservasolicitud;
        protected IList<Salida> _salida;
        protected IList<SalidaHist> _salidahist;
        protected IList<UsuarioModulo> _usuariomodulo;
        protected IList<Articulo> _articulo;
        protected IList<CatArea> _catarea;
        protected IList<CatUnidad> _catunidad;
        protected IList<Cierre> _cierre;
        protected IList<Conteos> _conteos;
        protected IList<Cotizacion> _cotizacion;
        protected IList<Anexo> _anexo;
        protected IList<CotizacionHist> _cotizacionhist;
        protected IList<Entrada> _entrada;
        protected IList<EntradaHist> _entradahist;
        protected IList<Fallo> _fallo;
        protected IList<FalloHist> _fallohist;
        protected IList<Fundamento> _fundamento;
        protected IList<Marbete> _marbete;
        protected IList<Pedido> _pedido;
        protected IList<PedidoHist> _pedidohist;
        protected IList<Proveedor> _proveedor;
		#endregion
		#region Constructors
			
		public Usuario() {}
					
		public Usuario(int idusuario, string rfc, string nombre, DateTime? fechaalta, DateTime? fechabaja, string estatus, string password) 
		{
			this._idusuario= idusuario;
			this._rfc= rfc;
			this._nombre= nombre;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._password= password;
		}

		public Usuario(int idusuario)
		{
			this._idusuario= idusuario;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdUsuario
		{
			get { return _idusuario; }
			set {_idusuario= value; }
		}
		public  virtual string Rfc
		{
			get { return _rfc; }
			set {_rfc= value; }
		}
		public  virtual string Nombre
		{
			get { return _nombre; }
			set {_nombre= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual string Password
		{
			get { return _password; }
			set {_password= value; }
		}
        public virtual IList<Requisicion> Requisicion
        {
            get { return _requisicion; }
            set { _requisicion = value; }
        }
        public virtual IList<RequisicionHist> RequisicionHist
        {
            get { return _requisicionhist; }
            set { _requisicionhist = value; }
        }
        public virtual IList<ReservaAutoHis> ReservaAutoHis
        {
            get { return _reservaautohis; }
            set { _reservaautohis = value; }
        }
        public virtual IList<ReservaAutorizada> ReservaAutorizada
        {
            get { return _reservaautorizada; }
            set { _reservaautorizada = value; }
        }
        public virtual IList<AnexoHist> AnexoHist
        {
            get { return _anexohist; }
            set { _anexohist = value; }
        }
        public virtual IList<ReservaSolicHist> ReservaSolicHist
        {
            get { return _reservasolichist; }
            set { _reservasolichist = value; }
        }
        public virtual IList<ReservaSolicitud> ReservaSolicitud
        {
            get { return _reservasolicitud; }
            set { _reservasolicitud = value; }
        }
        public virtual IList<Salida> Salida
        {
            get { return _salida; }
            set { _salida = value; }
        }
        public virtual IList<SalidaHist> SalidaHist
        {
            get { return _salidahist; }
            set { _salidahist = value; }
        }
        public virtual IList<UsuarioModulo> UsuarioModulo
        {
            get { return _usuariomodulo; }
            set { _usuariomodulo = value; }
        }
        public virtual IList<Articulo> Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }
        public virtual IList<CatArea> CatArea
        {
            get { return _catarea; }
            set { _catarea = value; }
        }
        public virtual IList<CatUnidad> CatUnidad
        {
            get { return _catunidad; }
            set { _catunidad = value; }
        }
        public virtual IList<Cierre> Cierre
        {
            get { return _cierre; }
            set { _cierre = value; }
        }
        public virtual IList<Conteos> Conteos
        {
            get { return _conteos; }
            set { _conteos = value; }
        }
        public virtual IList<Cotizacion> Cotizacion
        {
            get { return _cotizacion; }
            set { _cotizacion = value; }
        }
        public virtual IList<Anexo> Anexo
        {
            get { return _anexo; }
            set { _anexo = value; }
        }
        public virtual IList<CotizacionHist> CotizacionHist
        {
            get { return _cotizacionhist; }
            set { _cotizacionhist = value; }
        }
        public virtual IList<Entrada> Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }
        public virtual IList<EntradaHist> EntradaHist
        {
            get { return _entradahist; }
            set { _entradahist = value; }
        }
        public virtual IList<Fallo> Fallo
        {
            get { return _fallo; }
            set { _fallo = value; }
        }
        public virtual IList<FalloHist> FalloHist
        {
            get { return _fallohist; }
            set { _fallohist = value; }
        }
        public virtual IList<Fundamento> Fundamento
        {
            get { return _fundamento; }
            set { _fundamento = value; }
        }
        public virtual IList<Marbete> Marbete
        {
            get { return _marbete; }
            set { _marbete = value; }
        }
        public virtual IList<Pedido> Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }
        public virtual IList<PedidoHist> PedidoHist
        {
            get { return _pedidohist; }
            set { _pedidohist = value; }
        }
        public virtual IList<Proveedor> Proveedor
        {
            get { return _proveedor; }
            set { _proveedor = value; }
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
			Usuario castObj = (Usuario)obj;
			return ( castObj != null ) &&
			this._idusuario == castObj.IdUsuario;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idusuario.GetHashCode();
			return hash;
		}
		#endregion
        public override string ToString()
        {
            return Nombre;
        }
	}
}
