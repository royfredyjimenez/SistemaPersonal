namespace ProyectoPersonal
{
    partial class frmFormularioPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.agregarNuevoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.agregarNuevoToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.modificacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.eliminacionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listarRegistrosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirDelSistemaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem,
            this.listarRegistrosToolStripMenuItem,
            this.salirDelSistemaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(798, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // agregarNuevoToolStripMenuItem
            // 
            this.agregarNuevoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.agregarNuevoToolStripMenuItem1,
            this.modificacionToolStripMenuItem,
            this.eliminacionToolStripMenuItem});
            this.agregarNuevoToolStripMenuItem.Name = "agregarNuevoToolStripMenuItem";
            this.agregarNuevoToolStripMenuItem.Size = new System.Drawing.Size(112, 20);
            this.agregarNuevoToolStripMenuItem.Text = "Personal empresa";
            // 
            // agregarNuevoToolStripMenuItem1
            // 
            this.agregarNuevoToolStripMenuItem1.Name = "agregarNuevoToolStripMenuItem1";
            this.agregarNuevoToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.agregarNuevoToolStripMenuItem1.Text = "Agregar nuevo";
            this.agregarNuevoToolStripMenuItem1.Click += new System.EventHandler(this.agregarNuevoToolStripMenuItem1_Click);
            // 
            // modificacionToolStripMenuItem
            // 
            this.modificacionToolStripMenuItem.Name = "modificacionToolStripMenuItem";
            this.modificacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificacionToolStripMenuItem.Text = "Modificacion ";
            this.modificacionToolStripMenuItem.Click += new System.EventHandler(this.modificacionToolStripMenuItem_Click);
            // 
            // eliminacionToolStripMenuItem
            // 
            this.eliminacionToolStripMenuItem.Name = "eliminacionToolStripMenuItem";
            this.eliminacionToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.eliminacionToolStripMenuItem.Text = "Eliminacion";
            this.eliminacionToolStripMenuItem.Click += new System.EventHandler(this.eliminacionToolStripMenuItem_Click);
            // 
            // listarRegistrosToolStripMenuItem
            // 
            this.listarRegistrosToolStripMenuItem.Name = "listarRegistrosToolStripMenuItem";
            this.listarRegistrosToolStripMenuItem.Size = new System.Drawing.Size(95, 20);
            this.listarRegistrosToolStripMenuItem.Text = "Listar registros";
            this.listarRegistrosToolStripMenuItem.Click += new System.EventHandler(this.listarRegistrosToolStripMenuItem_Click);
            // 
            // salirDelSistemaToolStripMenuItem
            // 
            this.salirDelSistemaToolStripMenuItem.Name = "salirDelSistemaToolStripMenuItem";
            this.salirDelSistemaToolStripMenuItem.Size = new System.Drawing.Size(104, 20);
            this.salirDelSistemaToolStripMenuItem.Text = "Salir del Sistema";
            this.salirDelSistemaToolStripMenuItem.Click += new System.EventHandler(this.salirDelSistemaToolStripMenuItem_Click);
            // 
            // frmFormularioPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 397);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmFormularioPrincipal";
            this.Text = "Sistema de Personal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem agregarNuevoToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem modificacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem eliminacionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listarRegistrosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirDelSistemaToolStripMenuItem;
    }
}

