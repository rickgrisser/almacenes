/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CostoPromedio object for NHibernate mapped table 'costo_promedio'.
	/// </summary>
	[Serializable]
	public class CostoPromedio
	{
		#region Member Variables
		protected CostoPromedioId _id;
		protected decimal? _costopromediomember;
		
		#endregion
		#region Constructors
			
		public CostoPromedio() {}
					
		public CostoPromedio(CostoPromedioId id, decimal? costopromediomember) 
		{
			this._id= id;
			this._costopromediomember= costopromediomember;
			
		}

		public CostoPromedio(CostoPromedioId id)
		{
			this._id= id;			
		}
		
		#endregion
		#region Public Properties
		public  virtual CostoPromedioId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual decimal? CostoPromedioMember
		{
			get { return _costopromediomember; }
			set {_costopromediomember= value; }
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
			CostoPromedio castObj = (CostoPromedio)obj;
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
