using LinhaProducao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LinhaProducao
{ 
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*  try {
                   Clientes clientes = new Clientes();

                   clientes.id_funcionario = 1;
                   clientes.nome = "ze";
                   clientes.telefone = "19 999999999";
                   clientes.email = "ze@io";
                   clientes.SetDocumento("12345678901");

                   clientes.Insert(); 

                   MessageBox.Show("Cliente adicionado com sucesso");
               } 
               catch (Exception ex) {

                   MessageBox.Show(ex.Message);

               }*/
            try
            {
                Funcionarios funcionario = new Funcionarios();

                funcionario.id_empresa = 1;
                funcionario.nome = "funcionario 4";
                funcionario.email = "funcionario4@io";
                funcionario.SetSenha("12314");
                funcionario.SetNivel(1);

                funcionario.Insert();

                MessageBox.Show("funcionario adicionado com sucesso");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);

            }
        }
    }
}
