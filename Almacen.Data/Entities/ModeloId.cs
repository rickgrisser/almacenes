/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ModeloId object for NHibernate mapped table 'modelo'.
	/// </summary>
	[Serializable]
	public class ModeloId
	{
		#region Member Variables
		protected int _idmarca;
		protected int _idmodelo;
		protected int _idcabms;
		#endregion
		#region Constructors
			
		public ModeloId() {}
					
		public ModeloId(int idmarca, int idmodelo, int idcabms) 
		{
			this._idmarca= idmarca;
			this._idmodelo= idmodelo;
			this._idcabms= idcabms;
		}

		#endregion
		#region Public Properties
		public  virtual int IdMarca
		{
			get { return _idmarca; }
			set {_idmarca= value; }
		}
		public  virtual int IdModelo
		{
			get { return _idmodelo; }
			set {_idmodelo= value; }
		}
		public  virtual int IdCabms
		{
			get { return _idcabms; }
			set {_idcabms= value; }
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
			ModeloId castObj = (ModeloId)obj;
			return ( castObj != null ) &&
			this._idmarca == castObj.IdMarca &&
			this._idmodelo == castObj.IdModelo &&
			this._idcabms == castObj.IdCabms;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idmarca.GetHashCode();
			hash = 27 * hash * _idmodelo.GetHashCode();
			hash = 27 * hash * _idcabms.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
