/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ResguardoEntregaHist object for NHibernate mapped table 'resguardo_entrega_hist'.
	/// </summary>
	[Serializable]
	public class ResguardoEntregaHist
	{
		#region Member Variables
		protected ResguardoEntregaHistId _id;
		protected DateTime? _fechaminuta;
		protected string _comentarios;
		protected string _pais;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected int? _idcabms;
		protected int? _idarea;
		protected int? _idmarca;
		protected int? _idmodelo;
		protected IList<ResguardoEntregaDetalleHist> _resguardoentregadetallehist;
		#endregion
		#region Constructors
			
		public ResguardoEntregaHist() {}
					
		public ResguardoEntregaHist(ResguardoEntregaHistId id, DateTime? fechaminuta, string comentarios, string pais, DateTime? fechaalta, string ipterminal, int? idcabms, int? idarea, int? idmarca, int? idmodelo) 
		{
			this._id= id;
			this._fechaminuta= fechaminuta;
			this._comentarios= comentarios;
			this._pais= pais;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._idcabms= idcabms;
			this._idarea= idarea;
			this._idmarca= idmarca;
			this._idmodelo= idmodelo;
		}

		public ResguardoEntregaHist(ResguardoEntregaHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ResguardoEntregaHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual DateTime? FechaMinuta
		{
			get { return _fechaminuta; }
			set {_fechaminuta= value; }
		}
		public  virtual string Comentarios
		{
			get { return _comentarios; }
			set {_comentarios= value; }
		}
		public  virtual string Pais
		{
			get { return _pais; }
			set {_pais= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
		public  virtual int? IdCabms
		{
			get { return _idcabms; }
			set {_idcabms= value; }
		}
		public  virtual int? IdArea
		{
			get { return _idarea; }
			set {_idarea= value; }
		}
		public  virtual int? IdMarca
		{
			get { return _idmarca; }
			set {_idmarca= value; }
		}
		public  virtual int? IdModelo
		{
			get { return _idmodelo; }
			set {_idmodelo= value; }
		}
		public  virtual IList<ResguardoEntregaDetalleHist> ResguardoEntregaDetalleHist
		{
			get { return _resguardoentregadetallehist; }
			set {_resguardoentregadetallehist= value; }
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
			ResguardoEntregaHist castObj = (ResguardoEntregaHist)obj;
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
