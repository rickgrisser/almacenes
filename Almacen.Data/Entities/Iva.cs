/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Iva object for NHibernate mapped table 'iva'.
	/// </summary>
	[Serializable]
	public class Iva
	{
		#region Member Variables
		protected IvaId _id;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected IList<Anexo> _anexo;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		protected IList<AnexoHist> _anexohist;
		#endregion
		#region Constructors
			
		public Iva() {}
					
		public Iva(IvaId id, DateTime? fechaalta, DateTime? fechabaja, string estatus) 
		{
			this._id= id;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
		}

		public Iva(IvaId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual IvaId Id
		{
			get { return _id; }
			set {_id= value; }
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
		public  virtual IList<Anexo> Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
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
		public  virtual IList<AnexoHist> AnexoHist
		{
			get { return _anexohist; }
			set {_anexohist= value; }
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
			Iva castObj = (Iva)obj;
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
