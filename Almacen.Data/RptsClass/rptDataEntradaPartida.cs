using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaPartida
    {
        protected string _es;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected string _cvepartida;
        protected string _despartida;
        protected double _presupuesto;
        protected double _cuota;
        protected double _otros;
        protected string _tipopresupuesto;

        public virtual string Es
        {
            get { return _es; }
            set { _es = value; }
        }

        public virtual DateTime FechaIni
        {
            get { return _fechaini; }
            set { _fechaini = value; }
        }

        public virtual DateTime FechaFin
        {
            get { return _fechafin; }
            set { _fechafin = value; }
        }

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

        public virtual double Presupuesto
        {
            get { return _presupuesto; }
            set { _presupuesto = value; }
        }

        public virtual double Cuota
        {
            get { return _cuota; }
            set { _cuota = value; }
        }

        public virtual double Otros
        {
            get { return _otros; }
            set { _otros = value; }
        }

        public virtual string TipoPresupuesto
        {
            get { return _tipopresupuesto; }
            set { _tipopresupuesto = value; }
        }
    }
}
