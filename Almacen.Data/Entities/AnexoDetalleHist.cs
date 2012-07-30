/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// AnexoDetalleHist object for NHibernate mapped table 'anexo_detalle_hist'.
	/// </summary>
	[Serializable]
	public class AnexoDetalleHist
	{
		#region Member Variables
		protected AnexoDetalleHistId _id;
		protected Articulo _articulo;
		protected string _presentacion;
		protected decimal? _cantidad;
		#endregion
		#region Constructors
			
		public AnexoDetalleHist() {}
					
		public AnexoDetalleHist(AnexoDetalleHistId id, string presentacion, decimal? cantidad) 
		{
			this._id= id;
			this._presentacion= presentacion;
			this._cantidad= cantidad;
		}

		public AnexoDetalleHist(AnexoDetalleHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual AnexoDetalleHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual string Presentacion
		{
			get { return _presentacion; }
			set {_presentacion= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
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
			AnexoDetalleHist castObj = (AnexoDetalleHist)obj;
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
