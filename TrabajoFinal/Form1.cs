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

   
    public partial class frmPrincipal : Form
    {


        private void AbrirFormulario(Form frm) //--- Para abrir formulario MDI
        {
            foreach (Form f in this.MdiChildren)
            {
                if (f.GetType() == frm.GetType())
                {
                    f.Activate();
                    return;
                }
            }

            frm.MdiParent = this;
            frm.Show();
        }


        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void cargosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void gestiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

      
    }
}
