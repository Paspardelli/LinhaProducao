using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao.Views
{
    public partial class PaginaLogin : Form
    {
        public PaginaLogin()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaginaLogin_Load(object sender, EventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {

        }

        private void BotaoEntrar_Click(object sender, EventArgs e)
        {
            try
            {

                string email = TextBoxEmail.Text;
                string senha = TextBoxSenha.Text;

                Funcionarios funcionario = new Funcionarios();

                funcionario.email = email;
                funcionario.SetSenha(senha);

                funcionario.getFuncionariosPorEmailESenha();

                if (funcionario.logado)
                {
                    this.Hide();

                    PaginaPrincipal paginaPrincipal = new PaginaPrincipal();

                    paginaPrincipal.Show();
                }
                else
                {
                    throw new Exception("Erro ao realizar login, credenciais incorretas ou não encontradas.");
                }


            }catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
            
        }

        private void TextBoxSenha_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
