/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntregaDetalleHist object for NHibernate mapped table 'resguardo_entrega_detalle_hist'.
	/// </summary>
	[Serializable]
	public class ResguardoEntregaDetalleHist
	{
		#region Member Variables
		protected ResguardoEntregaDetalleHistId _id;
		protected string _serie;
		protected string _estatusbien;
		protected string _estatusasignacion;
		protected DateTime? _fechaultimomovimiento;
		protected int? _idbaja;
		protected IList<AsignacionBienHist> _asignacionbienhist;
		#endregion
		#region Constructors
			
		public ResguardoEntregaDetalleHist() {}
					
		public ResguardoEntregaDetalleHist(ResguardoEntregaDetalleHistId id, string serie, string estatusbien, string estatusasignacion, DateTime? fechaultimomovimiento, int? idbaja) 
		{
			this._id= id;
			this._serie= serie;
			this._estatusbien= estatusbien;
			this._estatusasignacion= estatusasignacion;
			this._fechaultimomovimiento= fechaultimomovimiento;
			this._idbaja= idbaja;
		}

		public ResguardoEntregaDetalleHist(ResguardoEntregaDetalleHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ResguardoEntregaDetalleHistId Id
		{
			get { return _id; }
			set {_id= value; }
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
		public  virtual int? IdBaja
		{
			get { return _idbaja; }
			set {_idbaja= value; }
		}
		public  virtual IList<AsignacionBienHist> AsignacionBienHist
		{
			get { return _asignacionbienhist; }
			set {_asignacionbienhist= value; }
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
			ResguardoEntregaDetalleHist castObj = (ResguardoEntregaDetalleHist)obj;
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
