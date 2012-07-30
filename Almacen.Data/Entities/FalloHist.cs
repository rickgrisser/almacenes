/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// FalloHist object for NHibernate mapped table 'fallo_hist'.
	/// </summary>
	[Serializable]
	public class FalloHist
	{
		#region Member Variables
		protected FalloHistId _id;
		protected int? _idcotizacion;
		protected int? _idanexo;
		protected Proveedor _proveedor;
		protected DateTime? _fecha;
		protected string _estado;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected IList<FalloDetalleHist> _fallodetallehist;
		#endregion
		#region Constructors
			
		public FalloHist() {}
					
		public FalloHist(FalloHistId id, int? idcotizacion, int? idanexo, DateTime? fecha, string estado, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._idcotizacion= idcotizacion;
			this._idanexo= idanexo;
			this._fecha= fecha;
			this._estado= estado;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public FalloHist(FalloHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual FalloHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual int? IdCotizacion
		{
			get { return _idcotizacion; }
			set {_idcotizacion= value; }
		}
		public  virtual int? IdAnexo
		{
			get { return _idanexo; }
			set {_idanexo= value; }
		}
		public  virtual Proveedor Proveedor
		{
			get { return _proveedor; }
			set {_proveedor= value; }
		}
		public  virtual DateTime? Fecha
		{
			get { return _fecha; }
			set {_fecha= value; }
		}
		public  virtual string Estado
		{
			get { return _estado; }
			set {_estado= value; }
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
		public  virtual IList<FalloDetalleHist> FalloDetalleHist
		{
			get { return _fallodetallehist; }
			set {_fallodetallehist= value; }
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
			FalloHist castObj = (FalloHist)obj;
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
