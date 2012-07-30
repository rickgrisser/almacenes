using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Almacen.Data.RptsClass
{
    [Serializable]
    public class rptDataPedidosGenerados
    {
        #region Member Variables

        protected int _numRequisicion;
        protected DateTime _fechaRequisicion;
        protected int _numPedido;
        protected DateTime _fechaPedido;
        protected string _partida;
        protected string _despartida;

        #endregion

        #region Public Properties

        public virtual int NumRequisicion
        {
            get { return _numRequisicion; }
            set { _numRequisicion = value; }
        }

        public virtual DateTime FechaRequisicion
        {
            get { return _fechaRequisicion; }
            set { _fechaRequisicion = value; }
        }

        public virtual int NumPedido
        {
            get { return _numPedido; }
            set { _numPedido = value; }
        }

        public virtual DateTime FechaPedido
        {
            get { return _fechaPedido; }
            set { _fechaPedido = value; }
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
        #endregion
    }
}
