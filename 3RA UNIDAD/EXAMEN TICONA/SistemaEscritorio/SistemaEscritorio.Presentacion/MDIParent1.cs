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
    public partial class MDIParent1 : Form
    {
        private int childFormNumber = 0;

        public int IdUsuario;
        public string Apelllido;
        public string Nombre;
        public string Usuario;
        public string Nivel;
        public string Estado;

        public MDIParent1()
        {
            InitializeComponent();
        }
        void AbriFrmCategoria()
        {
            FrmCategoria Frm = new FrmCategoria();
            Frm.MdiParent = this;
            Frm.Show();
        }
        void AbriFrmPersona()
        {
            FrmPersona Frm = new FrmPersona();
            Frm.MdiParent = this;
            Frm.Show();
        }
        void AbriFrmGrafico()
        {
            
        }
        void AbriFrmUsuarioParametro()
        {
            
        }



        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Ventana " + childFormNumber++;
            childForm.Show();
        }
        void Salir()
        {
            DialogResult Opcion;
            Opcion = MessageBox.Show("¿Esta seguro de salir del sistema?", "Sistema XYZ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (Opcion == DialogResult.OK)
            {
                Application.Exit();
            }

        }
        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Archivos de texto (*.txt)|*.txt|Todos los archivos (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void documentoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbriFrmCategoria();
        }

        private void Categoria_Click(object sender, EventArgs e)
        {
            AbriFrmCategoria();
        }

        private void personaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbriFrmPersona();
        }

        private void menuStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void MDIParent1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            Salir();
        }

        private void MDIParent1_Load(object sender, EventArgs e)
        {
            spBarraEstado.Text = "Bienvenido: " + Nombre + "," + Apelllido + " Nivel: [" + Nivel + "]";

            if (this.Nivel.Equals("Administrador"))
            {
                MenuMantenimiento.Visible = true;
                MenuConsultas.Visible = true;
                MenuReportes.Visible = true;
                MenuAyudas.Visible = true;
                MenuSalir.Visible = true;
            }
            else
            {
                if (this.Nivel.Equals("Supervisor"))
                {
                    MenuMantenimiento.Visible = true;
                    MnuMantePersona.Enabled = false;
                    MnuManteUsuario.Enabled = false;

                    Categoria.Visible = false;
                    btnDocumento.Enabled = true;
                    btnPersona.Enabled = false;
                    btnUsuario.Enabled = false;
                }
                else
                {
                    MenuMantenimiento.Enabled = false;

                    MenuReportes.Enabled = false;


                    Categoria.Visible = false;
                    btnDocumento.Visible = false;
                    btnPersona.Visible = false;
                    btnUsuario.Visible = false;


                }
            }
        }

        private void usuarioGraficoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbriFrmGrafico();
        }

        private void usuarioConParametroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbriFrmUsuarioParametro();
        }

        private void btnPersona_Click(object sender, EventArgs e)
        {

        }
        void AbriFrmCambiarPass()
        {
            FrmActualizarPassword Frm = new FrmActualizarPassword();
            Frm.MdiParent = this;
            Frm.Show();
        }
        private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbriFrmCambiarPass();
        }
    }
}
