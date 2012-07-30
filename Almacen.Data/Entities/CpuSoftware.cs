/*
using MyGeneration/Template/NHibernate (c) by lujan99@usa.net
*/
using System;
using System.Collections;
using System.Collections.Generic;

namespace Almacen.Data.Entities
{
	/// <summary>
	/// CpuSoftware object for NHibernate mapped table 'cpu_software'.
	/// </summary>
	[Serializable]
	public class CpuSoftware
	{
		#region Member Variables
		protected long _idcpusoftware;
	    protected Cpu _idcpu;
	    protected CatSoftware _idcatsoftware;
		protected DateTime? _fechaalta;
		protected string _ipterminal;
		protected Usuario _usuario;
		protected string _estatus;
		protected CatSoftware _catsoftware;
		#endregion
		#region Constructors
			
		public CpuSoftware() {}
					
		public CpuSoftware(long idcpusoftware, DateTime? fechaalta, string ipterminal, string estatus, CatSoftware catsoftware) 
		{
            this._idcpusoftware = idcpusoftware;
			this._fechaalta= fechaalta;
			this._ipterminal= ipterminal;
			this._estatus= estatus;
			this._catsoftware= catsoftware;
		}

        public CpuSoftware(long idcpusoftware, Cpu idcpu)
		{
            this._idcpusoftware = idcpusoftware;
            this._idcpu = idcpu;
		}
		
		#endregion
		#region Public Properties
		public  virtual long IdCpuSoftware
		{
            get { return _idcpusoftware; }
            set { _idcpusoftware = value; }
		}
        public virtual Cpu IdCpu
        {
            get { return _idcpu; }
            set { _idcpu = value; }
        }
        public virtual CatSoftware IdCatSoftware
        {
            get { return _idcatsoftware; }
            set { _idcatsoftware = value; }
        }
		public  virtual DateTime? FechaAlta
		{
			get { return _fechaalta; }
			set {_fechaalta= value; }
		}
		public  virtual string IpTerminal
		{
			get { return _ipterminal; }
			set {_ipterminal= value; }
		}
		public  virtual Usuario Usuario
		{
			get { return _usuario; }
			set {_usuario= value; }
		}
		public  virtual string Estatus
		{
			get { return _estatus; }
			set {_estatus= value; }
		}
		public  virtual CatSoftware CatSoftware
		{
			get { return _catsoftware; }
			set {_catsoftware= value; }
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
            //CpuSoftware castObj = (CpuSoftware)obj;
            //return ( castObj != null ) &&
            //this._id.Equals( castObj.Id);
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
