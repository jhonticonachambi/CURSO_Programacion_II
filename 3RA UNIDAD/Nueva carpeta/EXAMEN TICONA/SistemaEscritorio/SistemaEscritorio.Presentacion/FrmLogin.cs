using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscritorio.Negocio;


namespace SistemaEscritorio.Presentacion
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                string Usuario, Password;
                Usuario = txtusuario.Text.Trim();
                Password = txtContraseña.Text.Trim();
                DataTable Tabla = new DataTable();
                Tabla = UsuarioNegocio.Loguear(Usuario, Password);

                if (Tabla.Rows.Count <= 0)
                {
                    MessageBox.Show("El usuario no esta registrado en la base de datos....","Autenticacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    if (Convert.ToString(Tabla.Rows[0][5]) == "I")
                    {
                        MessageBox.Show("El usuario se encuentra inhabilitado, consulte con el Administrador", "Autenticacion del Sistema", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MDIParent1 MDI = new MDIParent1();
                        MDI.IdUsuario = Convert.ToInt32(Tabla.Rows[0][0]);
                        MDI.Apelllido = Convert.ToString(Tabla.Rows[0][1]);
                        MDI.Nombre = Convert.ToString(Tabla.Rows[0][2]);
                        MDI.Usuario = Convert.ToString(Tabla.Rows[0][3]);
                        MDI.Nivel = Convert.ToString(Tabla.Rows[0][4]);
                        MDI.Estado = Convert.ToString(Tabla.Rows[0][5]);
                        MDI.Show();
                        this.Hide();

                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
