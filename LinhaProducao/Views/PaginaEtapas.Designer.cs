namespace LinhaProducao.Views
{
    partial class PaginaEtapas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.botaoCadastroCliente = new System.Windows.Forms.Button();
            this.listViewClientes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroCliente
            // 
            this.botaoCadastroCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroCliente.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroCliente.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroCliente.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroCliente.Name = "botaoCadastroCliente";
            this.botaoCadastroCliente.Size = new System.Drawing.Size(283, 50);
            this.botaoCadastroCliente.TabIndex = 3;
            this.botaoCadastroCliente.Text = "Cadastrar novo cliente";
            this.botaoCadastroCliente.UseVisualStyleBackColor = false;
            // 
            // listViewClientes
            // 
            this.listViewClientes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewClientes.AutoArrange = false;
            this.listViewClientes.BackColor = System.Drawing.SystemColors.Info;
            this.listViewClientes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewClientes.HideSelection = false;
            this.listViewClientes.Location = new System.Drawing.Point(12, 70);
            this.listViewClientes.Name = "listViewClientes";
            this.listViewClientes.Size = new System.Drawing.Size(583, 368);
            this.listViewClientes.TabIndex = 2;
            this.listViewClientes.TileSize = new System.Drawing.Size(1, 1);
            this.listViewClientes.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroCliente);
            this.Controls.Add(this.listViewClientes);
            this.Name = "PaginaEtapas";
            this.Text = "PaginaEtapas";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroCliente;
        private System.Windows.Forms.ListView listViewClientes;
    }
}