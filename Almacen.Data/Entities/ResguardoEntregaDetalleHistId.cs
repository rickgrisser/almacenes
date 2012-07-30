/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntregaDetalleHistId object for NHibernate mapped table 'resguardo_entrega_detalle_hist'.
	/// </summary>
	[Serializable]
	public class ResguardoEntregaDetalleHistId
	{
		#region Member Variables
		protected int _inventario;
		protected int _consecutivo;
		protected ResguardoEntregaHist _resguardoentregahist;
		#endregion
		#region Constructors
			
		public ResguardoEntregaDetalleHistId() {}
					
		public ResguardoEntregaDetalleHistId(int inventario, int consecutivo, ResguardoEntregaHist resguardoentregahist) 
		{
			this._inventario= inventario;
			this._consecutivo= consecutivo;
			this._resguardoentregahist= resguardoentregahist;
		}

		#endregion
		#region Public Properties
		public  virtual int Inventario
		{
			get { return _inventario; }
			set {_inventario= value; }
		}
		public  virtual int Consecutivo
		{
			get { return _consecutivo; }
			set {_consecutivo= value; }
		}
		public  virtual ResguardoEntregaHist ResguardoEntregaHist
		{
			get { return _resguardoentregahist; }
			set {_resguardoentregahist= value; }
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
			ResguardoEntregaDetalleHistId castObj = (ResguardoEntregaDetalleHistId)obj;
			return ( castObj != null ) &&
			this._inventario == castObj.Inventario &&
			this._consecutivo == castObj.Consecutivo &&
			this._resguardoentregahist.Equals( castObj.ResguardoEntregaHist);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _inventario.GetHashCode();
			hash = 27 * hash * _consecutivo.GetHashCode();
			hash = 27 * hash * _resguardoentregahist.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
