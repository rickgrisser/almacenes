/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// TipoBaja object for NHibernate mapped table 'tipo_baja'.
	/// </summary>
	[Serializable]
	public class TipoBaja
	{
		#region Member Variables
		protected int _idbaja;
		protected string _desbaja;
		protected IList<ResguardoEntregaDetalle> _resguardoentregadetalle;
		#endregion
		#region Constructors
			
		public TipoBaja() {}
					
		public TipoBaja(int idbaja, string desbaja) 
		{
			this._idbaja= idbaja;
			this._desbaja= desbaja;
		}

		public TipoBaja(int idbaja)
		{
			this._idbaja= idbaja;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdBaja
		{
			get { return _idbaja; }
			set {_idbaja= value; }
		}
		public  virtual string DesBaja
		{
			get { return _desbaja; }
			set {_desbaja= value; }
		}
		public  virtual IList<ResguardoEntregaDetalle> ResguardoEntregaDetalle
		{
			get { return _resguardoentregadetalle; }
			set {_resguardoentregadetalle= value; }
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
			TipoBaja castObj = (TipoBaja)obj;
			return ( castObj != null ) &&
			this._idbaja == castObj.IdBaja;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idbaja.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
