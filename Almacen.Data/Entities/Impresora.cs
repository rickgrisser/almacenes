/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Impresora object for NHibernate mapped table 'impresora'.
	/// </summary>
	[Serializable]
	public class Impresora
	{
		#region Member Variables
	    protected long _idimpresora;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected int? _memoriamb;
		protected int? _velocidad;
		protected string _color;
		protected bool? _ethernet;
		protected CatTipopuerto _cattipopuerto;
		protected string _caracteristicastecnicas;
		protected int? _garantia;
		protected CatGarantia _catgarantia;
		protected CatTipoimpresora _cattipoimpresora;
		protected DateTime? _fechavencegarantia;
		protected CatClasificacion _catclasificacion;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected CatColorimpresora _catcolorimpresora;
		#endregion
		#region Constructors
			
		public Impresora() {}
					
		public Impresora(long idimpresora, int? memoriamb, int? velocidad, string color, bool? ethernet, string caracteristicastecnicas, int? garantia, DateTime? fechavencegarantia, DateTime? fechaalta, string ipterminal) 
		{
			this._idimpresora= idimpresora;
			this._memoriamb= memoriamb;
			this._velocidad= velocidad;
			this._color= color;
			this._ethernet= ethernet;
			this._caracteristicastecnicas= caracteristicastecnicas;
			this._garantia= garantia;
			this._fechavencegarantia= fechavencegarantia;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public Impresora(long idimpresora, ResguardoEntregaDetalle resguardoentregadetalle)
		{
            this._idimpresora = idimpresora;
		    this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdImpresora
		{
            get { return _idimpresora; }
            set { _idimpresora = value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual int? Memoriamb
		{
			get { return _memoriamb; }
			set {_memoriamb= value; }
		}
		public  virtual int? Velocidad
		{
			get { return _velocidad; }
			set {_velocidad= value; }
		}
		public  virtual string Color
		{
			get { return _color; }
			set {_color= value; }
		}
		public  virtual bool? Ethernet
		{
			get { return _ethernet; }
			set {_ethernet= value; }
		}
		public  virtual CatTipopuerto CatTipopuerto
		{
			get { return _cattipopuerto; }
			set {_cattipopuerto= value; }
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
		public  virtual CatGarantia CatGarantia
		{
			get { return _catgarantia; }
			set {_catgarantia= value; }
		}
		public  virtual CatTipoimpresora CatTipoimpresora
		{
			get { return _cattipoimpresora; }
			set {_cattipoimpresora= value; }
		}
		public  virtual DateTime? FechaVenceGarantia
		{
			get { return _fechavencegarantia; }
			set {_fechavencegarantia= value; }
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
		public  virtual CatColorimpresora CatColorimpresora
		{
			get { return _catcolorimpresora; }
			set {_catcolorimpresora= value; }
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
            //Impresora castObj = (Impresora)obj;
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
