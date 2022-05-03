namespace primeiroApp
{
    partial class frmEstoque
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label nomeProdutoLabel;
            System.Windows.Forms.Label descricaoProdutoLabel;
            System.Windows.Forms.Label valorProdutoLabel;
            System.Windows.Forms.Label dataVendaProdutoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.gbDados = new System.Windows.Forms.GroupBox();
            this.dataVendaProdutoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.tabelaProdutosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.aplicativoFarmaciaDBDataSet = new primeiroApp.aplicativoFarmaciaDBDataSet();
            this.valorProdutoTextBox = new System.Windows.Forms.TextBox();
            this.descricaoProdutoTextBox = new System.Windows.Forms.TextBox();
            this.nomeProdutoTextBox = new System.Windows.Forms.TextBox();
            this.tabelaProdutosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.tabelaProdutosBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.tabelaProdutosBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.tsbEditar = new System.Windows.Forms.ToolStripButton();
            this.tsbBloquear = new System.Windows.Forms.ToolStripButton();
            this.tabelaProdutosTableAdapter = new primeiroApp.aplicativoFarmaciaDBDataSetTableAdapters.tabelaProdutosTableAdapter();
            this.tableAdapterManager = new primeiroApp.aplicativoFarmaciaDBDataSetTableAdapters.TableAdapterManager();
            nomeProdutoLabel = new System.Windows.Forms.Label();
            descricaoProdutoLabel = new System.Windows.Forms.Label();
            valorProdutoLabel = new System.Windows.Forms.Label();
            dataVendaProdutoLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1.SuspendLayout();
            this.gbDados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoFarmaciaDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosDataGridView)).BeginInit();
            this.tableLayoutPanel2.SuspendLayout();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosBindingNavigator)).BeginInit();
            this.tabelaProdutosBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // nomeProdutoLabel
            // 
            nomeProdutoLabel.AutoSize = true;
            nomeProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeProdutoLabel.Location = new System.Drawing.Point(9, 22);
            nomeProdutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            nomeProdutoLabel.Name = "nomeProdutoLabel";
            nomeProdutoLabel.Size = new System.Drawing.Size(133, 18);
            nomeProdutoLabel.TabIndex = 0;
            nomeProdutoLabel.Text = "Nome do produto:";
            // 
            // descricaoProdutoLabel
            // 
            descricaoProdutoLabel.AutoSize = true;
            descricaoProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            descricaoProdutoLabel.Location = new System.Drawing.Point(10, 91);
            descricaoProdutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            descricaoProdutoLabel.Name = "descricaoProdutoLabel";
            descricaoProdutoLabel.Size = new System.Drawing.Size(163, 18);
            descricaoProdutoLabel.TabIndex = 2;
            descricaoProdutoLabel.Text = "Descrição do produto:";
            // 
            // valorProdutoLabel
            // 
            valorProdutoLabel.AutoSize = true;
            valorProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            valorProdutoLabel.Location = new System.Drawing.Point(9, 341);
            valorProdutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            valorProdutoLabel.Name = "valorProdutoLabel";
            valorProdutoLabel.Size = new System.Drawing.Size(127, 18);
            valorProdutoLabel.TabIndex = 4;
            valorProdutoLabel.Text = "Valor do produto:";
            // 
            // dataVendaProdutoLabel
            // 
            dataVendaProdutoLabel.AutoSize = true;
            dataVendaProdutoLabel.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataVendaProdutoLabel.Location = new System.Drawing.Point(208, 341);
            dataVendaProdutoLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            dataVendaProdutoLabel.Name = "dataVendaProdutoLabel";
            dataVendaProdutoLabel.Size = new System.Drawing.Size(193, 18);
            dataVendaProdutoLabel.TabIndex = 6;
            dataVendaProdutoLabel.Text = "Data de venda do produto:";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Controls.Add(this.gbDados, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tabelaProdutosDataGridView, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 116);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 33.33F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1193, 471);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // gbDados
            // 
            this.gbDados.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbDados.Controls.Add(dataVendaProdutoLabel);
            this.gbDados.Controls.Add(this.dataVendaProdutoDateTimePicker);
            this.gbDados.Controls.Add(valorProdutoLabel);
            this.gbDados.Controls.Add(this.valorProdutoTextBox);
            this.gbDados.Controls.Add(descricaoProdutoLabel);
            this.gbDados.Controls.Add(this.descricaoProdutoTextBox);
            this.gbDados.Controls.Add(nomeProdutoLabel);
            this.gbDados.Controls.Add(this.nomeProdutoTextBox);
            this.gbDados.Location = new System.Drawing.Point(5, 5);
            this.gbDados.Margin = new System.Windows.Forms.Padding(4);
            this.gbDados.Name = "gbDados";
            this.gbDados.Padding = new System.Windows.Forms.Padding(4);
            this.gbDados.Size = new System.Drawing.Size(587, 461);
            this.gbDados.TabIndex = 1;
            this.gbDados.TabStop = false;
            this.gbDados.Text = "Produtos";
            // 
            // dataVendaProdutoDateTimePicker
            // 
            this.dataVendaProdutoDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.tabelaProdutosBindingSource, "dataVendaProduto", true));
            this.dataVendaProdutoDateTimePicker.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataVendaProdutoDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dataVendaProdutoDateTimePicker.Location = new System.Drawing.Point(208, 370);
            this.dataVendaProdutoDateTimePicker.Margin = new System.Windows.Forms.Padding(4);
            this.dataVendaProdutoDateTimePicker.MinDate = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            this.dataVendaProdutoDateTimePicker.Name = "dataVendaProdutoDateTimePicker";
            this.dataVendaProdutoDateTimePicker.Size = new System.Drawing.Size(364, 26);
            this.dataVendaProdutoDateTimePicker.TabIndex = 7;
            // 
            // tabelaProdutosBindingSource
            // 
            this.tabelaProdutosBindingSource.DataMember = "tabelaProdutos";
            this.tabelaProdutosBindingSource.DataSource = this.aplicativoFarmaciaDBDataSet;
            // 
            // aplicativoFarmaciaDBDataSet
            // 
            this.aplicativoFarmaciaDBDataSet.DataSetName = "aplicativoFarmaciaDBDataSet";
            this.aplicativoFarmaciaDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // valorProdutoTextBox
            // 
            this.valorProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaProdutosBindingSource, "valorProduto", true));
            this.valorProdutoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valorProdutoTextBox.Location = new System.Drawing.Point(6, 370);
            this.valorProdutoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.valorProdutoTextBox.Name = "valorProdutoTextBox";
            this.valorProdutoTextBox.Size = new System.Drawing.Size(192, 26);
            this.valorProdutoTextBox.TabIndex = 5;
            // 
            // descricaoProdutoTextBox
            // 
            this.descricaoProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaProdutosBindingSource, "descricaoProduto", true));
            this.descricaoProdutoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descricaoProdutoTextBox.Location = new System.Drawing.Point(9, 120);
            this.descricaoProdutoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.descricaoProdutoTextBox.Multiline = true;
            this.descricaoProdutoTextBox.Name = "descricaoProdutoTextBox";
            this.descricaoProdutoTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.descricaoProdutoTextBox.Size = new System.Drawing.Size(565, 214);
            this.descricaoProdutoTextBox.TabIndex = 3;
            // 
            // nomeProdutoTextBox
            // 
            this.nomeProdutoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tabelaProdutosBindingSource, "nomeProduto", true));
            this.nomeProdutoTextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nomeProdutoTextBox.Location = new System.Drawing.Point(9, 51);
            this.nomeProdutoTextBox.Margin = new System.Windows.Forms.Padding(4);
            this.nomeProdutoTextBox.Name = "nomeProdutoTextBox";
            this.nomeProdutoTextBox.Size = new System.Drawing.Size(565, 26);
            this.nomeProdutoTextBox.TabIndex = 1;
            // 
            // tabelaProdutosDataGridView
            // 
            this.tabelaProdutosDataGridView.AllowUserToAddRows = false;
            this.tabelaProdutosDataGridView.AllowUserToDeleteRows = false;
            this.tabelaProdutosDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaProdutosDataGridView.AutoGenerateColumns = false;
            this.tabelaProdutosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabelaProdutosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.tabelaProdutosDataGridView.DataSource = this.tabelaProdutosBindingSource;
            this.tabelaProdutosDataGridView.Location = new System.Drawing.Point(601, 5);
            this.tabelaProdutosDataGridView.Margin = new System.Windows.Forms.Padding(4);
            this.tabelaProdutosDataGridView.Name = "tabelaProdutosDataGridView";
            this.tabelaProdutosDataGridView.ReadOnly = true;
            this.tabelaProdutosDataGridView.Size = new System.Drawing.Size(587, 461);
            this.tabelaProdutosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "produtosID";
            this.dataGridViewTextBoxColumn1.HeaderText = "Produto ID:";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "nomeProduto";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome do produto:";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 200;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "descricaoProduto";
            this.dataGridViewTextBoxColumn3.HeaderText = "Descrição do produto:";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "valorProduto";
            this.dataGridViewTextBoxColumn4.HeaderText = "Valor (preço):";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "dataVendaProduto";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data da venda:";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel2.ColumnCount = 1;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 4);
            this.tableLayoutPanel2.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(1192, 100);
            this.tableLayoutPanel2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(5, 1);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1182, 98);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastro de produtos";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Single;
            this.tableLayoutPanel3.ColumnCount = 1;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Controls.Add(this.tabelaProdutosBindingNavigator, 0, 0);
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 595);
            this.tableLayoutPanel3.Margin = new System.Windows.Forms.Padding(4);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(1192, 100);
            this.tableLayoutPanel3.TabIndex = 2;
            // 
            // tabelaProdutosBindingNavigator
            // 
            this.tabelaProdutosBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tabelaProdutosBindingNavigator.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabelaProdutosBindingNavigator.AutoSize = false;
            this.tabelaProdutosBindingNavigator.BindingSource = this.tabelaProdutosBindingSource;
            this.tabelaProdutosBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tabelaProdutosBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tabelaProdutosBindingNavigator.Dock = System.Windows.Forms.DockStyle.None;
            this.tabelaProdutosBindingNavigator.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tabelaProdutosBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.tabelaProdutosBindingNavigatorSaveItem,
            this.tsbEditar,
            this.tsbBloquear});
            this.tabelaProdutosBindingNavigator.Location = new System.Drawing.Point(1, 1);
            this.tabelaProdutosBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tabelaProdutosBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tabelaProdutosBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tabelaProdutosBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tabelaProdutosBindingNavigator.Name = "tabelaProdutosBindingNavigator";
            this.tabelaProdutosBindingNavigator.Padding = new System.Windows.Forms.Padding(0, 0, 2, 0);
            this.tabelaProdutosBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tabelaProdutosBindingNavigator.Size = new System.Drawing.Size(1190, 98);
            this.tabelaProdutosBindingNavigator.TabIndex = 3;
            this.tabelaProdutosBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(53, 95);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 26);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(52, 95);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // tabelaProdutosBindingNavigatorSaveItem
            // 
            this.tabelaProdutosBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tabelaProdutosBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tabelaProdutosBindingNavigatorSaveItem.Image")));
            this.tabelaProdutosBindingNavigatorSaveItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tabelaProdutosBindingNavigatorSaveItem.Name = "tabelaProdutosBindingNavigatorSaveItem";
            this.tabelaProdutosBindingNavigatorSaveItem.Size = new System.Drawing.Size(52, 95);
            this.tabelaProdutosBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tabelaProdutosBindingNavigatorSaveItem.Click += new System.EventHandler(this.tabelaProdutosBindingNavigatorSaveItem_Click);
            // 
            // tsbEditar
            // 
            this.tsbEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbEditar.Image = ((System.Drawing.Image)(resources.GetObject("tsbEditar.Image")));
            this.tsbEditar.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbEditar.Name = "tsbEditar";
            this.tsbEditar.Size = new System.Drawing.Size(52, 95);
            this.tsbEditar.Text = "Editar";
            this.tsbEditar.Click += new System.EventHandler(this.tsbEditar_Click);
            // 
            // tsbBloquear
            // 
            this.tsbBloquear.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tsbBloquear.Image = ((System.Drawing.Image)(resources.GetObject("tsbBloquear.Image")));
            this.tsbBloquear.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.tsbBloquear.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbBloquear.Name = "tsbBloquear";
            this.tsbBloquear.Size = new System.Drawing.Size(52, 95);
            this.tsbBloquear.Text = "Bloquear";
            this.tsbBloquear.Click += new System.EventHandler(this.tsbBloquear_Click);
            // 
            // tabelaProdutosTableAdapter
            // 
            this.tabelaProdutosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.tabelaIMCTableAdapter = null;
            this.tableAdapterManager.tabelaProdutosTableAdapter = this.tabelaProdutosTableAdapter;
            this.tableAdapterManager.tabelaUsuarioTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = primeiroApp.aplicativoFarmaciaDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1204, 699);
            this.Controls.Add(this.tableLayoutPanel3);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEstoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.gbDados.ResumeLayout(false);
            this.gbDados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.aplicativoFarmaciaDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosDataGridView)).EndInit();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabelaProdutosBindingNavigator)).EndInit();
            this.tabelaProdutosBindingNavigator.ResumeLayout(false);
            this.tabelaProdutosBindingNavigator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private aplicativoFarmaciaDBDataSet aplicativoFarmaciaDBDataSet;
        private System.Windows.Forms.BindingSource tabelaProdutosBindingSource;
        private aplicativoFarmaciaDBDataSetTableAdapters.tabelaProdutosTableAdapter tabelaProdutosTableAdapter;
        private aplicativoFarmaciaDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tabelaProdutosBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripButton tabelaProdutosBindingNavigatorSaveItem;
        private System.Windows.Forms.DataGridView tabelaProdutosDataGridView;
        private System.Windows.Forms.GroupBox gbDados;
        private System.Windows.Forms.TextBox nomeProdutoTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dataVendaProdutoDateTimePicker;
        private System.Windows.Forms.TextBox valorProdutoTextBox;
        private System.Windows.Forms.TextBox descricaoProdutoTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.ToolStripButton tsbEditar;
        private System.Windows.Forms.ToolStripButton tsbBloquear;
    }
}