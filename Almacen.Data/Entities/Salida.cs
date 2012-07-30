/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
//using Almacen.Data.Audit;
using NHibernate.Validator.Constraints;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Salida object for NHibernate mapped table 'salida'.
	/// </summary>
	[Serializable]
    //[Auditable]
    public class Salida : INotifyPropertyChanged
	{
		#region Member Variables
		protected long _idsalida;
		protected int? _numerosalida;
		protected DateTime? _fechasalida;
		protected string _jefeservicio;
		protected string _recibio;
        //protected int? _entrego;
	    protected Usuario _entrego;
		protected string _estadosalida;
		protected Almacen _almacen;
		protected CatArea _catarea;
		protected string _noorden;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected int? _modificacion;
		protected IList<SalidaDetalle> _salidadetalle;
		#endregion
		#region Constructors
			
		public Salida() {}

        public Salida(long idsalida, int? numerosalida, DateTime? fechasalida, string jefeservicio, string recibio, Usuario entrego, string estadosalida, string noorden, DateTime? fechaalta, string ipterminal, int? modificacion) 
		{
			this._idsalida= idsalida;
			this._numerosalida= numerosalida;
			this._fechasalida= fechasalida;
			this._jefeservicio= jefeservicio;
			this._recibio= recibio;
			this._entrego= entrego;
			this._estadosalida= estadosalida;
			this._noorden= noorden;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

		public Salida(int idsalida)
		{
			this._idsalida= idsalida;
		}
		
		#endregion
		#region Public Properties
        public virtual long IdSalida
		{
			get { return _idsalida; }
			set {_idsalida= value; }
		}
        [NotNull(Message = "Folio - Campo Requerido")]
		public  virtual int? NumeroSalida
		{
            get { return _numerosalida; }
            set { _numerosalida = value; }
		}
		public  virtual DateTime? FechaSalida
		{
			get { return _fechasalida; }
			//set {_fechasalida= value; }
            set
            {
                if (_fechasalida != value)
                {
                    _fechasalida = value;
                    OnPropertyChanged("FechaSalida");
                }
            }
		}
        [NotNullNotEmpty(Message = "Vo.Bo. - Campo Requerido")]
		public  virtual string JefeServicio
		{
			get { return _jefeservicio; }
			set {_jefeservicio= value; }
		}
        [NotNullNotEmpty(Message = "Recibio - Campo Requerido")]
		public  virtual string Recibio
		{
			get { return _recibio; }
			set {_recibio= value; }
		}
        [NotNull(Message = "Entrego - Campo Requerido")]
		public  virtual Usuario Entrego
		{
			get { return _entrego; }
			//set {_entrego= value; }
            set
            {
                if (_entrego != value)
                {
                    _entrego = value;
                    OnPropertyChanged("Entrego");
                }
            }
		}
		public  virtual string EstadoSalida
		{
			get { return _estadosalida; }
			set {_estadosalida= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
		}
        [NotNull(Message = "Area - Campo Requerido")]
        public virtual CatArea CatArea
        {
            get { return _catarea; }
            //set { _catarea = value; }
            set
            {
                if (_catarea != value)
                {
                    _catarea = value;
                    OnPropertyChanged("CatArea");
                }
            }
        }
		public  virtual string NoOrden
		{
			get { return _noorden; }
			set {_noorden= value; }
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
		public  virtual int? Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
		}
        [NotEmpty(Message = "Ninguna Salida Ingresada")]
        [Valid]
		public  virtual IList<SalidaDetalle> SalidaDetalle
		{
			get { return _salidadetalle; }
			set {_salidadetalle= value; }
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
			Salida castObj = (Salida)obj;
			return ( castObj != null ) &&
			this._idsalida == castObj.IdSalida;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idsalida.GetHashCode();
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
