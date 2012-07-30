/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoEntregaHis object for NHibernate mapped table 'pedido_entrega_his'.
	/// </summary>
	[Serializable]
	public class PedidoEntregaHis
	{
		#region Member Variables
		protected PedidoEntregaHisId _id;
		protected DateTime? _fechainicial;
		protected DateTime? _fechafinal;
		protected decimal? _cantidad;
		#endregion
		#region Constructors
			
		public PedidoEntregaHis() {}
					
		public PedidoEntregaHis(PedidoEntregaHisId id, DateTime? fechainicial, DateTime? fechafinal, decimal? cantidad) 
		{
			this._id= id;
			this._fechainicial= fechainicial;
			this._fechafinal= fechafinal;
			this._cantidad= cantidad;
		}

		public PedidoEntregaHis(PedidoEntregaHisId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual PedidoEntregaHisId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaInicial
		{
			get { return _fechainicial; }
			set {_fechainicial= value; }
		}
		public  virtual DateTime? FechaFinal
		{
			get { return _fechafinal; }
			set {_fechafinal= value; }
		}
		public  virtual decimal? Cantidad
		{
			get { return _cantidad; }
			set {_cantidad= value; }
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
			PedidoEntregaHis castObj = (PedidoEntregaHis)obj;
			return ( castObj != null ) &&
			this._id.Equals( castObj.Id);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
