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
	/// Consumible object for NHibernate mapped table 'consumible'.
	/// </summary>
	[Serializable]
	public class Consumible
	{
		#region Member Variables
		protected ConsumibleId _id;
		protected CatColor _catcolor;
		protected CatTipoconsumible _cattipoconsumible;
		protected CatTipoimpresora _cattipoimpresora;
		protected string _numeroparte;
		#endregion
		#region Constructors
			
		public Consumible() {}
					
		public Consumible(ConsumibleId id, string numeroparte) 
		{
			this._id= id;
			this._numeroparte= numeroparte;
		}

		public Consumible(ConsumibleId id)
		{
			this._id= id;
		}
		
		#endregion
		#region Public Properties
		public  virtual ConsumibleId Id
		{
			get { return _id; }
			set {_id= value; }
		}
		public  virtual CatColor CatColor
		{
			get { return _catcolor; }
			set {_catcolor= value; }
		}
		public  virtual CatTipoconsumible CatTipoconsumible
		{
			get { return _cattipoconsumible; }
			set {_cattipoconsumible= value; }
		}
		public  virtual CatTipoimpresora CatTipoimpresora
		{
			get { return _cattipoimpresora; }
			set {_cattipoimpresora= value; }
		}
		public  virtual string NumeroParte
		{
			get { return _numeroparte; }
			set {_numeroparte= value; }
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
			Consumible castObj = (Consumible)obj;
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
