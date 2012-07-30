/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// PedidoHist object for NHibernate mapped table 'pedido_hist'.
	/// </summary>
	[Serializable]
	public class PedidoHist
	{
		#region Member Variables
		protected PedidoHistId _id;
		protected DateTime? _fechapedido;
		protected int? _numeropedido;
		protected CatTipopedido _cattipopedido;
		protected Proveedor _proveedor;
		protected int? _idanexo;
		protected int? _idrequisicion;
		protected Fundamento _fundamento;
		protected int? _idreservaautoriza;
		protected CatArea _catarea;
		protected decimal? _importedescuento;
		protected Iva _iva;
		protected CatActividad _catactividad;
		protected CatPresupuesto _catpresupuesto;
		protected string _estadopedido;
		protected decimal? _importetotal;
		protected string _observaciones;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected IList<PedidoDetalleHis> _pedidodetallehis;
		#endregion
		#region Constructors
			
		public PedidoHist() {}
					
		public PedidoHist(PedidoHistId id, DateTime? fechapedido, int? numeropedido, int? idanexo, int? idrequisicion, int? idreservaautoriza, decimal? importedescuento, string estadopedido, decimal? importetotal, string observaciones, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._fechapedido= fechapedido;
			this._numeropedido= numeropedido;
			this._idanexo= idanexo;
			this._idrequisicion= idrequisicion;
			this._idreservaautoriza= idreservaautoriza;
			this._importedescuento= importedescuento;
			this._estadopedido= estadopedido;
			this._importetotal= importetotal;
			this._observaciones= observaciones;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public PedidoHist(PedidoHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual PedidoHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaPedido
		{
			get { return _fechapedido; }
			set {_fechapedido= value; }
		}
		public  virtual int? NumeroPedido
		{
			get { return _numeropedido; }
			set {_numeropedido= value; }
		}
		public  virtual CatTipopedido CatTipopedido
		{
			get { return _cattipopedido; }
			set {_cattipopedido= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual int? IdAnexo
		{
			get { return _idanexo; }
			set {_idanexo= value; }
		}
		public  virtual int? IdRequisicion
		{
			get { return _idrequisicion; }
			set {_idrequisicion= value; }
		}
		public  virtual Fundamento Fundamento
		{
			get { return _fundamento; }
			set {_fundamento= value; }
		}
		public  virtual int? IdReservaautoriza
		{
			get { return _idreservaautoriza; }
			set {_idreservaautoriza= value; }
		}
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			set {_catarea= value; }
		}
		public  virtual decimal? ImporteDescuento
		{
			get { return _importedescuento; }
			set {_importedescuento= value; }
		}
		public  virtual Iva Iva
		{
			get { return _iva; }
			set {_iva= value; }
		}
		public  virtual CatActividad CatActividad
		{
			get { return _catactividad; }
			set {_catactividad= value; }
		}
		public  virtual CatPresupuesto CatPresupuesto
		{
			get { return _catpresupuesto; }
			set {_catpresupuesto= value; }
		}
		public  virtual string EstadoPedido
		{
			get { return _estadopedido; }
			set {_estadopedido= value; }
		}
		public  virtual decimal? ImporteTotal
		{
			get { return _importetotal; }
			set {_importetotal= value; }
		}
		public  virtual string Observaciones
		{
			get { return _observaciones; }
			set {_observaciones= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
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
		public  virtual IList<PedidoDetalleHis> PedidoDetalleHis
		{
			get { return _pedidodetallehis; }
			set {_pedidodetallehis= value; }
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
			PedidoHist castObj = (PedidoHist)obj;
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
