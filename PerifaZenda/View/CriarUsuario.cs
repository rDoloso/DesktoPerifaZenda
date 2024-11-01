using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static PerifaZenda.Database;

namespace PerifaZenda
{
    public partial class CriarUsuario : Form
    {

        private int idFuncionario;
        public CriarUsuario(int idFuncionario)
        {
            InitializeComponent();

            this.idFuncionario = idFuncionario;
        }

        private void buttonHome_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirmar_Click(object sender, EventArgs e)
        {
            string email = textBoxEmail.Text.Trim();
            string usuario = textBoxUsuario.Text.Trim();
            string senha = textBoxSenha.Text;
            string mensagem = "";
            

            //VERIFICAR ENTRADAS
            if (string.IsNullOrEmpty(email) || 
                string.IsNullOrEmpty(usuario) || 
                string.IsNullOrEmpty(senha))
            {
                mensagem = "Os seguintes campos são obrigatórios:\n";

                if (string.IsNullOrEmpty(email)) mensagem += "- E-mail\n";
                if (string.IsNullOrEmpty(email)) mensagem += "- Usuario\n";
                if (string.IsNullOrEmpty(email)) mensagem += "- Senha\n";

                MessageBox.Show(mensagem, "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Database db = new Database();

            ResultadoCriarLogin resultado = db.CriarLogin(usuario, email, senha, idFuncionario: idFuncionario);

            switch (resultado)
            {
                case ResultadoCriarLogin.Sucesso:
                    MessageBox.Show("Usuário cadastrado com sucesso!");
                    break;
                case ResultadoCriarLogin.UsuarioOuEmailJaExistente:
                    MessageBox.Show("Erro: O usuário ou e-mail já estão cadastrados. Tente outro.");
                    break;

            }
        }
    }
}
