/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// SalidaDetHist object for NHibernate mapped table 'salida_det_hist'.
	/// </summary>
	[Serializable]
	public class SalidaDetHist
	{
		#region Member Variables
		protected SalidaDetHistId _id;
		protected int? _identrada;
		protected int? _renglonentrada;
		protected Articulo _articulo;
		protected decimal? _cantidadpedida;
		protected decimal? _cantidadsurtida;
		protected DateTime? _fechacaducidad;
		protected string _nolote;
		protected decimal? _costopromedio;
		protected int? _idactividad;
		protected int? _idpresupuesto;
		#endregion
		#region Constructors
			
		public SalidaDetHist() {}
					
		public SalidaDetHist(SalidaDetHistId id, int? identrada, int? renglonentrada, decimal? cantidadpedida, decimal? cantidadsurtida, DateTime? fechacaducidad, string nolote, decimal? costopromedio, int? idactividad, int? idpresupuesto) 
		{
			this._id= id;
			this._identrada= identrada;
			this._renglonentrada= renglonentrada;
			this._cantidadpedida= cantidadpedida;
			this._cantidadsurtida= cantidadsurtida;
			this._fechacaducidad= fechacaducidad;
			this._nolote= nolote;
			this._costopromedio= costopromedio;
			this._idactividad= idactividad;
			this._idpresupuesto= idpresupuesto;
		}

		public SalidaDetHist(SalidaDetHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual SalidaDetHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual int? IdEntrada
		{
			get { return _identrada; }
			set {_identrada= value; }
		}
		public  virtual int? RenglonEntrada
		{
			get { return _renglonentrada; }
			set {_renglonentrada= value; }
		}
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual decimal? CantidadPedida
		{
			get { return _cantidadpedida; }
			set {_cantidadpedida= value; }
		}
		public  virtual decimal? CantidadSurtida
		{
			get { return _cantidadsurtida; }
			set {_cantidadsurtida= value; }
		}
		public  virtual DateTime? FechaCaducidad
		{
			get { return _fechacaducidad; }
			set {_fechacaducidad= value; }
		}
		public  virtual string NoLote
		{
			get { return _nolote; }
			set {_nolote= value; }
		}
		public  virtual decimal? CostoPromedio
		{
			get { return _costopromedio; }
			set {_costopromedio= value; }
		}
		public  virtual int? IdActividad
		{
			get { return _idactividad; }
			set {_idactividad= value; }
		}
		public  virtual int? IdPresupuesto
		{
			get { return _idpresupuesto; }
			set {_idpresupuesto= value; }
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
			SalidaDetHist castObj = (SalidaDetHist)obj;
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
