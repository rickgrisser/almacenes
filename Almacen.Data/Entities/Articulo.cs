/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NHibernate.Validator.Constraints;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Articulo object for NHibernate mapped table 'articulo'.
	/// </summary>
	[Serializable]
    public class Articulo : INotifyPropertyChanged
	{
		#region Member Variables
		protected ArticuloId _id;
		protected string _desarticulo;
        protected string _catunidad;        
		protected string _presentacion;
		protected short? _presentacioncant;
		protected string _presentacionunid;
		protected decimal? _maximo;
		protected decimal? _minimo;
		protected decimal? _puntoreorden;
		protected decimal? _consumopromedio;
		protected decimal? _movimientoprom;
		protected string _tipomovimiento;
		protected string _arealocaliza;
		protected string _anaquellocaliza;
		protected string _nivellocaliza;
		protected Usuario  _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
        protected byte[] _imagen;
        protected IList<ArticuloFarmacia> _articulofarmacia;
        protected IList<ArticuloPartida> _articulopartida;
		protected IList<ReqDetHist> _reqdethist;
		protected IList<RequisicionDetall> _requisiciondetall;
		protected IList<SalidaDetHist> _salidadethist;
		protected IList<SalidaDetalle> _salidadetalle;
		protected IList<Cierre> _cierre;
		protected IList<Conteos> _conteos;
		protected IList<CotizacionDetHis> _cotizaciondethis;
		protected IList<CotizacionDetalle> _cotizaciondetalle;
		protected IList<CuadroBasico> _cuadrobasico;
		protected IList<EntradaDetHist> _entradadethist;
		protected IList<EntradaDetalle> _entradadetalle;
		protected IList<AnexoDetalle> _anexodetalle;
		protected IList<FalloDetalle> _fallodetalle;
		protected IList<FalloDetalleHist> _fallodetallehist;
		protected IList<Marbete> _marbete;
		protected IList<AnexoDetalleHist> _anexodetallehist;
		protected IList<PedidoDetalle> _pedidodetalle;
		protected IList<PedidoDetalleHis> _pedidodetallehis;
		#endregion
		#region Constructors
			
		public Articulo() {}
        //string gramaje, string dosis, int? idgrupo,, Almacen almacen
		public Articulo(ArticuloId id, string desarticulo, string presentacion, short? presentacioncant, string presentacionunid, decimal? maximo, decimal? minimo, decimal? puntoreorden, decimal? consumopromedio, decimal? movimientoprom, string tipomovimiento, string arealocaliza, string anaquellocaliza, string nivellocaliza,  DateTime? fechaalta, string ipterminal, byte[] imagen)//, Almacen almacen) 
		{
			this._id= id;
			this._desarticulo= desarticulo;
			this._presentacion= presentacion;
			this._presentacioncant= presentacioncant;
			this._presentacionunid= presentacionunid;
			this._maximo= maximo;
			this._minimo= minimo;
			this._puntoreorden= puntoreorden;
			this._consumopromedio= consumopromedio;
			this._movimientoprom= movimientoprom;
			this._tipomovimiento= tipomovimiento;
			this._arealocaliza= arealocaliza;
			this._anaquellocaliza= anaquellocaliza;
			this._nivellocaliza= nivellocaliza;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
            this._imagen = imagen;
           
		}

		public Articulo(ArticuloId id)//, Almacen almacen)
		{
			this._id= id;
			//this._almacen= almacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual ArticuloId Id
		{
			get { return _id; }
			set {_id= value; }
		}
        [NotNullNotEmpty(Message = "Descripción del Articulo - Campo Requerido")]
		public  virtual string DesArticulo
		{
			get { return _desarticulo; }
			set {_desarticulo= value.ToUpper(); }
		}
        [NotNullNotEmpty(Message = "Unidad Almacen - Campo Requerido")]
		public  virtual string CatUnidad
		{
			get { return _catunidad; }
			//set {_catunidad= value; }
            set
            {
                if (_catunidad != value)
                {
                    _catunidad = value;
                    OnPropertyChanged("CatUnidad");
                }
            }
		}
        [NotNullNotEmpty(Message = "Presentación - Campo Requerido")]
		public  virtual string Presentacion
		{
			get { return _presentacion; }
			//set {_presentacion= value; }
            set
            {
                if (_presentacion != value)
                {
                    _presentacion = value;
                    OnPropertyChanged("Presentacion");
                }
            }
		}
        [Min(1,Message="Cantidad Mayor a Cero")]
        [NotNull(Message = "Cantidad - Campo Requerido")]
		public  virtual short? PresentacionCant
		{
			get { return _presentacioncant; }
			set {_presentacioncant= value; }
		}
        [NotNullNotEmpty(Message = "Presentación Unidad - Campo Requerido")]
		public  virtual string PresentacionUnid
		{
			get { return _presentacionunid; }
			//set {_presentacionunid= value; }
            set
            {
                if (_presentacionunid != value)
                {
                    _presentacionunid = value;
                    OnPropertyChanged("PresentacionUnid");
                }
            }
		}
        
        [DecimalMin(0.00001, Message = "Maximo Mayor a Cero")]
        [NotNull(Message = "Maximo - Campo Requerido")]
		public  virtual decimal? Maximo
		{
			get { return _maximo; }
			set {_maximo= value; }
		}
        [DecimalMin(0.00001, Message = "Minimo Mayor a Cero")]
        [NotNull(Message = "Minimo - Campo Requerido")]
		public  virtual decimal? Minimo
		{
			get { return _minimo; }
			set {_minimo= value; }
		}
        [DecimalMin(0.00001, Message = "Punto Reorden Mayor a Cero")]
        [NotNull(Message = "Punto Reorden - Campo Requerido")]
		public  virtual decimal? PuntoReorden
		{
			get { return _puntoreorden; }
			set {_puntoreorden= value; }
		}
		public  virtual decimal? ConsumoPromedio
		{
			get { return _consumopromedio; }
			set {_consumopromedio= value; }
		}
		public  virtual decimal? MovimientoProm
		{
			get { return _movimientoprom; }
			set {_movimientoprom= value; }
		}
		public  virtual string TipoMovimiento
		{
			get { return _tipomovimiento; }
			set {_tipomovimiento= value; }
		}
        //[NotNullNotEmpty(Message = "Area Localiza - Campo Requerido")]
		public  virtual string AreaLocaliza
		{
			get { return _arealocaliza; }
			set {_arealocaliza= value; }
		}
        //[NotNullNotEmpty(Message = "Anaquel Localiza - Campo Requerido")]
		public  virtual string AnaquelLocaliza
		{
			get { return _anaquellocaliza; }
			set {_anaquellocaliza= value; }
		}
        //[NotNullNotEmpty(Message = "Nivel Localiza - Campo Requerido")]
		public  virtual string NivelLocaliza
		{
			get { return _nivellocaliza; }
			set {_nivellocaliza= value; }
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
        
        public virtual byte[] Imagen
        {
            get { return _imagen; }
            set { _imagen = value; }
        }
        [Valid]
        public virtual IList<ArticuloFarmacia> ArticuloFarmacia
        {
            get { return _articulofarmacia; }
            set { _articulofarmacia = value; }
        }
        
        public  virtual IList<ArticuloPartida> ArticuloPartida
        {
            get { return _articulopartida; }
            set { _articulopartida = value; }
        }

		public  virtual IList<ReqDetHist> ReqDetHist
		{
			get { return _reqdethist; }
			set {_reqdethist= value; }
		}
		public  virtual IList<RequisicionDetall> RequisicionDetall
		{
			get { return _requisiciondetall; }
			set {_requisiciondetall= value; }
		}
		public  virtual IList<SalidaDetHist> SalidaDetHist
		{
			get { return _salidadethist; }
			set {_salidadethist= value; }
		}
		public  virtual IList<SalidaDetalle> SalidaDetalle
		{
			get { return _salidadetalle; }
			set {_salidadetalle= value; }
		}
		public  virtual IList<Cierre> Cierre
		{
			get { return _cierre; }
			set {_cierre= value; }
		}
		public  virtual IList<Conteos> Conteos
		{
			get { return _conteos; }
			set {_conteos= value; }
		}
        
		public  virtual IList<CotizacionDetHis> CotizacionDetHis
		{
			get { return _cotizaciondethis; }
			set {_cotizaciondethis= value; }
		}
		public  virtual IList<CotizacionDetalle> CotizacionDetalle
		{
			get { return _cotizaciondetalle; }
			set {_cotizaciondetalle= value; }
		}
        [Valid]
		public  virtual IList<CuadroBasico> CuadroBasico
		{
			get { return _cuadrobasico; }
			set {_cuadrobasico= value; }
		}
		public  virtual IList<EntradaDetHist> EntradaDetHist
		{
			get { return _entradadethist; }
			set {_entradadethist= value; }
		}
		public  virtual IList<EntradaDetalle> EntradaDetalle
		{
			get { return _entradadetalle; }
			set {_entradadetalle= value; }
		}
		public  virtual IList<AnexoDetalle> AnexoDetalle
		{
			get { return _anexodetalle; }
			set {_anexodetalle= value; }
		}
		public  virtual IList<FalloDetalle> FalloDetalle
		{
			get { return _fallodetalle; }
			set {_fallodetalle= value; }
		}
		public  virtual IList<FalloDetalleHist> FalloDetalleHist
		{
			get { return _fallodetallehist; }
			set {_fallodetallehist= value; }
		}
		public  virtual IList<Marbete> Marbete
		{
			get { return _marbete; }
			set {_marbete= value; }
		}
		public  virtual IList<AnexoDetalleHist> AnexoDetalleHist
		{
			get { return _anexodetallehist; }
			set {_anexodetallehist= value; }
		}
		public  virtual IList<PedidoDetalle> PedidoDetalle
		{
			get { return _pedidodetalle; }
			set {_pedidodetalle= value; }
		}
		public  virtual IList<PedidoDetalleHis> PedidoDetalleHis
		{
			get { return _pedidodetallehis; }
			set {_pedidodetallehis= value; }
		}
       
        #endregion
		
        //#region Equals And HashCode Overrides
        ///// <summary>
        ///// local implementation of Equals based on unique value members
        ///// </summary>
        //public override bool Equals( object obj )
        //{
        //    if( this == obj ) return true;
        //    if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
        //    Articulo castObj = (Articulo)obj;
        //    return ( castObj != null ) &&
        //    this._id.Equals( castObj.Id);
        //}
        ///// <summary>
        ///// local implementation of GetHashCode based on unique value members
        ///// </summary>
        //public override int GetHashCode()
        //{
        //    int hash = 57;
        //    hash = 27 * hash * _id.GetHashCode();
        //    return hash;
        //}
        //#endregion
        public event PropertyChangedEventHandler PropertyChanged;
        #region business logic

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
	}
}
