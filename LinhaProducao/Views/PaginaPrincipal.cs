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
    public partial class PaginaPrincipal : Form
    {
        public PaginaPrincipal()
        {
            InitializeComponent();
        }
        public void AbrirForm<Forms>() where Forms : Form, new()
        {
            Form formulario;

            panelConteudo.Controls.Clear();

            formulario = panelConteudo.Controls.OfType<Form>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();

                formulario.TopLevel = false;

                formulario.FormBorderStyle = FormBorderStyle.None;

                formulario.Dock = DockStyle.Fill;

                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;

                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if(formulario.WindowState == FormWindowState.Minimized)
                {
                    formulario.WindowState = FormWindowState.Normal;
                }
            
            }

        }

        private void PaginaPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void botaoCliente_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaClientes>();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProdutos>();
        }

        private void botaoLinhaProducao_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaLinhaProducao>();
        }

        private void botaoOrdemProducao_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaOrdemProducao>();
        }

        private void botaoSetores_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaSetores>();
        }

        private void botaoProcessos_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaProcessos>();
        }

        private void botaoEtapas_Click(object sender, EventArgs e)
        {
            AbrirForm<PaginaEtapas>();
        }
    }
}
