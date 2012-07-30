/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// EntradaHist object for NHibernate mapped table 'entrada_hist'.
	/// </summary>
    [Serializable]
    public class EntradaHist
    {
        #region Member Variables

	    protected long _id;
	    protected long _idexterno;
        protected int? _numeroentrada;
        protected DateTime? _fechaentrada;
        protected string _numerofactura;
        protected Pedido _pedido;
        protected Usuario _recibio;
        protected Usuario _supervisor;
        protected string _estadoentrada;
        protected Almacen _almacen;
        protected CatActividad _catactividad;
        protected CatPresupuesto _catpresupuesto;
        protected Usuario _usuario;
        protected DateTime? _fechamodificacion;
        protected string _ipterminal;
        protected string _tipo;
        protected int _modificacion;
        #endregion

        #region Constructors

        public EntradaHist() { }

        //public EntradaHist(EntradaHistId id, int? numeroentrada, DateTime? fechaentrada, string numerofactura, int? recibio, int? supervisor, string estadoentrada, DateTime? fechaalta, string ipterminal)
        //{
        //    this._id = id;
        //    this._numeroentrada = numeroentrada;
        //    this._fechaentrada = fechaentrada;
        //    this._numerofactura = numerofactura;
        //    this._recibio = recibio;
        //    this._supervisor = supervisor;
        //    this._estadoentrada = estadoentrada;
        //    this._fechaalta = fechaalta;
        //    this._ipterminal = ipterminal;
        //}

        //public EntradaHist(EntradaHistId id)
        //{
        //    this._id = id;
        //}

        #endregion

        #region Public Properties
        public virtual long Id
        {
            get { return _id; }
            set { _id = value; }
        }
        public virtual long IdExterno
        {
            get { return _idexterno; }
            set { _idexterno = value; }
        }
        public virtual int? NumeroEntrada
        {
            get { return _numeroentrada; }
            set { _numeroentrada = value; }
        }
        public virtual DateTime? FechaEntrada
        {
            get { return _fechaentrada; }
            set { _fechaentrada = value; }
        }
        public virtual string NumeroFactura
        {
            get { return _numerofactura; }
            set { _numerofactura = value; }
        }
        public virtual Pedido Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
        }
        public virtual Usuario Recibio
        {
            get { return _recibio; }
            set { _recibio = value; }
        }
        public virtual Usuario Supervisor
        {
            get { return _supervisor; }
            set { _supervisor = value; }
        }
        public virtual string EstadoEntrada
        {
            get { return _estadoentrada; }
            set { _estadoentrada = value; }
        }
        public virtual Almacen Almacen
        {
            get { return _almacen; }
            set { _almacen = value; }
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
        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public virtual DateTime? FechaModificacion
        {
            get { return _fechamodificacion; }
            set { _fechamodificacion = value; }
        }
        public virtual string IpTerminal
        {
            get { return _ipterminal; }
            set { _ipterminal = value; }
        }
        public virtual string Tipo
        {
            get { return _tipo; }
            set { _tipo = value; }
        }
        public virtual int Modificacion
        {
            get { return _modificacion; }
            set { _modificacion = value; }
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
