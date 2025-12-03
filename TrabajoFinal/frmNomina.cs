using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoFinal
{
    public partial class frmNomina : Form
    {

        GestionDePersonalEntities2 db = new GestionDePersonalEntities2();
        public frmNomina()
        {
            InitializeComponent();
        }

        private void CargarEmpleados()
        {
            cboEmpleado.DataSource = db.Empleados.ToList();
            cboEmpleado.DisplayMember = "NombreEmpleado";
            cboEmpleado.ValueMember = "EmpleadoID";
        }

        private void frmNomina_Load(object sender, EventArgs e)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }
    }
}
