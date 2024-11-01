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
    public partial class Vendas : Form
    {
        public Vendas()
        {
            InitializeComponent();
            dataGridViewProdutosVenda.Columns.Add("idProduto", "ID");
            dataGridViewProdutosVenda.Columns["idProduto"].Width = 25;
            dataGridViewProdutosVenda.Columns.Add("nome", "Nome");
            dataGridViewProdutosVenda.Columns.Add("codProduto", "Código");
            dataGridViewProdutosVenda.Columns["codProduto"].Width = 75;
            dataGridViewProdutosVenda.Columns.Add("preco", "Preço");
            dataGridViewProdutosVenda.Columns["preco"].Width = 60;
            dataGridViewProdutosVenda.Columns.Add("quantidade", "Quantidade");
            dataGridViewProdutosVenda.Columns["quantidade"].Width = 70;
            dataGridViewProdutosVenda.Columns.Add("precoTotalProduto", "Preço Total");
            dataGridViewProdutosVenda.Columns["precoTotalProduto"].Width = 75;

            dataGridViewProdutosVenda.Columns.Add(new DataGridViewButtonColumn()
            {
                Name = "btnRemover",
                HeaderText = "Remover",
                Text = "Remover",
                UseColumnTextForButtonValue = true
            });
            dataGridViewProdutosVenda.Columns["btnRemover"].Width = 70;

            dataGridViewProdutosVenda.CellContentClick += dataGridViewProdutosVenda_CellContentClick;

        }

        //REMOVE PRODUTO DESEJADO DA DATAGRID 
        private void dataGridViewProdutosVenda_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridViewProdutosVenda.Columns["btnRemover"].Index)
            {
                if (!dataGridViewProdutosVenda.Rows[e.RowIndex].IsNewRow)
                {
                    dataGridViewProdutosVenda.Rows.RemoveAt(e.RowIndex);
                    AtualizarValorTotal();
                }
            }
        }

        //ATUALIZA O VALOR APOS EXCLUSAO DA DATAGRID
        private void AtualizarValorTotal()
        {
            double precoTotalVenda = 0;

            foreach (DataGridViewRow row in dataGridViewProdutosVenda.Rows)
            {
                if (row.IsNewRow) continue;

                double precoTotalProduto = Convert.ToDouble(row.Cells["precoTotalProduto"].Value);
                precoTotalVenda += precoTotalProduto;
            }

            textBoxValorTotal.Text = $"R$ {precoTotalVenda}";
        }

        private void buttonAdicionarProduto_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            string produtoText = textBoxProduto.Text.Trim();
            int quantidade = (int)numericQuantidade.Value;


            int idProduto = 0;
            if (int.TryParse(produtoText, out int id))
            {
                idProduto = db.BuscarProdutoPorId(id);
            }
            else
            {
                idProduto = db.BuscarProdutoPorCodigo(produtoText);
            }

            int qtdEstoque = db.VerificaQTDItemEstoque(id: idProduto);

            if (idProduto == 0)
            {
                MessageBox.Show($"Não foi possivel encontrar produto pelo id ou codigo: {produtoText}.");
                return;
            }

            if(qtdEstoque < quantidade)
            {
                MessageBox.Show("A quantidade solicitada excede o estoque disponível. Por favor, ajuste a quantidade ou verifique o estoque.", "Quantidade Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning); 
                return;
            }

            string StringConexao = "Server=tcp:perifazendaserver.database.windows.net,1433;Initial Catalog=dbPerifaZenda;Persist Security Info=False;User ID=adminperifazenda;Password=Admin@perifazenda;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

            //BANCO PARA TESTE
            //string StringConexao = "Data Source=DESKTOP-B0T0JQ1;Initial Catalog = DbFazendaUrbana; Integrated Security = True; MultipleActiveResultSets=True;";

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = @"SELECT nome, codProduto, preco FROM Produto WHERE idProduto = @IdProduto;";

                    using (SqlCommand comando = new SqlCommand(query, conexao))
                    {
                        comando.Parameters.AddWithValue("@IdProduto", idProduto);

                        using (SqlDataReader reader = comando.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string nome = reader["nome"].ToString();
                                string codProduto = reader["codProduto"].ToString();
                                double preco = Convert.ToDouble(reader["preco"]);
                                double precoTotalProduto = preco * quantidade;

                                dataGridViewProdutosVenda.Rows.Add(idProduto, nome, codProduto, preco, quantidade, precoTotalProduto);
                            }
                            else
                            {
                                MessageBox.Show("Produto não encontrado na base de dados.");
                            }
                        }
                    }
                }
                catch (Exception ex) { MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message); }

                AtualizarValorTotal();
            }

            
        }

        private void buttonFinalizarVenda_Click(object sender, EventArgs e)
        {
            Database db = new Database();

            //PEGAR VALOR TOTAL
            double valorTot = Convert.ToDouble(textBoxValorTotal.Text.Replace("R", "").Replace("$", "").Trim());

            if(valorTot == 0) { MessageBox.Show("Por favor, adicione algum produto para realizar a compra!", "Carrinho Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning); return; }

            // GERAR CODIGO DA VENDA
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            StringBuilder result = new StringBuilder(8);

            for (int i = 0; i < 8; i++)
            {
                result.Append(chars[random.Next(chars.Length)]);
            }
            string codigoVenda = result.ToString();

            
            bool venda = db.IncluirVenda(2, codigoVenda, 2, 0, valorTot);

            if (venda)
            {
                foreach (DataGridViewRow row in dataGridViewProdutosVenda.Rows)
                {
                    if (row.IsNewRow) continue; // Ignorar a nova linha em branco

                    int fkProduto = db.BuscarProdutoPorCodigo(row.Cells["codProduto"].Value.ToString());
                    int quantidadeVenda = Convert.ToInt32(row.Cells["quantidade"].Value);

                    bool incluiu = db.IncluirItemVenda(codigoVenda, fkProduto, quantidadeVenda);
                    if (incluiu)
                    {
                        //VERIFICAR QUANTIDADE EM ESTOQUE
                        int qdtEstoque = db.VerificaQTDItemEstoque(null, fkProduto);
                        int qtdNovaEstoque = qdtEstoque - quantidadeVenda;
                        db.AtualizarEstoque(qtdNovaEstoque, id:fkProduto);
                    }

                    
                }
                MessageBox.Show("Venda realizada com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
