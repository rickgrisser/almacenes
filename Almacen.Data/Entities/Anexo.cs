/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Anexo object for NHibernate mapped table 'anexo'.
	/// </summary>
	[Serializable]
	public class Anexo
	{
		#region Member Variables
		protected long _idanexo;
		protected string _numeroanexo;
		protected DateTime? _fechaanexo;
		protected string _instituto;
		protected string _desanexo;
		protected TipoLicitacion _tipolicitacion;
		protected decimal? _techopresupuestal;
		protected short? _importeiva;
		protected Iva _iva;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechamodificacion;
		protected string _ipterminal;
		protected int _modificacion;
		protected IList<Requisicion> _requisicion;
		protected IList<RequisicionHist> _requisicionhist;
		protected IList<Cotizacion> _cotizacion;
        //protected IList<AnexoDetalle> _anexodetalle;
        protected IList<AnexoDetalle> _anexodetalle = new List<AnexoDetalle>();
        protected IList<Pedido> _pedido;
		#endregion
		#region Constructors
			
		public Anexo() {}
					
		public Anexo(int idanexo, string numeroanexo, DateTime? fechaanexo, string instituto, string desanexo, decimal? techopresupuestal, short? importeiva, DateTime? fechamodificacion, string ipterminal, int modificacion) 
		{
			this._idanexo= idanexo;
			this._numeroanexo= numeroanexo;
			this._fechaanexo= fechaanexo;
			this._instituto= instituto;
			this._desanexo= desanexo;
			this._techopresupuestal= techopresupuestal;
			this._importeiva= importeiva;
			this._fechamodificacion= fechamodificacion;
			this._ipterminal= ipterminal;
			this._modificacion= modificacion;
		}

		public Anexo(long idanexo)
		{
			this._idanexo= idanexo;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdAnexo
		{
			get { return _idanexo; }
			set {_idanexo= value; }
		}
		public  virtual string NumeroAnexo
		{
			get { return _numeroanexo; }
			set {_numeroanexo= value; }
		}
		public  virtual DateTime? FechaAnexo
		{
			get { return _fechaanexo; }
			set {_fechaanexo= value; }
		}
		public  virtual string Instituto
		{
			get { return _instituto; }
			set {_instituto= value; }
		}
		public  virtual string DesAnexo
		{
			get { return _desanexo; }
			set {_desanexo= value; }
		}
		public  virtual TipoLicitacion TipoLicitacion
		{
			get { return _tipolicitacion; }
			set {_tipolicitacion= value; }
		}
		public  virtual decimal? TechoPresupuestal
		{
			get { return _techopresupuestal; }
			set {_techopresupuestal= value; }
		}
		public  virtual short? ImporteIva
		{
			get { return _importeiva; }
			set {_importeiva= value; }
		}
		public  virtual Iva Iva
		{
			get { return _iva; }
			set {_iva= value; }
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
		public  virtual DateTime? FechaModificacion
		{
			get { return _fechamodificacion; }
            set { _fechamodificacion = value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual int Modificacion
		{
			get { return _modificacion; }
			set {_modificacion= value; }
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
		public  virtual IList<Cotizacion> Cotizacion
		{
			get { return _cotizacion; }
			set {_cotizacion= value; }
		}
		public  virtual IList<AnexoDetalle> AnexoDetalle
		{
			get { return _anexodetalle; }
			set {_anexodetalle= value; }
		}
        public virtual IList<Pedido> Pedido
        {
            get { return _pedido; }
            set { _pedido = value; }
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
			Anexo castObj = (Anexo)obj;
			return ( castObj != null ) &&
			this._idanexo == castObj.IdAnexo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idanexo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
