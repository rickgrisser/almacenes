/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatResmonitor object for NHibernate mapped table 'cat_resmonitor'.
	/// </summary>
	[Serializable]
	public class CatResmonitor
	{
		#region Member Variables
		protected int _idresmonitor;
		protected string _desresmonitor;
		protected IList<Monitor> _monitor;
		#endregion
		#region Constructors
			
		public CatResmonitor() {}
					
		public CatResmonitor(int idresmonitor, string desresmonitor) 
		{
			this._idresmonitor= idresmonitor;
			this._desresmonitor= desresmonitor;
		}

		public CatResmonitor(int idresmonitor)
		{
			this._idresmonitor= idresmonitor;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdResmonitor
		{
			get { return _idresmonitor; }
			set {_idresmonitor= value; }
		}
		public  virtual string DesResmonitor
		{
			get { return _desresmonitor; }
			set {_desresmonitor= value; }
		}
		public  virtual IList<Monitor> Monitor
		{
			get { return _monitor; }
			set {_monitor= value; }
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
			CatResmonitor castObj = (CatResmonitor)obj;
			return ( castObj != null ) &&
			this._idresmonitor == castObj.IdResmonitor;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idresmonitor.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
