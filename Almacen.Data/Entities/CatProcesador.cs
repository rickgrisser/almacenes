/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CatProcesador object for NHibernate mapped table 'cat_procesador'.
	/// </summary>
	[Serializable]
	public class CatProcesador
	{
		#region Member Variables
		protected int _idprocesador;
		protected string _desprocesador;
		protected IList<Cpu> _cpu;
		#endregion
		#region Constructors
			
		public CatProcesador() {}
					
		public CatProcesador(int idprocesador, string desprocesador) 
		{
			this._idprocesador= idprocesador;
			this._desprocesador= desprocesador;
		}

		public CatProcesador(int idprocesador)
		{
			this._idprocesador= idprocesador;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdProcesador
		{
			get { return _idprocesador; }
			set {_idprocesador= value; }
		}
		public  virtual string DesProcesador
		{
			get { return _desprocesador; }
			set {_desprocesador= value; }
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
			CatProcesador castObj = (CatProcesador)obj;
			return ( castObj != null ) &&
			this._idprocesador == castObj.IdProcesador;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idprocesador.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
