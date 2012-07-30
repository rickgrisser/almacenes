using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataSalidaArea
    {
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected string _desarea;
        protected string _partida;
        protected string _despartida;
        protected int _cveart;
        protected string _desarticulo;
        protected string _medida;
        protected double _enero;
        protected double _febrero;
        protected double _marzo;
        protected double _abril;
        protected double _mayo;
        protected double _junio;
        protected double _julio;
        protected double _agosto;
        protected double _septiembre;
        protected double _octubre;
        protected double _noviembre;
        protected double _diciembre;

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

        public virtual string DesArea
        {
            get { return _desarea; }
            set { _desarea = value; }
        }

        public virtual string Partida
        {
            get { return _partida; }
            set { _partida = value; }
        }

        public virtual string DesPartida
        {
            get { return _despartida; }
            set { _despartida = value; }
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

        public virtual double Enero
        {
            get { return _enero; }
            set { _enero = value; }
        }

        public virtual double Febrero
        {
            get { return _febrero; }
            set { _febrero = value; }
        }

        public virtual double Marzo
        {
            get { return _marzo; }
            set { _marzo = value; }
        }

        public virtual double Abril
        {
            get { return _abril; }
            set { _abril = value; }
        }

        public virtual double Mayo
        {
            get { return _mayo; }
            set { _mayo = value; }
        }

        public virtual double Junio
        {
            get { return _junio; }
            set { _junio = value; }
        }

        public virtual double Julio
        {
            get { return _julio; }
            set { _julio = value; }
        }

        public virtual double Agosto
        {
            get { return _agosto; }
            set { _agosto = value; }
        }

        public virtual double Septiembre
        {
            get { return _septiembre; }
            set { _septiembre = value; }
        }

        public virtual double Octubre
        {
            get { return _octubre; }
            set { _octubre = value; }
        }

        public virtual double Noviembre
        {
            get { return _noviembre; }
            set { _noviembre = value; }
        }

        public virtual double Diciembre
        {
            get { return _diciembre; }
            set { _diciembre = value; }
        }
    }
}
