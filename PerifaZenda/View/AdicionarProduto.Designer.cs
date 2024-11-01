namespace PerifaZenda
{
    partial class AdicionarProduto
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBoxAdicionarProduto = new System.Windows.Forms.GroupBox();
            this.comboBoxFornecedor = new System.Windows.Forms.ComboBox();
            this.fornecedorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dbPerifaZendaDataSet = new PerifaZenda.dbPerifaZendaDataSet();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxPrecoProduto = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxTipoProduto = new System.Windows.Forms.ComboBox();
            this.tipoProdutoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.textBoxNomeProduto = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tipoProdutoTableAdapter = new PerifaZenda.dbPerifaZendaDataSetTableAdapters.TipoProdutoTableAdapter();
            this.fornecedorTableAdapter = new PerifaZenda.dbPerifaZendaDataSetTableAdapters.FornecedorTableAdapter();
            this.groupBoxAdicionarProduto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::PerifaZenda.Properties.Resources.botaoHome1;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHome.Location = new System.Drawing.Point(8, 38);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(28, 24);
            this.buttonHome.TabIndex = 22;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // groupBoxAdicionarProduto
            // 
            this.groupBoxAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxAdicionarProduto.Controls.Add(this.comboBoxFornecedor);
            this.groupBoxAdicionarProduto.Controls.Add(this.label6);
            this.groupBoxAdicionarProduto.Controls.Add(this.textBoxPrecoProduto);
            this.groupBoxAdicionarProduto.Controls.Add(this.label4);
            this.groupBoxAdicionarProduto.Controls.Add(this.label2);
            this.groupBoxAdicionarProduto.Controls.Add(this.comboBoxTipoProduto);
            this.groupBoxAdicionarProduto.Controls.Add(this.textBoxNomeProduto);
            this.groupBoxAdicionarProduto.Controls.Add(this.buttonConfirmar);
            this.groupBoxAdicionarProduto.Controls.Add(this.label3);
            this.groupBoxAdicionarProduto.Controls.Add(this.label1);
            this.groupBoxAdicionarProduto.Controls.Add(this.pictureBox1);
            this.groupBoxAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxAdicionarProduto.Location = new System.Drawing.Point(39, 24);
            this.groupBoxAdicionarProduto.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.groupBoxAdicionarProduto.Name = "groupBoxAdicionarProduto";
            this.groupBoxAdicionarProduto.Size = new System.Drawing.Size(722, 402);
            this.groupBoxAdicionarProduto.TabIndex = 21;
            this.groupBoxAdicionarProduto.TabStop = false;
            this.groupBoxAdicionarProduto.Text = " ";
            // 
            // comboBoxFornecedor
            // 
            this.comboBoxFornecedor.DataSource = this.fornecedorBindingSource;
            this.comboBoxFornecedor.DisplayMember = "nome";
            this.comboBoxFornecedor.FormattingEnabled = true;
            this.comboBoxFornecedor.Location = new System.Drawing.Point(301, 294);
            this.comboBoxFornecedor.Name = "comboBoxFornecedor";
            this.comboBoxFornecedor.Size = new System.Drawing.Size(302, 21);
            this.comboBoxFornecedor.TabIndex = 25;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(307, 274);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 17);
            this.label6.TabIndex = 23;
            this.label6.Text = "FORNECEDOR DO PRODUTO:";
            // 
            // textBoxPrecoProduto
            // 
            this.textBoxPrecoProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxPrecoProduto.Location = new System.Drawing.Point(301, 236);
            this.textBoxPrecoProduto.Name = "textBoxPrecoProduto";
            this.textBoxPrecoProduto.Size = new System.Drawing.Size(302, 22);
            this.textBoxPrecoProduto.TabIndex = 22;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(307, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 17);
            this.label4.TabIndex = 21;
            this.label4.Text = "PRECO DO PRODUTO:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(307, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 17);
            this.label2.TabIndex = 18;
            this.label2.Text = "TIPO DE PRODUTO:";
            // 
            // comboBoxTipoProduto
            // 
            this.comboBoxTipoProduto.DataSource = this.tipoProdutoBindingSource;
            this.comboBoxTipoProduto.DisplayMember = "descricao";
            this.comboBoxTipoProduto.FormattingEnabled = true;
            this.comboBoxTipoProduto.Location = new System.Drawing.Point(301, 124);
            this.comboBoxTipoProduto.Name = "comboBoxTipoProduto";
            this.comboBoxTipoProduto.Size = new System.Drawing.Size(302, 21);
            this.comboBoxTipoProduto.TabIndex = 17;
            this.comboBoxTipoProduto.ValueMember = "idTipoProduto";
            this.comboBoxTipoProduto.SelectedIndexChanged += new System.EventHandler(this.comboBoxTipoProduto_SelectedIndexChanged);
            // 
            // tipoProdutoBindingSource
            // 
            this.tipoProdutoBindingSource.DataMember = "TipoProduto";
            this.tipoProdutoBindingSource.DataSource = this.dbPerifaZendaDataSet;
            // 
            // textBoxNomeProduto
            // 
            this.textBoxNomeProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxNomeProduto.Location = new System.Drawing.Point(301, 180);
            this.textBoxNomeProduto.Name = "textBoxNomeProduto";
            this.textBoxNomeProduto.Size = new System.Drawing.Size(302, 22);
            this.textBoxNomeProduto.TabIndex = 11;
            this.textBoxNomeProduto.TextChanged += new System.EventHandler(this.textBoxNomeProduto_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmar.Location = new System.Drawing.Point(375, 336);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(133, 25);
            this.buttonConfirmar.TabIndex = 10;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(307, 161);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(170, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME DO PRODUTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(183, 17);
            this.label1.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(364, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADICIONAR PRODUTO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::PerifaZenda.Properties.Resources.produtos;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Location = new System.Drawing.Point(33, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 130, 3, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // tipoProdutoTableAdapter
            // 
            this.tipoProdutoTableAdapter.ClearBeforeFill = true;
            // 
            // fornecedorTableAdapter
            // 
            this.fornecedorTableAdapter.ClearBeforeFill = true;
            // 
            // AdicionarProduto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.groupBoxAdicionarProduto);
            this.Name = "AdicionarProduto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Produto";
            this.Load += new System.EventHandler(this.AdicionarProduto_Load);
            this.groupBoxAdicionarProduto.ResumeLayout(false);
            this.groupBoxAdicionarProduto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fornecedorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoProdutoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxAdicionarProduto;
        private System.Windows.Forms.TextBox textBoxNomeProduto;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBoxTipoProduto;
        private System.Windows.Forms.TextBox textBoxPrecoProduto;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxFornecedor;
        private System.Windows.Forms.Label label6;
        private dbPerifaZendaDataSet dbPerifaZendaDataSet;
        private System.Windows.Forms.BindingSource tipoProdutoBindingSource;
        private dbPerifaZendaDataSetTableAdapters.TipoProdutoTableAdapter tipoProdutoTableAdapter;
        private System.Windows.Forms.BindingSource fornecedorBindingSource;
        private dbPerifaZendaDataSetTableAdapters.FornecedorTableAdapter fornecedorTableAdapter;
    }
}