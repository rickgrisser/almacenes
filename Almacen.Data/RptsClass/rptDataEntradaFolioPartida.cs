using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataEntradaFolioPartida
    {
        protected string _es;
        protected DateTime _fechaini;
        protected DateTime _fechafin;
        protected string _partida;
        protected int _folio;
        protected DateTime _fecha;
        protected string _desproveedor;
        protected string _factura;
        protected int _numpedido;
        protected string _tipopedido;
        protected double _total;

        public virtual string ES
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

        public virtual string Partida
        {
            get { return _partida; }
            set { _partida = value; }
        }

        public virtual int Folio
        {
            get { return _folio; }
            set { _folio = value; }
        }

        public virtual DateTime Fecha
        {
            get { return _fecha; }
            set { _fecha = value; }
        }

        public virtual string Desproveedor
        {
            get { return _desproveedor; }
            set { _desproveedor = value; }
        }

        public virtual string Factura
        {
            get { return _factura; }
            set { _factura = value; }
        }

        public virtual int NumPedido
        {
            get { return _numpedido; }
            set { _numpedido = value; }
        }

        public virtual string TipoPedido
        {
            get { return _tipopedido; }
            set { _tipopedido = value; }
        }

        public virtual double Total
        {
            get { return _total; }
            set { _total = value; }
        }
    }
}
