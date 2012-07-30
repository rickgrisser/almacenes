/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using Almacen.Data.Entities;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ConsumibleId object for NHibernate mapped table 'consumible'.
	/// </summary>
	[Serializable]
	public class ConsumibleId
	{
		#region Member Variables
		protected string _idconsumible;
		protected Modelo _modelo;
		#endregion
		#region Constructors
			
		public ConsumibleId() {}
					
		public ConsumibleId(string idconsumible, Modelo modelo) 
		{
			this._idconsumible= idconsumible;
			this._modelo= modelo;
		}

		#endregion
		#region Public Properties
		public  virtual string IdConsumible
		{
			get { return _idconsumible; }
			set {_idconsumible= value; }
		}
		public  virtual Modelo Modelo
		{
			get { return _modelo; }
			set {_modelo= value; }
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
			ConsumibleId castObj = (ConsumibleId)obj;
			return ( castObj != null ) &&
			this._idconsumible == castObj.IdConsumible &&
			this._modelo.Equals( castObj.Modelo);
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idconsumible.GetHashCode();
			hash = 27 * hash * _modelo.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
