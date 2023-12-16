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
    public partial class PaginaSetores : Form
    {
        public PaginaSetores()
        {
            InitializeComponent();

            try
            {
                Setores Setores = new Setores();

                listViewSetores.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewSetores.View = View.Details;
                listViewSetores.LabelEdit = true;
                listViewSetores.AllowColumnReorder = true;
                listViewSetores.CheckBoxes = true;
                listViewSetores.FullRowSelect = true;
                listViewSetores.GridLines = true;
                listViewSetores.Sorting = SortOrder.Ascending;

                listViewSetores.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewSetores.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewSetores.Columns.Add("ID_EMPRESA", -2, HorizontalAlignment.Left);
                listViewSetores.Columns.Add("ID_RESPONSAVEL", -2, HorizontalAlignment.Left);

                foreach (Setores setor in Setores.GetListaSetores())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(setor.nome);
                    item.SubItems.Add(setor.id_empresa.ToString());
                    item.SubItems.Add(setor.id_responsavel.ToString());

                    listViewSetores.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void listViewSetores_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaSetores_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void botaoCadastroSetor_Click(object sender, EventArgs e)
        {
            FormularioSetores setor = new FormularioSetores();
            setor.Show();
        }
    }
}
