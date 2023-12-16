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
    public partial class PaginaEtapas : Form
    {
        public PaginaEtapas()
        {
            InitializeComponent();

            try
            {
                Etapas Etapas = new Etapas();

                listViewEtapas.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewEtapas.View = View.Details;
                listViewEtapas.LabelEdit = true;
                listViewEtapas.AllowColumnReorder = true;
                listViewEtapas.CheckBoxes = true;
                listViewEtapas.FullRowSelect = true;
                listViewEtapas.GridLines = true;
                listViewEtapas.Sorting = SortOrder.Ascending;

                listViewEtapas.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ORDEM", -2, HorizontalAlignment.Left);
                listViewEtapas.Columns.Add("ID_PROCESSO", -2, HorizontalAlignment.Left);

                foreach (Etapas etapa in Etapas.GetListaEtapas())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(etapa.nome);
                    item.SubItems.Add(etapa.ordem.ToString());
                    item.SubItems.Add(etapa.id_processo.ToString());

                    listViewEtapas.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }

        private void listViewEtapas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaEtapas_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
