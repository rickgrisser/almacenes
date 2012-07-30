/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CierrePaso object for NHibernate mapped table 'cierre_paso'.
	/// </summary>
	[Serializable]
	public class CierrePaso
	{
		#region Member Variables
		protected CierrePasoId _id;
		//protected string _entsal;
		protected decimal? _cantidad;
		protected decimal? _costop;
		//protected int? _llave;
		#endregion
		#region Constructors
			
		public CierrePaso() {}
					
		public CierrePaso(CierrePasoId id,  decimal? cantidad, decimal? costop)//string entsal,, int? llave) 
		{
			this._id= id;
			//this._entsal= entsal;
			this._cantidad= cantidad;
			this._costop= costop;
			//this._llave= llave;
		}

		public CierrePaso(CierrePasoId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual CierrePasoId Id
		{
			get { return _id; }
			set {_id= value; }
		}
        //public  virtual string EntSal
        //{
        //    get { return _entsal; }
        //    set {_entsal= value; }
        //}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
		public  virtual decimal? CostoP
		{
			get { return _costop; }
			set {_costop= value; }
		}
        //public  virtual int? Llave
        //{
        //    get { return _llave; }
        //    set {_llave= value; }
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
            CierrePaso castObj = (CierrePaso)obj;
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
