/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Proveedor object for NHibernate mapped table 'proveedor'.
	/// </summary>
	[Serializable]
	public class Proveedor
	{
		#region Member Variables
		protected int _cveproveedor;
		protected string _nombrefiscal;
		protected string _nombrecomercial;
		protected string _paterno;
		protected string _materno;
		protected string _nombre;
		protected string _calle;
		protected string _colonia;
		protected string _delegacion;
		protected string _estado;
		protected string _pais;
		protected string _codigop;
		protected string _rfc;
		protected string _tel;
		protected string _tel2;
		protected string _tel3;
		protected string _fax;
		protected string _correo;
		protected string _rpaterno;
		protected string _rmaterno;
		protected string _rnombre;
		protected string _giro;
		protected string _observacion;
		protected string _ipterminal;
		protected DateTime? _fechaalta;
		protected Usuario _usuario;
		protected IList<Cotizacion> _cotizacion;
		protected IList<CotizacionHist> _cotizacionhist;
		protected IList<Fallo> _fallo;
		protected IList<FalloHist> _fallohist;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public Proveedor() {}
					
		public Proveedor(int cveproveedor, string nombrefiscal, string nombrecomercial, string paterno, string materno, string nombre, string calle, string colonia, string delegacion, string estado, string pais, string codigop, string rfc, string tel, string tel2, string tel3, string fax, string correo, string rpaterno, string rmaterno, string rnombre, string giro, string observacion, string ipterminal, DateTime? fechaalta) 
		{
			this._cveproveedor= cveproveedor;
			this._nombrefiscal= nombrefiscal;
			this._nombrecomercial= nombrecomercial;
			this._paterno= paterno;
			this._materno= materno;
			this._nombre= nombre;
			this._calle= calle;
			this._colonia= colonia;
			this._delegacion= delegacion;
			this._estado= estado;
			this._pais= pais;
			this._codigop= codigop;
			this._rfc= rfc;
			this._tel= tel;
			this._tel2= tel2;
			this._tel3= tel3;
			this._fax= fax;
			this._correo= correo;
			this._rpaterno= rpaterno;
			this._rmaterno= rmaterno;
			this._rnombre= rnombre;
			this._giro= giro;
			this._observacion= observacion;
			this._ipterminal= ipterminal;
			this._fechaalta= fechaalta;
		}

		public Proveedor(int cveproveedor)
		{
			this._cveproveedor= cveproveedor;
		}
		
		#endregion
		#region Public Properties
		public  virtual int CveProveedor
		{
			get { return _cveproveedor; }
			set {_cveproveedor= value; }
		}
		public  virtual string NombreFiscal
		{
			get { return _nombrefiscal; }
			set {_nombrefiscal= value; }
		}
		public  virtual string NombreComercial
		{
			get { return _nombrecomercial; }
			set {_nombrecomercial= value; }
		}
		public  virtual string Paterno
		{
			get { return _paterno; }
			set {_paterno= value; }
		}
		public  virtual string Materno
		{
			get { return _materno; }
			set {_materno= value; }
		}
		public  virtual string Nombre
		{
			get { return _nombre; }
			set {_nombre= value; }
		}
		public  virtual string Calle
		{
			get { return _calle; }
			set {_calle= value; }
		}
		public  virtual string Colonia
		{
			get { return _colonia; }
			set {_colonia= value; }
		}
		public  virtual string Delegacion
		{
			get { return _delegacion; }
			set {_delegacion= value; }
		}
		public  virtual string Estado
		{
			get { return _estado; }
			set {_estado= value; }
		}
		public  virtual string Pais
		{
			get { return _pais; }
			set {_pais= value; }
		}
		public  virtual string CodigoP
		{
			get { return _codigop; }
			set {_codigop= value; }
		}
		public  virtual string Rfc
		{
			get { return _rfc; }
			set {_rfc= value; }
		}
		public  virtual string Tel
		{
			get { return _tel; }
			set {_tel= value; }
		}
		public  virtual string Tel2
		{
			get { return _tel2; }
			set {_tel2= value; }
		}
		public  virtual string Tel3
		{
			get { return _tel3; }
			set {_tel3= value; }
		}
		public  virtual string Fax
		{
			get { return _fax; }
			set {_fax= value; }
		}
		public  virtual string Correo
		{
			get { return _correo; }
			set {_correo= value; }
		}
		public  virtual string Rpaterno
		{
			get { return _rpaterno; }
			set {_rpaterno= value; }
		}
		public  virtual string Rmaterno
		{
			get { return _rmaterno; }
			set {_rmaterno= value; }
		}
		public  virtual string Rnombre
		{
			get { return _rnombre; }
			set {_rnombre= value; }
		}
		public  virtual string Giro
		{
			get { return _giro; }
			set {_giro= value; }
		}
		public  virtual string Observacion
		{
			get { return _observacion; }
			set {_observacion= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual IList<Cotizacion> Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
		public  virtual IList<CotizacionHist> CotizacionHist
		{
			get { return _cotizacionhist; }
			set {_cotizacionhist= value; }
		}
		public  virtual IList<Fallo> Fallo
		{
			get { return _fallo; }
			set {_fallo= value; }
		}
		public  virtual IList<FalloHist> FalloHist
		{
			get { return _fallohist; }
			set {_fallohist= value; }
		}
		public  virtual IList<Pedido> Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
		public  virtual IList<PedidoHist> PedidoHist
		{
			get { return _pedidohist; }
			set {_pedidohist= value; }
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
			Proveedor castObj = (Proveedor)obj;
			return ( castObj != null ) &&
			this._cveproveedor == castObj.CveProveedor;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _cveproveedor.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
