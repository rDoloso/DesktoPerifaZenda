using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PerifaZenda.Login;
using static PerifaZenda.PedidoFornecedor;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;

namespace PerifaZenda
{
    internal class Database
    {
        string StringConexao = "Server=tcp:perifazendaserver.database.windows.net,1433;Initial Catalog=dbPerifaZenda;Persist Security Info=False;User ID=adminperifazenda;Password=Admin@perifazenda;MultipleActiveResultSets=True;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
        
        //BANCO PARA TESTE
        //string StringConexao = "Data Source=DESKTOP-B0T0JQ1;Initial Catalog = DbFazendaUrbana; Integrated Security = True; MultipleActiveResultSets=True;";
        
        public bool BuscarLogin(string usuario, string senha)
        {
            bool senhaValido = false;
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {

                    conexao.Open();

                    string query = "SELECT * FROM Login WHERE username = @usuario";

                    SqlCommand command = new SqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@usuario", usuario);

                    SqlDataReader reader = command.ExecuteReader();

                    //Leitura da tabela para encontradar a senha e o hash
                    if (reader.Read())
                    {
                        string saltKey = reader["saltKey"].ToString();
                        string hashSenha = reader["senhaHash"].ToString();

                        senhaValido = Login.VerificarSenha(senha, saltKey, hashSenha);

                    }

                }
                catch(Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message);

                }
                return senhaValido;
               
            }
        }

        public bool VerificaFuncionario(string usuario)
        {
            bool funcionario = false;
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {

                    conexao.Open();

                    string query = "SELECT * FROM Login WHERE username = @usuario";

                    SqlCommand command = new SqlCommand(query, conexao);

                    command.Parameters.AddWithValue("@usuario", usuario);

                    SqlDataReader reader = command.ExecuteReader();

                    //Leitura da tabela para encontradar a senha e o hash
                    if (reader.Read())
                    {
                        string tipoLogin = reader["tipoLogin"].ToString();
                        if (tipoLogin == "1")
                        {
                            funcionario = true;
                        }
                    }


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message);

                }
                return funcionario;
            }
        }

        /*
         VerificaCargoFuncionario
        Retorna uma string informando o cargo do funcionario
         
         */
        public string VerificaCargoFuncionario(string usuario)
        {
            string cargo = null;

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    // Pegar id do funcionario
                    string queryLogin = "SELECT fkFuncionario FROM Login WHERE username = @usuario";
                    SqlCommand commandLogin = new SqlCommand(queryLogin, conexao);
                    commandLogin.Parameters.AddWithValue("@usuario", usuario);

                    object result = commandLogin.ExecuteScalar();

                    if (result != null)
                    {
                        int idFuncionario = Convert.ToInt32(result);

                        //Pegar o tipoFuncionario usando o idFuncionario
                        string queryFuncionario = "SELECT tipoFuncionario FROM Funcionario WHERE idFuncionario = @idFuncionario";
                        SqlCommand commandFuncionario = new SqlCommand(queryFuncionario, conexao);
                        commandFuncionario.Parameters.AddWithValue("@idFuncionario", idFuncionario);

                        // Pegar o cargo do funcionario
                        SqlDataReader reader = commandFuncionario.ExecuteReader();

                        //Leitura da tabela para encontradar a senha e o hash
                        if (reader.Read())
                        {
                            int tipoFuncionario = Convert.ToInt32(reader["tipoFuncionario"]);

                            switch (tipoFuncionario)
                            {
                                case 1:
                                    cargo = "Admin";
                                        break;
                                case 2:
                                    cargo = "Vendedor";
                                    break;
                            }
                            return cargo;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Usuário não encontrado.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message);
                }
            }

            return cargo;
        }

        public int BuscarProdutoPorCodigo(string codigoProduto)
        {
            int idProduto = 0;

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM Produto WHERE codProduto = @CodigoProduto";

                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@CodigoProduto", codigoProduto);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProduto = Convert.ToInt32(reader["idProduto"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO: " + ex.Message);
                }
            }

            return idProduto; // Retorna 0 se o produto não for encontrado
        }

        public int BuscarProdutoPorId(int id)
        {
            int idProduto = 0;

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM Produto WHERE idProduto = @IdProduto";

                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@IdProduto", id);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idProduto = Convert.ToInt32(reader["idProduto"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO: " + ex.Message);
                }
            }

            return idProduto; // Retorna 0 se o produto não for encontrado
        }

        public int VerificaQTDItemEstoque(string codigo = null, int id = 0)
        {
            int quantidadeEmEstoque = 0;

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                
                try
                {
                   

                    conexao.Open();

                    string query = "SELECT * FROM Estoque WHERE fkProduto = @IdProduto";

                    // Consulta por codigo de produto.
                    if (codigo != null)
                    {
                        int idProduto = BuscarProdutoPorCodigo(codigo);

                        using (SqlCommand command = new SqlCommand(query, conexao))
                        {
                            command.Parameters.AddWithValue("@IdProduto", idProduto);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    quantidadeEmEstoque = Convert.ToInt32(reader["qtdEstoque"]);
                                    return quantidadeEmEstoque;
                                }
                            }
                        }
                    }
                    // Consulta por id de produto.
                    if (codigo == null)
                    {
                        int idProduto = BuscarProdutoPorId(id);

                        using (SqlCommand command = new SqlCommand(query, conexao))
                        {
                            command.Parameters.AddWithValue("@IdProduto", idProduto);

                            using (SqlDataReader reader = command.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    quantidadeEmEstoque = Convert.ToInt32(reader["qtdEstoque"]);
                                    return quantidadeEmEstoque;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message);
                }
            }

            return quantidadeEmEstoque;
        }

        public bool IncluirFuncionario(string cpf, int cargo, string nome, string dataNasc, string cep, string logradouro,string bairro, string cidadeEstado, string numero = "NULL", string complemento = "NULL")
        {

            DateTime dataNascFormatada;

            DateTime.TryParseExact(dataNasc, "dd/MM/yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out dataNascFormatada);

                using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                string query = @"INSERT INTO Funcionario(cpf,tipoFuncionario, nome, nascimento, cep, logradouro, numero, bairro, cidadeEstado, complemento)" +
                                "VALUES (@Cpf, @Cargo, @Nome, @DataNasc, @Cep, @Logradouro, @Numero, @Bairro, @CidadeEstado, @Complemento)";

                SqlCommand command = new SqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Cpf", cpf);
                command.Parameters.AddWithValue("@Cargo", cargo);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.Add("@DataNasc", SqlDbType.Date).Value = dataNascFormatada;
                command.Parameters.AddWithValue("@Cep", cep);
                command.Parameters.AddWithValue("@Logradouro", logradouro);
                command.Parameters.AddWithValue("@Numero", numero);
                command.Parameters.AddWithValue("@Bairro", bairro);
                command.Parameters.AddWithValue("@CidadeEstado", cidadeEstado);
                command.Parameters.AddWithValue("@Complemento", complemento);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Funcionario inlcuido com sucesso!");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro ao incluir funcionário: {ex.Message}");
                    return false; 
                }
            }
        }


       public bool AtualizarEstoque(int quantidadeEstoque, string codigo = null, int id = 0)
        {
            int idProduto = 0;

            if (codigo == null)
            {
                idProduto = BuscarProdutoPorId(id);
            }
            if(codigo != null)
            {
                idProduto = BuscarProdutoPorCodigo(codigo);
            }

            //Verificar se possui item no estoque.

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string queryEstoque = "SELECT * FROM Estoque WHERE fkProduto = @IdProduto";
                    string queryInserirEstoque = "INSERT INTO Estoque(fkProduto, qtdEstoque) " +
                                                 "VALUES(@IdProduto, @Quantidade);";
                    string queryUpdate = "UPDATE Estoque SET qtdEstoque = @Quantidade, dataModificacao = GETDATE() WHERE fkProduto = @IdProduto;";

                    using (SqlCommand command = new SqlCommand(queryEstoque, conexao))
                    {
                        command.Parameters.AddWithValue("@IdProduto", idProduto);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Se tiver item no estoque atualizar com a nova quantidade.
                            if (reader.Read())
                            {
                                reader.Close();
                                SqlCommand commandUpdate = new SqlCommand(queryUpdate, conexao);
                                commandUpdate.Parameters.AddWithValue("@IdProduto", idProduto);
                                commandUpdate.Parameters.AddWithValue("@Quantidade", quantidadeEstoque);

                                try
                                {
                                    commandUpdate.ExecuteNonQuery();
                                    //MessageBox.Show("Produto atualizado no estoque com sucesso!");
                                    return true;
                                }
                                catch (Exception ex)
                                {
                                    MessageBox.Show($"Erro ao atualizar produto no estoque: {ex.Message}");
                                    return false;
                                }

                            }
                            else // Se nao tiver item no estoque incluir
                            {
                                reader.Close();
                                SqlCommand commandAdicionar = new SqlCommand(queryInserirEstoque, conexao);

                                commandAdicionar.Parameters.AddWithValue("@IdProduto", id);
                                commandAdicionar.Parameters.AddWithValue("@Quantidade", quantidadeEstoque);

                                try
                                {
                                    commandAdicionar.ExecuteNonQuery();
                                    //MessageBox.Show("Produto adicionado no estoque com sucesso!");
                                    return true;
                                }
                                catch(Exception ex)
                                {
                                    MessageBox.Show($"Erro ao incluir produto no estoque: {ex.Message}");
                                    return false;
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO: " + ex.Message);
                }
                

            }
                return false;
        }

        public bool AdicionarProduto(int tipoProduto, string codProduto, string nome, double preco, int fkFornecedor)
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {

                conexao.Open();

                
                string query = "INSERT INTO Produto(tipoProduto, codProduto, nome, preco, fkFornecedor)" +
                    "VALUES(@TipoProduto, @CodProduto, @Nome, @Preco, @FkFornecedor)";

                SqlCommand command = new SqlCommand(query, conexao);

                command.Parameters.AddWithValue("@TipoProduto", tipoProduto);
                command.Parameters.AddWithValue("@CodProduto", codProduto);
                command.Parameters.AddWithValue("@Nome", nome);
                command.Parameters.AddWithValue("@Preco", preco);
                if (fkFornecedor == 0)
                {
                    command.Parameters.AddWithValue("@FkFornecedor", DBNull.Value);
                }
                else
                {
                    command.Parameters.AddWithValue("@FkFornecedor", fkFornecedor);
                }


                try
                {
                    command.ExecuteNonQuery();
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro ao incluir Produto: {ex.Message}");
                    return false;
                }
            }
            

        }


        public bool FazerCompra(int quantiadeComprada, int idProduto)
        {

            //Gerar codigo da compra
            Random random = new Random();

            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789"; // Letras e números
            StringBuilder codigoIndex = new StringBuilder(8);

            for (int i = 0; i < 8; i++)
            {
                int index = random.Next(chars.Length);
                codigoIndex.Append(chars[index]);
            }

            string codigo = codigoIndex.ToString();

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {

                conexao.Open();


                string query = "INSERT INTO Compra(codCompra, dataDeCompra, qtdCompra, fkProduto)" +
                                "VALUES(@Codigo, @DataCompra, @Qauntidade, @IdProduto);";

                SqlCommand command = new SqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Codigo", codigo);
                command.Parameters.AddWithValue("@DataCompra", DateTime.Now);
                command.Parameters.AddWithValue("@Qauntidade", quantiadeComprada);
                command.Parameters.AddWithValue("@IdProduto", idProduto);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Compra feita com sucesso!");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro ao fazer a compra: {ex.Message}");
                    return false;
                }
            }
        }

        public DataTable ConsultarDados(string tabela)
        {
            DataTable dataTable = new DataTable();

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = $"SELECT * FROM {tabela}";

                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            dataTable.Load(reader);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO: " + ex.Message);
                }
            }
            return dataTable;

        }

        public bool IncluirFornecedor(string cnpj, string razaoSoical, string cep, string logradouro, string numero, string bairro, string cidadeEstado, string complemento = "NULL")
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                string query = "INSERT INTO Fornecedor(cnpj, nome, cep, logradouro, numero, bairro, cidadeEstado, complemento)" +
                               "VALUES(@Cnpj, @RazaoSocial, @Cep, @Logradouro, @Numero, @Bairro, @CidadeEstado, @Complemento);";

                SqlCommand command = new SqlCommand(query, conexao);

                command.Parameters.AddWithValue("@Cnpj", cnpj);
                command.Parameters.AddWithValue("@RazaoSocial", razaoSoical);
                command.Parameters.AddWithValue("@Cep", cep);
                command.Parameters.AddWithValue("@Logradouro", logradouro);
                command.Parameters.AddWithValue("@Numero", numero);
                command.Parameters.AddWithValue("@Bairro", bairro);
                command.Parameters.AddWithValue("@CidadeEstado", cidadeEstado);
                command.Parameters.AddWithValue("@Complemento", complemento);


                try
                {
                    command.ExecuteNonQuery();
                    MessageBox.Show("Fornecedor inlcuido com sucesso!");
                    return true;
                }
                catch (SqlException ex)
                {
                    MessageBox.Show($"Erro ao incluir fornecedor: {ex.Message}");
                    return false;
                }
            }
        }

        public bool IncluirItemVenda(string codVenda, int idProduto, int quantidade)
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                string query = @"INSERT INTO ProdutoVenda (codVenda, fkProduto, quantidade)" +
                                "VALUES (@CodigoVenda, @IdProduto, @Quantidade)";


                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@CodigoVenda", codVenda);
                    command.Parameters.AddWithValue("@IdProduto", idProduto);
                    command.Parameters.AddWithValue("@Quantidade", quantidade);

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erro ao incluir fornecedor: {ex.Message}");
                        return false;
                    }

                }
            }
        }

        public bool IncluirVenda(int tipoVenda, string codVenda, int idFuncionario, int idCliente, double valorTot)
        {
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                conexao.Open();

                string query = @"INSERT INTO Venda (tipoVenda, codVenda, dataVenda, fkCliente, fkFuncionario, valorTotal)" +
                               "VALUES(@TipoVenda, @CodVenda, @DataVenda, @IdCliente, @IdFuncionario, @ValorTotal);";


                using (SqlCommand command = new SqlCommand(query, conexao))
                {
                    command.Parameters.AddWithValue("@TipoVenda", tipoVenda);
                    command.Parameters.AddWithValue("@CodVenda", codVenda);
                    command.Parameters.AddWithValue("@DataVenda", DateTime.Now);
                    command.Parameters.AddWithValue("@ValorTotal", valorTot);
                    // CLIENTE
                    if (idCliente == 0)
                    {
                        command.Parameters.AddWithValue("@IdCliente", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@IdCliente", idCliente);
                    }
                    //FUNCIONARIO
                    if (idFuncionario == 0)
                    {
                        command.Parameters.AddWithValue("@IdFuncionario", DBNull.Value);
                    }
                    else
                    {
                        command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
                    }

                    try
                    {
                        command.ExecuteNonQuery();
                        return true;
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show($"Erro ao finalizar venda: {ex.Message}");
                        return false;
                    }

                }
            }
        
        }



        public enum ResultadoCriarLogin
        {
            Sucesso = 1,
            UsuarioOuEmailJaExistente = 3,
            Erro = 0
        }


        public ResultadoCriarLogin CriarLogin(string usuario, string email, string senha, int idFuncionario = 0, int idCliente = 0)
        {
            
            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {

                    conexao.Open();
                    // VERIFICA USUARIO

                    string queryVerifica = @"SELECT COUNT(*) FROM Login WHERE username = @Usuario OR email = @Email";

                    using (SqlCommand commandVerifica = new SqlCommand(queryVerifica, conexao))
                    {
                        commandVerifica.Parameters.AddWithValue("@Usuario", usuario);
                        commandVerifica.Parameters.AddWithValue("@Email", email);


                        int existe = (int)commandVerifica.ExecuteScalar();
                        if (existe > 0)
                        {
                            return ResultadoCriarLogin.UsuarioOuEmailJaExistente;
                        }
                    }

                        
                    


                    // CASO NAO TENHA USUARIO E EMAIL CADASTRADO

                    Login login = new Login();
                    var saltHash = login.HashSenha(senha);

                    string saltKey = saltHash.salt;
                    string hashSenha = saltHash.hashSenha;

                    string queryInsert = "INSERT INTO Login(email, username, senhaHash, saltKey, tipoLogin, fkCliente, fkFuncionario)" +
                                         "VALUES(@Email, @Usuario, @HashSenha, @SaltKey, @TipoLogin, @IdCliente, @IdFuncionario)";

                    SqlCommand command = new SqlCommand(queryInsert, conexao);

                    command.Parameters.AddWithValue("@Email", email);
                    command.Parameters.AddWithValue("@Usuario", usuario);
                    command.Parameters.AddWithValue("@SaltKey", saltKey);
                    command.Parameters.AddWithValue("@HashSenha", hashSenha);


                    if (idFuncionario == 0) 
                    { 
                        command.Parameters.AddWithValue("@IdFuncionario", DBNull.Value); 
                    } else 
                    { 
                        command.Parameters.AddWithValue("@IdFuncionario", idFuncionario);
                        command.Parameters.AddWithValue("@TipoLogin", 1);

                    }

                    if (idCliente == 0)
                    {
                        command.Parameters.AddWithValue("@IdCliente", DBNull.Value);
                    }
                    else 
                    { 
                        command.Parameters.AddWithValue("@IdCliente", idCliente);
                        command.Parameters.AddWithValue("@TipoLogin", 2);
                    }

                    command.ExecuteNonQuery();
                    return ResultadoCriarLogin.Sucesso;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO:" + ex.Message);
                    return ResultadoCriarLogin.Erro;

                }

            }
        }

        public int BuscarIdFuncionario(string cpf)
        {
            int idFuncionario = 0;

            using (SqlConnection conexao = new SqlConnection(StringConexao))
            {
                try
                {
                    conexao.Open();

                    string query = "SELECT * FROM Funcionario WHERE cpf = @Cpf";

                    using (SqlCommand command = new SqlCommand(query, conexao))
                    {
                        command.Parameters.AddWithValue("@Cpf", cpf);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                idFuncionario = Convert.ToInt32(reader["idFuncionario"]);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Ocorreu um erro.\nERRO: " + ex.Message);
                }
            }

            return idFuncionario; // Retorna 0 se o produto não for encontrado
            
        }

    }




}

