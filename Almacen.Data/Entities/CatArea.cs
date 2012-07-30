/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatArea object for NHibernate mapped table 'cat_area'.
	/// </summary>
	[Serializable]
	public class CatArea
	{
		#region Member Variables
		protected short _cvearea;
		protected string _desarea;
		protected string _responsablearea;
		protected string _cargoarea;
        protected string _tipo;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected int? _estatus;
		protected Usuario _usuario;
		protected IList<Requisicion> _requisicion;
		protected IList<RequisicionHist> _requisicionhist;
		protected IList<ReservaSolicHist> _reservasolichist;
		protected IList<ReservaSolicitud> _reservasolicitud;
		protected IList<Salida> _salida;
		protected IList<SalidaHist> _salidahist;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public CatArea() {}
					
		public CatArea(short cvearea, string desarea, string responsablearea, string cargoarea, string tipo, DateTime? fechaalta, DateTime? fechabaja, int? estatus) 
		{
			this._cvearea= cvearea;
			this._desarea= desarea;
			this._responsablearea= responsablearea;
			this._cargoarea= cargoarea;
            this._tipo = tipo;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
		}

		public CatArea(short cvearea)
		{
			this._cvearea= cvearea;
		}
		
		#endregion
		#region Public Properties
		public  virtual short CveArea
		{
			get { return _cvearea; }
			set {_cvearea= value; }
		}
		public  virtual string DesArea
		{
			get { return _desarea; }
			set {_desarea= value; }
		}
		public  virtual string ResponsableArea
		{
			get { return _responsablearea; }
			set {_responsablearea= value; }
		}
		public  virtual string CargoArea
		{
			get { return _cargoarea; }
			set {_cargoarea= value; }
		}
        public virtual string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
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
		public  virtual int? Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual IList<Requisicion> Requisicion
		{
			get { return _requisicion; }
			set {_requisicion= value; }
		}
		public  virtual IList<RequisicionHist> RequisicionHist
		{
			get { return _requisicionhist; }
			set {_requisicionhist= value; }
		}
		public  virtual IList<ReservaSolicHist> ReservaSolicHist
		{
			get { return _reservasolichist; }
			set {_reservasolichist= value; }
		}
		public  virtual IList<ReservaSolicitud> ReservaSolicitud
		{
			get { return _reservasolicitud; }
			set {_reservasolicitud= value; }
		}
		public  virtual IList<Salida> Salida
		{
			get { return _salida; }
			set {_salida= value; }
		}
		public  virtual IList<SalidaHist> SalidaHist
		{
			get { return _salidahist; }
			set {_salidahist= value; }
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
			CatArea castObj = (CatArea)obj;
			return ( castObj != null ) &&
			this._cvearea == castObj.CveArea;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _cvearea.GetHashCode();
			return hash;
		}
		#endregion
        public override string ToString()
        {
            return DesArea;
        }
	}
}
