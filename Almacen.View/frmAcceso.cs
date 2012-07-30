using System;
using System.Windows.Forms;
using Almacen.Business;
using Almacen.Business.Seguridad;
using Almacen.Data.Entities;
using Spring.Context.Support;

namespace Almacen.View
{
    public partial class FrmAcceso : Form
    {

        public static Usuario UsuarioLog;        
              
        public IUsuarioService UsuarioService;
       
        public FrmAcceso()
        {
            InitializeComponent();
            txtUsuario.Text = @"DERA791215";
            //Acceder al contexto de spring
            var ctx = ContextRegistry.GetContext();
            UsuarioService = ctx["usuarioService"] as IUsuarioService;
        }             

        private void BtnIngresarClick(object sender, EventArgs e)
        {
            UsuarioLog = UsuarioService.UsuarioDao.accessAllow(txtUsuario.Text, Util.ReverseString(txtPassword.Text));
            if (UsuarioLog == null)
            {//Credenciales No Validas
                MessageBox.Show(@"No tiene Acceso al Sistema, Verifique credenciales",
                    @"Almacen", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else //Redireccionamos
            {
                this.Hide();
                new FrmAlmacen().ShowDialog();
            }
        }

        #region Eventos
        private void txtUsuario_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtUsuario, e);
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            Fx.OnKeyTab(txtPassword, e);
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        #endregion

        #region Metodos
       
        #endregion
        
    }
}
