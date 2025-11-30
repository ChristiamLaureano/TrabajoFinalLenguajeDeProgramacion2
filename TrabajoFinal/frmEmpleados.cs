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
        GestionDePersonalEntities db = new GestionDePersonalEntities();

        public frmEmpleados()
        {
            InitializeComponent();
        }

        private void frmEmpleados_Load(object sender, EventArgs e)
        {
            CargarDepartamentos();
            CargarCargos();
            CargarEmpleados();
            cboEstado.Items.Add("Vigente");
            cboEstado.Items.Add("No Vigente");
        }

        private void CargarDepartamentos()
        {
           
        }

        private void CargarDeparmentos()
        {
            cboDepartamento.DataSource = db.Departamentos.ToList();
            cboDepartamento.DisplayMember = "NombreDepartamento";
            cboDepartamento.ValueMember = "DepartamentoID";
        }


        private void CargarCargos()
        {
            cboCargo.DataSource = db.Cargos.ToList();
            cboCargo.DisplayMember = "NombreCargo";
            cboCargo.ValueMember = "CargoID";
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
                Empleado emp = new Empleado();

                emp.NombreEmpleado = txtNombre.Text;
                emp.DepartamentoID = (int)cboDepartamento.SelectedValue;
                emp.CargoID = (int)cboCargo.SelectedValue;
                emp.FechaInicio = dtpFecha.Value;
                emp.Salario = Convert.ToDecimal(txtSalario.Text);
                emp.Estado = cboEstado.Text == "vigente";


                CalcularNomina(emp);

                db.Empleados.Add(emp);
                db.SaveChanges();

                MessageBox.Show("Empleado guardado Correctamente");
                CargarEmpleados();
                Limpiar();

            }
            catch(Exception ex)
            { 
                MessageBox.Show("Error al Guardar" + ex.Message);
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
            try
            {
                int id = int.Parse(txtEmpleadoID.Text);
                var emp = db.Empleados.Find(id);

                emp.NombreEmpleado = txtNombre.Text;
                emp.DepartamentoID = (int)cboDepartamento.SelectedValue;
                emp.CargoID = (int)cboCargo.SelectedValue;
                emp.FechaInicio = dtpFecha.Value;
                emp.Salario = Convert.ToDecimal(txtSalario.Text);
                emp.Estado = cboEstado.Text == "Vigente";

                CalcularNomina(emp);
                db.SaveChanges();

                MessageBox.Show("Empleado actulizado");
                CargarEmpleados();
                Limpiar();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtEmpleadoID.Text);
                var emp = db.Empleados.Find(id);
                db.Empleados.Remove(emp);
                db.SaveChanges();
                MessageBox.Show("Empleado eliminado");
                CargarEmpleados();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:" + ex.Message);
            }
        }

        private void dgvEmpleados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow fila = dgvEmpleados.CurrentRow;

            txtEmpleadoID.Text = fila.Cells["EmpleadoID"].Value.ToString();
            txtNombre.Text = fila.Cells["NombreEmpleado"].Value.ToString();
            cboDepartamento.Text = fila.Cells["NombreDepartamento"].Value.ToString();
            cboCargo.Text = fila.Cells["NombreCargo"].Value.ToString();
            dtpFecha.Value = Convert.ToDateTime(fila.Cells["FechaInicio"].Value);
            txtSalario.Text = fila.Cells["Salario"].Value.ToString();
            cboEstado.Text = fila.Cells["Estado"].Value.ToString();
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

    }

}
