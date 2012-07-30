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
	/// CuadroBasico object for NHibernate mapped table 'cuadro_basico'.
	/// </summary>
	[Serializable]
	public class CuadroBasico
	{
		#region Member Variables
		protected CuadroBasicoId _id;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		//protected Almacen _almacen;
		#endregion
		#region Constructors
			
		public CuadroBasico() {}
					
		public CuadroBasico(CuadroBasicoId id, DateTime? fechaalta, DateTime? fechabaja)//, Almacen almacen) 
		{
			this._id= id;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			//this._almacen= almacen;
		}

		public CuadroBasico(CuadroBasicoId id)//, Almacen almacen)
		{
			this._id= id;
			//this._almacen= almacen;
		}
		
		#endregion
		#region Public Properties
        [Valid]
		public  virtual CuadroBasicoId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
        //public  virtual Almacen Almacen
        //{
        //    get { return _almacen; }
        //    set {_almacen= value; }
        //}
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
        //public override bool Equals( object obj )
        //{
        //    if( this == obj ) return true;
        //    if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
        //    CuadroBasico castObj = (CuadroBasico)obj;
        //    return ( castObj != null ) &&
        //    this._id.Equals( castObj.Id);
        //}
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
