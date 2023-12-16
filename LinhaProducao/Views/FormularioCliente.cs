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
    public partial class FormularioCliente : Form
    {
        public FormularioCliente()
        {
            InitializeComponent();

            try
            {
                List<Clientes> listaClientes = new List<Clientes>();

                Clientes clientes = new Clientes();
                listaClientes = clientes.GetListaClientes();

                comboBoxClientes.DataSource = listaClientes;
                comboBoxClientes.DisplayMember = "Nome";
                comboBoxClientes.ValueMember = "id";

            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void FormularioCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
