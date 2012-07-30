/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// SalidaHist object for NHibernate mapped table 'salida_hist'.
	/// </summary>
	[Serializable]
	public class SalidaHist
	{
		#region Member Variables
		protected SalidaHistId _id;
		protected int? _numerosalida;
		protected DateTime? _fechasalida;
		protected string _jefeservicio;
		protected string _recibio;
		protected int? _entrego;
		protected string _estadosalida;
		protected Almacen _almacen;
		protected CatArea _catarea;
		protected string _noorden;
		protected Usuario _usuario;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected IList<SalidaDetHist> _salidadethist;
		#endregion
		#region Constructors
			
		public SalidaHist() {}
					
		public SalidaHist(SalidaHistId id, int? numerosalida, DateTime? fechasalida, string jefeservicio, string recibio, int? entrego, string estadosalida, string noorden, DateTime? fechaalta, string ipterminal) 
		{
			this._id= id;
			this._numerosalida= numerosalida;
			this._fechasalida= fechasalida;
			this._jefeservicio= jefeservicio;
			this._recibio= recibio;
			this._entrego= entrego;
			this._estadosalida= estadosalida;
			this._noorden= noorden;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
		}

		public SalidaHist(SalidaHistId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual SalidaHistId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual int? NumeroSalida
		{
			get { return _numerosalida; }
			set {_numerosalida= value; }
		}
		public  virtual DateTime? FechaSalida
		{
			get { return _fechasalida; }
			set {_fechasalida= value; }
		}
		public  virtual string JefeServicio
		{
			get { return _jefeservicio; }
			set {_jefeservicio= value; }
		}
		public  virtual string Recibio
		{
			get { return _recibio; }
			set {_recibio= value; }
		}
		public  virtual int? Entrego
		{
			get { return _entrego; }
			set {_entrego= value; }
		}
		public  virtual string EstadoSalida
		{
			get { return _estadosalida; }
			set {_estadosalida= value; }
		}
		public  virtual Almacen Almacen
		{
			get { return _almacen; }
			set {_almacen= value; }
		}
		public  virtual CatArea CatArea
		{
			get { return _catarea; }
			set {_catarea= value; }
		}
		public  virtual string NoOrden
		{
			get { return _noorden; }
			set {_noorden= value; }
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
		public  virtual IList<SalidaDetHist> SalidaDetHist
		{
			get { return _salidadethist; }
			set {_salidadethist= value; }
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
			SalidaHist castObj = (SalidaHist)obj;
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
