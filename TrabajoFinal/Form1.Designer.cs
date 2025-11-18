namespace TrabajoFinal
{
    partial class frmPrincipal
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
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gestiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.departamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarDepartamentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarCargosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportarEmpleadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.gestiToolStripMenuItem,
            this.exportarToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.menuToolStripMenuItem.Text = "Menu ";
            // 
            // gestiToolStripMenuItem
            // 
            this.gestiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.departamentosToolStripMenuItem,
            this.cargosToolStripMenuItem,
            this.empleadosToolStripMenuItem});
            this.gestiToolStripMenuItem.Name = "gestiToolStripMenuItem";
            this.gestiToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.gestiToolStripMenuItem.Text = "Gestión";
            this.gestiToolStripMenuItem.Click += new System.EventHandler(this.gestiToolStripMenuItem_Click);
            // 
            // departamentosToolStripMenuItem
            // 
            this.departamentosToolStripMenuItem.Name = "departamentosToolStripMenuItem";
            this.departamentosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.departamentosToolStripMenuItem.Text = "Departamentos";
            // 
            // cargosToolStripMenuItem
            // 
            this.cargosToolStripMenuItem.Name = "cargosToolStripMenuItem";
            this.cargosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cargosToolStripMenuItem.Text = "Cargos";
            // 
            // empleadosToolStripMenuItem
            // 
            this.empleadosToolStripMenuItem.Name = "empleadosToolStripMenuItem";
            this.empleadosToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadosToolStripMenuItem.Text = "Empleados";
            // 
            // exportarToolStripMenuItem
            // 
            this.exportarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportarDepartamentosToolStripMenuItem,
            this.exportarCargosToolStripMenuItem,
            this.exportarEmpleadosToolStripMenuItem});
            this.exportarToolStripMenuItem.Name = "exportarToolStripMenuItem";
            this.exportarToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exportarToolStripMenuItem.Text = "Exportar ";
            // 
            // exportarDepartamentosToolStripMenuItem
            // 
            this.exportarDepartamentosToolStripMenuItem.Name = "exportarDepartamentosToolStripMenuItem";
            this.exportarDepartamentosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportarDepartamentosToolStripMenuItem.Text = "Exportar Departamentos";
            // 
            // exportarCargosToolStripMenuItem
            // 
            this.exportarCargosToolStripMenuItem.Name = "exportarCargosToolStripMenuItem";
            this.exportarCargosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportarCargosToolStripMenuItem.Text = "Exportar Cargos";
            // 
            // exportarEmpleadosToolStripMenuItem
            // 
            this.exportarEmpleadosToolStripMenuItem.Name = "exportarEmpleadosToolStripMenuItem";
            this.exportarEmpleadosToolStripMenuItem.Size = new System.Drawing.Size(201, 22);
            this.exportarEmpleadosToolStripMenuItem.Text = "Exportar Empleados";
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.Text = "Gestor Formularios";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gestiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem departamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarDepartamentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarCargosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportarEmpleadosToolStripMenuItem;
    }
}

