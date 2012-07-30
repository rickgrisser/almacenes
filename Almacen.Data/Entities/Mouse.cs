/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Mouse object for NHibernate mapped table 'mouse'.
	/// </summary>
	[Serializable]
	public class Mouse
	{
		#region Member Variables
	    protected long _idmouse;
	    protected ResguardoEntregaDetalle _resguardoentregadetalle;
		protected string _ipterminal;
		protected DateTime? _fechaalta;
		protected Usuario _usuario;
		protected CatTipopuerto _cattipopuerto;
		#endregion
		#region Constructors
			
		public Mouse() {}
					
		public Mouse(long idmouse, string ipterminal, DateTime? fechaalta) 
		{
            this._idmouse = idmouse;
			this._ipterminal= ipterminal;
			this._fechaalta= fechaalta;
		}

		public Mouse(long idmouse, ResguardoEntregaDetalle resguardoentregadetalle)
		{
		    this._idmouse = idmouse;
            this._resguardoentregadetalle = resguardoentregadetalle;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdMouse
		{
			get { return _idmouse; }
			set {_idmouse= value; }
		}
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual CatTipopuerto CatTipopuerto
		{
			get { return _cattipopuerto; }
			set {_cattipopuerto= value; }
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
            //Mouse castObj = (Mouse)obj;
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
