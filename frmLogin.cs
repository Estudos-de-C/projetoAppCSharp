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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        //Evento relacionado ao btnEntrar para entrar no formulário da aplicação
        private void btnEntrar_Click(object sender, EventArgs e)
        {
            if ((txtUsuario.Text == "Fábio Leonel") && (txtSenha.Text == "abc456"))
            {
                this.Visible = false; //deixa o frmLogin invisível

                frmPrincipal frmP = new frmPrincipal(); //transforma meu frmPrincipal em objeto e instancia

                frmP.Show(); //pega o objeto instancioado e abre

                txtUsuario.Clear();
                txtSenha.Clear();
            }
            else
            {
                MessageBox.Show("Usuário e/ou senha incorretos! Por favor, preencha novamente", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                txtUsuario.Clear();
                txtSenha.Clear();
            }
        }
    }
}
