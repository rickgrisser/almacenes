/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatColorimpresora object for NHibernate mapped table 'cat_colorimpresora'.
	/// </summary>
	[Serializable]
	public class CatColorimpresora
	{
		#region Member Variables
		protected int _idcolorimpresosa;
		protected string _descolorimpresosa;
		protected IList<Impresora> _impresora;
		#endregion
		#region Constructors
			
		public CatColorimpresora() {}
					
		public CatColorimpresora(int idcolorimpresosa, string descolorimpresosa) 
		{
			this._idcolorimpresosa= idcolorimpresosa;
			this._descolorimpresosa= descolorimpresosa;
		}

		public CatColorimpresora(int idcolorimpresosa)
		{
			this._idcolorimpresosa= idcolorimpresosa;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdColorimpresosa
		{
			get { return _idcolorimpresosa; }
			set {_idcolorimpresosa= value; }
		}
		public  virtual string DesColorimpresosa
		{
			get { return _descolorimpresosa; }
			set {_descolorimpresosa= value; }
		}
		public  virtual IList<Impresora> Impresora
		{
			get { return _impresora; }
			set {_impresora= value; }
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
			CatColorimpresora castObj = (CatColorimpresora)obj;
			return ( castObj != null ) &&
			this._idcolorimpresosa == castObj.IdColorimpresosa;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idcolorimpresosa.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
