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
    public partial class PaginaOrdemProducao : Form
    {
        public PaginaOrdemProducao()
        {
            InitializeComponent();

            try
            {
                OrdemProducoes OrdemProducao = new OrdemProducoes();

                listViewOrdemProducoes.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewOrdemProducoes.View = View.Details;
                listViewOrdemProducoes.LabelEdit = true;
                listViewOrdemProducoes.AllowColumnReorder = true;
                listViewOrdemProducoes.CheckBoxes = true;
                listViewOrdemProducoes.FullRowSelect = true;
                listViewOrdemProducoes.GridLines = true;
                listViewOrdemProducoes.Sorting = SortOrder.Ascending;

                listViewOrdemProducoes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewOrdemProducoes.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Left);
                listViewOrdemProducoes.Columns.Add("ID_SETOR", -2, HorizontalAlignment.Left);
                listViewOrdemProducoes.Columns.Add("ID_CLIENTE", -2, HorizontalAlignment.Left);

                foreach (OrdemProducoes ordemProducao in OrdemProducao.GetListaOrdemProducoes())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(ordemProducao.id_empresa.ToString());
                    item.SubItems.Add(ordemProducao.id_setor.ToString());
                    item.SubItems.Add(ordemProducao.id_cliente.ToString());

                    listViewOrdemProducoes.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void listViewOrdemProducoes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaOrdemProducoes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void PaginaOrdemProducao_Load(object sender, EventArgs e)
        {

        }

        private void botaoCadastroOrdemProducao_Click(object sender, EventArgs e)
        {
            FormularioOrdemProducao ordemProducao = new FormularioOrdemProducao();
            ordemProducao.Show();
        }
    }
}
