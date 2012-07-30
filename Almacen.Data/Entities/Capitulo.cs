/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Capitulo object for NHibernate mapped table 'capitulo'.
	/// </summary>
	[Serializable]
	public class Capitulo
	{
		#region Member Variables
		protected string _idcapitulo;
		protected string _descapitulo;
		#endregion
		#region Constructors
			
		public Capitulo() {}
					
		public Capitulo(string idcapitulo, string descapitulo) 
		{
			this._idcapitulo= idcapitulo;
			this._descapitulo= descapitulo;
		}

		public Capitulo(string idcapitulo)
		{
			this._idcapitulo= idcapitulo;
		}
		
		#endregion
		#region Public Properties
		public  virtual string IdCapitulo
		{
			get { return _idcapitulo; }
			set {_idcapitulo= value; }
		}
		public  virtual string DesCapitulo
		{
			get { return _descapitulo; }
			set {_descapitulo= value; }
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
			Capitulo castObj = (Capitulo)obj;
			return ( castObj != null ) &&
			this._idcapitulo == castObj.IdCapitulo;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcapitulo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
