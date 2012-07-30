/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// Modelo object for NHibernate mapped table 'modelo'.
	/// </summary>
	[Serializable]
	public class Modelo
	{
		#region Member Variables
		protected ModeloId _id;
		protected string _desmodelo;
        protected IList<Consumible> _consumible;
		protected IList<ResguardoEntrega> _resguardoentrega;
		#endregion
		#region Constructors
			
		public Modelo() {}
					
		public Modelo(ModeloId id, string desmodelo) 
		{
			this._id= id;
			this._desmodelo= desmodelo;
		}

		public Modelo(ModeloId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ModeloId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual string DesModelo
		{
			get { return _desmodelo; }
			set {_desmodelo= value; }
		}
        public virtual IList<Consumible> Consumible
        {
            get { return _consumible; }
            set { _consumible = value; }
        }
		public  virtual IList<ResguardoEntrega> ResguardoEntrega
		{
			get { return _resguardoentrega; }
			set {_resguardoentrega= value; }
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
			Modelo castObj = (Modelo)obj;
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
