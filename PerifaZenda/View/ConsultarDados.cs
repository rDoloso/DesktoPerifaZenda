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
    public partial class ConsultarDados : Form
    {
        public ConsultarDados()
        {
            InitializeComponent();
        }

        private void groupBoxInformacoes_Enter(object sender, EventArgs e)
        {

        }

        private void buttonCliente_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Cliente");

            dataGridView1.DataSource = dados;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonCompras_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Compra");

            dataGridView1.DataSource = dados;
        }

        private void buttonEstoque_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Estoque");

            dataGridView1.DataSource = dados;
        }

        private void buttonFornecedor_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Fornecedor");

            dataGridView1.DataSource = dados;
        }

        private void buttonFuncionarios_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Funcionario");

            dataGridView1.DataSource = dados;
        }

        private void buttonProdutos_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Produto");

            dataGridView1.DataSource = dados;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            DataTable dados = db.ConsultarDados("Venda");

            dataGridView1.DataSource = dados;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
