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
    public partial class frmCalculoIMC : Form
    {
        public frmCalculoIMC()
        {
            InitializeComponent();

            //inativa e deixa dos btn's dos graus com a cor cinza
            btnGrau0.Enabled = false;
            btnGrau0.BackColor = Color.LightGray;

            btnGrau0_0.Enabled = false;
            btnGrau0_0.BackColor = Color.LightGray;

            btnGrauI.Enabled = false;
            btnGrauI.BackColor = Color.LightGray;

            btnGrauII.Enabled = false;
            btnGrauII.BackColor = Color.LightGray;

            btnGrauIII.Enabled = false;
            btnGrauIII.BackColor = Color.LightGray; 
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            //limpa as txt's
            txtAltura.Clear();
            txtPeso.Clear();

            //reconfigura a label resultado
            lblResultado.Text = "Resultado calculado";

            //inativa e deixa dos btn's dos graus com a cor cinza
            btnGrau0.Enabled = false;
            btnGrau0.BackColor = Color.LightGray;

            btnGrau0_0.Enabled = false;
            btnGrau0_0.BackColor = Color.LightGray;

            btnGrauI.Enabled = false;
            btnGrauI.BackColor = Color.LightGray;

            btnGrauII.Enabled = false;
            btnGrauII.BackColor = Color.LightGray;

            btnGrauIII.Enabled = false;
            btnGrauIII.BackColor = Color.LightGray;
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if ((txtAltura.Text == "") || (txtPeso.Text == ""))
            {
                MessageBox.Show("Por favor, preencha os campos altura e peso com números!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                double altura, peso, resultado; //declara as variáveis

                //faz as conversões das txt's em doubles
                altura = Convert.ToDouble(txtAltura.Text);
                peso = Convert.ToDouble(txtPeso.Text);

                //realiza o cálculo do IMC
                resultado = peso / (altura * altura);

                //converte o resultado para a txt
                lblResultado.Text = resultado.ToString("N2"); //determina duas casas após a vírgula

                //condições de cálculos e respostas
                if (resultado < 18.5)
                {
                    btnGrau0.Enabled = true; //fica ativado
                    btnGrau0.BackColor = Color.White; //muda a cor

                    btnGrau0_0.Enabled = false;
                    btnGrau0_0.BackColor = Color.LightGray;

                    btnGrauI.Enabled = false;
                    btnGrauI.BackColor = Color.LightGray;

                    btnGrauII.Enabled = false;
                    btnGrauII.BackColor = Color.LightGray;

                    btnGrauIII.Enabled = false;
                    btnGrauIII.BackColor = Color.LightGray;
                }
                else if ((resultado >= 18.5) && (resultado <= 24.9))
                {
                    btnGrau0.Enabled = false;
                    btnGrau0.BackColor = Color.LightGray;

                    btnGrau0_0.Enabled = true; //fica ativado
                    btnGrau0_0.BackColor = Color.LightGreen; //muda a cor

                    btnGrauI.Enabled = false;
                    btnGrauI.BackColor = Color.LightGray;

                    btnGrauII.Enabled = false;
                    btnGrauII.BackColor = Color.LightGray;

                    btnGrauIII.Enabled = false;
                    btnGrauIII.BackColor = Color.LightGray;
                }
                else if ((resultado >= 25.0) && (resultado <= 29.9))
                {
                    btnGrau0.Enabled = false;
                    btnGrau0.BackColor = Color.LightGray;

                    btnGrau0_0.Enabled = false;
                    btnGrau0_0.BackColor = Color.LightGray;

                    btnGrauI.Enabled = true; //fica ativado
                    btnGrauI.BackColor = Color.Yellow; //muda a cor

                    btnGrauII.Enabled = false;
                    btnGrauII.BackColor = Color.LightGray;

                    btnGrauIII.Enabled = false;
                    btnGrauIII.BackColor = Color.LightGray;
                }
                else if ((resultado >= 30.0) && (resultado <= 39.9))
                {
                    btnGrau0.Enabled = false;
                    btnGrau0.BackColor = Color.LightGray;

                    btnGrau0_0.Enabled = false;
                    btnGrau0_0.BackColor = Color.LightGray;

                    btnGrauI.Enabled = false;
                    btnGrauI.BackColor = Color.LightGray;

                    btnGrauII.Enabled = true; //fica ativado
                    btnGrauII.BackColor = Color.Orange; //muda a cor

                    btnGrauIII.Enabled = false;
                    btnGrauIII.BackColor = Color.LightGray;
                }
                else if (resultado >= 40.0)
                {
                    btnGrau0.Enabled = false;
                    btnGrau0.BackColor = Color.LightGray;

                    btnGrau0_0.Enabled = false;
                    btnGrau0_0.BackColor = Color.LightGray;

                    btnGrauI.Enabled = false;
                    btnGrauI.BackColor = Color.LightGray;

                    btnGrauII.Enabled = false;
                    btnGrauII.BackColor = Color.LightGray;

                    btnGrauIII.Enabled = true; //fica ativado
                    btnGrauIII.BackColor = Color.Red; //muda a cor
                }
            }
        }

        //eventos dos botões referentes aos graus
        private void btnGrau0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você possui o grau '0' - magreza. Procure o seu médico!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
       
        private void btnGrau0_0_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você possui o grau '0' - normal. Parabéns! Mantenha os cuidados alimentares!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrauI_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você possui o grau 'I' - sobrepeso. E isso merece a atenção do médico ou nutricionista!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrauII_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você possui o grau 'II' - obesidade. Procure o seu médico!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnGrauIII_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Você possui o grau 'III' - obesidade grave. Procure o seu médico!", "Atenção!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void txtAltura_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula!");
            }
        }

        private void txtPeso_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar != ',') && !char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Este campo aceita somente número e vírgula!");
            }
        }
       
    }
}