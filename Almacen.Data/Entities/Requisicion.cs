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
	/// Requisicion object for NHibernate mapped table 'requisicion'.
	/// </summary>
	[Serializable]
    public class Requisicion : INotifyPropertyChanged
	{
		#region Member Variables
		protected long _idrequisicion;
		protected Anexo _anexo;
		protected int? _numerorequisicion;
		protected DateTime? _fecharequisicion;
		protected CatArea _catarea;
		protected string _estatus;
		protected short? _duracionabastc;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected int? _modificacion;
		protected IList<RequisicionDetall> _requisiciondetall;
		protected IList<Pedido> _pedido;
		#endregion
		#region Constructors
			
		public Requisicion() {}

        public Requisicion(long idrequisicion, int? numerorequisicion, DateTime? fecharequisicion, string estatus, short? duracionabastc, DateTime? fechaalta, string ipterminal, int? modificacion) 
		{
			this._idrequisicion= idrequisicion;
			this._numerorequisicion= numerorequisicion;
			this._fecharequisicion= fecharequisicion;
			this._estatus= estatus;
			this._duracionabastc= duracionabastc;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

        public Requisicion(long idrequisicion)
		{
			this._idrequisicion= idrequisicion;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdRequisicion
		{
			get { return _idrequisicion; }
			set {_idrequisicion= value; }
		}
        [NotNull(Message = "Licitación - Campo Requerido")]
		public  virtual Anexo Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
        [NotNull(Message = "Folio - Campo Requerido")]
		public  virtual int? NumeroRequisicion
		{
			get { return _numerorequisicion; }
			set {_numerorequisicion= value; }
		}
		public  virtual DateTime? FechaRequisicion
		{
			get { return _fecharequisicion; }
			//set {_fecharequisicion= value; }
            set
            {
                if (_fecharequisicion != value)
                {
                    _fecharequisicion = value;
                    OnPropertyChanged("FechaRequisicion");
                }
            }
		}
        [NotNull(Message = "Area - Campo Requerido")]
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			//set {_catarea= value; }
            set
            {
                if (_catarea != value)
                {
                    _catarea = value;
                    OnPropertyChanged("CatArea");
                }
            }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
        [NotNull(Message = "Abasto/Meses - Campo Requerido")]
		public  virtual short? DuracionAbastc
		{
			get { return _duracionabastc; }
			set {_duracionabastc= value; }
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
        [NotEmpty(Message = "Ninguna Requisicion Ingresada")]
        [Valid]
		public  virtual IList<RequisicionDetall> RequisicionDetall
		{
			get { return _requisiciondetall; }
			set {_requisiciondetall= value; }
		}
		public  virtual IList<Pedido> Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
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
			Requisicion castObj = (Requisicion)obj;
			return ( castObj != null ) &&
			this._idrequisicion == castObj.IdRequisicion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idrequisicion.GetHashCode();
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
