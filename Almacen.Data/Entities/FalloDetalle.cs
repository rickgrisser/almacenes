/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// FalloDetalle object for NHibernate mapped table 'fallo_detalle'.
	/// </summary>
	[Serializable]
	public class FalloDetalle
	{
		#region Member Variables
		protected long _idfallodetalle;
	    protected short _rengloanexo;
	    protected Fallo _fallo;
		protected decimal? _cantidadmax;
		protected decimal? _cantidadmin;
		protected decimal? _cantidadped;
		protected decimal? _preciofallo;
		protected Articulo _articulo;
		//protected Fallo _fallo;
		#endregion
		#region Constructors
			
		public FalloDetalle() {}
					
		public FalloDetalle(long idfallodetalle, decimal? cantidadmax, decimal? cantidadmin, decimal? cantidadped, decimal? preciofallo)//, Fallo fallo) 
		{
            this._idfallodetalle = idfallodetalle;
			this._cantidadmax= cantidadmax;
			this._cantidadmin= cantidadmin;
			this._cantidadped= cantidadped;
			this._preciofallo= preciofallo;
			//this._fallo= fallo;
		}

        public FalloDetalle(long idfallodetalle)//, Fallo fallo)
		{
            this._idfallodetalle = idfallodetalle;
			//this._fallo= fallo;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdFalloDetalle
		{
            get { return _idfallodetalle; }
            set { _idfallodetalle = value; }
		}
        public virtual short RenglonAnexo
        {
            get { return _rengloanexo; }
            set { _rengloanexo = value; }
        }
        public virtual Fallo Fallo
        {
            get { return _fallo; }
            set { _fallo = value; }
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
        //public  virtual Fallo Fallo
        //{
        //    get { return _fallo; }
        //    set {_fallo= value; }
        //}
        #endregion

        #region Bindeo

        private int _clave;
        public virtual int Clave
        {
            get
            {
                if (Articulo != null)
                    _clave = Articulo.Id.CveArt;
                return _clave;
            }
            set { _clave = value; }
        }

        private string _descripcion;
        public virtual string Descripcion
        {
            get
            {
                if (Articulo != null)
                    _descripcion = Articulo.DesArticulo;
                return _descripcion;
            }
            set { _descripcion = value; }
        }

        private string _unidad;
        public virtual string Unidad
        {
            get
            {
                if (Articulo != null)
                    _unidad = Articulo.CatUnidad;
                return _unidad;
            }
            set { _unidad = value; }
        }

	    private decimal _requisicion;
        public virtual decimal Requisicion
	    {
	        get { return _requisicion; }
            set { _requisicion = value; }
	    }

        #endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            //FalloDetalle castObj = (FalloDetalle)obj;
            //return (castObj != null) &&
            //this._id.Equals(castObj.Id);
		    return false;
        }
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
            //if (_id == null)
            //    return 57;
            //hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
