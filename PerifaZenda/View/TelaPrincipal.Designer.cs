namespace PerifaZenda
{
    partial class TelaPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TelaPrincipal));
            this.buttonAdicionarFuncionario = new System.Windows.Forms.Button();
            this.buttonAdicionarProduto = new System.Windows.Forms.Button();
            this.buttonPedirFornecedor = new System.Windows.Forms.Button();
            this.buttonDarPermissao = new System.Windows.Forms.Button();
            this.buttonVerificarDados = new System.Windows.Forms.Button();
            this.buttonAtualizarEstoque = new System.Windows.Forms.Button();
            this.groupBoxInformacoes = new System.Windows.Forms.GroupBox();
            this.buttonSair = new System.Windows.Forms.Button();
            this.labelDataEHora = new System.Windows.Forms.Label();
            this.usuarioLogado = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.buttonAdicionarFornecedor = new System.Windows.Forms.Button();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.buttonVender = new System.Windows.Forms.Button();
            this.groupBoxInformacoes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAdicionarFuncionario
            // 
            this.buttonAdicionarFuncionario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAdicionarFuncionario.BackgroundImage = global::PerifaZenda.Properties.Resources.AdicionarNovoFuncionario;
            this.buttonAdicionarFuncionario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdicionarFuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarFuncionario.Location = new System.Drawing.Point(61, 98);
            this.buttonAdicionarFuncionario.Name = "buttonAdicionarFuncionario";
            this.buttonAdicionarFuncionario.Size = new System.Drawing.Size(145, 93);
            this.buttonAdicionarFuncionario.TabIndex = 0;
            this.buttonAdicionarFuncionario.UseVisualStyleBackColor = false;
            this.buttonAdicionarFuncionario.Click += new System.EventHandler(this.buttonAdicionarFuncionario_Click);
            // 
            // buttonAdicionarProduto
            // 
            this.buttonAdicionarProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAdicionarProduto.BackgroundImage = global::PerifaZenda.Properties.Resources.produtos;
            this.buttonAdicionarProduto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdicionarProduto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAdicionarProduto.Location = new System.Drawing.Point(239, 98);
            this.buttonAdicionarProduto.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonAdicionarProduto.Name = "buttonAdicionarProduto";
            this.buttonAdicionarProduto.Size = new System.Drawing.Size(145, 93);
            this.buttonAdicionarProduto.TabIndex = 1;
            this.buttonAdicionarProduto.UseVisualStyleBackColor = false;
            this.buttonAdicionarProduto.Click += new System.EventHandler(this.buttonAdicionarProduto_Click);
            // 
            // buttonPedirFornecedor
            // 
            this.buttonPedirFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonPedirFornecedor.BackgroundImage = global::PerifaZenda.Properties.Resources.maoTrocandoDinheiro;
            this.buttonPedirFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPedirFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonPedirFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPedirFornecedor.Location = new System.Drawing.Point(417, 98);
            this.buttonPedirFornecedor.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonPedirFornecedor.Name = "buttonPedirFornecedor";
            this.buttonPedirFornecedor.Size = new System.Drawing.Size(145, 93);
            this.buttonPedirFornecedor.TabIndex = 2;
            this.buttonPedirFornecedor.UseVisualStyleBackColor = false;
            this.buttonPedirFornecedor.Click += new System.EventHandler(this.buttonPedirFornecedor_Click);
            // 
            // buttonDarPermissao
            // 
            this.buttonDarPermissao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonDarPermissao.BackgroundImage = global::PerifaZenda.Properties.Resources.permissoes;
            this.buttonDarPermissao.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonDarPermissao.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonDarPermissao.Location = new System.Drawing.Point(595, 292);
            this.buttonDarPermissao.Name = "buttonDarPermissao";
            this.buttonDarPermissao.Size = new System.Drawing.Size(145, 93);
            this.buttonDarPermissao.TabIndex = 5;
            this.buttonDarPermissao.UseVisualStyleBackColor = false;
            this.buttonDarPermissao.Click += new System.EventHandler(this.buttonDarPermissao_Click);
            // 
            // buttonVerificarDados
            // 
            this.buttonVerificarDados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonVerificarDados.BackgroundImage = global::PerifaZenda.Properties.Resources.VerificarDados;
            this.buttonVerificarDados.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVerificarDados.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonVerificarDados.Location = new System.Drawing.Point(239, 292);
            this.buttonVerificarDados.Name = "buttonVerificarDados";
            this.buttonVerificarDados.Size = new System.Drawing.Size(145, 93);
            this.buttonVerificarDados.TabIndex = 4;
            this.buttonVerificarDados.UseVisualStyleBackColor = false;
            this.buttonVerificarDados.Click += new System.EventHandler(this.buttonVerificarEstoque_Click);
            // 
            // buttonAtualizarEstoque
            // 
            this.buttonAtualizarEstoque.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAtualizarEstoque.BackgroundImage = global::PerifaZenda.Properties.Resources.estoqueImage;
            this.buttonAtualizarEstoque.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAtualizarEstoque.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonAtualizarEstoque.Location = new System.Drawing.Point(61, 292);
            this.buttonAtualizarEstoque.Name = "buttonAtualizarEstoque";
            this.buttonAtualizarEstoque.Size = new System.Drawing.Size(145, 93);
            this.buttonAtualizarEstoque.TabIndex = 3;
            this.buttonAtualizarEstoque.UseVisualStyleBackColor = false;
            this.buttonAtualizarEstoque.Click += new System.EventHandler(this.buttonAtualizarEstoque_Click);
            // 
            // groupBoxInformacoes
            // 
            this.groupBoxInformacoes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxInformacoes.Controls.Add(this.buttonSair);
            this.groupBoxInformacoes.Controls.Add(this.labelDataEHora);
            this.groupBoxInformacoes.Controls.Add(this.usuarioLogado);
            this.groupBoxInformacoes.Controls.Add(this.pictureBox1);
            this.groupBoxInformacoes.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBoxInformacoes.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxInformacoes.Location = new System.Drawing.Point(0, 0);
            this.groupBoxInformacoes.Name = "groupBoxInformacoes";
            this.groupBoxInformacoes.Size = new System.Drawing.Size(800, 41);
            this.groupBoxInformacoes.TabIndex = 6;
            this.groupBoxInformacoes.TabStop = false;
            // 
            // buttonSair
            // 
            this.buttonSair.BackColor = System.Drawing.Color.Transparent;
            this.buttonSair.BackgroundImage = global::PerifaZenda.Properties.Resources.buttonSair1;
            this.buttonSair.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSair.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonSair.Location = new System.Drawing.Point(639, 7);
            this.buttonSair.Name = "buttonSair";
            this.buttonSair.Size = new System.Drawing.Size(120, 27);
            this.buttonSair.TabIndex = 3;
            this.buttonSair.UseVisualStyleBackColor = false;
            this.buttonSair.Click += new System.EventHandler(this.buttonSair_Click);
            // 
            // labelDataEHora
            // 
            this.labelDataEHora.AutoSize = true;
            this.labelDataEHora.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.labelDataEHora.Location = new System.Drawing.Point(312, 11);
            this.labelDataEHora.Name = "labelDataEHora";
            this.labelDataEHora.Size = new System.Drawing.Size(201, 18);
            this.labelDataEHora.TabIndex = 2;
            this.labelDataEHora.Text = "00/00/0000 00:00:00";
            // 
            // usuarioLogado
            // 
            this.usuarioLogado.AutoSize = true;
            this.usuarioLogado.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.usuarioLogado.Location = new System.Drawing.Point(80, 13);
            this.usuarioLogado.Name = "usuarioLogado";
            this.usuarioLogado.Size = new System.Drawing.Size(140, 18);
            this.usuarioLogado.TabIndex = 1;
            this.usuarioLogado.Text = "UsuarioLogado";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PerifaZenda.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(38, 9);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(36, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox1.Font = new System.Drawing.Font("Verdana", 7.1F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(61, 191);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(145, 19);
            this.textBox1.TabIndex = 12;
            this.textBox1.Text = "ADICIONAR FUNCIONARIO";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox2.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox2.Location = new System.Drawing.Point(239, 191);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(145, 20);
            this.textBox2.TabIndex = 13;
            this.textBox2.Text = "ADICIONAR PRODUTO";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox3.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox3.Location = new System.Drawing.Point(417, 191);
            this.textBox3.Margin = new System.Windows.Forms.Padding(0);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(145, 20);
            this.textBox3.TabIndex = 14;
            this.textBox3.Text = "PEDIR NO FORNECEDOR";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox4.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox4.Location = new System.Drawing.Point(595, 385);
            this.textBox4.Margin = new System.Windows.Forms.Padding(0);
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(145, 20);
            this.textBox4.TabIndex = 17;
            this.textBox4.Text = "DAR PERMISSÕES";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox5.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox5.Location = new System.Drawing.Point(239, 385);
            this.textBox5.Margin = new System.Windows.Forms.Padding(0);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(145, 20);
            this.textBox5.TabIndex = 16;
            this.textBox5.Text = "VERIFICAR DADOS";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox6.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox6.Location = new System.Drawing.Point(61, 385);
            this.textBox6.Margin = new System.Windows.Forms.Padding(0);
            this.textBox6.Name = "textBox6";
            this.textBox6.ReadOnly = true;
            this.textBox6.Size = new System.Drawing.Size(145, 20);
            this.textBox6.TabIndex = 15;
            this.textBox6.Text = "ATUALIZAR ESTOQUE";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox8.Font = new System.Drawing.Font("Verdana", 7F, System.Drawing.FontStyle.Bold);
            this.textBox8.Location = new System.Drawing.Point(595, 191);
            this.textBox8.Margin = new System.Windows.Forms.Padding(0);
            this.textBox8.Name = "textBox8";
            this.textBox8.ReadOnly = true;
            this.textBox8.Size = new System.Drawing.Size(145, 19);
            this.textBox8.TabIndex = 20;
            this.textBox8.Text = "ADICIONAR FORNECEDOR";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonAdicionarFornecedor
            // 
            this.buttonAdicionarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonAdicionarFornecedor.BackgroundImage = global::PerifaZenda.Properties.Resources.fornecedor;
            this.buttonAdicionarFornecedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonAdicionarFornecedor.FlatAppearance.BorderSize = 0;
            this.buttonAdicionarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAdicionarFornecedor.Location = new System.Drawing.Point(595, 98);
            this.buttonAdicionarFornecedor.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonAdicionarFornecedor.Name = "buttonAdicionarFornecedor";
            this.buttonAdicionarFornecedor.Size = new System.Drawing.Size(145, 93);
            this.buttonAdicionarFornecedor.TabIndex = 18;
            this.buttonAdicionarFornecedor.UseVisualStyleBackColor = false;
            this.buttonAdicionarFornecedor.Click += new System.EventHandler(this.buttonAdicionarFornecedor_Click);
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.textBox7.Font = new System.Drawing.Font("Verdana", 7.5F, System.Drawing.FontStyle.Bold);
            this.textBox7.Location = new System.Drawing.Point(417, 385);
            this.textBox7.Margin = new System.Windows.Forms.Padding(0);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(145, 20);
            this.textBox7.TabIndex = 22;
            this.textBox7.Text = "VENDER";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // buttonVender
            // 
            this.buttonVender.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.buttonVender.BackgroundImage = global::PerifaZenda.Properties.Resources.vendas;
            this.buttonVender.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonVender.FlatAppearance.BorderSize = 0;
            this.buttonVender.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonVender.Location = new System.Drawing.Point(417, 292);
            this.buttonVender.Margin = new System.Windows.Forms.Padding(30, 3, 3, 3);
            this.buttonVender.Name = "buttonVender";
            this.buttonVender.Size = new System.Drawing.Size(145, 93);
            this.buttonVender.TabIndex = 21;
            this.buttonVender.UseVisualStyleBackColor = false;
            this.buttonVender.Click += new System.EventHandler(this.buttonVender_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.buttonVender);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.buttonAdicionarFornecedor);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.groupBoxInformacoes);
            this.Controls.Add(this.buttonDarPermissao);
            this.Controls.Add(this.buttonVerificarDados);
            this.Controls.Add(this.buttonAtualizarEstoque);
            this.Controls.Add(this.buttonPedirFornecedor);
            this.Controls.Add(this.buttonAdicionarProduto);
            this.Controls.Add(this.buttonAdicionarFuncionario);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TelaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PerifaZenda";
            this.groupBoxInformacoes.ResumeLayout(false);
            this.groupBoxInformacoes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAdicionarFuncionario;
        private System.Windows.Forms.Button buttonAdicionarProduto;
        private System.Windows.Forms.Button buttonPedirFornecedor;
        private System.Windows.Forms.Button buttonDarPermissao;
        private System.Windows.Forms.Button buttonVerificarDados;
        private System.Windows.Forms.Button buttonAtualizarEstoque;
        private System.Windows.Forms.GroupBox groupBoxInformacoes;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label usuarioLogado;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label labelDataEHora;
        private System.Windows.Forms.Button buttonSair;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.Button buttonAdicionarFornecedor;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button buttonVender;
    }
}