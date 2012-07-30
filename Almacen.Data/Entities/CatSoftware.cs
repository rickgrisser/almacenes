/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatSoftware object for NHibernate mapped table 'cat_software'.
	/// </summary>
	[Serializable]
	public class CatSoftware
	{
		#region Member Variables
		protected int _idsoftware;
		protected string _dessoftware;
		protected CatCategoriasoftware _catcategoriasoftware;
		protected CatFabricantesoft _catfabricantesoft;
		protected string _version;
		protected int? _licencias;
		protected CatTipolicencia _cattipolicencia;
		protected DateTime? _fechaadquisicion;
		protected decimal? _costo;
		protected string _observaciones;
		protected int? _garantia;
		protected CatGarantia _catgarantia;
		protected DateTime? _fechavencegarantia;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected string _folio;
		protected int? _licenciasdisponibles;
		protected string _serial;
        //protected IList<CpuSoftware> _cpusoftware;
        //protected IList<DiscoManual> _discomanual;
		#endregion
		#region Constructors
			
		public CatSoftware() {}
					
		public CatSoftware(int idsoftware, string dessoftware, string version, int? licencias, DateTime? fechaadquisicion, decimal? costo, string observaciones, int? garantia, DateTime? fechavencegarantia, DateTime? fechaalta, string ipterminal, string folio, int? licenciasdisponibles, string serial) 
		{
			this._idsoftware= idsoftware;
			this._dessoftware= dessoftware;
			this._version= version;
			this._licencias= licencias;
			this._fechaadquisicion= fechaadquisicion;
			this._costo= costo;
			this._observaciones= observaciones;
			this._garantia= garantia;
			this._fechavencegarantia= fechavencegarantia;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._folio= folio;
			this._licenciasdisponibles= licenciasdisponibles;
			this._serial= serial;
		}

		public CatSoftware(int idsoftware)
		{
			this._idsoftware= idsoftware;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdSoftware
		{
			get { return _idsoftware; }
			set {_idsoftware= value; }
		}
		public  virtual string DesSoftware
		{
			get { return _dessoftware; }
			set {_dessoftware= value; }
		}
		public  virtual CatCategoriasoftware CatCategoriasoftware
		{
			get { return _catcategoriasoftware; }
			set {_catcategoriasoftware= value; }
		}
		public  virtual CatFabricantesoft CatFabricantesoft
		{
			get { return _catfabricantesoft; }
			set {_catfabricantesoft= value; }
		}
		public  virtual string Version
		{
			get { return _version; }
			set {_version= value; }
		}
		public  virtual int? Licencias
		{
			get { return _licencias; }
			set {_licencias= value; }
		}
		public  virtual CatTipolicencia CatTipolicencia
		{
			get { return _cattipolicencia; }
			set {_cattipolicencia= value; }
		}
		public  virtual DateTime? Fechaadquisicion
		{
			get { return _fechaadquisicion; }
			set {_fechaadquisicion= value; }
		}
		public  virtual decimal? Costo
		{
			get { return _costo; }
			set {_costo= value; }
		}
		public  virtual string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones= value; }
		}
		public  virtual int? Garantia
		{
			get { return _garantia; }
			set {_garantia= value; }
		}
		public  virtual CatGarantia CatGarantia
		{
			get { return _catgarantia; }
			set {_catgarantia= value; }
		}
		public  virtual DateTime? FechaVenceGarantia
		{
			get { return _fechavencegarantia; }
			set {_fechavencegarantia= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual string Folio
		{
			get { return _folio; }
			set {_folio= value; }
		}
		public  virtual int? LicenciasDisponibles
		{
			get { return _licenciasdisponibles; }
			set {_licenciasdisponibles= value; }
		}
		public  virtual string Serial
		{
			get { return _serial; }
			set {_serial= value; }
		}
        //public  virtual IList<CpuSoftware> CpuSoftware
        //{
        //    get { return _cpusoftware; }
        //    set {_cpusoftware= value; }
        //}
        //public  virtual IList<DiscoManual> DiscoManual
        //{
        //    get { return _discomanual; }
        //    set {_discomanual= value; }
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
			CatSoftware castObj = (CatSoftware)obj;
			return ( castObj != null ) &&
			this._idsoftware == castObj.IdSoftware;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idsoftware.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
