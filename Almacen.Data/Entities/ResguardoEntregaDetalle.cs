/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntregaDetalle object for NHibernate mapped table 'resguardo_entrega_detalle'.
	/// </summary>
	[Serializable]
	public class ResguardoEntregaDetalle
	{
		#region Member Variables
	    protected long _idresguardoentregadetalle;
	    protected ResguardoEntrega _resguardoentrega;
	    protected long _inventario;
	    protected int _consecutivo;
		protected string _descripcion;
        protected string _observaciones;
		protected string _serie;
		protected string _estatusbien;
		protected string _estatusasignacion;
		protected DateTime? _fechaultimomovimiento;
		protected TipoBaja _tipobaja;
        protected string _statussoptec;
	    protected CatTipoanexotecnico _cattipoanexotecnico;
		protected IList<AsignacionBien> _asignacionbien;
        protected IList<Cpu> _cpu;
        protected IList<Monitor> _monitor;
        protected IList<Teclado> _teclado;
        protected IList<Impresora> _impresora;
        protected IList<Dispositivo> _dispositivo;
        protected IList<Ups> _ups;
        protected IList<Mouse> _mouse;
		#endregion
		#region Constructors
			
		public ResguardoEntregaDetalle() {}

        public ResguardoEntregaDetalle(long idresguardoentregadetalle, string descripcion, string observaciones, string serie, string estatusbien, string estatusasignacion, DateTime? fechaultimomovimiento) 
		{
            this._idresguardoentregadetalle = idresguardoentregadetalle;
			this._descripcion= descripcion;
            this._observaciones = observaciones;
			this._serie= serie;
			this._estatusbien= estatusbien;
			this._estatusasignacion= estatusasignacion;
			this._fechaultimomovimiento= fechaultimomovimiento;
		}

        public ResguardoEntregaDetalle(long idresguardoentregadetalle, ResguardoEntrega resguardoEntrega)
		{
            this._idresguardoentregadetalle = idresguardoentregadetalle;
            this._resguardoentrega = resguardoEntrega;
		}
		
		#endregion
		#region Public Properties
        public virtual long IdResguardoEntregaDetalle
		{
            get { return _idresguardoentregadetalle; }
            set { _idresguardoentregadetalle = value; }
		}
        public virtual ResguardoEntrega ResguardoEntrega
        {
            get { return _resguardoentrega; }
            set { _resguardoentrega = value; }
        }
        public virtual long Inventario
        {
            get { return _inventario; }
            set { _inventario = value; }
        }
        public virtual int Consecutivo
        {
            get { return _consecutivo; }
            set { _consecutivo = value; }
        }
		public  virtual string Descripcion
		{
			get { return _descripcion; }
			set {_descripcion= value; }
		}
        public virtual string Observaciones
        {
            get { return _observaciones; }
            set { _observaciones = value; }
        }
		public  virtual string Serie
		{
			get { return _serie; }
			set {_serie= value; }
		}
		public  virtual string EstatusBien
		{
			get { return _estatusbien; }
			set {_estatusbien= value; }
		}
		public  virtual string EstatusAsignacion
		{
			get { return _estatusasignacion; }
			set {_estatusasignacion= value; }
		}
		public  virtual DateTime? FechaUltimoMovimiento
		{
			get { return _fechaultimomovimiento; }
			set {_fechaultimomovimiento= value; }
		}
		public  virtual TipoBaja TipoBaja
		{
			get { return _tipobaja; }
			set {_tipobaja= value; }
		}
        public virtual string StatusSoptec
        {
            get { return _statussoptec; }
            set { _statussoptec = value; }
        }
        public virtual CatTipoanexotecnico CatTipoanexotecnico
        {
            get { return _cattipoanexotecnico; }
            set { _cattipoanexotecnico = value; }
        }
		public  virtual IList<AsignacionBien> AsignacionBien
		{
			get { return _asignacionbien; }
			set {_asignacionbien= value; }
		}
        public virtual IList<Cpu> Cpu
        {
            get { return _cpu; }
            set { _cpu = value; }
        }
        public virtual IList<Monitor> Monitor
        {
            get { return _monitor; }
            set { _monitor = value; }
        }
        public virtual IList<Teclado> Teclado
        {
            get { return _teclado; }
            set { _teclado = value; }
        }
        public virtual IList<Impresora> Impresora
        {
            get { return _impresora; }
            set { _impresora = value; }
        }
        public virtual IList<Dispositivo> Dispositivo
        {
            get { return _dispositivo; }
            set { _dispositivo = value; }
        }
        public virtual IList<Ups> Ups
        {
            get { return _ups; }
            set { _ups = value; }
        }
        public virtual IList<Mouse> Mouse
        {
            get { return _mouse; }
            set { _mouse = value; }
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
            //ResguardoEntregaDetalle castObj = (ResguardoEntregaDetalle)obj;
            //return ( castObj != null ) &&
            //this._id.Equals( castObj.Id);}
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
