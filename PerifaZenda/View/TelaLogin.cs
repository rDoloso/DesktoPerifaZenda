using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PerifaZenda;
using static PerifaZenda.Login;
using static PerifaZenda.Database;


namespace PerifaZenda.View
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();
        }



        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBoxLogin.Text;
            string senha = textBoxSenha.Text;

            Database db = new Database();

            bool valido = db.BuscarLogin(usuario, senha);
            bool funcionario = db.VerificaFuncionario(usuario);
            if (valido && funcionario)
            {

                MessageBox.Show("Login bem-sucedido!! ");
                TelaPrincipal telaPrincipal = new TelaPrincipal(usuario);
                this.Hide();
                telaPrincipal.FormClosed += (s, args) => this.Show();
                telaPrincipal.ShowDialog();

            }
            else if (valido && funcionario == false)
            {
                MessageBox.Show("Login de funcionario invalido!");
            }
            else
            {
                MessageBox.Show("Usuário ou senha inválidos.");
            }

        }
    }
}