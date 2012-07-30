/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntrega object for NHibernate mapped table 'resguardo_entrega'.
	/// </summary>
	[Serializable]
	public class ResguardoEntrega
	{
		#region Member Variables
	    protected long _idresguardo;
	    protected EntradaDetalle _entradadetalle;
		protected DateTime? _fechaminuta;
		protected string _comentarios;
		protected string _pais;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected Modelo _modelo;
		protected int? _idarea;
        protected Usuario _idrecibe;
        protected Usuario _identrega;
        protected Usuario _idevatecno;
        protected string _nombreentrga;
        protected string _recibe;
		protected IList<ResguardoEntregaDetalle> _resguardoentregadetalle;
		#endregion
		#region Constructors
			
		public ResguardoEntrega() {}
					
		public ResguardoEntrega(long idresguardo, DateTime? fechaminuta, string comentarios, string pais, DateTime? fechaalta, string ipterminal, int? idarea) 
		{
            this._idresguardo = idresguardo;
			this._fechaminuta= fechaminuta;
			this._comentarios= comentarios;
			this._pais= pais;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._idarea= idarea;
		}

        public ResguardoEntrega(long idresguardo, EntradaDetalle entradaDetalle)
		{
            this._idresguardo = idresguardo;
            this._entradadetalle = entradaDetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdResguardo
		{
            get { return _idresguardo; }
            set { _idresguardo = value; }
		}
        public virtual EntradaDetalle EntradaDetalle
        {
            get { return _entradadetalle; }
            set { _entradadetalle = value; }
        }
		public  virtual DateTime? FechaMinuta
		{
			get { return _fechaminuta; }
			set {_fechaminuta= value; }
		}
		public  virtual string Comentarios
		{
			get { return _comentarios; }
			set {_comentarios= value; }
		}
		public  virtual string Pais
		{
			get { return _pais; }
			set {_pais= value; }
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
		public  virtual Modelo Modelo
		{
			get { return _modelo; }
			set {_modelo= value; }
		}
		public  virtual int? IdArea
		{
			get { return _idarea; }
			set {_idarea= value; }
		}
        public virtual Usuario IdRecibe
        {
            get { return _idrecibe; }
            set { _idrecibe = value; }
        }
        public virtual Usuario IdEntrega
        {
            get { return _identrega; }
            set { _identrega = value; }
        }
        public virtual Usuario IdEvatecno
        {
            get { return _idevatecno; }
            set { _idevatecno = value; }
        }
        public virtual string NombreEntrega
        {
            get { return _nombreentrga; }
            set { _nombreentrga = value; }
        }
        public virtual string Recibe
        {
            get { return _recibe; }
            set { _recibe = value; }
        }
        public virtual IList<ResguardoEntregaDetalle> ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
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
            //ResguardoEntrega castObj = (ResguardoEntrega)obj;
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
