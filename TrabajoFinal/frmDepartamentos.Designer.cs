namespace TrabajoFinal
{
    partial class frmDepartamentos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDepartamentos));
            System.Windows.Forms.Button btnLimpiar;
            this.IbIID = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.IbINombre = new System.Windows.Forms.Label();
            this.txtNombreDepartamento = new System.Windows.Forms.TextBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.dvgDepartamentos = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnExportarCSV = new System.Windows.Forms.Button();
            btnLimpiar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDepartamentos)).BeginInit();
            this.SuspendLayout();
            // 
            // IbIID
            // 
            this.IbIID.AutoSize = true;
            this.IbIID.Location = new System.Drawing.Point(57, 65);
            this.IbIID.Name = "IbIID";
            this.IbIID.Size = new System.Drawing.Size(21, 13);
            this.IbIID.TabIndex = 0;
            this.IbIID.Text = "ID:";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(58, 98);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 1;
            // 
            // IbINombre
            // 
            this.IbINombre.AutoSize = true;
            this.IbINombre.Location = new System.Drawing.Point(253, 65);
            this.IbINombre.Name = "IbINombre";
            this.IbINombre.Size = new System.Drawing.Size(47, 13);
            this.IbINombre.TabIndex = 2;
            this.IbINombre.Text = "Nombre:";
            // 
            // txtNombreDepartamento
            // 
            this.txtNombreDepartamento.Location = new System.Drawing.Point(256, 98);
            this.txtNombreDepartamento.Name = "txtNombreDepartamento";
            this.txtNombreDepartamento.Size = new System.Drawing.Size(100, 20);
            this.txtNombreDepartamento.TabIndex = 3;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Image = ((System.Drawing.Image)(resources.GetObject("btnAgregar.Image")));
            this.btnAgregar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAgregar.Location = new System.Drawing.Point(3, 190);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(110, 44);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Image = ((System.Drawing.Image)(resources.GetObject("btnEliminar.Image")));
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEliminar.Location = new System.Drawing.Point(243, 190);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(96, 44);
            this.btnEliminar.TabIndex = 5;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnActualizar
            // 
            this.btnActualizar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnActualizar.Image = ((System.Drawing.Image)(resources.GetObject("btnActualizar.Image")));
            this.btnActualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnActualizar.Location = new System.Drawing.Point(119, 190);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(98, 44);
            this.btnActualizar.TabIndex = 6;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // btnLimpiar
            // 
            btnLimpiar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpiar.Image")));
            btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            btnLimpiar.Location = new System.Drawing.Point(357, 190);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new System.Drawing.Size(95, 44);
            btnLimpiar.TabIndex = 7;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // dvgDepartamentos
            // 
            this.dvgDepartamentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDepartamentos.Location = new System.Drawing.Point(3, 298);
            this.dvgDepartamentos.Name = "dvgDepartamentos";
            this.dvgDepartamentos.Size = new System.Drawing.Size(449, 150);
            this.dvgDepartamentos.TabIndex = 8;
            this.dvgDepartamentos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dvgDepartamentos_CellContentClick);
            // 
            // btnCargar
            // 
            this.btnCargar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCargar.Image = ((System.Drawing.Image)(resources.GetObject("btnCargar.Image")));
            this.btnCargar.Location = new System.Drawing.Point(39, 240);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(166, 42);
            this.btnCargar.TabIndex = 9;
            this.btnCargar.Text = "Cargar";
            this.btnCargar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCargar.UseVisualStyleBackColor = true;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnExportarCSV
            // 
            this.btnExportarCSV.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExportarCSV.Image = ((System.Drawing.Image)(resources.GetObject("btnExportarCSV.Image")));
            this.btnExportarCSV.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnExportarCSV.Location = new System.Drawing.Point(256, 240);
            this.btnExportarCSV.Name = "btnExportarCSV";
            this.btnExportarCSV.Size = new System.Drawing.Size(170, 42);
            this.btnExportarCSV.TabIndex = 10;
            this.btnExportarCSV.Text = "Exportar CVS";
            this.btnExportarCSV.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnExportarCSV.UseVisualStyleBackColor = true;
            this.btnExportarCSV.Click += new System.EventHandler(this.btnExportarCSV_Click);
            // 
            // frmDepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(464, 450);
            this.Controls.Add(this.btnExportarCSV);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.dvgDepartamentos);
            this.Controls.Add(btnLimpiar);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.txtNombreDepartamento);
            this.Controls.Add(this.IbINombre);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.IbIID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmDepartamentos";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "frmDepartamentos";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDepartamentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label IbIID;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label IbINombre;
        private System.Windows.Forms.TextBox txtNombreDepartamento;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.DataGridView dvgDepartamentos;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExportarCSV;
    }
}