/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// TipoMedicamento object for NHibernate mapped table 'tipo_medicamento'.
	/// </summary>
	[Serializable]
	public class TipoMedicamento
	{
		#region Member Variables
		protected int _idtipomed;
		protected string _desmedicamento;
        protected IList<ArticuloFarmacia> _articulofarmacia;
		protected IList<Articulo> _articulo;
		#endregion
		#region Constructors
			
		public TipoMedicamento() {}
					
		public TipoMedicamento(int idtipomed, string desmedicamento) 
		{
			this._idtipomed= idtipomed;
			this._desmedicamento= desmedicamento;
		}

		public TipoMedicamento(int idtipomed)
		{
			this._idtipomed= idtipomed;
		}
		
		#endregion
		#region Public Properties
		public  virtual int IdTipomed
		{
			get { return _idtipomed; }
			set {_idtipomed= value; }
		}
		public  virtual string DesMedicamento
		{
			get { return _desmedicamento; }
			set {_desmedicamento= value; }
		}
        public virtual IList<ArticuloFarmacia> ArticuloFarmacia
        {
            get { return _articulofarmacia; }
            set { _articulofarmacia = value; }
        }
        public virtual IList<Articulo> Articulo
        {
            get { return _articulo; }
            set { _articulo = value; }
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
			TipoMedicamento castObj = (TipoMedicamento)obj;
			return ( castObj != null ) &&
			this._idtipomed == castObj.IdTipomed;
		}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			hash = 27 * hash * _idtipomed.GetHashCode();
			return hash;
		}
		#endregion
        public override string ToString()
        {
            return DesMedicamento;
        }
	}
}
