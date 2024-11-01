using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PerifaZenda
{
    public partial class AdicionarFornecedor : Form
    {
        public AdicionarFornecedor()
        {
            InitializeComponent();

            textBoxCEP.TextChanged += new EventHandler(textBoxCEP_TextChanged);
            textBoxCEP.KeyPress += new KeyPressEventHandler(textBoxCEP_KeyPress);
            textBoxCNPJ.TextChanged += new EventHandler(textBoxCNPJ_TextChanged);
            textBoxCNPJ.KeyPress += new KeyPressEventHandler(textBoxCNPJ_KeyPress);
            textBoxNum.KeyPress += new KeyPressEventHandler(textBoxNum_KeyPress);
        }

        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }
        }

        private void textBoxCEP_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }

            // Evita mais numeros que o necesario
            if (textBoxCEP.Text.Length > 8 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Colocar "-" no CEP.
        private void textBoxCEP_TextChanged(object sender, EventArgs e)
        {
            textBoxCEP.TextChanged -= textBoxCEP_TextChanged;

            string text = textBoxCEP.Text.Replace("-", "");

            if (text.Length > 0)
            {
                if (text.Length >= 5)
                {
                    text = text.Insert(5, "-");
                }
            }

            textBoxCEP.Text = text;

            textBoxCEP.SelectionStart = textBoxCEP.Text.Length;

            textBoxCEP.TextChanged += textBoxCEP_TextChanged;

        }

        private void textBoxCNPJ_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }

            if (!char.IsControl(e.KeyChar) && textBoxCNPJ.Text.Length > 17)
            {
                e.Handled = true; // Cancela a entrada
            }
        }

        // Colocar "." e "-" nas posicoes corretas no CPF.
        private void textBoxCNPJ_TextChanged(object sender, EventArgs e)
        {
            // Remove o evento temporariamente para evitar loops
            textBoxCNPJ.TextChanged -= textBoxCNPJ_TextChanged;

            string text = textBoxCNPJ.Text.Replace(".", "").Replace("-", "").Replace("/", "");

            if (text.Length > 0)
            {
                if (text.Length >= 2)
                {
                    text = text.Insert(2, ".");
                }
                if (text.Length >= 6)
                {
                    text = text.Insert(6, ".");
                }
                if (text.Length >= 10)
                {
                    text = text.Insert(10, "/");
                }
                if (text.Length >= 15)
                {
                    text = text.Insert(15, "-");
                }

            }

            textBoxCNPJ.Text = text;

            textBoxCNPJ.SelectionStart = textBoxCNPJ.Text.Length;

            textBoxCNPJ.TextChanged += textBoxCNPJ_TextChanged;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            // Campos obrigatorios
            string nome = textBoxRazaoSocial.Text.Trim();
            string cnpj = textBoxCNPJ.Text.Trim();
            string cep = textBoxCEP.Text.Trim();
            string logradouro = textBoxLogradouro.Text.Trim();
            string cidadeEstado = textBoxCidadeEstado.Text.Trim();
            string bairro = textBoxBairro.Text.Trim();
            string numero = textBoxNum.Text.Trim();
            // Campos que podem ser nulos
            string complemento = textBoxComplemento.Text.Trim();

            string mensagem = "";

            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cnpj) || cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Trim().Length != 14 ||
                string.IsNullOrEmpty(cep) || cep.Replace("-", "").Trim().Length != 8 || string.IsNullOrEmpty(numero) ||
                string.IsNullOrEmpty(logradouro) || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cidadeEstado))
            {
                mensagem = "Os seguintes campos são obrigatórios:\n";

                if (string.IsNullOrEmpty(nome)) mensagem += "- Razão social\n";
                if (cnpj.Replace(".", "").Replace("-", "").Replace("/", "").Trim().Length != 14)
                    mensagem += "- CNPJ (deve ter 14 dígitos)\n";
                if (string.IsNullOrEmpty(cep) || cep.Replace("-", "").Trim().Length != 8)
                    mensagem += "- CEP (deve ter 8 dígitos)\n";
                if (string.IsNullOrEmpty(logradouro)) mensagem += "- Logradouro\n";
                if (string.IsNullOrEmpty(numero)) mensagem += "- Numero\n";
                if (string.IsNullOrEmpty(bairro)) mensagem += "- Bairro\n";
                if (string.IsNullOrEmpty(cidadeEstado)) mensagem += "- Cidade/Estado\n";

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool incluirFornecedor = db.IncluirFornecedor(cnpj, nome, cep, logradouro, numero, bairro, cidadeEstado, complemento);
        }
    }
}
