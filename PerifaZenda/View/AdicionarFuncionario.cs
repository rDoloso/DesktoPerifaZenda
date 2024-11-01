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
    public partial class AdicionarFuncionario : Form
    {
        public AdicionarFuncionario()
        {
            InitializeComponent();

            textBoxDataNascimento.TextChanged += new EventHandler(textBoxDataNascimento_TextChanged);
            textBoxCPF.TextChanged += new EventHandler(textBoxCPF_TextChanged);
            textBoxCEP.TextChanged += new EventHandler(textBoxCEP_TextChanged);
            textBoxDataNascimento.KeyPress += new KeyPressEventHandler(textBoxDataNascimento_KeyPress);
            textBoxNum.KeyPress += new KeyPressEventHandler(textBoxNum_KeyPress);
            textBoxCPF.KeyPress += new KeyPressEventHandler(textBoxCPF_KeyPress);
            textBoxCEP.KeyPress += new KeyPressEventHandler(textBoxCEP_KeyPress);
        }

        // Controle para aceitar apenas numeros como digitos na textBoxDataNascimento.
        private void textBoxDataNascimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }

            // Evita mais numeros que o necesario
            if (textBoxDataNascimento.Text.Length > 9 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        // Colocar "/" no formato de data e validar data.
        private void textBoxDataNascimento_TextChanged(object sender, EventArgs e)
        {
            // Evita mais numeros que o necesario


            // Remove o evento temporariamente para evitar loops
            textBoxDataNascimento.TextChanged -= textBoxDataNascimento_TextChanged;

            // Verifica se já tem a barra e o número de caracteres
            string text = textBoxDataNascimento.Text.Replace("/", "");

            // Verifica o comprimento e formata colocando "/"
            if (text.Length > 0)
            {
                if (text.Length >= 2)
                {
                    text = text.Insert(2, "/");
                }
                if (text.Length >= 5)
                {
                    text = text.Insert(5, "/");
                }
            }

            // Atualiza texto da textBox
            textBoxDataNascimento.Text = text;
           
            // Coloca o cursor no final do texto
            textBoxDataNascimento.SelectionStart = textBoxDataNascimento.Text.Length;

            textBoxDataNascimento.TextChanged += textBoxDataNascimento_TextChanged;


            // Validação da data
            if (textBoxDataNascimento.Text.Length == 10)
            {
                DateTime dataNascimento;
                bool isValidDate = DateTime.TryParseExact(textBoxDataNascimento.Text, "dd/MM/yyyy",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out dataNascimento);

                if (!isValidDate || dataNascimento > DateTime.Now)
                {
                    MessageBox.Show("Data inválida! Por favor, insira uma data correta 'DD/MM/YYYY'.",
                        "Erro",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    // Limpa o textBox
                    textBoxDataNascimento.Clear();
                }
            }
        }

        // Controle para aceitar apenas numeros como digitos na textBoxNum.
        private void textBoxNum_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Verifica se a tecla pressionada não é um dígito e não é a tecla de controle (como Backspace)
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }
        }

        // Controle para aceitar apenas numeros como digitos na textBoxCPF.
        private void textBoxCPF_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancela a entrada
            }

            if (!char.IsControl(e.KeyChar) && textBoxCPF.Text.Length > 13)
            {
                e.Handled = true; // Cancela a entrada
            }
        }

        // Colocar "." e "-" nas posicoes corretas no CPF.
        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {
            // Remove o evento temporariamente para evitar loops
            textBoxCPF.TextChanged -= textBoxCPF_TextChanged;

            string text = textBoxCPF.Text.Replace(".", "").Replace("-", "");

            if (text.Length > 0)
            {
                if(text.Length >= 3)
                {
                    text = text.Insert(3, ".");
                }
                if (text.Length >= 7)
                {
                    text = text.Insert(7, ".");
                }
                if (text.Length >= 11)
                {
                    text = text.Insert(11, "-");
                }

            }

            textBoxCPF.Text = text;

            textBoxCPF.SelectionStart = textBoxCPF.Text.Length;

            textBoxCPF.TextChanged += textBoxCPF_TextChanged;
        }

        // Controle para aceitar apenas numeros como digitos no CEP.
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
                if(text.Length >= 5)
                {
                    text = text.Insert(5, "-");
                }
            }

            textBoxCEP.Text = text;

            textBoxCEP.SelectionStart = textBoxCEP.Text.Length;

            textBoxCEP.TextChanged += textBoxCEP_TextChanged;

        }

        private void AdicionarFuncionario_Load(object sender, EventArgs e)
        {
 

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            // Campos obrigatorios
            string nome = textBoxNomeESobrenome.Text.Trim();
            string cpf = textBoxCPF.Text.Trim();
            string dataNasc = textBoxDataNascimento.Text.Trim();
            string departamento = comboBoxDepartamento.Text.Trim();
            string cep = textBoxCEP.Text.Trim();
            string logradouro = textBoxLogradouro.Text.Trim();
            string cidadeEstado = textBoxCidadeEstado.Text.Trim();
            string bairro = textBoxBairro.Text.Trim();
            string cargo = comboBoxDepartamento.SelectedItem?.ToString();
            // Campos que podem ser nulos
            string numero = textBoxNum.Text.Trim();
            string complemento = textBoxComplemento.Text.Trim();

            string mensagem = "";

            // Verifica entradas
            if (string.IsNullOrEmpty(nome) || string.IsNullOrEmpty(cpf) || cpf.Replace(".", "").Replace("-", "").Trim().Length != 11||
                string.IsNullOrEmpty(dataNasc) || dataNasc.Replace("/", "").Trim().Length != 8 || string.IsNullOrEmpty(departamento) || 
                string.IsNullOrEmpty(cep) || cep.Replace("-", "").Trim().Length != 8 ||
                string.IsNullOrEmpty(logradouro) || string.IsNullOrEmpty(bairro) || string.IsNullOrEmpty(cidadeEstado))
            {
                mensagem = "Os seguintes campos são obrigatórios:\n";

                if (string.IsNullOrEmpty(nome)) mensagem += "- Nome\n";
                if (string.IsNullOrEmpty(cpf) || cpf.Replace(".", "").Replace("-", "").Trim().Length != 11) 
                    mensagem += "- CPF (deve ter 11 dígitos)\n";
                if (string.IsNullOrEmpty(dataNasc) || dataNasc.Replace("/", "").Trim().Length != 8)
                    mensagem += "- Data de Nascimento (deve ter 8 dígitos dd/mm/yyyy)\n";
                if (string.IsNullOrEmpty(departamento)) mensagem += "- Departamento\n";
                if (string.IsNullOrEmpty(cep) || cep.Replace("-", "").Trim().Length != 8) 
                    mensagem += "- CEP (deve ter 8 dígitos)\n";
                if (string.IsNullOrEmpty(logradouro)) mensagem += "- Logradouro\n";
                if (string.IsNullOrEmpty(bairro)) mensagem += "- Bairro\n";
                if (string.IsNullOrEmpty(cidadeEstado)) mensagem += "- Cidade/Estado\n";

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            DataRowView rowView = comboBoxDepartamento.SelectedItem as DataRowView;
            string cargoNome = rowView["descricao"].ToString().Trim();

            int cargoInt = 0;
            // Identifica cargo e passa para o id do cargo
            switch (cargoNome.Trim())
            {
                case "Admin":
                    cargoInt = 1;
                    break;
                case "Vendedor":
                    cargoInt = 2;
                    break;
                case "Entregador":
                    cargoInt = 3;
                    break;
                default:
                    MessageBox.Show("Cargo Invalido");
                    return;
            }
            bool incluirFuncionario = db.IncluirFuncionario(cpf, cargoInt, nome, dataNasc, cep, logradouro, bairro, cidadeEstado, numero, complemento);

            if (incluirFuncionario)
            {
                CriarUsuario criarUsuario = new CriarUsuario(db.BuscarIdFuncionario(cpf));

                criarUsuario.ShowDialog();
            }

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBoxNomeESobrenome_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxDepartamento_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AdicionarFuncionario_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPerifaZendaDataSet.TipoFuncionario' table. You can move, or remove it, as needed.
            this.tipoFuncionarioTableAdapter.Fill(this.dbPerifaZendaDataSet.TipoFuncionario);

        }
    }

    
}
