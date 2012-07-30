/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Fundamento object for NHibernate mapped table 'fundamento'.
	/// </summary>
	[Serializable]
	public class Fundamento
	{
		#region Member Variables
		protected short _cvefundamento;
		protected short? _artifundamento;
		protected string _incisofundamento;
		protected string _fraccfundamento;
		protected string _desfundamento;
		protected DateTime? _fechaalta;
		protected DateTime? _fechabaja;
		protected string _estatus;
		protected string _ipterminal;
		protected Usuario _usuario;
		protected IList<Pedido> _pedido;
		protected IList<PedidoHist> _pedidohist;
		#endregion
		#region Constructors
			
		public Fundamento() {}
					
		public Fundamento(short cvefundamento, short? artifundamento, string incisofundamento, string fraccfundamento, string desfundamento, DateTime? fechaalta, DateTime? fechabaja, string estatus, string ipterminal) 
		{
			this._cvefundamento= cvefundamento;
			this._artifundamento= artifundamento;
			this._incisofundamento= incisofundamento;
			this._fraccfundamento= fraccfundamento;
			this._desfundamento= desfundamento;
			this._fechaalta= fechaalta;
			this._fechabaja= fechabaja;
			this._estatus= estatus;
			this._ipterminal= ipterminal;
		}

		public Fundamento(short cvefundamento)
		{
			this._cvefundamento= cvefundamento;
		}
		
		#endregion
		#region Public Properties
		public  virtual short CveFundamento
		{
			get { return _cvefundamento; }
			set {_cvefundamento= value; }
		}
		public  virtual short? ArtiFundamento
		{
			get { return _artifundamento; }
			set {_artifundamento= value; }
		}
		public  virtual string IncisoFundamento
		{
			get { return _incisofundamento; }
			set {_incisofundamento= value; }
		}
		public  virtual string FraccFundamento
		{
			get { return _fraccfundamento; }
			set {_fraccfundamento= value; }
		}
		public  virtual string DesFundamento
		{
			get { return _desfundamento; }
			set {_desfundamento= value; }
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
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
			Fundamento castObj = (Fundamento)obj;
			return ( castObj != null ) &&
			this._cvefundamento == castObj.CveFundamento;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _cvefundamento.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
