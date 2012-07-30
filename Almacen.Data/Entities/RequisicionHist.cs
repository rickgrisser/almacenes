/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// RequisicionHist object for NHibernate mapped table 'requisicion_hist'.
	/// </summary>
	[Serializable]
	public class RequisicionHist
	{
		#region Member Variables
		protected RequisicionHistId _id;
		protected Anexo _anexo;
		protected int? _numerorequisicion;
		protected DateTime? _fecharequisicion;
		protected CatArea _catarea;
		protected string _estatus;
		protected short? _duracionabasto;
		protected Usuario _usuario;
		protected Almacen _almacen;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected IList<ReqDetHist> _reqdethist;
		#endregion
		#region Constructors
			
		public RequisicionHist() {}
					
		public RequisicionHist(RequisicionHistId id, int? numerorequisicion, DateTime? fecharequisicion, string estatus, short? duracionabasto, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._numerorequisicion= numerorequisicion;
			this._fecharequisicion= fecharequisicion;
			this._estatus= estatus;
			this._duracionabasto= duracionabasto;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public RequisicionHist(RequisicionHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual RequisicionHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual Anexo Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
		}
		public  virtual int? NumeroRequisicion
		{
			get { return _numerorequisicion; }
			set {_numerorequisicion= value; }
		}
		public  virtual DateTime? FechaRequisicion
		{
			get { return _fecharequisicion; }
			set {_fecharequisicion= value; }
		}
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			set {_catarea= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual short? DuracionAbasto
		{
			get { return _duracionabasto; }
			set {_duracionabasto= value; }
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
		public  virtual IList<ReqDetHist> ReqDetHist
		{
			get { return _reqdethist; }
			set {_reqdethist= value; }
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
			RequisicionHist castObj = (RequisicionHist)obj;
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
