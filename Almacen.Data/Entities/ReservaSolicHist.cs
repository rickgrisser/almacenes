/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ReservaSolicHist object for NHibernate mapped table 'reserva_solic_hist'.
	/// </summary>
	[Serializable]
	public class ReservaSolicHist
	{
		#region Member Variables
		protected ReservaSolicHistId _id;
		protected CatEjercicio _catejercicio;
		protected DateTime? _fechareserva;
		protected string _foliosolicita;
		protected decimal? _importe;
		protected CatPartida _catpartida;
		protected CatArea _catarea;
		protected string _concepto;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected Usuario _usuario;
		#endregion
		#region Constructors
			
		public ReservaSolicHist() {}
					
		public ReservaSolicHist(ReservaSolicHistId id, DateTime? fechareserva, string foliosolicita, decimal? importe, string concepto, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._fechareserva= fechareserva;
			this._foliosolicita= foliosolicita;
			this._importe= importe;
			this._concepto= concepto;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public ReservaSolicHist(ReservaSolicHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ReservaSolicHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual CatEjercicio CatEjercicio
		{
			get { return _catejercicio; }
			set {_catejercicio= value; }
		}
		public  virtual DateTime? FechaReserva
		{
			get { return _fechareserva; }
			set {_fechareserva= value; }
		}
		public  virtual string FolioSolicita
		{
			get { return _foliosolicita; }
			set {_foliosolicita= value; }
		}
		public  virtual decimal? Importe
		{
			get { return _importe; }
			set {_importe= value; }
		}
		public  virtual CatPartida CatPartida
		{
			get { return _catpartida; }
			set {_catpartida= value; }
		}
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			set {_catarea= value; }
		}
		public  virtual string Concepto
		{
			get { return _concepto; }
			set {_concepto= value; }
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
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			ReservaSolicHist castObj = (ReservaSolicHist)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
