/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Cierre object for NHibernate mapped table 'cierre'.
	/// </summary>
	[Serializable]
	public class Cierre
	{
		#region Member Variables
		protected CierreId _id;
		protected decimal _importe;
		protected decimal? _existencia;
		protected DateTime? _fechaalta;
		protected string _estatus;
		protected Usuario _usuario;
		protected CierrePaso _cierrepaso;
        //protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public Cierre() {}

        public Cierre(CierreId id, decimal importe, decimal? existencia, DateTime? fechaalta, string estatus)//, Almacen almacen)
        {
            this._id = id;
            this._importe = importe;
            this._existencia = existencia;
            this._fechaalta = fechaalta;
            this._estatus = estatus;
            //this._almacen = almacen;
        }

		public Cierre(CierreId id)//, decimal importe)//, Almacen almacen)
		{
			this._id= id;
			//this._importe= importe;
			//this._almacen= almacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual CierreId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual decimal Importe
		{
			get { return _importe; }
			set {_importe= value; }
		}
		public  virtual decimal? Existencia
		{
			get { return _existencia; }
			set {_existencia= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual CierrePaso CierrePaso
		{
			get { return _cierrepaso; }
			set {_cierrepaso= value; }
		}
        //public virtual Almacen Almacen
        //{
        //    get { return _almacen; }
        //    set { _almacen = value; }
        //}
		#endregion

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            Cierre castObj = (Cierre)obj;
            return (castObj != null) &&
            this._id.Equals(castObj.Id);
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
