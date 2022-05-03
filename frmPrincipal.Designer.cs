namespace primeiroApp
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.lblTitulo = new System.Windows.Forms.Label();
            this.gbInicial = new System.Windows.Forms.GroupBox();
            this.btnEstoque = new System.Windows.Forms.Button();
            this.btnIMC = new System.Windows.Forms.Button();
            this.gbInicial.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.ForeColor = System.Drawing.Color.Firebrick;
            this.lblTitulo.Location = new System.Drawing.Point(107, 16);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(359, 25);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Sistema Intergrado de Farmácias";
            // 
            // gbInicial
            // 
            this.gbInicial.Controls.Add(this.btnEstoque);
            this.gbInicial.Controls.Add(this.btnIMC);
            this.gbInicial.Controls.Add(this.lblTitulo);
            this.gbInicial.Location = new System.Drawing.Point(12, 50);
            this.gbInicial.Name = "gbInicial";
            this.gbInicial.Size = new System.Drawing.Size(592, 376);
            this.gbInicial.TabIndex = 1;
            this.gbInicial.TabStop = false;
            this.gbInicial.Text = "Seja bem vindo!";
            // 
            // btnEstoque
            // 
            this.btnEstoque.BackColor = System.Drawing.Color.AliceBlue;
            this.btnEstoque.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnEstoque.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEstoque.Image = global::primeiroApp.Properties.Resources.iconeEstoque2;
            this.btnEstoque.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEstoque.Location = new System.Drawing.Point(327, 142);
            this.btnEstoque.Name = "btnEstoque";
            this.btnEstoque.Size = new System.Drawing.Size(228, 126);
            this.btnEstoque.TabIndex = 2;
            this.btnEstoque.Text = "Estoque";
            this.btnEstoque.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEstoque.UseVisualStyleBackColor = false;
            this.btnEstoque.Click += new System.EventHandler(this.btnEstoque_Click);
            // 
            // btnIMC
            // 
            this.btnIMC.BackColor = System.Drawing.Color.Honeydew;
            this.btnIMC.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIMC.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnIMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIMC.Image = global::primeiroApp.Properties.Resources.calculatorIcon;
            this.btnIMC.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIMC.Location = new System.Drawing.Point(32, 142);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(228, 126);
            this.btnIMC.TabIndex = 1;
            this.btnIMC.Text = "Cálculo de IMC";
            this.btnIMC.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIMC.UseVisualStyleBackColor = false;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(616, 496);
            this.Controls.Add(this.gbInicial);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPrincipal";
            this.Text = "Tela Inicial";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmPrincipal_FormClosed);
            this.gbInicial.ResumeLayout(false);
            this.gbInicial.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.GroupBox gbInicial;
        private System.Windows.Forms.Button btnEstoque;
        private System.Windows.Forms.Button btnIMC;
    }
}