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
    public partial class FrmDocumento : Form
    {
        public FrmDocumento()
        {
            InitializeComponent();
        }

        private void ListarGrilla()
        {
            try
            {
                dgvListar.DataSource = DocumentoNegocio.Listar();
                this.TitulosGrilla();
                this.Limpiar();
                this.Visualizar();

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
            dgvListar.Columns[3].Width = 70;
            dgvListar.Columns[4].Width = 70;
            dgvListar.Columns[5].Width = 70;
            dgvListar.Columns[6].Width = 150;
            dgvListar.Columns[7].Width = 70;

            dgvListar.Columns[1].HeaderText = "ID";
            dgvListar.Columns[2].HeaderText = "Categoria";
            dgvListar.Columns[3].HeaderText = "Nombre";
            dgvListar.Columns[4].HeaderText = "Extension";
            dgvListar.Columns[5].HeaderText = "Tamaño";
            dgvListar.Columns[6].HeaderText = "Descripcion";
            dgvListar.Columns[7].HeaderText = "Estado";

        }
        public void Limpiar()
        {
            txtId.Text = "";
            txtNombre.Text = "";
            txtExtension.Text = "";
            txtTamaño.Text = "";
            cmbCategoria.Text = "";
            txtDescripcion.Text = "";
            txtEstadosss.Text = "";
        }

        public void Visualizar()
        {
            btnGrabar.Visible = true;
            btnAcualizar.Visible = true;

            dgvListar.Columns[0].Visible = false;//columna seleccionaren la grilla
            btnEliminar.Visible = false;
        }


        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmDocumento_Load(object sender, EventArgs e)
        {
            this.ListarGrilla();
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
                            rpta = DocumentoNegocio.Eliminar(codigo);
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






        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if (txtNombre.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos...");
                    

                }
                else
                {
                    if (rbtnActivo.Checked == true)
                    {
                        txtEstadosss.Text = "A";
                    }
                    if (rbtnInactivo.Checked == true)
                    {
                        txtEstadosss.Text = "I";
                    }
                        Rpta = DocumentoNegocio.Insertar(cmbCategoria.Text.Trim(),txtNombre.Text.Trim(), txtTamaño.Text.Trim(), txtExtension.Text.Trim(), txtDescripcion.Text.Trim(),txtEstadosss.Text.Trim());
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se grabo el registro correctamente...");
                        this.Limpiar();
                        this.Visualizar();
                        this.ListarGrilla();

                    }
                    else
                    {
                        this.MensajeError(Rpta);
                    }
                }


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


                dgvListar.DataSource = CategoriaNegocio.Buscar(Buscar);
                this.TitulosGrilla();
                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListar.Rows.Count);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }

        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            Reportes.Form1 Reporte = new Reportes.Form1();
            Reporte.ShowDialog();
        }
    }
}
