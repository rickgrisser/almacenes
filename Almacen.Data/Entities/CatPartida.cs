/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatPartida object for NHibernate mapped table 'cat_partida'.
	/// </summary>
	[Serializable]
	public class CatPartida
	{
		#region Member Variables
		protected string _partida;
		protected string _despartida;
		protected string _clase;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _ipterminal;
        protected IList<ArticuloPartida> _articulopartida;
		protected IList<ReservaAutoHis> _reservaautohis;
		protected IList<ReservaAutorizada> _reservaautorizada;
		protected IList<ReservaSolicHist> _reservasolichist;
		protected IList<ReservaSolicitud> _reservasolicitud;
        protected IList<Articulo> _articulo;
		#endregion
		#region Constructors
			
		public CatPartida() {}
					
		public CatPartida(string partida, string despartida, string clase, DateTime? fechaalta, DateTime? fechabaja, string estatus, string ipterminal) 
		{
			this._partida= partida;
			this._despartida= despartida;
			this._clase= clase;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._ipterminal= ipterminal;
		}

		public CatPartida(string partida)
		{
			this._partida= partida;
		}
		
		#endregion
		#region Public Properties
		public  virtual string Partida
		{
			get { return _partida; }
			set {_partida= value; }
		}
		public  virtual string DesPartida
		{
			get { return _despartida; }
			set {_despartida= value; }
		}
		public  virtual string Clase
		{
			get { return _clase; }
			set {_clase= value; }
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
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
        public virtual IList<ArticuloPartida> ArticuloPartida
        {
            get { return _articulopartida; }
            set { _articulopartida = value; }
        }
		public  virtual IList<ReservaAutoHis> ReservaAutoHis
		{
			get { return _reservaautohis; }
			set {_reservaautohis= value; }
		}
		public  virtual IList<ReservaAutorizada> ReservaAutorizada
		{
			get { return _reservaautorizada; }
			set {_reservaautorizada= value; }
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
        public virtual IList<Articulo> Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
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
			CatPartida castObj = (CatPartida)obj;
			return ( castObj != null ) &&
			this._partida == castObj.Partida;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _partida.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
