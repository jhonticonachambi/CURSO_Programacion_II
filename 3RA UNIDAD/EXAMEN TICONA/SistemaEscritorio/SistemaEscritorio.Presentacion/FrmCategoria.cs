using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaEscritorio.Presentacion;
using SistemaEscritorio.Negocio;
using System.Web.UI.WebControls;

namespace SistemaEscritorio.Presentacion
{
    public partial class FrmCategoria : Form
    {
        private string NombreAnterior;
        public FrmCategoria()
        {
            InitializeComponent();
            CargarComboEstado();
        }

        //Metodo Listar

        private void ListarGrilla()
        {
            try
            {
                dgvListar.DataSource = CategoriaNegocio.Listar();
                this.TitulosGrilla();
                this.Limpiar();
                this.Visualizar();

                lblTotal.Text = "Total de registros: " + Convert.ToString(dgvListar.Rows.Count);
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message + ex.StackTrace);
            }
               
        }
        //Metodo Buscar
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
        private void TitulosGrilla()
        {
            dgvListar.Columns[0].Visible = false;
            dgvListar.Columns[1].Width = 70;
            dgvListar.Columns[2].Width = 150;
            dgvListar.Columns[3].Width = 250;
            dgvListar.Columns[4].Width = 70;
            dgvListar.Columns[1].HeaderText = "Codigo";
            dgvListar.Columns[2].HeaderText = "Categoria";
            dgvListar.Columns[3].HeaderText = "Descripcion";
            dgvListar.Columns[4].HeaderText = "Estado";

        }

        private void FrmCategoria_Load(object sender, EventArgs e)
        {
            this.ListarGrilla();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void dgvListar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dgvListar.Columns["Seleccionar"].Index)
            {
                DataGridViewCheckBoxCell chkEliminar = (DataGridViewCheckBoxCell)dgvListar.Rows[e.RowIndex].Cells["Seleccionar"];
                chkEliminar.Value = !Convert.ToBoolean(chkEliminar.Value);
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            this.Buscar();
        }
        //Metodo Limpiar
        public void Limpiar()
        {
            txtId.Text = "";
            txtCategoria.Text = "";
            txtDescripcion.Text = "";
           
        }
        //Metodo Cargar combo estado
        private void CargarComboEstado()
        {
            cboEstado.Items.Clear();
            cboEstado.Items.Add(new ListItem("Activo","A"));
            cboEstado.Items.Add(new ListItem("Inactivo", "I"));


        }

        //Metodo Visualizar
        public void Visualizar()
        {
            btnGrabar.Visible = true;
            btnAcualizar.Visible = true;

            dgvListar.Columns[0].Visible = false;//columna seleccionaren la grilla
            btnEliminar.Visible = false;
            btnActivar.Visible = false;
            btnDesactivar.Visible = false;
        }
        //Metodo Mensaje de error
        private void MensajeError(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
        //Metodo Mensaje de correcto
        private void MensajeCorrecto(string mensaje)
        {
            MessageBox.Show(mensaje, "Sistema XYZ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnGrabar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
                if(txtCategoria.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos...");
                    ErrorAlerta.SetError(txtCategoria, "Ingrese Categoria");

                }
                else
                {
                    Rpta = CategoriaNegocio.Insertar(txtCategoria.Text.Trim(), txtDescripcion.Text.Trim(), cboEstado.Text.Trim()) ;
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

        private void btnAcualizar_Click(object sender, EventArgs e)
        {
            try
            {
                string Rpta = "";
            
                if (txtCategoria.Text == string.Empty || txtId.Text == string.Empty)
                {
                    this.MensajeError("Faltan ingresar datos en algunos campos...");
                    ErrorAlerta.SetError(txtCategoria, "Ingrese Categoria");

                }
                else
                {
                    Rpta = CategoriaNegocio.Actualizar(Convert.ToInt32(txtId.Text),this.NombreAnterior, txtCategoria.Text.Trim(), txtDescripcion.Text.Trim(), cboEstado.Text.Trim());
                  
                    if (Rpta.Equals("OK"))
                    {
                        this.MensajeCorrecto("Se actualizo el registro correctamente...");
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

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Limpiar();
            this.Visualizar();
            tabGestionar.SelectedIndex = 0;//tab del listar

        }

        private void dgvListar_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                this.Limpiar();
                this.Visualizar();
                string Estado = "";
                btnAcualizar.Visible = true;
                btnGrabar.Visible = false;
                txtId.Text = Convert.ToString(dgvListar.CurrentRow.Cells["categoria_id"].Value);

                this.NombreAnterior = Convert.ToString(dgvListar.CurrentRow.Cells["nombre"].Value);

                txtCategoria.Text = Convert.ToString(dgvListar.CurrentRow.Cells["nombre"].Value);


                txtDescripcion.Text = Convert.ToString(dgvListar.CurrentRow.Cells["descripcion"].Value);


                if (dgvListar.CurrentRow.Cells["estado"].Value.Equals(new ListItem("Activo", "A")))
                {
                    Estado = "Activo";

                }
                if (dgvListar.CurrentRow.Cells["estado"].Value.Equals(new ListItem("Inactivo", "I")))
                {
                    Estado = "Inactivo";

                }
                cboEstado.Text = Estado;

                tabGestionar.SelectedIndex = 1;
            }
            catch(Exception)
            {
                MessageBox.Show("Seleccione desde la celda categoria...");
            }
        }

        private void chkSeleccionar_CheckedChanged(object sender, EventArgs e)
        {
            if (chkSeleccionar.Checked)
            {
                dgvListar.Columns[0].Visible = true;//columna seleccionaren la grilla
                btnEliminar.Visible = true;
                btnActivar.Visible = true;
                btnDesactivar.Visible = true;
            }
            else
            {
                dgvListar.Columns[0].Visible = false;//columna seleccionaren la grilla
                btnEliminar.Visible = false;
                btnActivar.Visible = false;
                btnDesactivar.Visible = false;
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
                            rpta = CategoriaNegocio.Eliminar(codigo);
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

        private void btnActivar_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de Activar el(los) registros(s)...", "Sistema XYZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgvListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = CategoriaNegocio.Activar(codigo);
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

        private void btnDesactivar_Click(object sender, EventArgs e)
        {
            try
            {


                DialogResult Opcion;
                Opcion = MessageBox.Show("¿Esta seguro de Desactivar el(los) registros(s)...", "Sistema XYZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                if (Opcion == DialogResult.OK)
                {
                    int codigo;
                    string rpta = "";

                    foreach (DataGridViewRow row in dgvListar.Rows)
                    {
                        if (Convert.ToBoolean(row.Cells[0].Value))
                        {
                            codigo = Convert.ToInt32(row.Cells[1].Value);
                            rpta = CategoriaNegocio.Desactivar(codigo);
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

        private void btnReporte_Click(object sender, EventArgs e)
        {
            
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }
    }
}
