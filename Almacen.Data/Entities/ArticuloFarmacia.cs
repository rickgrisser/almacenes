/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using NHibernate.Validator.Constraints;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// ArticuloFarmacia object for NHibernate mapped table 'articulo_farmacia'.
	/// </summary>
	[Serializable]
    public class ArticuloFarmacia : INotifyPropertyChanged
	{
		#region Member Variables
        protected ArticuloFarmaciaId _id;
        protected ViaAdministracion _viaadministracion;
        protected TipoMedicamento _tipomedicamento;
		protected string _grupo;
		protected string _dosis;
		protected string _gramaje;
		#endregion
		#region Constructors
			
		public ArticuloFarmacia() {}
					
		public ArticuloFarmacia(ArticuloFarmaciaId id, string grupo, string dosis, string gramaje) 
		{
            this._id = id;
			this._grupo= grupo;
			this._dosis= dosis;
			this._gramaje= gramaje;
		}

        public ArticuloFarmacia(ArticuloFarmaciaId id)
        {
            this._id= id;
        }
		
		#endregion
		#region Public Properties
        public virtual ArticuloFarmaciaId Id
        {
            get { return _id; }
            set { _id = value; }
        }
        //public virtual int CveArt
        //{
        //    get { return _cveart; }
        //    set { _cveart = value; }
        //}
        //public virtual Almacen Almacen
        //{
        //    get { return _almacen; }
        //    set { _almacen = value; }
        //}
        [NotNull(Message = "Via Administración - Campo Requerido")]
        public virtual ViaAdministracion ViaAdministracion
        {
            get { return _viaadministracion; }
            //set { _viaadministracion = value; }
            set
            {
                if (_viaadministracion != value)
                {
                    _viaadministracion = value;
                    OnPropertyChanged("ViaAdministracion");
                }
            }
        }
        [NotNull(Message = "Tipo Medicamento - Campo Requerido")]
        public virtual TipoMedicamento TipoMedicamento
        {
            get { return _tipomedicamento; }
            //set { _tipomedicamento = value; }
            set
            {
                if (_tipomedicamento != value)
                {
                    _tipomedicamento = value;
                    OnPropertyChanged("TipoMedicamento");
                }
            }
        }
        [NotNullNotEmpty(Message = "Grupo - Campo Requerido")]
		public  virtual string Grupo
		{
			get { return _grupo; }
			set {_grupo= value; }
		}
        [NotNullNotEmpty(Message = "Dosis - Campo Requerido")]
		public  virtual string Dosis
		{
			get { return _dosis; }
			set {_dosis= value; }
		}
        [NotNullNotEmpty(Message = "Gramaje - Campo Requerido")]
		public  virtual string Gramaje
		{
			get { return _gramaje; }
			set {_gramaje= value; }
		}
		#endregion
		
		#region Equals And HashCode Overrides
		/// <summary>
		/// local implementation of Equals based on unique value members
		/// </summary>
        //public override bool Equals( object obj )
        //{
        //    if( this == obj ) return true;
        //    if( ( obj == null ) || ( obj.GetType() != this.GetType() ) ) return false;
        //    ArticuloFarmacia castObj = (ArticuloFarmacia)obj;
        //    return (castObj != null) &&
        //    this._id.Equals(castObj.Id);
        //}
		/// <summary>
		/// local implementation of GetHashCode based on unique value members
		/// </summary>
		public override int GetHashCode()
		{
			int hash = 57;
			//hash = 27 * hash * _id.GetHashCode();
			return hash;
		}
		#endregion
        public event PropertyChangedEventHandler PropertyChanged;
        #region business logic

        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }
        #endregion
	}
}
