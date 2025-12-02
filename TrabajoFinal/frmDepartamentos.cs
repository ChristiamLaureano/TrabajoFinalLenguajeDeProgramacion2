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
                    var lista = db.Departamentos.ToList();
                    MessageBox.Show("Registros encontrados: " + lista.Count);
                    dvgDepartamentos.DataSource = lista;
            }
                catch (Exception ex) 
                {
                    MessageBox.Show("Error al agregar:/n" + ex.Message);

                
            }


        }


        private void btnAgregar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtNombreDepartamento.Text))
                {
                    MessageBox.Show("Debe Escribir un nombre.");
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
                MessageBox.Show("Error al agregar:" + ex.Message);
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

                MessageBox.Show("Departamento actualizado");
                CargarDatos();
                Limpiar();


            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar:" + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse (txtID.Text);
                var dep = db.Departamentos.Find(id);

                if (dep == null)
                {
                    MessageBox.Show("El ID no existe.");
                    return; 

                }

                db.Departamentos.Remove(dep);
                db.SaveChanges();

                MessageBox.Show("Deparmentos eliminado.");
                CargarDatos();
                Limpiar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar." + ex.Message );
            }

        }

        private void Limpiar ()
        {
            txtID.Clear();
            txtNombreDepartamento.Clear();
            txtNombreDepartamento.Focus();
        }

        private void dvgDepartamentos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtID.Text = dvgDepartamentos.Rows[e.RowIndex].Cells["DepartamentoID"].Value.ToString();
                txtNombreDepartamento.Text = dvgDepartamentos.Rows[e.RowIndex].Cells["NombreDepartamento"].Value.ToString();
            }
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            CargarDatos();
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
                  
                    sw.WriteLine("DepartamentoID,NombreDepartamento");

                    foreach (var dep in db.Departamentos)
                    {
                        sw.WriteLine($"{dep.DepartamentoID},{dep.NombreDepartamento}");
                    }
                }

                MessageBox.Show("Exportado correctamente.");
            }
        }

        private void frmDepartamentos_Load_1(object sender, EventArgs e)
        {

        }
    }
}
