/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatUnidadlectora object for NHibernate mapped table 'cat_unidadlectora'.
	/// </summary>
	[Serializable]
	public class CatUnidadlectora
	{
		#region Member Variables
		protected int _idunidadlectora;
		protected string _desunidadlectora;
		protected IList<Cpu> _cpu;
		#endregion
		#region Constructors
			
		public CatUnidadlectora() {}
					
		public CatUnidadlectora(int idunidadlectora, string desunidadlectora) 
		{
			this._idunidadlectora= idunidadlectora;
			this._desunidadlectora= desunidadlectora;
		}

		public CatUnidadlectora(int idunidadlectora)
		{
			this._idunidadlectora= idunidadlectora;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdUnidadlectora
		{
			get { return _idunidadlectora; }
			set {_idunidadlectora= value; }
		}
		public  virtual string DesUnidadlectora
		{
			get { return _desunidadlectora; }
			set {_desunidadlectora= value; }
		}
		public  virtual IList<Cpu> Cpu
		{
			get { return _cpu; }
			set {_cpu= value; }
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
			CatUnidadlectora castObj = (CatUnidadlectora)obj;
			return ( castObj != null ) &&
			this._idunidadlectora == castObj.IdUnidadlectora;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idunidadlectora.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
