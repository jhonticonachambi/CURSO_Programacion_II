namespace SistemaEscritorio.Presentacion
{
    partial class MDIParent1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDIParent1));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.MenuMantenimiento = new System.Windows.Forms.ToolStripMenuItem();
            this.MnumanteCategoria = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuMantePersona = new System.Windows.Forms.ToolStripMenuItem();
            this.MnuManteUsuario = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuConsultas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuReportes = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioGraficoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.usuarioConParametroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuAyudas = new System.Windows.Forms.ToolStripMenuItem();
            this.contentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.indexToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuSalir = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Categoria = new System.Windows.Forms.ToolStripButton();
            this.btnDocumento = new System.Windows.Forms.ToolStripButton();
            this.btnPersona = new System.Windows.Forms.ToolStripButton();
            this.btnUsuario = new System.Windows.Forms.ToolStripButton();
            this.btnConsultas = new System.Windows.Forms.ToolStripButton();
            this.btnReportes = new System.Windows.Forms.ToolStripButton();
            this.btnSalir = new System.Windows.Forms.ToolStripButton();
            this.BarraEstado = new System.Windows.Forms.StatusStrip();
            this.spBarraEstado = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.cambiarContraseñaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.BarraEstado.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuMantenimiento,
            this.MenuConsultas,
            this.MenuReportes,
            this.MenuAyudas,
            this.MenuSalir,
            this.cambiarContraseñaToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(725, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // MenuMantenimiento
            // 
            this.MenuMantenimiento.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MnumanteCategoria,
            this.documentoToolStripMenuItem,
            this.MnuMantePersona,
            this.MnuManteUsuario});
            this.MenuMantenimiento.Name = "MenuMantenimiento";
            this.MenuMantenimiento.Size = new System.Drawing.Size(101, 20);
            this.MenuMantenimiento.Text = "&Mantenimiento";
            // 
            // MnumanteCategoria
            // 
            this.MnumanteCategoria.Name = "MnumanteCategoria";
            this.MnumanteCategoria.Size = new System.Drawing.Size(137, 22);
            this.MnumanteCategoria.Text = "&Categoria";
            this.MnumanteCategoria.Click += new System.EventHandler(this.categoriaToolStripMenuItem_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(137, 22);
            this.documentoToolStripMenuItem.Text = "&Documento";
            this.documentoToolStripMenuItem.Click += new System.EventHandler(this.documentoToolStripMenuItem_Click);
            // 
            // MnuMantePersona
            // 
            this.MnuMantePersona.Name = "MnuMantePersona";
            this.MnuMantePersona.Size = new System.Drawing.Size(137, 22);
            this.MnuMantePersona.Text = "&Persona";
            this.MnuMantePersona.Click += new System.EventHandler(this.personaToolStripMenuItem_Click);
            // 
            // MnuManteUsuario
            // 
            this.MnuManteUsuario.Name = "MnuManteUsuario";
            this.MnuManteUsuario.Size = new System.Drawing.Size(137, 22);
            this.MnuManteUsuario.Text = "&Usuario";
            // 
            // MenuConsultas
            // 
            this.MenuConsultas.Name = "MenuConsultas";
            this.MenuConsultas.Size = new System.Drawing.Size(71, 20);
            this.MenuConsultas.Text = "Consultas";
            // 
            // MenuReportes
            // 
            this.MenuReportes.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.usuarioGraficoToolStripMenuItem,
            this.usuarioConParametroToolStripMenuItem});
            this.MenuReportes.Name = "MenuReportes";
            this.MenuReportes.Size = new System.Drawing.Size(65, 20);
            this.MenuReportes.Text = "Reportes";
            // 
            // usuarioGraficoToolStripMenuItem
            // 
            this.usuarioGraficoToolStripMenuItem.Name = "usuarioGraficoToolStripMenuItem";
            this.usuarioGraficoToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.usuarioGraficoToolStripMenuItem.Text = "Usuario grafico";
            this.usuarioGraficoToolStripMenuItem.Click += new System.EventHandler(this.usuarioGraficoToolStripMenuItem_Click);
            // 
            // usuarioConParametroToolStripMenuItem
            // 
            this.usuarioConParametroToolStripMenuItem.Name = "usuarioConParametroToolStripMenuItem";
            this.usuarioConParametroToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.usuarioConParametroToolStripMenuItem.Text = "Usuario Con parametro";
            this.usuarioConParametroToolStripMenuItem.Click += new System.EventHandler(this.usuarioConParametroToolStripMenuItem_Click);
            // 
            // MenuAyudas
            // 
            this.MenuAyudas.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.contentsToolStripMenuItem,
            this.indexToolStripMenuItem,
            this.searchToolStripMenuItem,
            this.toolStripSeparator8,
            this.aboutToolStripMenuItem});
            this.MenuAyudas.Name = "MenuAyudas";
            this.MenuAyudas.Size = new System.Drawing.Size(53, 20);
            this.MenuAyudas.Text = "Ay&uda";
            // 
            // contentsToolStripMenuItem
            // 
            this.contentsToolStripMenuItem.Name = "contentsToolStripMenuItem";
            this.contentsToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
            this.contentsToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.contentsToolStripMenuItem.Text = "&Contenido";
            // 
            // indexToolStripMenuItem
            // 
            this.indexToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("indexToolStripMenuItem.Image")));
            this.indexToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.indexToolStripMenuItem.Name = "indexToolStripMenuItem";
            this.indexToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.indexToolStripMenuItem.Text = "&Índice";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("searchToolStripMenuItem.Image")));
            this.searchToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.searchToolStripMenuItem.Text = "&Buscar";
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(173, 6);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(176, 22);
            this.aboutToolStripMenuItem.Text = "&Acerca de... ...";
            // 
            // MenuSalir
            // 
            this.MenuSalir.Name = "MenuSalir";
            this.MenuSalir.Size = new System.Drawing.Size(41, 20);
            this.MenuSalir.Text = "Salir";
            this.MenuSalir.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripSeparator2,
            this.Categoria,
            this.btnDocumento,
            this.btnPersona,
            this.btnUsuario,
            this.btnConsultas,
            this.btnReportes,
            this.btnSalir});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(725, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Categoria
            // 
            this.Categoria.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Categoria.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.application;
            this.Categoria.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Categoria.Name = "Categoria";
            this.Categoria.Size = new System.Drawing.Size(23, 22);
            this.Categoria.Text = "toolStripButton1";
            this.Categoria.Click += new System.EventHandler(this.Categoria_Click);
            // 
            // btnDocumento
            // 
            this.btnDocumento.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnDocumento.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.application_edit;
            this.btnDocumento.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDocumento.Name = "btnDocumento";
            this.btnDocumento.Size = new System.Drawing.Size(23, 22);
            this.btnDocumento.Text = "toolStripButton2";
            // 
            // btnPersona
            // 
            this.btnPersona.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnPersona.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.community_users;
            this.btnPersona.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPersona.Name = "btnPersona";
            this.btnPersona.Size = new System.Drawing.Size(23, 22);
            this.btnPersona.Text = "toolStripButton3";
            this.btnPersona.Click += new System.EventHandler(this.btnPersona_Click);
            // 
            // btnUsuario
            // 
            this.btnUsuario.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnUsuario.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.user_accept;
            this.btnUsuario.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnUsuario.Name = "btnUsuario";
            this.btnUsuario.Size = new System.Drawing.Size(23, 22);
            this.btnUsuario.Text = "toolStripButton4";
            // 
            // btnConsultas
            // 
            this.btnConsultas.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnConsultas.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.computer_accept;
            this.btnConsultas.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnConsultas.Name = "btnConsultas";
            this.btnConsultas.Size = new System.Drawing.Size(23, 22);
            this.btnConsultas.Text = "toolStripButton5";
            // 
            // btnReportes
            // 
            this.btnReportes.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnReportes.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.chart;
            this.btnReportes.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnReportes.Name = "btnReportes";
            this.btnReportes.Size = new System.Drawing.Size(23, 22);
            this.btnReportes.Text = "toolStripButton6";
            // 
            // btnSalir
            // 
            this.btnSalir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnSalir.Image = global::SistemaEscritorio.Presentacion.Properties.Resources.salir;
            this.btnSalir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(23, 22);
            this.btnSalir.Text = "toolStripButton7";
            this.btnSalir.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // BarraEstado
            // 
            this.BarraEstado.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.spBarraEstado});
            this.BarraEstado.Location = new System.Drawing.Point(0, 505);
            this.BarraEstado.Name = "BarraEstado";
            this.BarraEstado.Size = new System.Drawing.Size(725, 22);
            this.BarraEstado.TabIndex = 2;
            this.BarraEstado.Text = "StatusStrip";
            // 
            // spBarraEstado
            // 
            this.spBarraEstado.Name = "spBarraEstado";
            this.spBarraEstado.Size = new System.Drawing.Size(42, 17);
            this.spBarraEstado.Text = "Estado";
            // 
            // cambiarContraseñaToolStripMenuItem
            // 
            this.cambiarContraseñaToolStripMenuItem.Name = "cambiarContraseñaToolStripMenuItem";
            this.cambiarContraseñaToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.cambiarContraseñaToolStripMenuItem.Text = "Cambiar Contraseña";
            this.cambiarContraseñaToolStripMenuItem.Click += new System.EventHandler(this.cambiarContraseñaToolStripMenuItem_Click);
            // 
            // MDIParent1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 527);
            this.Controls.Add(this.BarraEstado);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MDIParent1";
            this.Text = "MDIParent1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MDIParent1_FormClosing);
            this.Load += new System.EventHandler(this.MDIParent1_Load);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.BarraEstado.ResumeLayout(false);
            this.BarraEstado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.StatusStrip BarraEstado;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripStatusLabel spBarraEstado;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MenuMantenimiento;
        private System.Windows.Forms.ToolStripMenuItem MenuAyudas;
        private System.Windows.Forms.ToolStripMenuItem contentsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem indexToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.ToolStripMenuItem MnumanteCategoria;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem MnuMantePersona;
        private System.Windows.Forms.ToolStripMenuItem MnuManteUsuario;
        private System.Windows.Forms.ToolStripMenuItem MenuConsultas;
        private System.Windows.Forms.ToolStripMenuItem MenuReportes;
        private System.Windows.Forms.ToolStripButton Categoria;
        private System.Windows.Forms.ToolStripButton btnDocumento;
        private System.Windows.Forms.ToolStripButton btnPersona;
        private System.Windows.Forms.ToolStripButton btnUsuario;
        private System.Windows.Forms.ToolStripButton btnConsultas;
        private System.Windows.Forms.ToolStripButton btnReportes;
        private System.Windows.Forms.ToolStripButton btnSalir;
        private System.Windows.Forms.ToolStripMenuItem MenuSalir;
        private System.Windows.Forms.ToolStripMenuItem usuarioGraficoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usuarioConParametroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cambiarContraseñaToolStripMenuItem;
    }
}



