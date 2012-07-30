using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataRequisicionVale
    {

        #region Member Variables

        protected int _numerorequisicion;
        protected DateTime _fecha;
        protected string _licitacion;
        protected int _cveart;
        protected string _desarticulo;
        protected string _unidad;
        protected double _cantidad;
        protected double _costo;
        protected string _cvepartida;

        #endregion

        #region Public Properties

        public virtual int NumeroRequisicion
        {
            get { return _numerorequisicion; }
            set { _numerorequisicion = value; }
        }

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual string Licitacion
        {
            get { return _licitacion; }
            set { _licitacion = value; }
        }

        public virtual int CveArt
        {
            get { return _cveart; }
            set { _cveart = value; }
        }

        public virtual string DesArticulo
        {
            get { return _desarticulo; }
            set { _desarticulo = value; }
        }

        public virtual string Unidad
        {
            get { return _unidad; }
            set { _unidad = value; }
        }

        public virtual double Cantidad
        {
            get { return _cantidad; }
            set { _cantidad = value; }
        }

        public virtual double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public virtual string CvePartida
        {
            get { return _cvepartida; }
            set { _cvepartida = value; }
        }

        #endregion
    }
}
