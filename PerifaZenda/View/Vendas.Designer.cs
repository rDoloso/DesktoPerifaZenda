namespace PerifaZenda
{
    partial class Vendas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vendas));
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBoxEstoqueProdutos = new System.Windows.Forms.GroupBox();
            this.textBoxValorTotal = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.dataGridViewProdutosVenda = new System.Windows.Forms.DataGridView();
            this.numericQuantidade = new System.Windows.Forms.NumericUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.buttonFinalizarVenda = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxEstoqueProdutos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosVenda)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonHome
            // 
            this.buttonHome.BackColor = System.Drawing.Color.Transparent;
            this.buttonHome.BackgroundImage = global::PerifaZenda.Properties.Resources.botaoHome1;
            this.buttonHome.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonHome.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonHome.Location = new System.Drawing.Point(6, 38);
            this.buttonHome.Margin = new System.Windows.Forms.Padding(1, 3, 3, 3);
            this.buttonHome.Name = "buttonHome";
            this.buttonHome.Size = new System.Drawing.Size(28, 24);
            this.buttonHome.TabIndex = 20;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // groupBoxEstoqueProdutos
            // 
            this.groupBoxEstoqueProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxEstoqueProdutos.Controls.Add(this.textBoxValorTotal);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label2);
            this.groupBoxEstoqueProdutos.Controls.Add(this.buttonAdicionarProduto);
            this.groupBoxEstoqueProdutos.Controls.Add(this.dataGridViewProdutosVenda);
            this.groupBoxEstoqueProdutos.Controls.Add(this.numericQuantidade);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label4);
            this.groupBoxEstoqueProdutos.Controls.Add(this.textBoxProduto);
            this.groupBoxEstoqueProdutos.Controls.Add(this.buttonFinalizarVenda);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label3);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label1);
            this.groupBoxEstoqueProdutos.Controls.Add(this.pictureBox1);
            this.groupBoxEstoqueProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxEstoqueProdutos.Location = new System.Drawing.Point(42, 24);
            this.groupBoxEstoqueProdutos.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.groupBoxEstoqueProdutos.Name = "groupBoxEstoqueProdutos";
            this.groupBoxEstoqueProdutos.Size = new System.Drawing.Size(1133, 402);
            this.groupBoxEstoqueProdutos.TabIndex = 19;
            this.groupBoxEstoqueProdutos.TabStop = false;
            this.groupBoxEstoqueProdutos.Text = " ";
            // 
            // textBoxValorTotal
            // 
            this.textBoxValorTotal.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxValorTotal.Location = new System.Drawing.Point(912, 312);
            this.textBoxValorTotal.Name = "textBoxValorTotal";
            this.textBoxValorTotal.ReadOnly = true;
            this.textBoxValorTotal.Size = new System.Drawing.Size(131, 22);
            this.textBoxValorTotal.TabIndex = 20;
            this.textBoxValorTotal.Text = "R$ 0.00";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(671, 314);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(225, 17);
            this.label2.TabIndex = 19;
            this.label2.Text = "VALOR TOTAL DA COMPRA:";
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarProduto.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAdicionarProduto.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(334, 280);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(159, 25);
            this.buttonAdicionarProduto.TabIndex = 18;
            this.buttonAdicionarProduto.Text = "ADICIONAR PRODUTO";
            this.buttonAdicionarProduto.UseVisualStyleBackColor = false;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // dataGridViewProdutosVenda
            // 
            this.dataGridViewProdutosVenda.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProdutosVenda.Location = new System.Drawing.Point(587, 24);
            this.dataGridViewProdutosVenda.Name = "dataGridViewProdutosVenda";
            this.dataGridViewProdutosVenda.Size = new System.Drawing.Size(518, 274);
            this.dataGridViewProdutosVenda.TabIndex = 17;
            // 
            // numericQuantidade
            // 
            this.numericQuantidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.numericQuantidade.Location = new System.Drawing.Point(267, 227);
            this.numericQuantidade.Name = "numericQuantidade";
            this.numericQuantidade.Size = new System.Drawing.Size(282, 22);
            this.numericQuantidade.TabIndex = 16;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(273, 201);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(103, 14);
            this.label4.TabIndex = 14;
            this.label4.Text = "QUANTIDADE:";
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxProduto.Location = new System.Drawing.Point(267, 151);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(282, 22);
            this.textBoxProduto.TabIndex = 11;
            // 
            // buttonFinalizarVenda
            // 
            this.buttonFinalizarVenda.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonFinalizarVenda.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonFinalizarVenda.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFinalizarVenda.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonFinalizarVenda.Location = new System.Drawing.Point(776, 359);
            this.buttonFinalizarVenda.Name = "buttonFinalizarVenda";
            this.buttonFinalizarVenda.Size = new System.Drawing.Size(133, 25);
            this.buttonFinalizarVenda.TabIndex = 10;
            this.buttonFinalizarVenda.Text = "FINALIZAR VENDA";
            this.buttonFinalizarVenda.UseVisualStyleBackColor = false;
            this.buttonFinalizarVenda.Click += new System.EventHandler(this.buttonFinalizarVenda_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(273, 125);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 14);
            this.label3.TabIndex = 3;
            this.label3.Text = "CODIGO/ID DO PRODUTO:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(141, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(326, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "VENDA DE PRODUTO";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PerifaZenda.Properties.Resources.vendas;
            this.pictureBox1.Location = new System.Drawing.Point(33, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 130, 3, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Vendas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.ClientSize = new System.Drawing.Size(1214, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.groupBoxEstoqueProdutos);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Vendas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vendas";
            this.groupBoxEstoqueProdutos.ResumeLayout(false);
            this.groupBoxEstoqueProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProdutosVenda)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericQuantidade)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxEstoqueProdutos;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Button buttonFinalizarVenda;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.NumericUpDown numericQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dataGridViewProdutosVenda;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxValorTotal;
    }
}