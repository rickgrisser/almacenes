/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoEntrega object for NHibernate mapped table 'pedido_entrega'.
	/// </summary>
	[Serializable]
	public class PedidoEntrega
	{
		#region Member Variables
		//protected PedidoEntregaId _id;
	    protected long _idpedidoentrega;
	    protected PedidoDetalle _pedidodetalle;
	    protected short _entrega;
		protected DateTime? _fechainicial;
		protected DateTime? _fechafinal;
		protected decimal? _cantidad;
		#endregion
		#region Constructors
			
		public PedidoEntrega() {}

        public PedidoEntrega(long idpedidoentrega, DateTime? fechainicial, DateTime? fechafinal, decimal? cantidad) 
		{
            this._idpedidoentrega = idpedidoentrega;
			this._fechainicial= fechainicial;
			this._fechafinal= fechafinal;
			this._cantidad= cantidad;
		}

        public PedidoEntrega(long idpedidoentrega, PedidoDetalle pedidodetalle)
		{
            this._idpedidoentrega = idpedidoentrega;
            this._pedidodetalle = pedidodetalle;
		}
		
		#endregion
		#region Public Properties
        public virtual long IdPedidoEntrega
		{
            get { return _idpedidoentrega; }
            set { _idpedidoentrega = value; }
		}
        public virtual PedidoDetalle PedidoDetalle
        {
            get { return _pedidodetalle; }
            set { _pedidodetalle = value; }
        }
        public virtual short Entrega
        {
            get { return _entrega; }
            set { _entrega = value; }
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
            //PedidoEntrega castObj = (PedidoEntrega)obj;
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
