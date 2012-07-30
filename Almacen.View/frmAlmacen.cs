using System;
using System.Collections.Generic;
using System.Data;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Almacen.Data.Entities;
using Spring.Context;
using Spring.Context.Support;
using Almacen.Business.ModAlmacen;
using Almacen.Business;

namespace Almacen.View
{
    public partial class FrmAlmacen : Form
    {
        public static Data.Entities.Almacen AlmacenActual;
        public IAlmacenService AlmacenService;
        public FrmAlmacen()
        {
            InitializeComponent();
            IApplicationContext ctx = ContextRegistry.GetContext();
            AlmacenService = ctx["almacenService"] as IAlmacenService;
            AlmacenService.Almacenes(cmbAlmacen,FrmAcceso.UsuarioLog.IdUsuario);
            btnIngresar.Enabled = cmbAlmacen.Items.Count > 0 ? true : false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            var objUsuarioModulo = cmbAlmacen.SelectedValue as UsuarioModulo;
            AlmacenActual = objUsuarioModulo.Id.Modulo.Id.Almacen;
            Hide();
            new FrmMenu().ShowDialog();
            Show();
        }
        
    }
}
