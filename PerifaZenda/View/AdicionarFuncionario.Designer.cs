using System.Drawing;

namespace PerifaZenda
{
    partial class AdicionarFuncionario
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
            this.groupBoxAdicionarFornecedor = new System.Windows.Forms.GroupBox();
            this.textBoxBairro = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.textBoxComplemento = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBoxCidadeEstado = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.textBoxNum = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.textBoxLogradouro = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBoxCEP = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxDataNascimento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxNomeESobrenome = new System.Windows.Forms.TextBox();
            this.comboBoxDepartamento = new System.Windows.Forms.ComboBox();
            this.textBoxCPF = new System.Windows.Forms.TextBox();
            this.buttonConfirmar = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dbPerifaZendaDataSet = new PerifaZenda.dbPerifaZendaDataSet();
            this.tipoFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tipoFuncionarioTableAdapter = new PerifaZenda.dbPerifaZendaDataSetTableAdapters.TipoFuncionarioTableAdapter();
            this.groupBoxAdicionarFornecedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFuncionarioBindingSource)).BeginInit();
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
            this.buttonHome.TabIndex = 16;
            this.buttonHome.UseVisualStyleBackColor = false;
            this.buttonHome.Click += new System.EventHandler(this.buttonHome_Click);
            // 
            // groupBoxAdicionarFornecedor
            // 
            this.groupBoxAdicionarFornecedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(217)))), ((int)(((byte)(217)))));
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxBairro);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label11);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxComplemento);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label10);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxCidadeEstado);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label9);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxNum);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label8);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxLogradouro);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label7);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxCEP);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label4);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxDataNascimento);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label6);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxNomeESobrenome);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.comboBoxDepartamento);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.textBoxCPF);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.buttonConfirmar);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label5);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label3);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label2);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.label1);
            this.groupBoxAdicionarFornecedor.Controls.Add(this.pictureBox1);
            this.groupBoxAdicionarFornecedor.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBoxAdicionarFornecedor.Location = new System.Drawing.Point(39, 24);
            this.groupBoxAdicionarFornecedor.Margin = new System.Windows.Forms.Padding(30, 15, 30, 15);
            this.groupBoxAdicionarFornecedor.Name = "groupBoxAdicionarFornecedor";
            this.groupBoxAdicionarFornecedor.Size = new System.Drawing.Size(722, 557);
            this.groupBoxAdicionarFornecedor.TabIndex = 15;
            this.groupBoxAdicionarFornecedor.TabStop = false;
            // 
            // textBoxBairro
            // 
            this.textBoxBairro.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxBairro.Location = new System.Drawing.Point(261, 422);
            this.textBoxBairro.Name = "textBoxBairro";
            this.textBoxBairro.Size = new System.Drawing.Size(396, 22);
            this.textBoxBairro.TabIndex = 30;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label11.Location = new System.Drawing.Point(266, 396);
            this.label11.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(78, 17);
            this.label11.TabIndex = 29;
            this.label11.Text = "BAIRRO:";
            // 
            // textBoxComplemento
            // 
            this.textBoxComplemento.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxComplemento.Location = new System.Drawing.Point(320, 475);
            this.textBoxComplemento.Name = "textBoxComplemento";
            this.textBoxComplemento.Size = new System.Drawing.Size(342, 22);
            this.textBoxComplemento.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label10.Location = new System.Drawing.Point(327, 449);
            this.label10.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(135, 17);
            this.label10.TabIndex = 27;
            this.label10.Text = "COMPLEMENTO:";
            // 
            // textBoxCidadeEstado
            // 
            this.textBoxCidadeEstado.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxCidadeEstado.Location = new System.Drawing.Point(57, 475);
            this.textBoxCidadeEstado.Name = "textBoxCidadeEstado";
            this.textBoxCidadeEstado.Size = new System.Drawing.Size(220, 22);
            this.textBoxCidadeEstado.TabIndex = 26;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(64, 449);
            this.label9.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(150, 17);
            this.label9.TabIndex = 25;
            this.label9.Text = "CIDADE/ESTADO:";
            // 
            // textBoxNum
            // 
            this.textBoxNum.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxNum.Location = new System.Drawing.Point(57, 422);
            this.textBoxNum.Name = "textBoxNum";
            this.textBoxNum.Size = new System.Drawing.Size(148, 22);
            this.textBoxNum.TabIndex = 24;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(60, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(82, 17);
            this.label8.TabIndex = 23;
            this.label8.Text = "NUMERO:";
            // 
            // textBoxLogradouro
            // 
            this.textBoxLogradouro.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxLogradouro.Location = new System.Drawing.Point(261, 365);
            this.textBoxLogradouro.Name = "textBoxLogradouro";
            this.textBoxLogradouro.Size = new System.Drawing.Size(396, 22);
            this.textBoxLogradouro.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(266, 339);
            this.label7.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 17);
            this.label7.TabIndex = 21;
            this.label7.Text = "LOGRADOURO:";
            // 
            // textBoxCEP
            // 
            this.textBoxCEP.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxCEP.Location = new System.Drawing.Point(57, 365);
            this.textBoxCEP.Name = "textBoxCEP";
            this.textBoxCEP.Size = new System.Drawing.Size(148, 22);
            this.textBoxCEP.TabIndex = 20;
            this.textBoxCEP.TextChanged += new System.EventHandler(this.textBoxCEP_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(64, 339);
            this.label4.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 19;
            this.label4.Text = "CEP:";
            // 
            // textBoxDataNascimento
            // 
            this.textBoxDataNascimento.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxDataNascimento.Location = new System.Drawing.Point(308, 233);
            this.textBoxDataNascimento.Name = "textBoxDataNascimento";
            this.textBoxDataNascimento.Size = new System.Drawing.Size(349, 22);
            this.textBoxDataNascimento.TabIndex = 18;
            this.textBoxDataNascimento.TextChanged += new System.EventHandler(this.textBoxDataNascimento_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(327, 206);
            this.label6.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(195, 17);
            this.label6.TabIndex = 17;
            this.label6.Text = "DATA DE NASCIMENTO:";
            // 
            // textBoxNomeESobrenome
            // 
            this.textBoxNomeESobrenome.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxNomeESobrenome.Location = new System.Drawing.Point(308, 104);
            this.textBoxNomeESobrenome.Name = "textBoxNomeESobrenome";
            this.textBoxNomeESobrenome.Size = new System.Drawing.Size(349, 22);
            this.textBoxNomeESobrenome.TabIndex = 16;
            this.textBoxNomeESobrenome.TextChanged += new System.EventHandler(this.textBoxNomeESobrenome_TextChanged);
            // 
            // comboBoxDepartamento
            // 
            this.comboBoxDepartamento.DataSource = this.tipoFuncionarioBindingSource;
            this.comboBoxDepartamento.DisplayMember = "descricao";
            this.comboBoxDepartamento.Font = new System.Drawing.Font("Verdana", 9F);
            this.comboBoxDepartamento.FormattingEnabled = true;
            this.comboBoxDepartamento.Location = new System.Drawing.Point(308, 301);
            this.comboBoxDepartamento.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.comboBoxDepartamento.Name = "comboBoxDepartamento";
            this.comboBoxDepartamento.Size = new System.Drawing.Size(349, 22);
            this.comboBoxDepartamento.TabIndex = 14;
            this.comboBoxDepartamento.ValueMember = "descricao";
            this.comboBoxDepartamento.SelectedIndexChanged += new System.EventHandler(this.comboBoxDepartamento_SelectedIndexChanged);
            // 
            // textBoxCPF
            // 
            this.textBoxCPF.Font = new System.Drawing.Font("Verdana", 9F);
            this.textBoxCPF.Location = new System.Drawing.Point(308, 168);
            this.textBoxCPF.Name = "textBoxCPF";
            this.textBoxCPF.Size = new System.Drawing.Size(349, 22);
            this.textBoxCPF.TabIndex = 11;
            this.textBoxCPF.TextChanged += new System.EventHandler(this.textBoxCPF_TextChanged);
            // 
            // buttonConfirmar
            // 
            this.buttonConfirmar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(83)))), ((int)(((byte)(131)))), ((int)(((byte)(23)))));
            this.buttonConfirmar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonConfirmar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonConfirmar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.buttonConfirmar.Location = new System.Drawing.Point(269, 515);
            this.buttonConfirmar.Name = "buttonConfirmar";
            this.buttonConfirmar.Size = new System.Drawing.Size(133, 25);
            this.buttonConfirmar.TabIndex = 10;
            this.buttonConfirmar.Text = "CONFIRMAR";
            this.buttonConfirmar.UseVisualStyleBackColor = false;
            this.buttonConfirmar.Click += new System.EventHandler(this.buttonConfirmar_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(327, 271);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 17);
            this.label5.TabIndex = 5;
            this.label5.Text = "DEPARTAMENTO:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(327, 142);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 13, 3, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 17);
            this.label3.TabIndex = 3;
            this.label3.Text = "CPF:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(327, 78);
            this.label2.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(180, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "NOME E SOBRENOME:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(86, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(115, 15, 115, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(538, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "ADICIONAR NOVO FUNCIONARIO:";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PerifaZenda.Properties.Resources.AdicionarNovoFuncionario;
            this.pictureBox1.Location = new System.Drawing.Point(33, 137);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(30, 130, 3, 130);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(198, 172);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // dbPerifaZendaDataSet
            // 
            this.dbPerifaZendaDataSet.DataSetName = "dbPerifaZendaDataSet";
            this.dbPerifaZendaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tipoFuncionarioBindingSource
            // 
            this.tipoFuncionarioBindingSource.DataMember = "TipoFuncionario";
            this.tipoFuncionarioBindingSource.DataSource = this.dbPerifaZendaDataSet;
            // 
            // tipoFuncionarioTableAdapter
            // 
            this.tipoFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // AdicionarFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackgroundImage = global::PerifaZenda.Properties.Resources.backgroundTelas1;
            this.ClientSize = new System.Drawing.Size(800, 605);
            this.Controls.Add(this.buttonHome);
            this.Controls.Add(this.groupBoxAdicionarFornecedor);
            this.Name = "AdicionarFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Adicionar Novo Funcionario";
            this.Load += new System.EventHandler(this.AdicionarFuncionario_Load_1);
            this.groupBoxAdicionarFornecedor.ResumeLayout(false);
            this.groupBoxAdicionarFornecedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbPerifaZendaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tipoFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonHome;
        private System.Windows.Forms.GroupBox groupBoxAdicionarFornecedor;
        private System.Windows.Forms.TextBox textBoxCPF;
        private System.Windows.Forms.Button buttonConfirmar;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBoxNomeESobrenome;
        private System.Windows.Forms.TextBox textBoxDataNascimento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxCEP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxCidadeEstado;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBoxNum;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox textBoxLogradouro;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBoxComplemento;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBoxBairro;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ComboBox comboBoxDepartamento;
        private dbPerifaZendaDataSet dbPerifaZendaDataSet;
        private System.Windows.Forms.BindingSource tipoFuncionarioBindingSource;
        private dbPerifaZendaDataSetTableAdapters.TipoFuncionarioTableAdapter tipoFuncionarioTableAdapter;
    }
}