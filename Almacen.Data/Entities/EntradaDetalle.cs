/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using NHibernate.Validator.Constraints;
using Almacen.Data.Auxiliares;
namespace Almacen.Data.Entities
{
	/// <summary>
	/// EntradaDetalle object for NHibernate mapped table 'entrada_detalle'.
	/// </summary>
	[Serializable]
	public class EntradaDetalle:IDetalle
	{
		#region Member Variables
		
	    protected long _identradadetalle;
        protected Entrada _entrada = new Entrada();
	    protected short _renglonentrada;
		protected Articulo _articulo;
		protected decimal? _cantidad;
		protected decimal? _existencia;
		protected decimal? _precioentrada;
		protected DateTime? _fechacaducidad;
		protected string _nolote;
        protected IList<SalidaDetalle> _salidadetalle;
        protected IList<ResguardoEntrega> _resguardoentrega;
		#endregion
		#region Constructors
			
		public EntradaDetalle() {}

        public EntradaDetalle(long identradadetalle, decimal? cantidad, decimal? existencia, decimal? precioentrada, DateTime? fechacaducidad, string nolote, Entrada entrada)
        {
            this._identradadetalle = identradadetalle;
            this._cantidad = cantidad;
            this._existencia = existencia;
            this._precioentrada = precioentrada;
            this._fechacaducidad = fechacaducidad;
            this._nolote = nolote;
            this._entrada = entrada;
        }

        public EntradaDetalle(long identradadetalle, Entrada entrada)
		{
            this._identradadetalle = identradadetalle;
            this._entrada = entrada;
		}
		
		#endregion
		#region Public Properties

	    public virtual long IdEntradaDetalle
		{
			get { return _identradadetalle; }
			set {_identradadetalle= value; }
		}
        public virtual Entrada Entrada
        {
            get { return _entrada; }
            set { _entrada = value; }
        }
        public virtual short RenglonEntrada
        {
            get { return _renglonentrada; }
            set { _renglonentrada = value; }
        }
        [NotNull(Message = "Articulo - Campo Requerido")]
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
        [NotNull(Message = "Cantidad - Campo Requerido")]
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual decimal? Existencia
		{
			get { return _existencia; }
			set {_existencia= value; }
		}
        [NotNull(Message = "Precio Entrada - Campo Requerido")]
		public  virtual decimal? PrecioEntrada
		{
			get { return _precioentrada; }
			set {_precioentrada= value; }
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
        public virtual IList<SalidaDetalle> SalidaDetalle
        {
            get { return _salidadetalle; }
            set { _salidadetalle = value; }
        }
        public virtual IList<ResguardoEntrega> ResguardoEntrega
        {
            get { return _resguardoentrega; }
            set { _resguardoentrega = value; }
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
        #endregion

        #region Equals And HashCode Overrides
        /// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
        //public override bool Equals(object obj)
        //{
        //    if (this == obj) return true;
        //    if ((obj == null) || (obj.GetType() != this.GetType())) return false;
        //    EntradaDetalle castObj = (EntradaDetalle)obj;
        //    return (castObj != null) &&
        //    this._id.Equals(castObj.Id);
        //}
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
