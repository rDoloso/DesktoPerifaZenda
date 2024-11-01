namespace PerifaZenda
{
    partial class EstoqueProdutos
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
            this.buttonHome = new System.Windows.Forms.Button();
            this.groupBoxEstoqueProdutos = new System.Windows.Forms.GroupBox();
            this.textBoxQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxProduto = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBoxEstoqueProdutos.SuspendLayout();
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
            this.buttonHome.TabIndex = 18;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // groupBoxEstoqueProdutos
            // 
            this.groupBoxEstoqueProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxEstoqueProdutos.Controls.Add(this.textBoxQuantidade);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label2);
            this.groupBoxEstoqueProdutos.Controls.Add(this.textBoxProduto);
            this.groupBoxEstoqueProdutos.Controls.Add(this.buttonConfirmar);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label3);
            this.groupBoxEstoqueProdutos.Controls.Add(this.label1);
            this.groupBoxEstoqueProdutos.Controls.Add(this.pictureBox1);
            this.groupBoxEstoqueProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxEstoqueProdutos.Location = new System.Drawing.Point(39, 24);
            this.groupBoxEstoqueProdutos.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.groupBoxEstoqueProdutos.Name = "groupBoxEstoqueProdutos";
            this.groupBoxEstoqueProdutos.Size = new System.Drawing.Size(722, 402);
            this.groupBoxEstoqueProdutos.TabIndex = 17;
            this.groupBoxEstoqueProdutos.TabStop = false;
            this.groupBoxEstoqueProdutos.Text = " ";
            // 
            // textBoxQuantidade
            // 
            this.textBoxQuantidade.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxQuantidade.Location = new System.Drawing.Point(540, 268);
            this.textBoxQuantidade.Name = "textBoxQuantidade";
            this.textBoxQuantidade.ReadOnly = true;
            this.textBoxQuantidade.Size = new System.Drawing.Size(44, 22);
            this.textBoxQuantidade.TabIndex = 13;
            this.textBoxQuantidade.Text = "0";
            this.textBoxQuantidade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(301, 273);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 17);
            this.label2.TabIndex = 12;
            this.label2.Text = "QUANTIDADE EM ESTOQUE:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // textBoxProduto
            // 
            this.textBoxProduto.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxProduto.Location = new System.Drawing.Point(304, 168);
            this.textBoxProduto.Name = "textBoxProduto";
            this.textBoxProduto.Size = new System.Drawing.Size(302, 22);
            this.textBoxProduto.TabIndex = 11;
            this.textBoxProduto.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmar.Location = new System.Drawing.Point(376, 217);
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
            this.label3.Location = new System.Drawing.Point(310, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(199, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "NOME/ID DO PRODUTO:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(174, 49);
            this.label1.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(392, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ESTOQUE DE PRODUTOS:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PerifaZenda.Properties.Resources.estoqueImage;
            this.pictureBox1.Location = new System.Drawing.Point(33, 133);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 130, 3, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // EstoqueProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.groupBoxEstoqueProdutos);
            this.Name = "EstoqueProdutos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque de Produtos";
            this.groupBoxEstoqueProdutos.ResumeLayout(false);
            this.groupBoxEstoqueProdutos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxEstoqueProdutos;
        private System.Windows.Forms.TextBox textBoxProduto;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxQuantidade;
        private System.Windows.Forms.Label label2;
    }
}