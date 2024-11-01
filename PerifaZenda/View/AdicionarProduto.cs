using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PerifaZenda
{
    public partial class AdicionarProduto : Form
    {
        public AdicionarProduto()
        {
            InitializeComponent();

            textBoxPrecoProduto.KeyPress += new KeyPressEventHandler(textBoxPrecoProduto_KeyPress);
        }

        private void comboBoxTipoProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (comboBoxTipoProduto.SelectedItem is DataRowView rowView)
            {
                string tipoProdutoSelecionado = rowView["descricao"].ToString().Trim(); 

                switch (tipoProdutoSelecionado)
                {
                    case "Produção própria":
                        comboBoxFornecedor.Enabled = false;
                        comboBoxFornecedor.SelectedIndex = -1; 
                        comboBoxFornecedor.Text = "";
                        break;
                    case "Fornecido":
                        comboBoxFornecedor.Enabled = true;
                        break;
                    default:
                        MessageBox.Show("Tipo de produto inválido.");
                        return;
                }
            }
        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBoxCodProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
          
        }

        private void textBoxPrecoProduto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' && textBoxPrecoProduto.Text.Length > 0)
            {
                if (textBoxPrecoProduto.Text.Contains('.'))
                {
                    e.Handled = true;
                }
            }
            else if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled= true;
            }

            if (textBoxPrecoProduto.Text.Contains("."))
            {
                string[] numPosPonto = textBoxPrecoProduto.Text.Split('.');
                if (numPosPonto.Length > 1 && numPosPonto[1].Length >= 2 && !char.IsControl(e.KeyChar))
                {
                    e.Handled = true; // Cancela a entrada se já houver 2 dígitos após o ponto
                }
            }
        }

        private void textBoxNomeProduto_TextChanged(object sender, EventArgs e)
        {

        }


        private void AdicionarProduto_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPerifaZendaDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.dbPerifaZendaDataSet.Fornecedor);
            // TODO: This line of code loads data into the 'dbPerifaZendaDataSet.TipoProduto' table. You can move, or remove it, as needed.
            this.tipoProdutoTableAdapter.Fill(this.dbPerifaZendaDataSet.TipoProduto);


            comboBoxTipoProduto.SelectedIndex = -1;
            comboBoxFornecedor.SelectedIndex = -1;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string nomeProduto = textBoxNomeProduto.Text.Trim();
            string precoText = textBoxPrecoProduto.Text.Trim();
            string tipoProduto = comboBoxTipoProduto.SelectedItem?.ToString();
            string fornecedor = comboBoxFornecedor.SelectedItem?.ToString();
            double precoProduto;
            int tipoProdutoInt;


            // Pegar dado da RowView do Tipo de produto.

            if (comboBoxTipoProduto.SelectedItem is DataRowView rowViewProduto)
            {
                tipoProduto = rowViewProduto["descricao"].ToString().Trim();
            }
                

            // Pegar dado da RowView do Fornecedor.
            int fornecedorId = 0;
            DataRowView rowViewFornecedor = comboBoxFornecedor.SelectedItem as DataRowView;
            if (rowViewFornecedor != null)
            {
                string fornecedorIdText = rowViewFornecedor["idFornecedor"].ToString().Trim();
                

                if (!int.TryParse(rowViewFornecedor["idFornecedor"].ToString(), out fornecedorId))
                {
                    MessageBox.Show("ID do fornecedor inválido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
            }


            if (double.TryParse(precoText, NumberStyles.Any, CultureInfo.InvariantCulture, out precoProduto))
            {
                MessageBox.Show($"Preço do produto: {precoProduto}");
            }
           


            //Verifica entrada

            if (string.IsNullOrEmpty(nomeProduto) || string.IsNullOrEmpty(precoText) || string.IsNullOrEmpty(tipoProduto))
            {
                string mensagem = "";

                mensagem = "Os seguintes campos são obrigatórios:\n";

                if (string.IsNullOrEmpty(nomeProduto)) mensagem += "- Nome do produto\n";
                if (string.IsNullOrEmpty(precoText)) mensagem += "- Preço do produto\n";
                if (string.IsNullOrEmpty(tipoProduto)) 
                { 
                    mensagem += "- Tipo do produto\n"; 
                }else if (tipoProduto.Trim() == "Fornecido" && rowViewFornecedor == null)
                {
                    mensagem += "- Fornecedor do produto\n";
                }


                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            switch (tipoProduto.Trim())
            {
                case "Produção própria":
                    tipoProdutoInt = 1;
                    break;
                case "Fornecido":
                    tipoProdutoInt = 2;
                    break;
                default:
                    MessageBox.Show("Tipo de produto Invalido.");
                    return;
            }

            if (tipoProduto== "Produção própria")
            {
                fornecedorId = 0;
            }

            // GERAR CODIGO DO PRODUTO
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder(8);

            for (int i = 0; i < 8; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            string codigoProduto = result.ToString();

            Database db = new Database();

            bool addProduto = db.AdicionarProduto(tipoProdutoInt,codigoProduto, nomeProduto, precoProduto, fornecedorId);

            if (addProduto) MessageBox.Show("Produto adicionado no estoque com sucesso!");
        }

        
    }
}
