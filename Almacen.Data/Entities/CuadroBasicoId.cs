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
	/// CuadroBasicoId object for NHibernate mapped table 'cuadro_basico'.
	/// </summary>
	[Serializable]
	public class CuadroBasicoId
	{
		#region Member Variables
		protected Articulo _articulo;
		protected int _cvecbasico;
		//protected Almacen _almacen;
		protected int _movimiento;
		#endregion
		#region Constructors
			
		public CuadroBasicoId() {}
					
		public CuadroBasicoId(Articulo articulo, int cvecbasico, int movimiento)//, Almacen almacen 
		{
			this._articulo= articulo;
			this._cvecbasico= cvecbasico;
			//this._almacen= almacen;
			this._movimiento= movimiento;
		}

		#endregion
		#region Public Properties
		public  virtual Articulo Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
        [Min(1, Message = "Clave Cuadro Basico Mayor a Cero")]
        [NotNull(Message = "Clave Cuadro Basico - Campo Requerido")]
		public  virtual int CveCBasico
		{
			get { return _cvecbasico; }
			set {_cvecbasico= value; }
		}
        //public  virtual Almacen Almacen
        //{
        //    get { return _almacen; }
        //    set {_almacen= value; }
        //}
		public  virtual int Movimiento
		{
            get { return _movimiento; }
            set { _movimiento = value; }
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
            CuadroBasicoId castObj = (CuadroBasicoId)obj;
            return (castObj != null) &&
            this._articulo.Equals(castObj.Articulo) &&
            this._cvecbasico == castObj.CveCBasico &&
            //this._almacen.Equals(castObj.Almacen) &&
            this._movimiento == castObj.Movimiento;
        }
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
            //hash = 27 * hash * _articulo.GetHashCode();
            //hash = 27 * hash * _cvecbasico.GetHashCode();
            //hash = 27 * hash * _almacen.GetHashCode();
            //hash = 27 * hash * _estatus.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
