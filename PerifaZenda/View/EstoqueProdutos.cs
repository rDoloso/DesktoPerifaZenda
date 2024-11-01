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
    public partial class EstoqueProdutos : Form
    {
        public EstoqueProdutos()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBoxCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Database db = new Database();
            textBoxQuantidade.Text = "";
            int qtdEstoque = 0;

            string verificarProduto = textBoxProduto.Text.Trim();

            if (int.TryParse(verificarProduto, out int produtoId))
            {
                qtdEstoque = db.VerificaQTDItemEstoque(null, produtoId);
            }
            else
            {
                qtdEstoque = db.VerificaQTDItemEstoque(verificarProduto, 0);
            }
            textBoxQuantidade.Text = qtdEstoque.ToString();



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
