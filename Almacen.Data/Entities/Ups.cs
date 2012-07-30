/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Ups object for NHibernate mapped table 'ups'.
	/// </summary>
	[Serializable]
	public class Ups
	{
		#region Member Variables

	    protected long _idups;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected int? _potenciava;
		protected string _caracteristicastecnicas;
		protected int? _garantia;
		protected DateTime? _fechavencegarantia;
		protected CatGarantia _catgarantia;
		protected CatClasificacion _catclasificacion;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		#endregion
		#region Constructors
			
		public Ups() {}
					
		public Ups(long idups, int? potenciava, string caracteristicastecnicas, int? garantia, DateTime? fechavencegarantia, DateTime? fechaalta, string ipterminal) 
		{
            this._idups = idups;
			this._potenciava= potenciava;
			this._caracteristicastecnicas= caracteristicastecnicas;
			this._garantia= garantia;
			this._fechavencegarantia= fechavencegarantia;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

        public Ups(long idups, ResguardoEntregaDetalle resguardoentregadetalle)
		{
            this._idups = idups;
            this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdUps
		{
			get { return _idups; }
			set {_idups= value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual int? Potenciava
		{
			get { return _potenciava; }
			set {_potenciava= value; }
		}
		public  virtual string CaracteristicasTecnicas
		{
			get { return _caracteristicastecnicas; }
			set {_caracteristicastecnicas= value; }
		}
		public  virtual int? Garantia
		{
			get { return _garantia; }
			set {_garantia= value; }
		}
		public  virtual DateTime? FechaVenceGarantia
		{
			get { return _fechavencegarantia; }
			set {_fechavencegarantia= value; }
		}
		public  virtual CatGarantia CatGarantia
		{
			get { return _catgarantia; }
			set {_catgarantia= value; }
		}
		public  virtual CatClasificacion CatClasificacion
		{
			get { return _catclasificacion; }
			set {_catclasificacion= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
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
            //Ups castObj = (Ups)obj;
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
