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
using System.Web.UI.WebControls;

namespace SistemaEscritorio.Presentacion
{
    public partial class FrmPersona : Form
    {
        private string NombreAnterior;
        public FrmPersona()
        {
            InitializeComponent();
        }

        private void ListarGrilla()
        {
            try
            {
                dgvListar.DataSource =PersonaNegocio.Listar();
                this.TitulosGrilla();
             
                this.Visualizar();

                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListar.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void Buscar()
        {
            try
            {
                string Buscar;
                Buscar = txtBuscar.Text;


                dgvListar.DataSource = PersonaNegocio.Buscar(Buscar);
                this.TitulosGrilla();
                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListar.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void TitulosGrilla()
        {
            dgvListar.Columns[0].Visible = false;

            dgvListar.Columns[1].Width = 70;
            dgvListar.Columns[2].Width = 70;
            dgvListar.Columns[3].Width = 150;
            dgvListar.Columns[4].Width = 150;
            dgvListar.Columns[5].Width = 10;
            dgvListar.Columns[6].Width = 250;
            dgvListar.Columns[7].Width = 50;
            dgvListar.Columns[8].Width = 250;
            dgvListar.Columns[9].Width = 150;
       

            dgvListar.Columns[1].HeaderText = "Persona_id";
            dgvListar.Columns[2].HeaderText = "Dni";
            dgvListar.Columns[3].HeaderText = "Nombre";
            dgvListar.Columns[4].HeaderText = "Apellido";
            dgvListar.Columns[5].HeaderText = "Sexo";
            dgvListar.Columns[6].HeaderText = "Email";
            dgvListar.Columns[7].HeaderText = "Celular";
            dgvListar.Columns[8].HeaderText = "Direccion";
            dgvListar.Columns[9].HeaderText = "Fecha de Nacimiento";



        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

            try
            {


                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de eliminar el(los) registros(s)...", "Sistema XYZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgvListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = PersonaNegocio.Eliminar(codigo);
                            if (rpta == "OK")
                            {
                                this.MensajeCorrecto("Se elimino el registro satisfactoriamente: " + Convert.ToString(row.Cells[1].Value));
                            }
                            else
                            {
                                this.MensajeError(rpta);
                            }

                        }
                    }
                    this.ListarGrilla();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void FrmPersona_Load(object sender, EventArgs e)
        {
            ListarGrilla();
        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }
        public void Visualizar()
        {
            btnGrabar.Visible = true;
            btnActulizar.Visible = true;

            dgvListar.Columns[0].Visible = false;//columna seleccionaren la grilla
            btnEliminar.Visible = false;
 
        }
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Metodo Mensaje de correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        
       
        public void Limpiar()
        {
            txtCodigo.Text = "";
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtDireccion.Text = "";
            txtCelular.Text = "";
            txtEmail.Text = "";

        }
        public void CargarCombo()
        {
            cboxSexo.Items.Add("M");
            cboxSexo.Items.Add("F");
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {

            this.Limpiar();
            this.Visualizar();
            tabGestionar.SelectedIndex = 0;//tab del listar
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListar.Columns[0].Visible = true;//columna seleccionaren la grilla
                btnEliminar.Visible = true;
              
            }
            else
            {
                dgvListar.Columns[0].Visible = false;//columna seleccionaren la grilla
                btnEliminar.Visible = false;
              
            }
        }

        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.Limpiar();
                this.Visualizar();
                btnActulizar.Visible = true;
                btnGrabar.Visible = false;
                txtCodigo.Text = Convert.ToString(dgvListar.CurrentRow.Cells["persona_id"].Value);

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
                }

                this.CargarCombo();



                tabGestionar.SelectedIndex = 1;
            }
            catch (Exception)
            {

                MessageBox.Show("Seleccione desde la celda Nombre");
            }
        }

        private void btnActulizar_Click(object sender, EventArgs e)
        {
            try
            {
                string rpta = "";
                if (txtDni.Text == string.Empty || txtCodigo.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar datos en algunos Campos");
                    ErrorAlerta.SetError(txtDni, "Ingrese dni");
                }
                else
                {
                    rpta = PersonaNegocio.Actualizar(Convert.ToInt32(txtCodigo.Text), txtDni.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), cboxSexo.Text.Trim(), txtEmail.Text.Trim(), txtCelular.Text.Trim(), txtDireccion.Text.Trim(), dateFechaNac.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se Grabo el Registro Correctamente...");
                        this.Limpiar();
                        this.Visualizar();
                        this.ListarGrilla();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnGrabar_Click_1(object sender, EventArgs e)
        {

            try
            {
                string rpta = "";
                if (txtDni.Text == string.Empty)
                {
                    this.MensajeError("Faltan Ingresar datos en algunos Campos");
                    ErrorAlerta.SetError(txtDni, "Ingrese Categoria");
                }
                else
                {
                    rpta = PersonaNegocio.Insertar(txtDni.Text.Trim(), txtNombre.Text.Trim(), txtApellido.Text.Trim(), cboxSexo.Text.Trim(), txtEmail.Text.Trim(), txtCelular.Text.Trim(), txtDireccion.Text.Trim(), dateFechaNac.Text.Trim());
                    if (rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se Grabo el Registro Correctamente...");
                        this.Limpiar();
                        this.Visualizar();
                        this.ListarGrilla();
                    }
                    else
                    {
                        this.MensajeError(rpta);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message + ex.StackTrace);
            }
        }

        private void btnActulizar_Click_1(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
