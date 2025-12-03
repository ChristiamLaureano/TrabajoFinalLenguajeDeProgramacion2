namespace TrabajoFinal
{
    partial class frmNomina
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
            this.dgvNomina = new System.Windows.Forms.DataGridView();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnGuardarNomina = new System.Windows.Forms.Button();
            this.btnCalcularNomina = new System.Windows.Forms.Button();
            this.groupCalculos = new System.Windows.Forms.GroupBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtISR = new System.Windows.Forms.TextBox();
            this.txtARS = new System.Windows.Forms.TextBox();
            this.txtSalarioNeto = new System.Windows.Forms.TextBox();
            this.txtAFP = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupDatos = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dtFechaNomina = new System.Windows.Forms.DateTimePicker();
            this.cboEmpleado = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSalarioNomina = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTiempo = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).BeginInit();
            this.groupCalculos.SuspendLayout();
            this.groupDatos.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvNomina
            // 
            this.dgvNomina.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNomina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNomina.Location = new System.Drawing.Point(12, 300);
            this.dgvNomina.Name = "dgvNomina";
            this.dgvNomina.ReadOnly = true;
            this.dgvNomina.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvNomina.Size = new System.Drawing.Size(612, 208);
            this.dgvNomina.TabIndex = 19;
            // 
            // btnCargar
            // 
            this.btnCargar.Location = new System.Drawing.Point(23, 256);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(601, 38);
            this.btnCargar.TabIndex = 18;
            this.btnCargar.Text = "Cargar Datos";
            this.btnCargar.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Location = new System.Drawing.Point(516, 203);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(108, 38);
            this.btnExportar.TabIndex = 17;
            this.btnExportar.Text = "Exportar CSV";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnGuardarNomina
            // 
            this.btnGuardarNomina.Location = new System.Drawing.Point(516, 99);
            this.btnGuardarNomina.Name = "btnGuardarNomina";
            this.btnGuardarNomina.Size = new System.Drawing.Size(102, 38);
            this.btnGuardarNomina.TabIndex = 15;
            this.btnGuardarNomina.Text = "Guardar Nómina";
            this.btnGuardarNomina.UseVisualStyleBackColor = true;
            // 
            // btnCalcularNomina
            // 
            this.btnCalcularNomina.Location = new System.Drawing.Point(516, 23);
            this.btnCalcularNomina.Name = "btnCalcularNomina";
            this.btnCalcularNomina.Size = new System.Drawing.Size(108, 38);
            this.btnCalcularNomina.TabIndex = 14;
            this.btnCalcularNomina.Text = "Calcular Nómina";
            this.btnCalcularNomina.UseVisualStyleBackColor = true;
            // 
            // groupCalculos
            // 
            this.groupCalculos.Controls.Add(this.label4);
            this.groupCalculos.Controls.Add(this.txtTiempo);
            this.groupCalculos.Controls.Add(this.label12);
            this.groupCalculos.Controls.Add(this.label11);
            this.groupCalculos.Controls.Add(this.label10);
            this.groupCalculos.Controls.Add(this.txtISR);
            this.groupCalculos.Controls.Add(this.txtARS);
            this.groupCalculos.Controls.Add(this.txtSalarioNeto);
            this.groupCalculos.Controls.Add(this.txtAFP);
            this.groupCalculos.Controls.Add(this.label9);
            this.groupCalculos.Location = new System.Drawing.Point(23, 118);
            this.groupCalculos.Name = "groupCalculos";
            this.groupCalculos.Size = new System.Drawing.Size(487, 132);
            this.groupCalculos.TabIndex = 12;
            this.groupCalculos.TabStop = false;
            this.groupCalculos.Text = "Deducciones";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(166, 79);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 13);
            this.label12.TabIndex = 8;
            this.label12.Text = "Salario Neto";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 75);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(25, 13);
            this.label11.TabIndex = 7;
            this.label11.Text = "ISR";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(166, 22);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 13);
            this.label10.TabIndex = 6;
            this.label10.Text = "ARS";
            // 
            // txtISR
            // 
            this.txtISR.Location = new System.Drawing.Point(9, 91);
            this.txtISR.Name = "txtISR";
            this.txtISR.ReadOnly = true;
            this.txtISR.Size = new System.Drawing.Size(100, 20);
            this.txtISR.TabIndex = 4;
            // 
            // txtARS
            // 
            this.txtARS.Location = new System.Drawing.Point(166, 41);
            this.txtARS.Name = "txtARS";
            this.txtARS.ReadOnly = true;
            this.txtARS.Size = new System.Drawing.Size(100, 20);
            this.txtARS.TabIndex = 3;
            // 
            // txtSalarioNeto
            // 
            this.txtSalarioNeto.Location = new System.Drawing.Point(166, 95);
            this.txtSalarioNeto.Name = "txtSalarioNeto";
            this.txtSalarioNeto.ReadOnly = true;
            this.txtSalarioNeto.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNeto.TabIndex = 2;
            // 
            // txtAFP
            // 
            this.txtAFP.Location = new System.Drawing.Point(9, 41);
            this.txtAFP.Name = "txtAFP";
            this.txtAFP.ReadOnly = true;
            this.txtAFP.Size = new System.Drawing.Size(100, 20);
            this.txtAFP.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "AFP";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(87, -70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(527, 55);
            this.label1.TabIndex = 11;
            this.label1.Text = "Formulario Empleados";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // groupDatos
            // 
            this.groupDatos.Controls.Add(this.label3);
            this.groupDatos.Controls.Add(this.txtSalarioNomina);
            this.groupDatos.Controls.Add(this.label2);
            this.groupDatos.Controls.Add(this.cboEmpleado);
            this.groupDatos.Controls.Add(this.dtFechaNomina);
            this.groupDatos.Controls.Add(this.label6);
            this.groupDatos.Location = new System.Drawing.Point(23, 20);
            this.groupDatos.Name = "groupDatos";
            this.groupDatos.Size = new System.Drawing.Size(487, 92);
            this.groupDatos.TabIndex = 10;
            this.groupDatos.TabStop = false;
            this.groupDatos.Text = "Datos del Empleado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(286, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(37, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fecha";
            // 
            // dtFechaNomina
            // 
            this.dtFechaNomina.Location = new System.Drawing.Point(281, 44);
            this.dtFechaNomina.Name = "dtFechaNomina";
            this.dtFechaNomina.Size = new System.Drawing.Size(200, 20);
            this.dtFechaNomina.TabIndex = 9;
            // 
            // cboEmpleado
            // 
            this.cboEmpleado.FormattingEnabled = true;
            this.cboEmpleado.Location = new System.Drawing.Point(24, 41);
            this.cboEmpleado.Name = "cboEmpleado";
            this.cboEmpleado.Size = new System.Drawing.Size(121, 21);
            this.cboEmpleado.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Empleado";
            // 
            // txtSalarioNomina
            // 
            this.txtSalarioNomina.Location = new System.Drawing.Point(167, 44);
            this.txtSalarioNomina.Name = "txtSalarioNomina";
            this.txtSalarioNomina.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioNomina.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(164, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Salario";
            // 
            // txtTiempo
            // 
            this.txtTiempo.Location = new System.Drawing.Point(289, 95);
            this.txtTiempo.Name = "txtTiempo";
            this.txtTiempo.ReadOnly = true;
            this.txtTiempo.Size = new System.Drawing.Size(145, 20);
            this.txtTiempo.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(289, 79);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(129, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tiempo Laborado (meses)";
            // 
            // frmNomina
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 545);
            this.Controls.Add(this.dgvNomina);
            this.Controls.Add(this.btnCargar);
            this.Controls.Add(this.btnExportar);
            this.Controls.Add(this.btnGuardarNomina);
            this.Controls.Add(this.btnCalcularNomina);
            this.Controls.Add(this.groupCalculos);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupDatos);
            this.Name = "frmNomina";
            this.Text = "frmNomina";
            ((System.ComponentModel.ISupportInitialize)(this.dgvNomina)).EndInit();
            this.groupCalculos.ResumeLayout(false);
            this.groupCalculos.PerformLayout();
            this.groupDatos.ResumeLayout(false);
            this.groupDatos.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvNomina;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.Button btnGuardarNomina;
        private System.Windows.Forms.Button btnCalcularNomina;
        private System.Windows.Forms.GroupBox groupCalculos;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtISR;
        private System.Windows.Forms.TextBox txtARS;
        private System.Windows.Forms.TextBox txtSalarioNeto;
        private System.Windows.Forms.TextBox txtAFP;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupDatos;
        private System.Windows.Forms.DateTimePicker dtFechaNomina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboEmpleado;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSalarioNomina;
        private System.Windows.Forms.TextBox txtTiempo;
        private System.Windows.Forms.Label label4;
    }
}