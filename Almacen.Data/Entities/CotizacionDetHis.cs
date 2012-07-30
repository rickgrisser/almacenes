/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CotizacionDetHis object for NHibernate mapped table 'cotizacion_det_his'.
	/// </summary>
	[Serializable]
	public class CotizacionDetHis
	{
		#region Member Variables
		protected CotizacionDetHisId _id;
		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _precio;
		protected string _observaciones;
		#endregion
		#region Constructors
			
		public CotizacionDetHis() {}
					
		public CotizacionDetHis(CotizacionDetHisId id, string marca, decimal? precio, string observaciones) 
		{
			this._id= id;
			this._marca= marca;
			this._precio= precio;
			this._observaciones= observaciones;
		}

		public CotizacionDetHis(CotizacionDetHisId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual CotizacionDetHisId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Marca
		{
			get { return _marca; }
			set {_marca= value; }
		}
		public  virtual decimal? Precio
		{
			get { return _precio; }
			set {_precio= value; }
		}
		public  virtual string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones= value; }
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
			CotizacionDetHis castObj = (CotizacionDetHis)obj;
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
