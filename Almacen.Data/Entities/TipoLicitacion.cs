/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// TipoLicitacion object for NHibernate mapped table 'tipo_licitacion'.
	/// </summary>
	[Serializable]
	public class TipoLicitacion
	{
		#region Member Variables
		protected int _idtipolicitacion;
		protected string _destipolicitacion;
		protected IList<AnexoHist> _anexohist;
		protected IList<Anexo> _anexo;
		#endregion
		#region Constructors
			
		public TipoLicitacion() {}
					
		public TipoLicitacion(int idtipolicitacion, string destipolicitacion) 
		{
			this._idtipolicitacion= idtipolicitacion;
			this._destipolicitacion= destipolicitacion;
		}

		public TipoLicitacion(int idtipolicitacion)
		{
			this._idtipolicitacion= idtipolicitacion;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipolicitacion
		{
			get { return _idtipolicitacion; }
			set {_idtipolicitacion= value; }
		}
		public  virtual string DesTipolicitacion
		{
			get { return _destipolicitacion; }
			set {_destipolicitacion= value; }
		}
		public  virtual IList<AnexoHist> AnexoHist
		{
			get { return _anexohist; }
			set {_anexohist= value; }
		}
		public  virtual IList<Anexo> Anexo
		{
			get { return _anexo; }
			set {_anexo= value; }
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
			TipoLicitacion castObj = (TipoLicitacion)obj;
			return ( castObj != null ) &&
			this._idtipolicitacion == castObj.IdTipolicitacion;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipolicitacion.GetHashCode();
			return hash;
		}
		#endregion
		
	}
}
