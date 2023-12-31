﻿using System;
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
    public partial class PaginaClientes : Form
    {
        public PaginaClientes()
        {
            InitializeComponent();

            try
            {
                Clientes clientes = new Clientes();

                listViewClientes.Bounds = new Rectangle(new Point(15, 70), new Size(700, 500));

                listViewClientes.View = View.Details;
                listViewClientes.LabelEdit = true;
                listViewClientes.AllowColumnReorder = true;
                listViewClientes.CheckBoxes = true;
                listViewClientes.FullRowSelect = true;
                listViewClientes.GridLines = true;
                listViewClientes.Sorting = SortOrder.Ascending;

                listViewClientes.Columns.Add("#", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("ID", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("NOME", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("TELEFONE", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("DOCUMENTO", -2, HorizontalAlignment.Left);
                listViewClientes.Columns.Add("EMAIL", -2, HorizontalAlignment.Left);

                foreach (Clientes cliente in clientes.GetListaClientes())
                {

                    ListViewItem item = new ListViewItem("", 0);
                    item.Checked = true;
                    item.SubItems.Add(cliente.id.ToString());
                    item.SubItems.Add(cliente.nome);
                    item.SubItems.Add(cliente.telefone);
                    item.SubItems.Add(cliente.GetDocumento());
                    item.SubItems.Add(cliente.email);

                    listViewClientes.Items.Add(item);
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }
           
        }

        private void listViewClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void PaginaClientes_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormularioCliente clientes = new FormularioCliente();
            clientes.Show();
        }
    }
}
