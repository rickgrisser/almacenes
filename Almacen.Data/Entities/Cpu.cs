/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Cpu object for NHibernate mapped table 'cpu'.
	/// </summary>
	[Serializable]
	public class Cpu
	{
		#region Member Variables
	    protected long _idcpu;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected CatTipocomputadora _cattipocomputadora;
		protected CatProcesador _catprocesador;
		protected decimal? _velocidadghz;
		protected decimal? _memoriagb;
		protected decimal? _discogb;
		protected string _caracteristicastecnicas;
		protected int? _garantia;
		protected CatGarantia _catgarantia;
		protected CatClasificacion _catclasificacion;
		protected DateTime? _fechavencegarantia;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected CatUnidadlectora _catunidadlectora;
		protected IList<CpuSoftware> _cpusoftware;
		#endregion
		#region Constructors
			
		public Cpu() {}
					
		public Cpu(long idcpu, decimal? velocidadghz, decimal? memoriagb, decimal? discogb, string caracteristicastecnicas, int? garantia, DateTime? fechavencegarantia, DateTime? fechaalta, string ipterminal) 
		{
            this._idcpu = idcpu;
			this._velocidadghz= velocidadghz;
			this._memoriagb= memoriagb;
			this._discogb= discogb;
			this._caracteristicastecnicas= caracteristicastecnicas;
			this._garantia= garantia;
			this._fechavencegarantia= fechavencegarantia;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

        public Cpu(long idcpu, ResguardoEntregaDetalle resguardoentregadetalle)
		{
            this._idcpu = idcpu;
            this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdCpu
		{
            get { return _idcpu; }
            set { _idcpu = value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual CatTipocomputadora CatTipocomputadora
		{
			get { return _cattipocomputadora; }
			set {_cattipocomputadora= value; }
		}
		public  virtual CatProcesador CatProcesador
		{
			get { return _catprocesador; }
			set {_catprocesador= value; }
		}
		public  virtual decimal? Velocidadghz
		{
			get { return _velocidadghz; }
			set {_velocidadghz= value; }
		}
		public  virtual decimal? Memoriagb
		{
			get { return _memoriagb; }
			set {_memoriagb= value; }
		}
		public  virtual decimal? Discogb
		{
			get { return _discogb; }
			set {_discogb= value; }
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
		public  virtual CatClasificacion CatClasificacion
		{
			get { return _catclasificacion; }
			set {_catclasificacion= value; }
		}
		public  virtual DateTime? FechaVenceGarantia
		{
			get { return _fechavencegarantia; }
			set {_fechavencegarantia= value; }
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
		public  virtual CatUnidadlectora CatUnidadlectora
		{
			get { return _catunidadlectora; }
			set {_catunidadlectora= value; }
		}
		public  virtual IList<CpuSoftware> CpuSoftware
		{
			get { return _cpusoftware; }
			set {_cpusoftware= value; }
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
            //Cpu castObj = (Cpu)obj;
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
