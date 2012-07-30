/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Teclado object for NHibernate mapped table 'teclado'.
	/// </summary>
	[Serializable]
	public class Teclado
	{
		#region Member Variables
	    protected long _idteclado;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected CatTipopuerto _cattipopuerto;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		#endregion
		#region Constructors
			
		public Teclado() {}
					
		public Teclado(long idteclado, DateTime? fechaalta, string ipterminal) 
		{
			this._idteclado= idteclado;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public Teclado(long idteclado, ResguardoEntregaDetalle resguardoentregadetalle)
		{
			this._idteclado= idteclado;
		    this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdTeclado
		{
            get { return _idteclado; }
            set { _idteclado = value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
        public  virtual CatTipopuerto CatTipopuerto
		{
			get { return _cattipopuerto; }
			set {_cattipopuerto= value; }
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
            //Teclado castObj = (Teclado)obj;
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
