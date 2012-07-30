/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// AsignacionBienHist object for NHibernate mapped table 'asignacion_bien_hist'.
	/// </summary>
	[Serializable]
	public class AsignacionBienHist
	{
		#region Member Variables
		protected AsignacionBienHistId _id;
		protected DateTime? _fechaasignacion;
		protected int? _idempleado;
		protected int? _idjefeactivo;
		protected Usuario _usuario;
		protected int? _idactivofijo;
		protected int? _idverificador;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		//protected IList<AsignacionBienDetalleHist> _asignacionbiendetallehist;
		#endregion
		#region Constructors
			
		public AsignacionBienHist() {}
					
		public AsignacionBienHist(AsignacionBienHistId id, DateTime? fechaasignacion, int? idempleado, int? idjefeactivo, int? idactivofijo, int? idverificador, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._fechaasignacion= fechaasignacion;
			this._idempleado= idempleado;
			this._idjefeactivo= idjefeactivo;
			this._idactivofijo= idactivofijo;
			this._idverificador= idverificador;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public AsignacionBienHist(AsignacionBienHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual AsignacionBienHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaAsignacion
		{
			get { return _fechaasignacion; }
			set {_fechaasignacion= value; }
		}
		public  virtual int? IdEmpleado
		{
			get { return _idempleado; }
			set {_idempleado= value; }
		}
		public  virtual int? IdJefeActivo
		{
			get { return _idjefeactivo; }
			set {_idjefeactivo= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual int? IdActivoFijo
		{
			get { return _idactivofijo; }
			set {_idactivofijo= value; }
		}
		public  virtual int? IdVerificador
		{
			get { return _idverificador; }
			set {_idverificador= value; }
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
        //public  virtual IList<AsignacionBienDetalleHist> AsignacionBienDetalleHist
        //{
        //    get { return _asignacionbiendetallehist; }
        //    set {_asignacionbiendetallehist= value; }
        //}
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
		public override bool Equals( object obj )
		{
			if( this == obj ) return true;
			if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
			AsignacionBienHist castObj = (AsignacionBienHist)obj;
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
