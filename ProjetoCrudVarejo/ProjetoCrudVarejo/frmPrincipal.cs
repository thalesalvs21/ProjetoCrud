using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoCrudVarejo
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void cadastroDeClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCliente c = new frmCliente();
            c.ShowDialog();
        }
    }
}
