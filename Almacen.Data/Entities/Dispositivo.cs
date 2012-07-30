/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Dispositivo object for NHibernate mapped table 'dispositivo'.
	/// </summary>
	[Serializable]
	public class Dispositivo
	{
		#region Member Variables

	    protected long _iddispositivo;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected CatTipodispositivo _cattipodispositivo;
		protected string _caracteristicastecnicas;
		protected int? _garantia;
		protected DateTime? _fechavencegarantia;
		protected CatGarantia _catgarantia;
		protected CatClasificacion _catclasificacion;
		protected Usuario _usuario;
		#endregion
		#region Constructors
			
		public Dispositivo() {}
					
		public Dispositivo(long iddispositivo, string caracteristicastecnicas, int? garantia, DateTime? fechavencegarantia) 
		{
            this._iddispositivo = iddispositivo;
			this._caracteristicastecnicas= caracteristicastecnicas;
			this._garantia= garantia;
			this._fechavencegarantia= fechavencegarantia;
		}

        public Dispositivo(long iddispositivo, ResguardoEntregaDetalle resguardoentregadetalle)
		{
            this._iddispositivo = iddispositivo;
            this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdDispositivo
		{
            get { return _iddispositivo; }
            set { _iddispositivo = value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual CatTipodispositivo CatTipodispositivo
		{
			get { return _cattipodispositivo; }
			set {_cattipodispositivo= value; }
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
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
            //Dispositivo castObj = (Dispositivo)obj;
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
