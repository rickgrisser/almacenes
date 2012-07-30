/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatTipopedido object for NHibernate mapped table 'cat_tipopedido'.
	/// </summary>
	[Serializable]
	public class CatTipopedido
	{
		#region Member Variables
		protected int _idtipoped;
		protected string _destipoped;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _ipterminal;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public CatTipopedido() {}
					
		public CatTipopedido(int idtipoped, string destipoped, DateTime? fechaalta, DateTime? fechabaja, string estatus, string ipterminal) 
		{
			this._idtipoped= idtipoped;
			this._destipoped= destipoped;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._ipterminal= ipterminal;
		}

		public CatTipopedido(int idtipoped)
		{
			this._idtipoped= idtipoped;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipoped
		{
			get { return _idtipoped; }
			set {_idtipoped= value; }
		}
		public  virtual string DesTipoped
		{
			get { return _destipoped; }
			set {_destipoped= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual DateTime? FechaBaja
		{
			get { return _fechabaja; }
			set {_fechabaja= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual IList<Pedido> Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
		public  virtual IList<PedidoHist> PedidoHist
		{
			get { return _pedidohist; }
			set {_pedidohist= value; }
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
			CatTipopedido castObj = (CatTipopedido)obj;
			return ( castObj != null ) &&
			this._idtipoped == castObj.IdTipoped;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipoped.GetHashCode();
			return hash;
		}
		#endregion

        public override string ToString()
        {
            return DesTipoped;
        }
	}
}
