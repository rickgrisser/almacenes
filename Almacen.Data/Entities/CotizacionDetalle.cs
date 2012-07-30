/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CotizacionDetalle object for NHibernate mapped table 'cotizacion_detalle'.
	/// </summary>
	[Serializable]
	public class CotizacionDetalle
	{
		#region Member Variables
		protected long _idcotizaciondetalle;
	    protected Cotizacion _idcotizacion;
	    protected short _renglonanexo;
		protected Articulo _articulo;
		protected string _marca;
		protected decimal? _precio;
		protected string _observaciones;
		#endregion
		#region Constructors
			
		public CotizacionDetalle() {}

        public CotizacionDetalle(long id_idcotizaciondetalle, string marca, decimal? precio, string observaciones) 
		{
            this._idcotizaciondetalle = id_idcotizaciondetalle;
			this._marca= marca;
			this._precio= precio;
			this._observaciones= observaciones;
		}

        public CotizacionDetalle(long idcotizaciondetalle)
		{
            this._idcotizaciondetalle = idcotizaciondetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdCotizacionDetalle
		{
			get { return _idcotizaciondetalle; }
			set {_idcotizaciondetalle= value; }
		}
        public virtual Cotizacion IdCotizacion
        {
            get { return _idcotizacion; }
            set { _idcotizacion = value; }
        }
        public virtual short RenglonAnexo
        {
            get { return _renglonanexo; }
            set { _renglonanexo = value; }
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
            //CotizacionDetalle castObj = (CotizacionDetalle)obj;
            //return ( castObj != null ) &&
            //this._id.Equals( castObj.Id);
		    return false;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
