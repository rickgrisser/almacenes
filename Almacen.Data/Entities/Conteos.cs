/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Conteos object for NHibernate mapped table 'conteos'.
	/// </summary>
	[Serializable]
	public class Conteos
	{
		#region Member Variables
		protected ConteosId _id;
		protected decimal? _conteo1;
		protected decimal? _conteo2;
		protected DateTime? _fechaalta;
		protected string _estatus;
		protected Usuario _usuario;
		#endregion
		#region Constructors
			
		public Conteos() {}
					
		public Conteos(ConteosId id, decimal? conteo1, decimal? conteo2, DateTime? fechaalta, string estatus) 
		{
			this._id= id;
			this._conteo1= conteo1;
			this._conteo2= conteo2;
			this._fechaalta= fechaalta;
			this._estatus= estatus;
		}

		public Conteos(ConteosId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ConteosId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual decimal? Conteo1
		{
			get { return _conteo1; }
			set {_conteo1= value; }
		}
		public  virtual decimal? Conteo2
		{
			get { return _conteo2; }
			set {_conteo2= value; }
		}
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
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
			Conteos castObj = (Conteos)obj;
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
