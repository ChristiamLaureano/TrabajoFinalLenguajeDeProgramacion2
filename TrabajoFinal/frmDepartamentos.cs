using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using DepartamentoEntity = TrabajoFinal.Departamento;

namespace TrabajoFinal
{
    public partial class frmDepartamentos : Form
    {
        GestionDePersonalEntities2 db = new GestionDePersonalEntities2();

        public frmDepartamentos()
        {
            InitializeComponent();
        }

        private void frmDepartamentos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            try
            {
                var lista = db.Departamentos
                              .Select(d => new
                              {
                                  d.DepartamentoID,
                                  d.NombreDepartamento
                              })
                              .ToList();

                dvgDepartamentos.DataSource = lista;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar departamentos:\n" + ex.Message);
            }
        }

        private void CargarEmpleadosPorDepartamento()
        {
            var consulta = db.Empleados
                .GroupBy(e => e.DepartamentoID)
                .Select(g => new
                {
                    Departamento = db.Departamentos
                                     .Where(d => d.DepartamentoID == g.Key)
                                     .Select(d => d.NombreDepartamento)
                                     .FirstOrDefault(),

                    CantidadEmpleados = g.Count()
                })
                .OrderByDescending(x => x.CantidadEmpleados)
                .ToList();

            dvgDepartamentos.DataSource = consulta;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnEmpleadosPorDepartamento_Click(object sender, EventArgs e)
        {
            CargarEmpleadosPorDepartamento();
        }

        
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                {
                    MessageBox.Show("Debe escribir un nombre.");
                    return;
                }

                DepartamentoEntity dep = new DepartamentoEntity
                {
                    NombreDepartamento = txtNombreDepartamento.Text
                };

                db.Departamentos.Add(dep);
                db.SaveChanges();

                MessageBox.Show("Departamento agregado.");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al agregar:\n" + ex.Message);
            }
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var dep = db.Departamentos.Find(id);

                if (dep == null)
                {
                    MessageBox.Show("El ID no existe.");
                    return;
                }

                dep.NombreDepartamento = txtNombreDepartamento.Text;
                db.SaveChanges();

                MessageBox.Show("Departamento actualizado.");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:\n" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(txtID.Text);
                var dep = db.Departamentos.Find(id);

                if (dep == null)
                {
                    MessageBox.Show("El ID no existe.");
                    return;
                }

                db.Departamentos.Remove(dep);
                db.SaveChanges();

                MessageBox.Show("Departamento eliminado.");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar:\n" + ex.Message);
            }
        }

        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "CSV (*.csv)|*.csv";
            save.FileName = "Departamentos.csv";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (StreamWriter sw = new StreamWriter(save.FileName))
                {
                    foreach (DataGridViewColumn col in dvgDepartamentos.Columns)
                        sw.Write(col.HeaderText + ",");

                    sw.WriteLine();

                    foreach (DataGridViewRow row in dvgDepartamentos.Rows)
                    {
                        if (!row.IsNewRow)
                        {
                            for (int i = 0; i < dvgDepartamentos.Columns.Count; i++)
                                sw.Write(row.Cells[i].Value + ",");

                            sw.WriteLine();
                        }
                    }
                }

                MessageBox.Show("Exportado correctamente.");
            }
        }

        private void dvgDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dvgDepartamentos.Columns.Contains("DepartamentoID"))
            {
                txtID.Text = dvgDepartamentos.Rows[e.RowIndex].Cells["DepartamentoID"].Value.ToString();
                txtNombreDepartamento.Text = dvgDepartamentos.Rows[e.RowIndex].Cells["NombreDepartamento"].Value.ToString();
            }
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtNombreDepartamento.Clear();
            txtNombreDepartamento.Focus();
        }
    }
}
