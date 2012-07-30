/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
namespace Almacen.Data.Entities
{
	/// <summary>
	/// SalidaDetalle object for NHibernate mapped table 'salida_detalle'.
	/// </summary>
	[Serializable]
	public class SalidaDetalle
	{
		#region Member Variables
	    protected long _idsalidadetalle;
	    protected Salida _salida;
	    protected short _renglonsalida;
        protected EntradaDetalle _entradadetalle;
        protected Articulo _articulo;
        protected decimal? _cantidadpedida;
        protected decimal? _cantidadsurtida;
        protected DateTime? _fechacaducidad;
        protected string _nolote;
        protected decimal? _costopromedio;
        protected CatActividad _catactividad;
        protected CatPresupuesto _catpresupuesto;
		#endregion
		#region Constructors
			
		public SalidaDetalle() {}

        public SalidaDetalle(long idsalidadetalle, decimal? cantidadpedida, decimal? cantidadsurtida, DateTime? fechacaducidad, string nolote, decimal? costopromedio, Salida salida) 
		{
            this._idsalidadetalle = idsalidadetalle;
            this._cantidadpedida = cantidadpedida;
            this._cantidadsurtida = cantidadsurtida;
            this._fechacaducidad = fechacaducidad;
            this._nolote = nolote;
            this._costopromedio = costopromedio;
			this._salida= salida;
		}

        public SalidaDetalle(long idsalidadetalle, Salida salida)
        {
            this._idsalidadetalle = idsalidadetalle;
            this._salida= salida;
        }
		
		#endregion
		#region Public Properties
		public  virtual long IdSalidaDetalle
		{
            get { return _idsalidadetalle; }
            set { _idsalidadetalle = value; }
		}
        public virtual Salida Salida
        {
            get { return _salida; }
            set { _salida = value; }
        }
        public virtual short RenglonSalida
        {
            get { return _renglonsalida; }
            set { _renglonsalida = value; }
        }
        public virtual EntradaDetalle EntradaDetalle
        {
            get { return _entradadetalle; }
            set { _entradadetalle = value; }
        }
         [NotNull(Message = "Articulo - Campo Requerido")]
        public virtual Articulo Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }
         [NotNull(Message = "Cantidad Pedida - Campo Requerido")]
        public virtual decimal? CantidadPedida
        {
            get { return _cantidadpedida; }
            set { _cantidadpedida = value; }
        }
         [NotNull(Message = "Cantidad Surtida - Campo Requerido")]
        public virtual decimal? CantidadSurtida
        {
            get { return _cantidadsurtida; }
            set { _cantidadsurtida = value; }
        }
        public virtual DateTime? FechaCaducidad
        {
            get { return _fechacaducidad; }
            set { _fechacaducidad = value; }
        }
        public virtual string NoLote
        {
            get { return _nolote; }
            set { _nolote = value; }
        }
        public virtual decimal? CostoPromedio
        {
            get { return _costopromedio; }
            set { _costopromedio = value; }
        }
        public virtual CatActividad CatActividad
        {
            get { return _catactividad; }
            set { _catactividad = value; }
        }
        public virtual CatPresupuesto CatPresupuesto
        {
            get { return _catpresupuesto; }
            set { _catpresupuesto = value; }
        }
       
		#endregion

        #region Bindeo

        private int _clave;
        public virtual int Clave
        {
            //get { return _clave; }
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
                if(Articulo!=null)
                _descripcion=Articulo.DesArticulo;
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

        private decimal _existencia;
        public virtual decimal Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
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
            //SalidaDetalle castObj = (SalidaDetalle)obj;
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
