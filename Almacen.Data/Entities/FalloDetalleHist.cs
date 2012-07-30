/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// FalloDetalleHist object for NHibernate mapped table 'fallo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class FalloDetalleHist
	{
		#region Member Variables
		protected FalloDetalleHistId _id;
		protected decimal? _cantidadmax;
		protected decimal? _cantidadmin;
		protected decimal? _cantidadped;
		protected decimal? _preciofallo;
		protected Articulo _articulo;
		#endregion
		#region Constructors
			
		public FalloDetalleHist() {}
					
		public FalloDetalleHist(FalloDetalleHistId id, decimal? cantidadmax, decimal? cantidadmin, decimal? cantidadped, decimal? preciofallo) 
		{
			this._id= id;
			this._cantidadmax= cantidadmax;
			this._cantidadmin= cantidadmin;
			this._cantidadped= cantidadped;
			this._preciofallo= preciofallo;
		}

		public FalloDetalleHist(FalloDetalleHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual FalloDetalleHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual decimal? CantidadMax
		{
			get { return _cantidadmax; }
			set {_cantidadmax= value; }
		}
		public  virtual decimal? CantidadMin
		{
			get { return _cantidadmin; }
			set {_cantidadmin= value; }
		}
		public  virtual decimal? CantidadPed
		{
			get { return _cantidadped; }
			set {_cantidadped= value; }
		}
		public  virtual decimal? PrecioFallo
		{
			get { return _preciofallo; }
			set {_preciofallo= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
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
			FalloDetalleHist castObj = (FalloDetalleHist)obj;
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
