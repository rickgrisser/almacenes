using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataCierre
    {
        protected string _cvepartida;
        protected string _despartida;
        protected DateTime _fechacierre;
        protected int _cveart;
        protected string _desarticulo;
        protected string _medida;
        protected double _existencia;
        protected double _costo;
        protected double _importe;

        public virtual string CvePartida
        {
            get { return _cvepartida; }
            set { _cvepartida = value; }
        }

        public virtual string DesPartida
        {
            get { return _despartida; }
            set { _despartida = value; }
        }

        public virtual DateTime FechaCierre
        {
            get { return _fechacierre; }
            set { _fechacierre = value; }
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

        public virtual string Medida
        {
            get { return _medida; }
            set { _medida = value; }
        }

        public virtual double Existencia
        {
            get { return _existencia; }
            set { _existencia = value; }
        }

        public virtual double Costo
        {
            get { return _costo; }
            set { _costo = value; }
        }

        public virtual double Importe
        {
            get { return _importe; }
            set { _importe = value; }
        }
    }
}
