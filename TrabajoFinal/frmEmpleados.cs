using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class frmEmpleados : Form

    {



        GestionDePersonalEntities2 db = new GestionDePersonalEntities2();

        public frmEmpleados()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Dock = DockStyle.None;
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
            CargarCargos();
            CargarEmpleados();

            cboEstado.Items.Clear();
            cboEstado.Items.Add("Vigente");
            cboEstado.Items.Add("No Vigente");
        }

        private void CargarDepartamentos()
        {
            var datos = db.Departamentos.ToList();

            var bs = new BindingSource();
            bs.DataSource = datos;

            cboDepartamento.DataSource = null;
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "DepartamentoID";
            cboDepartamento.DataSource = bs;

            if (datos.Count > 0) cboDepartamento.SelectedIndex = 0;
        }

        private void CargarDeparmentos()
        {
            cboDepartamento.DataSource = db.Departamentos.ToList();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "DepartamentoID";
            cboDepartamento.SelectedIndex = -1;
        }


        private void CargarCargos()
        {
            var datos = db.Cargos.ToList();

            var bs = new BindingSource();
            bs.DataSource = datos;

            cboCargo.DataSource = null;
            cboCargo.DisplayMember = "NombreCargo";
            cboCargo.ValueMember = "CargoID";
            cboCargo.DataSource = bs;

            if (datos.Count > 0) cboCargo.SelectedIndex = 0;
        }
      
        private void CargarEmpleados()
        {
            var lista = (from e in db.Empleados
                         join d in db.Departamentos on e.DepartamentoID equals d.DepartamentoID
                         join c in db.Cargos on e.CargoID equals c.CargoID
                         select new
                         {
                             e.EmpleadoID,
                             e.NombreEmpleado,
                             Departamento = d.NombreDepartamento,
                             Cargo = c.NombreCargo,
                             e.FechaInicio,
                             e.Salario,
                             Estado = e.Estado ? "Vigente" : "No Vigente"
                         }).ToList();

            dgvEmpleados.DataSource = lista;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {


            try
            {
                if (cboDepartamento.SelectedValue == null || cboCargo.SelectedValue == null)
                {
                    MessageBox.Show("Seleccione Departamento y Cargo");
                    return;
                }

                if (!decimal.TryParse(txtSalario.Text, out decimal salario))
                {
                    MessageBox.Show("Ingrese un salario válido");
                    return;
                }

                DialogResult r = MessageBox.Show(
                 "¿Desea guardar este empleado con estos descuentos?\n\n" +
                 $"AFP: {txtAFP.Text}\n" +
                 $"ARS: {txtARS.Text}\n" +
                 $"ISR: {txtISR.Text}\n" +
                 $"Neto: {txtNeto.Text}",
                 "Confirmación",
                 MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question
                );

                if (r == DialogResult.No)
                    return;

                Empleado emp = new Empleado();

                emp.NombreEmpleado = txtNombre.Text;
                emp.DepartamentoID = (int)cboDepartamento.SelectedValue;
                emp.CargoID = (int)cboCargo.SelectedValue;
                emp.FechaInicio = dtpFecha.Value;
                emp.Salario = salario;
                emp.Estado = cboEstado.Text == "Vigente";

                CalcularNomina(emp);

                db.Empleados.Add(emp);
                db.SaveChanges();

                MessageBox.Show("Empleado guardado correctamente");
                CargarEmpleados();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }

        }

        private void CalcularNomina(Empleado emp)
        {
            decimal salario = emp.Salario;

            // calculos segun Salarios del pais
            decimal afp = salario * 0.0287M;
            decimal ars = salario * 0.0304M;

            decimal isr = CalcularISR(salario);

            emp.AFP = afp;
            emp.ARS = ars;
            emp.ISR = isr;

            txtAFP.Text = salario.ToString("N2");
            txtARS.Text = ars.ToString("N2");
            txtISR.Text = isr.ToString("N2");
            txtNeto.Text = (salario - afp - ars - isr).ToString("N2");

        
        }

        private decimal CalcularISR(decimal salario)
        {
            if (salario <= 34685) return 0;
            else if (salario <= 52027) return (salario - 34685) * 0.15M;
            else if (salario <= 72260) return ((52027 - 34685) * 0.15M) + ((salario - 52027) * 0.20m);
            else return ((52027 - 34685) * 0.15M) + ((72260 - 52027) * 0.20M) + ((salario - 72260) * -0.25M);
        }

        private string CalcularTiempo(DateTime fecha)
        {
            var hoy = DateTime.Now;
            int años = hoy.Year - fecha.Year;
            int meses = hoy.Month - fecha.Month;   
            if (meses < 0)
            {
                años--;
                meses += 12;
            }
            return $"{años} años y {meses} meses";
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpleadoID.Text))
            {
                MessageBox.Show("Seleccione un registro primero");
                return;
            }

            try
            {
                int id = Convert.ToInt32(txtEmpleadoID.Text);
                var emp = db.Empleados.Find(id);

                if (emp == null)
                {
                    MessageBox.Show("Empleado no encontrado");
                    return;
                }

                emp.NombreEmpleado = txtNombre.Text;
                emp.DepartamentoID = (int)cboDepartamento.SelectedValue;
                emp.CargoID = (int)cboCargo.SelectedValue;
                emp.FechaInicio = dtpFecha.Value;
                emp.Salario = Convert.ToDecimal(txtSalario.Text);
                emp.Estado = cboEstado.Text == "Activo" || cboEstado.Text == "Vigente";

                CalcularNomina(emp);
                db.SaveChanges();

                MessageBox.Show("Registro actualizado correctamente");
                CargarEmpleados();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtEmpleadoID.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult r = MessageBox.Show("¿Eliminar este empleado?", "Confirmar", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (r == DialogResult.No) return;

            try
            {
                int id = Convert.ToInt32(txtEmpleadoID.Text);
                var emp = db.Empleados.Find(id);

                if (emp != null)
                {
                    db.Empleados.Remove(emp);
                    db.SaveChanges();

                    MessageBox.Show("Empleado eliminado");
                    CargarEmpleados();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow fila = dgvEmpleados.Rows[e.RowIndex];

                txtEmpleadoID.Text = fila.Cells["EmpleadoID"].Value.ToString();
                txtNombre.Text = fila.Cells["NombreEmpleado"].Value.ToString();
                cboDepartamento.Text = fila.Cells["Departamento"].Value.ToString();
                cboCargo.Text = fila.Cells["Cargo"].Value.ToString();
                dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);
                txtSalario.Text = fila.Cells["Salario"].Value.ToString();
                cboEstado.Text = fila.Cells["Estado"].Value.ToString();
            }
        }

        private void Limpiar()
        {
            txtEmpleadoID.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
            txtAFP.Clear();
            txtARS.Clear();
            txtISR.Clear();
            txtNeto.Clear();
            txtTiempo.Clear();
        }

        private void txtSalario_TextChanged(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtSalario.Text, out decimal salario))
            {
                CalcularVistaNomina(salario);
            }
            else
            {

                txtAFP.Clear();
                txtARS.Clear();
                txtISR.Clear();
                txtNeto.Clear();
                txtTiempo.Clear();
            }
        }

        private void CalcularVistaNomina(decimal salario)
        {
            decimal afp = salario * 0.0287M;
            decimal ars = salario * 0.0304M;
            decimal isr = CalcularISR(salario);

            txtAFP.Text = afp.ToString("N2");
            txtARS.Text = ars.ToString("N2");
            txtISR.Text = isr.ToString("N2");
            txtNeto.Text = (salario - afp - ars - isr).ToString("N2");

            txtTiempo.Text = CalcularTiempo(dtpFecha.Value);
        }

        private void cboDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnExportar_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV (*.csv)|*.csv";
            sfd.Title = "Guardar archivo CSV";
            sfd.FileName = "Empleados.csv";

            if (sfd.ShowDialog() != DialogResult.OK)
                return;

            StringBuilder contenido = new StringBuilder();

            // Encabezados
            for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
            {
                contenido.Append(dgvEmpleados.Columns[i].HeaderText);
                if (i < dgvEmpleados.Columns.Count - 1)
                    contenido.Append(",");
            }
            contenido.AppendLine();

            // Filas
            foreach (DataGridViewRow fila in dgvEmpleados.Rows)
            {
                if (!fila.IsNewRow)
                {
                    for (int i = 0; i < dgvEmpleados.Columns.Count; i++)
                    {
                        contenido.Append(fila.Cells[i].Value?.ToString());
                        if (i < dgvEmpleados.Columns.Count - 1)
                            contenido.Append(",");
                    }
                    contenido.AppendLine();
                }
            }

           
            System.IO.File.WriteAllText(sfd.FileName, contenido.ToString(), Encoding.UTF8);

            MessageBox.Show("Datos exportados correctamente", "Exportación CSV", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
           CargarEmpleados();
        }

        private void txtEmpleadoID_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void groupDatos_Enter(object sender, EventArgs e)
        {

        }
    }

}
