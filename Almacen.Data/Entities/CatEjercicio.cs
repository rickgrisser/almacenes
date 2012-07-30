/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatEjercicio object for NHibernate mapped table 'cat_ejercicio'.
	/// </summary>
	[Serializable]
	public class CatEjercicio
	{
		#region Member Variables
		protected int _idejercicio;
		protected string _desejercicio;
		protected string _estatus;
		protected IList<ReservaAutoHis> _reservaautohis;
		protected IList<ReservaAutorizada> _reservaautorizada;
		protected IList<ReservaSolicHist> _reservasolichist;
		protected IList<ReservaSolicitud> _reservasolicitud;
		#endregion
		#region Constructors
			
		public CatEjercicio() {}
					
		public CatEjercicio(int idejercicio, string desejercicio, string estatus) 
		{
			this._idejercicio= idejercicio;
			this._desejercicio= desejercicio;
			this._estatus= estatus;
		}

		public CatEjercicio(int idejercicio)
		{
			this._idejercicio= idejercicio;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdEjercicio
		{
			get { return _idejercicio; }
			set {_idejercicio= value; }
		}
		public  virtual string DesEjercicio
		{
			get { return _desejercicio; }
			set {_desejercicio= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
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
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			CatEjercicio castObj = (CatEjercicio)obj;
			return ( castObj != null ) &&
			this._idejercicio == castObj.IdEjercicio;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idejercicio.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
