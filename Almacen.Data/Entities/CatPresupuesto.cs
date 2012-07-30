/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatPresupuesto object for NHibernate mapped table 'cat_presupuesto'.
	/// </summary>
	[Serializable]
	public class CatPresupuesto
	{
		#region Member Variables
		protected int _idpresupuesto;
		protected string _despresupuesto;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected IList<SalidaDetalle> _salidadetalle;
		protected IList<Entrada> _entrada;
		protected IList<EntradaHist> _entradahist;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public CatPresupuesto() {}
					
		public CatPresupuesto(int idpresupuesto, string despresupuesto, DateTime? fechaalta, DateTime? fechabaja, string estatus) 
		{
			this._idpresupuesto= idpresupuesto;
			this._despresupuesto= despresupuesto;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
		}

		public CatPresupuesto(int idpresupuesto)
		{
			this._idpresupuesto= idpresupuesto;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdPresupuesto
		{
			get { return _idpresupuesto; }
			set {_idpresupuesto= value; }
		}
		public  virtual string DesPresupuesto
		{
			get { return _despresupuesto; }
			set {_despresupuesto= value; }
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
		public  virtual IList<SalidaDetalle> SalidaDetalle
		{
			get { return _salidadetalle; }
			set {_salidadetalle= value; }
		}
		public  virtual IList<Entrada> Entrada
		{
			get { return _entrada; }
			set {_entrada= value; }
		}
		public  virtual IList<EntradaHist> EntradaHist
		{
			get { return _entradahist; }
			set {_entradahist= value; }
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
			CatPresupuesto castObj = (CatPresupuesto)obj;
			return ( castObj != null ) &&
			this._idpresupuesto == castObj.IdPresupuesto;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _idpresupuesto.GetHashCode();
			return hash;
		}
		#endregion
        public override string ToString()
        {
            return DesPresupuesto;
        }
	}
}
