/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReservaAutorizada object for NHibernate mapped table 'reserva_autorizada'.
	/// </summary>
	[Serializable]
	public class ReservaAutorizada
	{
		#region Member Variables
		protected int _idreservaautoriza;
		protected CatEjercicio _catejercicio;
		protected DateTime? _fechaautoriza;
		protected int? _folioautoriza;
		protected decimal? _mes01;
		protected decimal? _mes02;
		protected decimal? _mes03;
		protected decimal? _mes04;
		protected decimal? _mes05;
		protected decimal? _mes06;
		protected decimal? _mes07;
		protected decimal? _mes08;
		protected decimal? _mes09;
		protected decimal? _mes10;
		protected decimal? _mes11;
		protected decimal? _mes12;
		protected CatPartida _catpartida;
		protected ReservaSolicitud _reservasolicitud;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected Usuario _usuario;
		protected string _modificacion;
		#endregion
		#region Constructors
			
		public ReservaAutorizada() {}
					
		public ReservaAutorizada(int idreservaautoriza, DateTime? fechaautoriza, int? folioautoriza, decimal? mes01, decimal? mes02, decimal? mes03, decimal? mes04, decimal? mes05, decimal? mes06, decimal? mes07, decimal? mes08, decimal? mes09, decimal? mes10, decimal? mes11, decimal? mes12, DateTime? fechaalta, string ipterminal, string modificacion) 
		{
			this._idreservaautoriza= idreservaautoriza;
			this._fechaautoriza= fechaautoriza;
			this._folioautoriza= folioautoriza;
			this._mes01= mes01;
			this._mes02= mes02;
			this._mes03= mes03;
			this._mes04= mes04;
			this._mes05= mes05;
			this._mes06= mes06;
			this._mes07= mes07;
			this._mes08= mes08;
			this._mes09= mes09;
			this._mes10= mes10;
			this._mes11= mes11;
			this._mes12= mes12;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

		public ReservaAutorizada(int idreservaautoriza)
		{
			this._idreservaautoriza= idreservaautoriza;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdReservaautoriza
		{
			get { return _idreservaautoriza; }
			set {_idreservaautoriza= value; }
		}
		public  virtual CatEjercicio CatEjercicio
		{
			get { return _catejercicio; }
			set {_catejercicio= value; }
		}
		public  virtual DateTime? FechaAutoriza
		{
			get { return _fechaautoriza; }
			set {_fechaautoriza= value; }
		}
		public  virtual int? FolioAutoriza
		{
			get { return _folioautoriza; }
			set {_folioautoriza= value; }
		}
		public  virtual decimal? Mes01
		{
			get { return _mes01; }
			set {_mes01= value; }
		}
		public  virtual decimal? Mes02
		{
			get { return _mes02; }
			set {_mes02= value; }
		}
		public  virtual decimal? Mes03
		{
			get { return _mes03; }
			set {_mes03= value; }
		}
		public  virtual decimal? Mes04
		{
			get { return _mes04; }
			set {_mes04= value; }
		}
		public  virtual decimal? Mes05
		{
			get { return _mes05; }
			set {_mes05= value; }
		}
		public  virtual decimal? Mes06
		{
			get { return _mes06; }
			set {_mes06= value; }
		}
		public  virtual decimal? Mes07
		{
			get { return _mes07; }
			set {_mes07= value; }
		}
		public  virtual decimal? Mes08
		{
			get { return _mes08; }
			set {_mes08= value; }
		}
		public  virtual decimal? Mes09
		{
			get { return _mes09; }
			set {_mes09= value; }
		}
		public  virtual decimal? Mes10
		{
			get { return _mes10; }
			set {_mes10= value; }
		}
		public  virtual decimal? Mes11
		{
			get { return _mes11; }
			set {_mes11= value; }
		}
		public  virtual decimal? Mes12
		{
			get { return _mes12; }
			set {_mes12= value; }
		}
		public  virtual CatPartida CatPartida
		{
			get { return _catpartida; }
			set {_catpartida= value; }
		}
		public  virtual ReservaSolicitud ReservaSolicitud
		{
			get { return _reservasolicitud; }
			set {_reservasolicitud= value; }
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
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual string Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
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
			ReservaAutorizada castObj = (ReservaAutorizada)obj;
			return ( castObj != null ) &&
			this._idreservaautoriza == castObj.IdReservaautoriza;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idreservaautoriza.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
