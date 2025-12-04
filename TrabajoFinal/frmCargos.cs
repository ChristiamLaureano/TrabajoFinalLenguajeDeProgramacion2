using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class frmCargos : Form
    {

        GestionDePersonalEntities2 db = new GestionDePersonalEntities2();

        public frmCargos()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void frmCargos_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            dgvCargos.DataSource = db.Cargos
                .OrderBy(c => c.CargoID)
                .Select(c => new
                {
                    c.CargoID,
                    c.NombreCargo
                })
                .ToList();
        }

        private void CargarEmpleadosPorCargo()
        {
            var consulta = db.Empleados
                .GroupBy(e => e.CargoID)
                .Select(g => new
                {
                    Cargo = db.Cargos
                              .Where(c => c.CargoID == g.Key)
                              .Select(c => c.NombreCargo)
                              .FirstOrDefault(),

                    CantidadEmpleados = g.Count()
                })
                .OrderByDescending(x => x.CantidadEmpleados)
                .ToList();

            dgvCargos.DataSource = consulta;
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                CargarDatos();
                MessageBox.Show("Datos cargados correctamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar datos: " + ex.Message);
            }
        }

        private void btnResumenPorCargo_Click(object sender, EventArgs e)
        {
            CargarEmpleadosPorCargo();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            try
            {
                int id = int.Parse(txtID.Text);
                Cargo cargo = db.Cargos.Find(id);

                if (cargo == null)
                {
                    MessageBox.Show("No existe");
                    return;
                }

                cargo.NombreCargo = txtNombreCargo.Text;
                db.SaveChanges();

                MessageBox.Show("Cargo actualizado");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtID.Text))
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }

            DialogResult r = MessageBox.Show("¿Eliminar este cargo?",
                                             "Confirmar",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

            if (r == DialogResult.No) return;

            try
            {
                int id = int.Parse(txtID.Text);
                Cargo cargo = db.Cargos.Find(id);

                if (cargo != null)
                {
                    db.Cargos.Remove(cargo);
                    db.SaveChanges();

                    MessageBox.Show("Cargo eliminado");
                    CargarDatos();
                    Limpiar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

       
        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombreCargo.Text))
            {
                MessageBox.Show("Debe escribir un nombre");
                return;
            }

            try
            {
                Cargo cargo = new Cargo
                {
                    NombreCargo = txtNombreCargo.Text.Trim()
                };

                db.Cargos.Add(cargo);
                db.SaveChanges();

                MessageBox.Show("Cargo agregado");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar: " + ex.Message);
            }
        }

        private void dgvCargos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dgvCargos.Columns.Contains("CargoID"))
            {
                DataGridViewRow fila = dgvCargos.Rows[e.RowIndex];

                txtID.Text = fila.Cells["CargoID"].Value.ToString();
                txtNombreCargo.Text = fila.Cells["NombreCargo"].Value.ToString();
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void Limpiar()
        {
            txtID.Clear();
            txtNombreCargo.Clear();
            txtNombreCargo.Focus();
        }

        // ================= EXPORT CSV =================
        private void btnExportarCSV_Click(object sender, EventArgs e)
        {
            if (dgvCargos.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos para exportar");
                return;
            }

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Archivo CSV (*.csv)|*.csv";
            sfd.FileName = "Cargos.csv";

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (StreamWriter sw = new StreamWriter(sfd.FileName))
                    {
                        for (int i = 0; i < dgvCargos.Columns.Count; i++)
                        {
                            sw.Write(dgvCargos.Columns[i].HeaderText);
                            if (i < dgvCargos.Columns.Count - 1)
                                sw.Write(",");
                        }
                        sw.WriteLine();

                        foreach (DataGridViewRow fila in dgvCargos.Rows)
                        {
                            if (!fila.IsNewRow)
                            {
                                for (int i = 0; i < dgvCargos.Columns.Count; i++)
                                {
                                    sw.Write(fila.Cells[i].Value?.ToString());
                                    if (i < dgvCargos.Columns.Count - 1)
                                        sw.Write(",");
                                }
                                sw.WriteLine();
                            }
                        }
                    }

                    MessageBox.Show("Archivo exportado correctamente ✅");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al exportar: " + ex.Message);
                }
            }
        }

    }
}
