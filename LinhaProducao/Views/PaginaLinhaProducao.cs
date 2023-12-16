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
    public partial class PaginaLinhaProducao : Form
    {
        public PaginaLinhaProducao()
        {
            InitializeComponent();

            try
            {
                LinhaProducoes LinhaProducao = new LinhaProducoes();

                listViewLinhaProducao.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewLinhaProducao.View = View.Details;
                listViewLinhaProducao.LabelEdit = true;
                listViewLinhaProducao.AllowColumnReorder = true;
                listViewLinhaProducao.CheckBoxes = true;
                listViewLinhaProducao.FullRowSelect = true;
                listViewLinhaProducao.GridLines = true;
                listViewLinhaProducao.Sorting = SortOrder.Ascending;

                listViewLinhaProducao.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewLinhaProducao.Columns.Add("NOME", -2, HorizontalAlignment.Left);

                foreach (LinhaProducoes linhaProducoes in LinhaProducao.GetListaLinhaProducoes())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(linhaProducoes.id.ToString());
                    item.SubItems.Add(linhaProducoes.nome);

                    listViewLinhaProducao.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
        }

        private void PaginaLinhaProducao_Load(object sender, EventArgs e)
        {

        }

        private void botaoCadastroLinhaProducao_Click(object sender, EventArgs e)
        {
            FormularioLinhaProducao linhaProducao = new FormularioLinhaProducao();
            linhaProducao.Show();
        }
    }
}
