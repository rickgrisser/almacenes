/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Monitor object for NHibernate mapped table 'monitor'.
	/// </summary>
	[Serializable]
	public class Monitor
	{
		#region Member Variables
	    protected long _idmonitor;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected CatResmonitor _catresmonitor;
		protected decimal? _tamano;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		#endregion
		#region Constructors
			
		public Monitor() {}
					
		public Monitor(long idmonitor, decimal? tamano, DateTime? fechaalta, string ipterminal) 
		{
            this._idmonitor = idmonitor;
			this._tamano= tamano;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public Monitor(long idmonitor, ResguardoEntregaDetalle resguardoentregadetalle)
		{
            this._idmonitor = idmonitor;
		    this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdMonitor
		{
            get { return _idmonitor; }
            set { _idmonitor = value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual CatResmonitor CatResmonitor
		{
			get { return _catresmonitor; }
			set {_catresmonitor= value; }
		}
		public  virtual decimal? Tamano
		{
			get { return _tamano; }
			set {_tamano= value; }
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
            //Monitor castObj = (Monitor)obj;
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
