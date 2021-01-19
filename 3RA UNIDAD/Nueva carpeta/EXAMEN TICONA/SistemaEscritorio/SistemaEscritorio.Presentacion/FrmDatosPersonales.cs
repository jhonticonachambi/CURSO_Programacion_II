using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaEscritorio.Presentacion
{
    public partial class FrmDatosPersonales : Form
    {
        public FrmDatosPersonales()
        {
            InitializeComponent();
        }
        /*
        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";

        }*/



        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void FrmDatosPersonales_Load(object sender, EventArgs e)
        {

            /*txtCodigo.Text = Convert.ToString(dgvListar.CurrentRow.Cells["persona_id"].Value);

            txtDni.Text = Convert.ToString(dgvListar.CurrentRow.Cells["dni"].Value);
            txtNombre.Text = Convert.ToString(dgvListar.CurrentRow.Cells["nombre"].Value);
            txtApellido.Text = Convert.ToString(dgvListar.CurrentRow.Cells["apellido"].Value);
            txtEmail.Text = Convert.ToString(dgvListar.CurrentRow.Cells["email"].Value);
            txtCelular.Text = Convert.ToString(dgvListar.CurrentRow.Cells["celular"].Value);
            txtDireccion.Text = Convert.ToString(dgvListar.CurrentRow.Cells["direccion"].Value);
            dateFechaNac.Text = Convert.ToString(dgvListar.CurrentRow.Cells["fechanacimiento"].Value);

            if (dgvListar.CurrentRow.Cells["sexo"].Value.Equals("M"))
            {


                cboxSexo.Text = Convert.ToString(dgvListar.CurrentRow.Cells["sexo"].Value);
            }
            else if (dgvListar.CurrentRow.Cells["sexo"].Value.Equals("F"))
            {


                cboxSexo.Text = Convert.ToString(dgvListar.CurrentRow.Cells["sexo"].Value);
            }*/

        }
    }
}
