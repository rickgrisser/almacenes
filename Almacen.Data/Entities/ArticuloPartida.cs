/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ArticuloPartida object for NHibernate mapped table 'articulo_partida'.
	/// </summary>
	[Serializable]
	public class ArticuloPartida
	{
		#region Member Variables
		protected ArticuloPartidaId _id;
        protected DateTime? _fechainicio;
		protected DateTime? _fechafin;
        //protected CatPartida _catpartida;
		#endregion
		#region Constructors
			
		public ArticuloPartida() {}
					
		public ArticuloPartida(ArticuloPartidaId id, DateTime? fechainicio, DateTime? fechafin)//, CatPartida catpartida) 
		{
			this._id= id;            
			this._fechainicio= fechainicio;
			this._fechafin= fechafin;
            //this._catpartida = catpartida;
		}

		public ArticuloPartida(ArticuloPartidaId id)//, CatPartida catpartida)
		{
			this._id= id;
			//this._catpartida= catpartida;
		}
		
		#endregion
		#region Public Properties
		public  virtual ArticuloPartidaId Id
		{
			get { return _id; }
			set {_id= value; }
		}       		
        public  virtual DateTime? FechaInicio
		{
			get { return _fechainicio; }
			set {_fechainicio= value; }
		}
		public  virtual DateTime? FechaFin
		{
			get { return _fechafin; }
			set {_fechafin= value; }
		}
        //public virtual CatPartida CatPartida
        //{
        //    get { return _catpartida; }
        //    set { _catpartida = value; }
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
        //    ArticuloPartida castObj = (ArticuloPartida)obj;
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
