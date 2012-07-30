/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CotizacionHist object for NHibernate mapped table 'cotizacion_hist'.
	/// </summary>
	[Serializable]
	public class CotizacionHist
	{
		#region Member Variables
		protected CotizacionHistId _id;
		protected Proveedor _proveedor;
		protected DateTime? _fechacotizacion;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected IList<CotizacionDetHis> _cotizaciondethis;
		#endregion
		#region Constructors
			
		public CotizacionHist() {}
					
		public CotizacionHist(CotizacionHistId id, DateTime? fechacotizacion, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._fechacotizacion= fechacotizacion;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public CotizacionHist(CotizacionHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual CotizacionHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual DateTime? FechaCotizacion
		{
			get { return _fechacotizacion; }
			set {_fechacotizacion= value; }
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
		public  virtual IList<CotizacionDetHis> CotizacionDetHis
		{
			get { return _cotizaciondethis; }
			set {_cotizaciondethis= value; }
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
			CotizacionHist castObj = (CotizacionHist)obj;
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
