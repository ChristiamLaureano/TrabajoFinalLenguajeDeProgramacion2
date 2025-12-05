namespace TrabajoFinal
{
    partial class frmCargos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCargos));
            this.btnExportarCSV = new System.Windows.Forms.Button();
            this.btnCargar = new System.Windows.Forms.Button();
            this.dgvCargos = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.txtNombreCargo = new System.Windows.Forms.TextBox();
            this.IbINombre = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.IbIID = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarCSV.Image")));
            this.btnExportarCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCSV.Location = new System.Drawing.Point(310, 211);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(151, 42);
            this.btnExportarCSV.TabIndex = 21;
            this.btnExportarCSV.Text = "Exportar CVS";
            this.btnExportarCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // btnCargar
            // 
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCargar.Location = new System.Drawing.Point(54, 211);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(155, 42);
            this.btnCargar.TabIndex = 20;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // dgvCargos
            // 
            this.dgvCargos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCargos.Location = new System.Drawing.Point(12, 264);
            this.dgvCargos.Name = "dgvCargos";
            this.dgvCargos.Size = new System.Drawing.Size(465, 150);
            this.dgvCargos.TabIndex = 19;
            this.dgvCargos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCargos_CellContentClick);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpiar.Location = new System.Drawing.Point(393, 161);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(88, 44);
            this.btnLimpiar.TabIndex = 18;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(132, 161);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(96, 44);
            this.btnActualizar.TabIndex = 17;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(281, 161);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(87, 44);
            this.btnEliminar.TabIndex = 16;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(16, 161);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 44);
            this.btnAgregar.TabIndex = 15;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // txtNombreCargo
            // 
            this.txtNombreCargo.Location = new System.Drawing.Point(269, 69);
            this.txtNombreCargo.Name = "txtNombreCargo";
            this.txtNombreCargo.Size = new System.Drawing.Size(100, 20);
            this.txtNombreCargo.TabIndex = 14;
            // 
            // IbINombre
            // 
            this.IbINombre.AutoSize = true;
            this.IbINombre.Location = new System.Drawing.Point(266, 36);
            this.IbINombre.Name = "IbINombre";
            this.IbINombre.Size = new System.Drawing.Size(47, 13);
            this.IbINombre.TabIndex = 13;
            this.IbINombre.Text = "Nombre:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(89, 69);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 12;
            // 
            // IbIID
            // 
            this.IbIID.AutoSize = true;
            this.IbIID.Location = new System.Drawing.Point(86, 36);
            this.IbIID.Name = "IbIID";
            this.IbIID.Size = new System.Drawing.Size(21, 13);
            this.IbIID.TabIndex = 11;
            this.IbIID.Text = "ID:";
            // 
            // frmCargos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(481, 426);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dgvCargos);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreCargo);
            this.Controls.Add(this.IbINombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.IbIID);
            this.ForeColor = System.Drawing.Color.Black;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCargos";
            this.Text = "frmCargos";
            this.Load += new System.EventHandler(this.frmCargos_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCargos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExportarCSV;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.DataGridView dgvCargos;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtNombreCargo;
        private System.Windows.Forms.Label IbINombre;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label IbIID;
    }
}