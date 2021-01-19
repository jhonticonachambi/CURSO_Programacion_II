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

using System.Data.SqlClient;
using System.Web.UI.WebControls;

namespace SistemaEscritorio.Presentacion
{
    public partial class FrmActualizarPassword : Form
    {
        public FrmActualizarPassword()
        {
            InitializeComponent();
        }


        void Limpiar()
        {
            txtNuevPass.Clear();
            txtPassActual.Clear();
            txtRepetPass.Clear();   
        }



        private void btnActualizar_Click(object sender, EventArgs e)
        {

          
            try
            {

                string rpta = "";

                string Contraseña, ContraseñaNueva, RepetirContraseña;
                Contraseña = txtPassActual.Text;
                ContraseñaNueva = txtNuevPass.Text;
                RepetirContraseña = txtRepetPass.Text;

                if (txtPassActual.Text == string.Empty)
                {
                    MessageBox.Show("Por favor complete el campo");
                }
                else
                {
                    rpta = UsuarioNegocio.ActualizarContraseña(Contraseña.Trim(), ContraseñaNueva.Trim());

                    if (rpta.Equals("OK"))
                    {
                        MessageBox.Show("Actualizado correctamente");
                        this.Limpiar();
                    }
                    else
                    {
                        MessageBox.Show(rpta);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
