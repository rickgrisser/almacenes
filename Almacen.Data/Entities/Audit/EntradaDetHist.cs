/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// EntradaDetHist object for NHibernate mapped table 'entrada_det_hist'.
	/// </summary>
	[Serializable]
	public class EntradaDetHist
	{
		#region Member Variables
		protected long _id;
	    protected long _idexterno;
	    protected Entrada _entrada;
        protected short _renglonentrada;
		protected Articulo _articulo;
		protected decimal? _cantidad;
		protected decimal? _existencia;
		protected decimal? _precioentrada;
		protected DateTime? _fechacaducidad;
		protected string _nolote;
	    protected string _tipo;
	    protected long _idhist;
		#endregion

		#region Constructors
			
		public EntradaDetHist() {}
					
		
		#endregion
		#region Public Properties
		public  virtual long Id
		{
			get { return _id; }
			set {_id= value; }
		}
        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
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
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
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
        public virtual string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public virtual long IdHist
        {
            get { return _idhist; }
            set { _idhist = value; }
        }
		#endregion

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            return true;
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
