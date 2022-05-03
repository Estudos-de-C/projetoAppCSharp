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
    public partial class frmEstoque : Form
    {
        public frmEstoque()
        {
            InitializeComponent();

            gbDados.Enabled = false; //inabilita o grupo de dados
        }

        private void tabelaProdutosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoFarmaciaDBDataSet);

            gbDados.Enabled = false; //inabilita o grupo de dados

            //gera msg para usuário
            MessageBox.Show("Dados salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'aplicativoFarmaciaDBDataSet.tabelaProdutos'. Você pode movê-la ou removê-la conforme necessário.
            this.tabelaProdutosTableAdapter.Fill(this.aplicativoFarmaciaDBDataSet.tabelaProdutos);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
            gbDados.Enabled = true; //habilita o grupo de dados
        }

        private void tsbEditar_Click(object sender, EventArgs e)
        {
            gbDados.Enabled = true; //habilita o grupo de dados
        }

        private void tsbBloquear_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoFarmaciaDBDataSet);

            gbDados.Enabled = false; //inabilita o grupo de dados

            //gera msg para usuário
            MessageBox.Show("Dados salvos com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void bindingNavigatorDeleteItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabelaProdutosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.aplicativoFarmaciaDBDataSet);

            gbDados.Enabled = false; //inabilita o grupo de dados

            //gera msg para usuário
            MessageBox.Show("Dados apagados com sucesso!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
