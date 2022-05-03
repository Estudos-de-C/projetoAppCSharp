namespace primeiroApp
{
    partial class frmCalculoIMC
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculoIMC));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbOrientacoes = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtAltura = new System.Windows.Forms.TextBox();
            this.txtPeso = new System.Windows.Forms.TextBox();
            this.lblNiveis = new System.Windows.Forms.Label();
            this.btnGrau0 = new System.Windows.Forms.Button();
            this.btnGrau0_0 = new System.Windows.Forms.Button();
            this.btnGrauI = new System.Windows.Forms.Button();
            this.btnGrauII = new System.Windows.Forms.Button();
            this.btnGrauIII = new System.Windows.Forms.Button();
            this.gbResultado = new System.Windows.Forms.GroupBox();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.lblAltura = new System.Windows.Forms.Label();
            this.lblPeso = new System.Windows.Forms.Label();
            this.lblResultado = new System.Windows.Forms.Label();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.gbOrientacoes.SuspendLayout();
            this.gbResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(189, 9);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(193, 24);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Calculadora de IMC";
            // 
            // gbOrientacoes
            // 
            this.gbOrientacoes.Controls.Add(this.label2);
            this.gbOrientacoes.Location = new System.Drawing.Point(12, 39);
            this.gbOrientacoes.Name = "gbOrientacoes";
            this.gbOrientacoes.Size = new System.Drawing.Size(561, 58);
            this.gbOrientacoes.TabIndex = 1;
            this.gbOrientacoes.TabStop = false;
            this.gbOrientacoes.Text = "Orientações";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(77, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(411, 26);
            this.label2.TabIndex = 0;
            this.label2.Text = "Por favor, escreva o valor da sua altura e o valor do seu peso e clique em \"calcu" +
    "lar\". \r\nPara limpar os cálculos, clique em \"limpar\".";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAltura
            // 
            this.txtAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAltura.Location = new System.Drawing.Point(79, 105);
            this.txtAltura.Name = "txtAltura";
            this.txtAltura.Size = new System.Drawing.Size(100, 26);
            this.txtAltura.TabIndex = 2;
            this.txtAltura.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAltura_KeyPress);
            // 
            // txtPeso
            // 
            this.txtPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPeso.Location = new System.Drawing.Point(79, 141);
            this.txtPeso.Name = "txtPeso";
            this.txtPeso.Size = new System.Drawing.Size(100, 26);
            this.txtPeso.TabIndex = 3;
            this.txtPeso.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeso_KeyPress);
            // 
            // lblNiveis
            // 
            this.lblNiveis.AutoSize = true;
            this.lblNiveis.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNiveis.Location = new System.Drawing.Point(270, 236);
            this.lblNiveis.Name = "lblNiveis";
            this.lblNiveis.Size = new System.Drawing.Size(56, 20);
            this.lblNiveis.TabIndex = 6;
            this.lblNiveis.Text = "Níveis";
            // 
            // btnGrau0
            // 
            this.btnGrau0.BackColor = System.Drawing.SystemColors.Window;
            this.btnGrau0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrau0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrau0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrau0.Location = new System.Drawing.Point(113, 271);
            this.btnGrau0.Name = "btnGrau0";
            this.btnGrau0.Size = new System.Drawing.Size(75, 44);
            this.btnGrau0.TabIndex = 7;
            this.btnGrau0.Text = "Grau 0";
            this.btnGrau0.UseVisualStyleBackColor = false;
            this.btnGrau0.Click += new System.EventHandler(this.btnGrau0_Click);
            // 
            // btnGrau0_0
            // 
            this.btnGrau0_0.BackColor = System.Drawing.Color.LightGreen;
            this.btnGrau0_0.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrau0_0.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrau0_0.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrau0_0.Location = new System.Drawing.Point(187, 271);
            this.btnGrau0_0.Name = "btnGrau0_0";
            this.btnGrau0_0.Size = new System.Drawing.Size(75, 44);
            this.btnGrau0_0.TabIndex = 8;
            this.btnGrau0_0.Text = "Grau 0";
            this.btnGrau0_0.UseVisualStyleBackColor = false;
            this.btnGrau0_0.Click += new System.EventHandler(this.btnGrau0_0_Click);
            // 
            // btnGrauI
            // 
            this.btnGrauI.BackColor = System.Drawing.Color.Yellow;
            this.btnGrauI.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrauI.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrauI.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrauI.Location = new System.Drawing.Point(261, 271);
            this.btnGrauI.Name = "btnGrauI";
            this.btnGrauI.Size = new System.Drawing.Size(75, 44);
            this.btnGrauI.TabIndex = 9;
            this.btnGrauI.Text = "Grau I";
            this.btnGrauI.UseVisualStyleBackColor = false;
            this.btnGrauI.Click += new System.EventHandler(this.btnGrauI_Click);
            // 
            // btnGrauII
            // 
            this.btnGrauII.BackColor = System.Drawing.Color.Orange;
            this.btnGrauII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrauII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrauII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrauII.Location = new System.Drawing.Point(335, 271);
            this.btnGrauII.Name = "btnGrauII";
            this.btnGrauII.Size = new System.Drawing.Size(75, 44);
            this.btnGrauII.TabIndex = 10;
            this.btnGrauII.Text = "Grau II";
            this.btnGrauII.UseVisualStyleBackColor = false;
            this.btnGrauII.Click += new System.EventHandler(this.btnGrauII_Click);
            // 
            // btnGrauIII
            // 
            this.btnGrauIII.BackColor = System.Drawing.Color.Red;
            this.btnGrauIII.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGrauIII.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGrauIII.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrauIII.Location = new System.Drawing.Point(409, 271);
            this.btnGrauIII.Name = "btnGrauIII";
            this.btnGrauIII.Size = new System.Drawing.Size(75, 44);
            this.btnGrauIII.TabIndex = 11;
            this.btnGrauIII.Text = "Grau III";
            this.btnGrauIII.UseVisualStyleBackColor = false;
            this.btnGrauIII.Click += new System.EventHandler(this.btnGrauIII_Click);
            // 
            // gbResultado
            // 
            this.gbResultado.Controls.Add(this.txtResultado);
            this.gbResultado.Location = new System.Drawing.Point(12, 338);
            this.gbResultado.Name = "gbResultado";
            this.gbResultado.Size = new System.Drawing.Size(561, 100);
            this.gbResultado.TabIndex = 12;
            this.gbResultado.TabStop = false;
            this.gbResultado.Text = "O que fazer com o resultado?";
            // 
            // txtResultado
            // 
            this.txtResultado.Enabled = false;
            this.txtResultado.Location = new System.Drawing.Point(21, 29);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(522, 55);
            this.txtResultado.TabIndex = 0;
            this.txtResultado.Text = "\r\nObserve o valor do resultado do cálculo de IMC. Clique no botão correspondente\r" +
    "\nao grau para visualizar as orientações.";
            this.txtResultado.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblAltura
            // 
            this.lblAltura.AutoSize = true;
            this.lblAltura.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAltura.Location = new System.Drawing.Point(11, 108);
            this.lblAltura.Name = "lblAltura";
            this.lblAltura.Size = new System.Drawing.Size(62, 20);
            this.lblAltura.TabIndex = 13;
            this.lblAltura.Text = "Altura:";
            // 
            // lblPeso
            // 
            this.lblPeso.AutoSize = true;
            this.lblPeso.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPeso.Location = new System.Drawing.Point(19, 143);
            this.lblPeso.Name = "lblPeso";
            this.lblPeso.Size = new System.Drawing.Size(54, 20);
            this.lblPeso.TabIndex = 14;
            this.lblPeso.Text = "Peso:";
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultado.Location = new System.Drawing.Point(219, 192);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(172, 20);
            this.lblResultado.TabIndex = 15;
            this.lblResultado.Text = "Resultado calculado";
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnLimpar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLimpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.Red;
            this.btnLimpar.Image = global::primeiroApp.Properties.Resources.iconeBorracha;
            this.btnLimpar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpar.Location = new System.Drawing.Point(424, 105);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(149, 62);
            this.btnLimpar.TabIndex = 5;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnCalcular
            // 
            this.btnCalcular.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnCalcular.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalcular.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.ForeColor = System.Drawing.Color.Green;
            this.btnCalcular.Image = global::primeiroApp.Properties.Resources.iconeResultado;
            this.btnCalcular.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCalcular.Location = new System.Drawing.Point(269, 105);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(149, 62);
            this.btnCalcular.TabIndex = 4;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCalcular.UseVisualStyleBackColor = false;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(185, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "Kg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(185, 108);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 20);
            this.label3.TabIndex = 16;
            this.label3.Text = "m";
            // 
            // frmCalculoIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(862, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.lblPeso);
            this.Controls.Add(this.lblAltura);
            this.Controls.Add(this.gbResultado);
            this.Controls.Add(this.btnGrauIII);
            this.Controls.Add(this.btnGrauII);
            this.Controls.Add(this.btnGrauI);
            this.Controls.Add(this.btnGrau0_0);
            this.Controls.Add(this.btnGrau0);
            this.Controls.Add(this.lblNiveis);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtPeso);
            this.Controls.Add(this.txtAltura);
            this.Controls.Add(this.gbOrientacoes);
            this.Controls.Add(this.lblTitulo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmCalculoIMC";
            this.Text = "Calculadora de Índice de Massa Corporal (IMC)";
            this.gbOrientacoes.ResumeLayout(false);
            this.gbOrientacoes.PerformLayout();
            this.gbResultado.ResumeLayout(false);
            this.gbResultado.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbOrientacoes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAltura;
        private System.Windows.Forms.TextBox txtPeso;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Label lblNiveis;
        private System.Windows.Forms.Button btnGrau0;
        private System.Windows.Forms.Button btnGrau0_0;
        private System.Windows.Forms.Button btnGrauI;
        private System.Windows.Forms.Button btnGrauII;
        private System.Windows.Forms.Button btnGrauIII;
        private System.Windows.Forms.GroupBox gbResultado;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblAltura;
        private System.Windows.Forms.Label lblPeso;
        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
    }
}