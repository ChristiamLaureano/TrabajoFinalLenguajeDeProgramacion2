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
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            IsMdiContainer = true;   
        }

        private void AbrirFormulario(Form form)
        {
            foreach (Form f in MdiChildren)
            {
                if (f.GetType() == form.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            form.MdiParent = this;
            form.Show();

        }
            


        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }


       
        private void departamenoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmDepartamentos());
        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmCargos());
        }

        private void empleadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new frmEmpleados());
        }
    }
}
