/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
    /// <summary>
    /// AsignacionBien object for NHibernate mapped table 'asignacion_bien'.
    /// </summary>
    [Serializable]
    public class AsignacionBien
    {
        #region Member Variables
        protected long _idasignacionbien;
        protected ResguardoEntregaDetalle _resguardoentregadetalle;
        protected int? _idempleado;
        protected Usuario _usuario;
        protected string _estatusasignacion;
        protected DateTime? _fechaasignacion;
        protected DateTime? _fechadesasignacion;
        protected string _ipterminal;
        #endregion
        #region Constructors

        public AsignacionBien() { }

        public AsignacionBien(long idasignacionbien, int? idempleado, string estatusasignacion, DateTime? fechaasignacion, DateTime? fechadesasignacion, string ipterminal)
        {
            this._idasignacionbien = idasignacionbien;
            this._idempleado = idempleado;
            this._estatusasignacion = estatusasignacion;
            this._fechaasignacion = fechaasignacion;
            this._fechadesasignacion = fechadesasignacion;
            this._ipterminal = ipterminal;
        }

        public AsignacionBien(long idasignacionbien, ResguardoEntregaDetalle resguardoentregadetalle)
        {
            this._idasignacionbien = idasignacionbien;
            this._resguardoentregadetalle = resguardoentregadetalle;
        }

        #endregion
        #region Public Properties
        public virtual long IdAsignacionBien
        {
            get { return _idasignacionbien; }
            set { _idasignacionbien = value; }
        }
        public virtual ResguardoEntregaDetalle ResguardoEntregaDetalle
        {
            get { return _resguardoentregadetalle; }
            set { _resguardoentregadetalle = value; }
        }
        public virtual int? IdEmpleado
        {
            get { return _idempleado; }
            set { _idempleado = value; }
        }
        public virtual Usuario Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public virtual string EstatusAsignacion
        {
            get { return _estatusasignacion; }
            set { _estatusasignacion = value; }
        }
        public virtual DateTime? FechaAsignacion
        {
            get { return _fechaasignacion; }
            set { _fechaasignacion = value; }
        }
        public virtual DateTime? FechaDesasignacion
        {
            get { return _fechadesasignacion; }
            set { _fechadesasignacion = value; }
        }
        public virtual string IpTerminal
        {
            get { return _ipterminal; }
            set { _ipterminal = value; }
        }
        #endregion

        #region Equals And HashCode Overrides
        /// <summary>
        /// local implementation of Equals based on unique value members
        /// </summary>
        public override bool Equals(object obj)
        {
            if (this == obj) return true;
            if ((obj == null) || (obj.GetType() != this.GetType())) return false;
            //AsignacionBien castObj = (AsignacionBien)obj;
            //return (castObj != null) &&
            //this._id.Equals(castObj.Id);
            return false;
        }
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

    }
}
