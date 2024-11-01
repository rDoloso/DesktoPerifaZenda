namespace PerifaZenda
{
    partial class PedidoFornecedor
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
            this.groupBoxPedidoFornecedor = new System.Windows.Forms.GroupBox();
            this.comboBoxProduto = new System.Windows.Forms.ComboBox();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.textBoxPreco = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPerifaZendaDataSet = new PerifaZenda.dbPerifaZendaDataSet();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonHome = new System.Windows.Forms.Button();
            this.fornecedorTableAdapter = new PerifaZenda.dbPerifaZendaDataSetTableAdapters.FornecedorTableAdapter();
            this.groupBoxPedidoFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPedidoFornecedor
            // 
            this.groupBoxPedidoFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxPedidoFornecedor.Controls.Add(this.comboBoxProduto);
            this.groupBoxPedidoFornecedor.Controls.Add(this.numericQuantidade);
            this.groupBoxPedidoFornecedor.Controls.Add(this.textBoxPreco);
            this.groupBoxPedidoFornecedor.Controls.Add(this.buttonConfirmar);
            this.groupBoxPedidoFornecedor.Controls.Add(this.comboBoxFornecedor);
            this.groupBoxPedidoFornecedor.Controls.Add(this.label5);
            this.groupBoxPedidoFornecedor.Controls.Add(this.label4);
            this.groupBoxPedidoFornecedor.Controls.Add(this.label3);
            this.groupBoxPedidoFornecedor.Controls.Add(this.label2);
            this.groupBoxPedidoFornecedor.Controls.Add(this.label1);
            this.groupBoxPedidoFornecedor.Controls.Add(this.pictureBox1);
            this.groupBoxPedidoFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxPedidoFornecedor.Location = new System.Drawing.Point(39, 24);
            this.groupBoxPedidoFornecedor.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.groupBoxPedidoFornecedor.Name = "groupBoxPedidoFornecedor";
            this.groupBoxPedidoFornecedor.Size = new System.Drawing.Size(722, 402);
            this.groupBoxPedidoFornecedor.TabIndex = 0;
            this.groupBoxPedidoFornecedor.TabStop = false;
            // 
            // comboBoxProduto
            // 
            this.comboBoxProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.comboBoxProduto.FormattingEnabled = true;
            this.comboBoxProduto.Location = new System.Drawing.Point(308, 172);
            this.comboBoxProduto.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxProduto.Name = "comboBoxProduto";
            this.comboBoxProduto.Size = new System.Drawing.Size(302, 22);
            this.comboBoxProduto.TabIndex = 14;
            this.comboBoxProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduto_SelectedIndexChanged);
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.numericQuantidade.Location = new System.Drawing.Point(308, 306);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(302, 22);
            this.numericQuantidade.TabIndex = 13;
            this.numericQuantidade.ValueChanged += new System.EventHandler(this.numericQuantidade_ValueChanged);
            // 
            // textBoxPreco
            // 
            this.textBoxPreco.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxPreco.Location = new System.Drawing.Point(308, 240);
            this.textBoxPreco.Name = "textBoxPreco";
            this.textBoxPreco.ReadOnly = true;
            this.textBoxPreco.Size = new System.Drawing.Size(302, 22);
            this.textBoxPreco.TabIndex = 12;
            this.textBoxPreco.Text = "R$ 0,00";
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmar.Location = new System.Drawing.Point(401, 345);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(133, 25);
            this.buttonConfirmar.TabIndex = 10;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DataSource = this.fornecedorBindingSource;
            this.comboBoxFornecedor.DisplayMember = "nome";
            this.comboBoxFornecedor.Font = new System.Drawing.Font("Verdana", 9F);
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(308, 105);
            this.comboBoxFornecedor.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(302, 22);
            this.comboBoxFornecedor.TabIndex = 6;
            this.comboBoxFornecedor.ValueMember = "idFornecedor";
            this.comboBoxFornecedor.SelectedIndexChanged += new System.EventHandler(this.comboBoxFornecedor_SelectedIndexChanged);
            // 
            // fornecedorBindingSource
            // 
            this.fornecedorBindingSource.DataMember = "Fornecedor";
            this.fornecedorBindingSource.DataSource = this.dbPerifaZendaDataSet;
            // 
            // dbPerifaZendaDataSet
            // 
            this.dbPerifaZendaDataSet.DataSetName = "dbPerifaZendaDataSet";
            this.dbPerifaZendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(327, 276);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(120, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "QUANTIDADE:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(327, 209);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(68, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "PRECO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(327, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "PRODUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(327, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "FORNECEDOR:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(560, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "PEDIR NO FORNECEDOR PARCEIRO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PerifaZenda.Properties.Resources.maoTrocandoDinheiro;
            this.pictureBox1.Location = new System.Drawing.Point(33, 115);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 130, 3, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::PerifaZenda.Properties.Resources.botaoHome1;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHome.Location = new System.Drawing.Point(5, 38);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(28, 24);
            this.buttonHome.TabIndex = 14;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // PedidoFornecedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.groupBoxPedidoFornecedor);
            this.Name = "PedidoFornecedor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Pedir no fornecedor";
            this.Load += new System.EventHandler(this.PedidoFornecedor_Load);
            this.groupBoxPedidoFornecedor.ResumeLayout(false);
            this.groupBoxPedidoFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPedidoFornecedor;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.TextBox textBoxPreco;
        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.ComboBox comboBoxProduto;
        private dbPerifaZendaDataSet dbPerifaZendaDataSet;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private dbPerifaZendaDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
    }
}

