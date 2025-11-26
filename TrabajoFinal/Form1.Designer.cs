namespace TrabajoFinal
{
    partial class FrmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.gestionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamenoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestionToolStripMenuItem,
            this.departamenoToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.empleadosToolStripMenuItem,
            this.exportarToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // gestionToolStripMenuItem
            // 
            this.gestionToolStripMenuItem.Name = "gestionToolStripMenuItem";
            this.gestionToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.gestionToolStripMenuItem.Text = "Gestion";
            // 
            // departamenoToolStripMenuItem
            // 
            this.departamenoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("departamenoToolStripMenuItem.Image")));
            this.departamenoToolStripMenuItem.Name = "departamenoToolStripMenuItem";
            this.departamenoToolStripMenuItem.Size = new System.Drawing.Size(116, 20);
            this.departamenoToolStripMenuItem.Text = "Departamentos";
            this.departamenoToolStripMenuItem.Click += new System.EventHandler(this.departamenoToolStripMenuItem_Click);
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("cargosToolStripMenuItem.Image")));
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.cargosToolStripMenuItem.Text = "Cargos";
            this.cargosToolStripMenuItem.Click += new System.EventHandler(this.cargosToolStripMenuItem_Click);
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("empleadosToolStripMenuItem.Image")));
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            this.empleadosToolStripMenuItem.Click += new System.EventHandler(this.empleadosToolStripMenuItem_Click);
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("exportarToolStripMenuItem.Image")));
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(78, 20);
            this.exportarToolStripMenuItem.Text = "Exportar";
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ayudaToolStripMenuItem.Image")));
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmPrincipal";
            this.Text = "Recursos Humanos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem gestionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamenoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
    }
}

