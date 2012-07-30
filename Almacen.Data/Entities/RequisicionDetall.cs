/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// RequisicionDetall object for NHibernate mapped table 'requisicion_detall'.
	/// </summary>
	[Serializable]
	public class RequisicionDetall
	{
		#region Member Variables
	    protected long _idrequisiciondetalle;
	    protected Requisicion _requisicion;
	    protected short _renglon;
		protected Articulo _articulo;
		protected decimal? _cantidad;
		#endregion
		#region Constructors
			
		public RequisicionDetall() {}

        public RequisicionDetall(long idrequisiciondetalle, decimal? cantidad, Requisicion requisicion) 
		{
            this._idrequisiciondetalle = idrequisiciondetalle;
			this._cantidad= cantidad;
			this._requisicion= requisicion;
		}

        public RequisicionDetall(long idrequisiciondetalle, Requisicion requisicion)
		{
            this._idrequisiciondetalle = idrequisiciondetalle;
			this._requisicion= requisicion;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdRequisicionDetalle
		{
            get { return _idrequisiciondetalle; }
            set { _idrequisiciondetalle = value; }
		}

		public  virtual Requisicion Requisicion
		{
            get { return _requisicion; }
            set { _requisicion = value; }
		}
        public virtual short Renglon
        {
            get { return _renglon; }
            set { _renglon = value; }
        }
        public virtual Articulo Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
        }
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
		}
        //public  virtual Requisicion Requisicion
        //{
        //    get { return _requisicion; }
        //    set {_requisicion= value; }
        //}

        #region Bindeo
        
        #endregion

		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            //RequisicionDetall castObj = (RequisicionDetall)obj;
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
