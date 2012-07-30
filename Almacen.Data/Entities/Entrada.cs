/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using Almacen.Data.Auxiliares;
using NHibernate.Validator.Constraints;
namespace Almacen.Data.Entities
{
	/// <summary>
	/// Entrada object for NHibernate mapped table 'entrada'.
	/// </summary>
	//
    //[Serializable]
    //[Auditable]
    public class Entrada : INotifyPropertyChanged,IPadre
	{
		#region Member Variables
		protected long _identrada;
		protected int? _numeroentrada;
		protected DateTime? _fechaentrada;
		protected string _numerofactura;
		protected Pedido _pedido;
        protected Usuario _recibio;
        protected Usuario _supervisor;
		protected string _estadoentrada;
		protected Almacen _almacen;
		protected CatActividad _catactividad;
		protected CatPresupuesto _catpresupuesto;
		protected Usuario _usuario;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int? _modificacion;
        protected IList<EntradaDetalle> _entradadetalle = new List<EntradaDetalle>();
		#endregion
		#region Constructors
			
		public Entrada() {}

        public Entrada(long identrada, int? numeroentrada, DateTime? fechaentrada, string numerofactura, Usuario recibio, Usuario supervisor, string estadoentrada, DateTime? fechamodificacion, string ipterminal, int? modificacion) 
		{
			this._identrada= identrada;
			this._numeroentrada= numeroentrada;
			this._fechaentrada= fechaentrada;
			this._numerofactura= numerofactura;
			this._recibio= recibio;
			this._supervisor= supervisor;
			this._estadoentrada= estadoentrada;
			this._fechamodificacion= fechamodificacion;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

		public Entrada(int identrada)
		{
			this._identrada= identrada;
		}
		
		#endregion
		#region Public Properties
        
		public  virtual long IdEntrada
		{
			get { return _identrada; }
			set {_identrada= value; }
		}
        [NotNull(Message = "Folio - Campo Requerido")]
		public  virtual int? NumeroEntrada
		{
			get { return _numeroentrada; }
			set {_numeroentrada= value; }
		}
		public  virtual DateTime? FechaEntrada
		{
			get { return _fechaentrada; }
			set {_fechaentrada= value; }
		}
        [NotNullNotEmpty(Message = "Numero Factura - Campo Requerido")]
		public  virtual string NumeroFactura
		{
			get { return _numerofactura; }
			set {_numerofactura= value; }
		}
		public  virtual Pedido Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
        [NotNull(Message = "Usuario Recibio - Campo Requerido")]
		public virtual Usuario Recibio
		{
			get { return _recibio; }
            set
            {
                if (_recibio != value)
                {
                    _recibio = value;
                    OnPropertyChanged("Recibio");
                }
            }
		}
        [NotNull(Message = "Usuario Superviso - Campo Requerido")]
        public virtual Usuario Supervisor
		{
			get { return _supervisor; }
			//set {_supervisor= value; }
            set
            {
                if (_supervisor != value)
                {
                    _supervisor = value;
                    OnPropertyChanged("Supervisor");
                }
            }
		}
		public  virtual string EstadoEntrada
		{
			get { return _estadoentrada; }
			set {_estadoentrada= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
		}
        [NotNull(Message = "Actividad - Campo Requerido")]
		public  virtual CatActividad CatActividad
		{
			get { return _catactividad; }
            set
            {
                if (_catactividad != value)
                {
                    _catactividad = value;
                    OnPropertyChanged("CatActividad");
                }
            }
		}
        [NotNull(Message = "Presupuesto - Campo Requerido")]
		public  virtual CatPresupuesto CatPresupuesto
		{
            get { return _catpresupuesto; }
            set
            {
                if (_catpresupuesto != value)
                {
                    _catpresupuesto = value;
                    OnPropertyChanged("CatPresupuesto");
                }
            }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
		public  virtual int? Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
		}
        [NotEmpty(Message = "Ningun Articulo Ingresado")]
        [Valid]
		public  virtual IList<EntradaDetalle> EntradaDetalle
		{
			get { return _entradadetalle; }
			set {_entradadetalle= value; }
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
			Entrada castObj = (Entrada)obj;
			return ( castObj != null ) &&
			this._identrada == castObj.IdEntrada;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _identrada.GetHashCode();
			return hash;
		}
        #endregion
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
