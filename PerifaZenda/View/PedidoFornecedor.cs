using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PerifaZenda.PedidoFornecedor;

namespace PerifaZenda
{
    public partial class PedidoFornecedor : Form
    {
        public PedidoFornecedor()
        {
            InitializeComponent();
        }

        public class Produto
        {
            public double Preco { get; set; }
            public string Nome { get; set; }

            public int Id { get; set; }
        }



        private void PedidoFornecedor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbPerifaZendaDataSet.Fornecedor' table. You can move, or remove it, as needed.
            this.fornecedorTableAdapter.Fill(this.dbPerifaZendaDataSet.Fornecedor);

           
            comboBoxFornecedor.SelectedIndex = -1;
            comboBoxProduto.SelectedIndex = -1;


        }

        private void CarregarProdutosDoFornecedor(int idFornecedor)
        {
            // String de conexão com o banco de dados
            string StringConexao = "Server=tcp:perifazendaserver.database.windows.net,1433;Initial Catalog=dbPerifaZenda;Persist Security Info=False;User ID=adminperifazenda;Password=Admin@perifazenda;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";


            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                string query = "SELECT nome, preco, idProduto FROM Produto WHERE fkFornecedor = @IdFornecedor;";

                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@IdFornecedor", idFornecedor);

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        var produtos = new List<Produto>();
                        while (reader.Read())
                        {
                            string nome = reader["nome"].ToString();
                            int idProduto = Convert.ToInt32(reader["idProduto"]);
                            double preco = Convert.ToDouble(reader["preco"]);
                            produtos.Add(new Produto { Preco = preco, Nome = nome, Id = idProduto });
                        }

                        // Atualiza a ComboBox de produtos
                        comboBoxProduto.DataSource = produtos;
                        comboBoxProduto.DisplayMember = "Nome";
                        comboBoxProduto.ValueMember = "Preco";
                    }
                }
            }
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {

            //Verificar entradas
            string fornecedor = comboBoxFornecedor.Text.Trim();
            string produtoText = comboBoxProduto.Text.Trim();
            int quantidade = (int)numericQuantidade.Value;


            if (string.IsNullOrEmpty(fornecedor) || string.IsNullOrEmpty(produtoText) || quantidade <= 0)
            {
                string mensagem = "Os seguintes campos são obrigatórios:\n";

                if (string.IsNullOrEmpty(fornecedor)) mensagem += "- Fornecedor\n";
                if (string.IsNullOrEmpty(produtoText)) mensagem += "- Produto\n";
                if (quantidade <= 0) mensagem += "- Quantidade (Digite um valor válido)";

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int idProduto = 0;
            if (comboBoxProduto.SelectedItem is Produto produto)
            {
                idProduto = produto.Id; 
            }

            Database db = new Database();
            bool compra = db.FazerCompra((int)numericQuantidade.Value, idProduto);
           
        }

      

        private void numericQuantidade_ValueChanged(object sender, EventArgs e)
        {
          
            if (comboBoxProduto.SelectedValue != null)
            {
                int quantidade = (int)numericQuantidade.Value;

                if (double.TryParse(comboBoxProduto.SelectedValue.ToString(), out double preco))
                {
                    double resultado = preco * quantidade;
                    string resultadoString = resultado.ToString("F2");

                    textBoxPreco.Text = "R$ " + resultadoString;
                }
            }
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void comboBoxProduto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxFornecedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBoxFornecedor.SelectedItem != null)
            {
                int idFornecedor = Convert.ToInt32(comboBoxFornecedor.SelectedValue);
                CarregarProdutosDoFornecedor(idFornecedor);

            }
        }
    }
}
