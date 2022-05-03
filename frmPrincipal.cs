using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace primeiroApp
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            frmCalculoIMC frmIMC = new frmCalculoIMC();
            frmIMC.Show();
        }

        private void btnEstoque_Click(object sender, EventArgs e)
        {
            frmEstoque frmE = new frmEstoque();
            frmE.Show();
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
