using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataSalidaVale
    {
        #region Member Variables
        protected string _area;
        protected DateTime _fecha;
        protected int _folio;
        protected int _cveart;
        protected string _desarticulo;
        protected string _unidad;
        protected double _cantidad;
        protected double _costo;
        protected DateTime _caducidad;
        protected int _numentrada;
        protected string _capturo;
        #endregion

        #region Public Properties

        public virtual string Area
        {
            get { return _area; }
            set { _area = value; }
        }

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual int Folio
        {
            get { return _folio; }
            set { _folio = value; }
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

        public virtual DateTime Caducidad
        {
            get { return _caducidad; }
            set { _caducidad = value; }
        }

        public virtual int NumEntrada
        {
            get { return _numentrada; }
            set { _numentrada = value; }
        }

        public virtual string Capturo
        {
            get { return _capturo; }
            set { _capturo = value; }
        }
        #endregion
    }
}
