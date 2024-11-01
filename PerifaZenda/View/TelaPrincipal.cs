using PerifaZenda.View;
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
    public partial class TelaPrincipal : Form
    {
        private string usuario;

        public TelaPrincipal(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

            usuarioLogado.Text = usuario;

            Timer timer = new Timer();
            timer.Interval = 1000; // 1 segundo
            timer.Tick += dataEHora;
            timer.Start();

        }

        private void dataEHora(object sender, EventArgs e)
        {

            DateTime dataAtual = DateTime.Now;

            string dataHora = dataAtual.ToString("dd/MM/yyyy HH:mm:ss");

            labelDataEHora.Text = dataHora;
        }

        private void buttonAdicionarFuncionario_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarFuncionario adicionarFuncionario = new AdicionarFuncionario();
                this.Hide();
                adicionarFuncionario.FormClosed += (s, args) => this.Show();
                adicionarFuncionario.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                this.Show();
            }
            
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            try
            {
                AdicionarProduto adicionarProduto = new AdicionarProduto();
                this.Hide();
                adicionarProduto.FormClosed += (s, args) => this.Show();
                adicionarProduto.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                this.Show();
            }
        }

        private void buttonPedirFornecedor_Click(object sender, EventArgs e)
        {
            try
            {
                PedidoFornecedor pedidoFornecedor = new PedidoFornecedor();
                this.Hide();
                pedidoFornecedor.FormClosed += (s, args) => this.Show();
                pedidoFornecedor.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                this.Show();
            }
        }

        private void buttonAtualizarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                AtualizarEstoque atualizarEstoque = new AtualizarEstoque();
                this.Hide();
                atualizarEstoque.FormClosed += (s, args) => this.Show();
                atualizarEstoque.ShowDialog();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                this.Show();
            }
        }

        private void buttonVerificarEstoque_Click(object sender, EventArgs e)
        {
            try
            {
                ConsultarDados consultarDados = new ConsultarDados();
                this.Hide();
                consultarDados.FormClosed += (s, args) => this.Show();
                consultarDados.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                this.Show();
            }
        }

        private void buttonDarPermissao_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            string cargo = db.VerificaCargoFuncionario(usuario);

            if (cargo == "Admin")
            {
                try
                {
                    Permissoes permissoes = new Permissoes();
                    this.Hide();
                    permissoes.FormClosed += (s, args) => this.Show();
                    permissoes.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Ocorreu um erro: {ex.Message}");
                    this.Show();
                }
            }
            else
            {
                MessageBox.Show("Você não tem a permissão necessária!");
            }
            
        }

        private void buttonSair_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("Você realmente deseja sair?", "Confirmação", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void buttonAdicionarFornecedor_Click(object sender, EventArgs e)
        {
            AdicionarFornecedor atualizarEstoque = new AdicionarFornecedor();
            this.Hide();
            atualizarEstoque.FormClosed += (s, args) => this.Show();
            atualizarEstoque.ShowDialog();
        }

        private void buttonVender_Click(object sender, EventArgs e)
        {
            Vendas vendas = new Vendas();
            this.Hide();
            vendas.FormClosed += (s, args) => this.Show();
            vendas.ShowDialog();
        }
    }
}
