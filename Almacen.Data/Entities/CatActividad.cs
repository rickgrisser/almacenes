/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatActividad object for NHibernate mapped table 'cat_actividad'.
	/// </summary>
	[Serializable]
	public class CatActividad
	{
		#region Member Variables
		protected int _idactividad;
		protected string _desactividad;
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
			
		public CatActividad() {}
					
		public CatActividad(int idactividad, string desactividad, DateTime? fechaalta, DateTime? fechabaja, string estatus) 
		{
			this._idactividad= idactividad;
			this._desactividad= desactividad;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
		}

		public CatActividad(int idactividad)
		{
			this._idactividad= idactividad;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdActividad
		{
			get { return _idactividad; }
			set {_idactividad= value; }
		}
		public  virtual string DesActividad
		{
			get { return _desactividad; }
			set {_desactividad= value; }
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
			CatActividad castObj = (CatActividad)obj;
			return ( castObj != null ) &&
			this._idactividad == castObj.IdActividad;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idactividad.GetHashCode();
			return hash;
		}
		#endregion

        public override string ToString()
        {
            return DesActividad;
        }
	}
}
