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
    public partial class AtualizarEstoque : Form
    {
        public AtualizarEstoque()
        {
            InitializeComponent();

        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            int qtdEstoque = (int)numericAtualizarEstoque.Value;

            string verificar = textBoxProduto.Text.Trim();

            if (int.TryParse(verificar, out int produtoId))
            {
                db.AtualizarEstoque(qtdEstoque, null, produtoId);
            }
            else
            {
                db.AtualizarEstoque(qtdEstoque, verificar, 0);
            }
            MessageBox.Show("Produto atualizado no estoque com sucesso!");

        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
