/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Almacen object for NHibernate mapped table 'almacen'.
	/// </summary>
	[Serializable]
	public class Almacen
	{
		#region Member Variables
		protected string _idalmacen;
		protected string _desalmacen;
		protected DateTime? _fechaalta;
		protected IList<Anexo> _anexo;
		protected IList<Requisicion> _requisicion;
		protected IList<RequisicionHist> _requisicionhist;
		protected IList<Salida> _salida;
		protected IList<Articulo> _articulo;
		protected IList<SalidaHist> _salidahist;
		protected IList<Cierre> _cierre;
		protected IList<CostoPromedio> _costopromedio;
		protected IList<Cotizacion> _cotizacion;
		protected IList<CotizacionHist> _cotizacionhist;
		protected IList<CuadroBasico> _cuadrobasico;
		protected IList<Entrada> _entrada;
		protected IList<EntradaHist> _entradahist;
		protected IList<Fallo> _fallo;
		protected IList<FalloHist> _fallohist;
		protected IList<Inventario> _inventario;
		protected IList<Modulo> _modulo;
		protected IList<Pedido> _pedido;
		protected IList<AnexoHist> _anexohist;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public Almacen() {}
					
		public Almacen(string idalmacen, string desalmacen, DateTime? fechaalta) 
		{
			this._idalmacen= idalmacen;
			this._desalmacen= desalmacen;
			this._fechaalta= fechaalta;
		}

		public Almacen(string idalmacen)
		{
			this._idalmacen= idalmacen;
		}
		
		#endregion
		#region Public Properties
		public  virtual string IdAlmacen
		{
			get { return _idalmacen; }
			set {_idalmacen= value; }
		}
		public  virtual string DesAlmacen
		{
			get { return _desalmacen; }
			set {_desalmacen= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual IList<Anexo> Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
		public  virtual IList<Requisicion> Requisicion
		{
			get { return _requisicion; }
			set {_requisicion= value; }
		}
		public  virtual IList<RequisicionHist> RequisicionHist
		{
			get { return _requisicionhist; }
			set {_requisicionhist= value; }
		}
		public  virtual IList<Salida> Salida
		{
			get { return _salida; }
			set {_salida= value; }
		}
		public  virtual IList<Articulo> Articulo
		{
			get { return _articulo; }
			set {_articulo= value; }
		}
		public  virtual IList<SalidaHist> SalidaHist
		{
			get { return _salidahist; }
			set {_salidahist= value; }
		}
		public  virtual IList<Cierre> Cierre
		{
			get { return _cierre; }
			set {_cierre= value; }
		}
		public  virtual IList<CostoPromedio> CostoPromedio
		{
			get { return _costopromedio; }
			set {_costopromedio= value; }
		}
		public  virtual IList<Cotizacion> Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
		public  virtual IList<CotizacionHist> CotizacionHist
		{
			get { return _cotizacionhist; }
			set {_cotizacionhist= value; }
		}
		public  virtual IList<CuadroBasico> CuadroBasico
		{
			get { return _cuadrobasico; }
			set {_cuadrobasico= value; }
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
		public  virtual IList<Fallo> Fallo
		{
			get { return _fallo; }
			set {_fallo= value; }
		}
		public  virtual IList<FalloHist> FalloHist
		{
			get { return _fallohist; }
			set {_fallohist= value; }
		}
		public  virtual IList<Inventario> Inventario
		{
			get { return _inventario; }
			set {_inventario= value; }
		}
		public  virtual IList<Modulo> Modulo
		{
			get { return _modulo; }
			set {_modulo= value; }
		}
		public  virtual IList<Pedido> Pedido
		{
			get { return _pedido; }
			set {_pedido= value; }
		}
		public  virtual IList<AnexoHist> AnexoHist
		{
			get { return _anexohist; }
			set {_anexohist= value; }
		}
		public  virtual IList<PedidoHist> PedidoHist
		{
			get { return _pedidohist; }
			set {_pedidohist= value; }
		}
		#endregion
		
        //#region Equals And HashCode Overrides
        ///// <summary>
        ///// local implementation of Equals based on unique value members
        ///// </summary>
        //public override bool Equals( object obj )
        //{
        //    if( this == obj ) return true;
        //    if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
        //    Almacen castObj = (Almacen)obj;
        //    return ( castObj != null ) &&
        //    this._idalmacen == castObj.IdAlmacen;
        //}
        ///// <summary>
        ///// local implementation of GetHashCode based on unique value members
        ///// </summary>
        //public override int GetHashCode()
        //{
        //    int hash = 57;
        //    hash = 27 * hash * _idalmacen.GetHashCode();
        //    return hash;
        //}
        //#endregion
		
	}
}
