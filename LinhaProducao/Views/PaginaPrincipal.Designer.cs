namespace LinhaProducao.Views
{
    partial class PaginaPrincipal
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
            this.painelCabecalho = new System.Windows.Forms.Panel();
            this.barraLateral = new System.Windows.Forms.Panel();
            this.labelTitulo = new System.Windows.Forms.Label();
            this.botaoCliente = new System.Windows.Forms.Button();
            this.panelConteudo = new System.Windows.Forms.Panel();
            this.botaoLinhaProducao = new System.Windows.Forms.Button();
            this.botaoProdutos = new System.Windows.Forms.Button();
            this.botaoOrdemProducao = new System.Windows.Forms.Button();
            this.botaoSetores = new System.Windows.Forms.Button();
            this.botaoProcessos = new System.Windows.Forms.Button();
            this.botaoEtapas = new System.Windows.Forms.Button();
            this.painelCabecalho.SuspendLayout();
            this.barraLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // painelCabecalho
            // 
            this.painelCabecalho.BackColor = System.Drawing.Color.Goldenrod;
            this.painelCabecalho.Controls.Add(this.labelTitulo);
            this.painelCabecalho.Dock = System.Windows.Forms.DockStyle.Top;
            this.painelCabecalho.Location = new System.Drawing.Point(0, 0);
            this.painelCabecalho.Name = "painelCabecalho";
            this.painelCabecalho.Size = new System.Drawing.Size(869, 67);
            this.painelCabecalho.TabIndex = 0;
            // 
            // barraLateral
            // 
            this.barraLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.barraLateral.Controls.Add(this.botaoEtapas);
            this.barraLateral.Controls.Add(this.botaoProcessos);
            this.barraLateral.Controls.Add(this.botaoSetores);
            this.barraLateral.Controls.Add(this.botaoOrdemProducao);
            this.barraLateral.Controls.Add(this.botaoProdutos);
            this.barraLateral.Controls.Add(this.botaoLinhaProducao);
            this.barraLateral.Controls.Add(this.botaoCliente);
            this.barraLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.barraLateral.Location = new System.Drawing.Point(0, 67);
            this.barraLateral.Name = "barraLateral";
            this.barraLateral.Size = new System.Drawing.Size(200, 467);
            this.barraLateral.TabIndex = 1;
            // 
            // labelTitulo
            // 
            this.labelTitulo.AutoSize = true;
            this.labelTitulo.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTitulo.ForeColor = System.Drawing.Color.SaddleBrown;
            this.labelTitulo.Location = new System.Drawing.Point(12, 9);
            this.labelTitulo.Name = "labelTitulo";
            this.labelTitulo.Size = new System.Drawing.Size(303, 40);
            this.labelTitulo.TabIndex = 0;
            this.labelTitulo.Text = "Linha de Produção";
            // 
            // botaoCliente
            // 
            this.botaoCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCliente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoCliente.FlatAppearance.BorderSize = 0;
            this.botaoCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCliente.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCliente.ForeColor = System.Drawing.Color.White;
            this.botaoCliente.Location = new System.Drawing.Point(12, 6);
            this.botaoCliente.Name = "botaoCliente";
            this.botaoCliente.Size = new System.Drawing.Size(176, 53);
            this.botaoCliente.TabIndex = 0;
            this.botaoCliente.Text = "Clientes";
            this.botaoCliente.UseVisualStyleBackColor = false;
            this.botaoCliente.Click += new System.EventHandler(this.botaoCliente_Click);
            // 
            // panelConteudo
            // 
            this.panelConteudo.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelConteudo.Location = new System.Drawing.Point(200, 67);
            this.panelConteudo.Name = "panelConteudo";
            this.panelConteudo.Size = new System.Drawing.Size(669, 467);
            this.panelConteudo.TabIndex = 2;
            // 
            // botaoLinhaProducao
            // 
            this.botaoLinhaProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoLinhaProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoLinhaProducao.FlatAppearance.BorderSize = 0;
            this.botaoLinhaProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoLinhaProducao.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoLinhaProducao.ForeColor = System.Drawing.Color.White;
            this.botaoLinhaProducao.Location = new System.Drawing.Point(12, 124);
            this.botaoLinhaProducao.Name = "botaoLinhaProducao";
            this.botaoLinhaProducao.Size = new System.Drawing.Size(176, 74);
            this.botaoLinhaProducao.TabIndex = 1;
            this.botaoLinhaProducao.Text = "Linha Produção";
            this.botaoLinhaProducao.UseVisualStyleBackColor = false;
            this.botaoLinhaProducao.Click += new System.EventHandler(this.botaoLinhaProducao_Click);
            // 
            // botaoProdutos
            // 
            this.botaoProdutos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoProdutos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoProdutos.FlatAppearance.BorderSize = 0;
            this.botaoProdutos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProdutos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProdutos.ForeColor = System.Drawing.Color.White;
            this.botaoProdutos.Location = new System.Drawing.Point(12, 65);
            this.botaoProdutos.Name = "botaoProdutos";
            this.botaoProdutos.Size = new System.Drawing.Size(176, 53);
            this.botaoProdutos.TabIndex = 2;
            this.botaoProdutos.Text = "Produtos";
            this.botaoProdutos.UseVisualStyleBackColor = false;
            this.botaoProdutos.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoOrdemProducao
            // 
            this.botaoOrdemProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoOrdemProducao.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoOrdemProducao.FlatAppearance.BorderSize = 0;
            this.botaoOrdemProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoOrdemProducao.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoOrdemProducao.ForeColor = System.Drawing.Color.White;
            this.botaoOrdemProducao.Location = new System.Drawing.Point(12, 204);
            this.botaoOrdemProducao.Name = "botaoOrdemProducao";
            this.botaoOrdemProducao.Size = new System.Drawing.Size(176, 74);
            this.botaoOrdemProducao.TabIndex = 3;
            this.botaoOrdemProducao.Text = "Ordem Produção";
            this.botaoOrdemProducao.UseVisualStyleBackColor = false;
            this.botaoOrdemProducao.Click += new System.EventHandler(this.botaoOrdemProducao_Click);
            // 
            // botaoSetores
            // 
            this.botaoSetores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoSetores.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoSetores.FlatAppearance.BorderSize = 0;
            this.botaoSetores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoSetores.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoSetores.ForeColor = System.Drawing.Color.White;
            this.botaoSetores.Location = new System.Drawing.Point(12, 284);
            this.botaoSetores.Name = "botaoSetores";
            this.botaoSetores.Size = new System.Drawing.Size(176, 53);
            this.botaoSetores.TabIndex = 4;
            this.botaoSetores.Text = "Setores";
            this.botaoSetores.UseVisualStyleBackColor = false;
            this.botaoSetores.Click += new System.EventHandler(this.botaoSetores_Click);
            // 
            // botaoProcessos
            // 
            this.botaoProcessos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoProcessos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoProcessos.FlatAppearance.BorderSize = 0;
            this.botaoProcessos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoProcessos.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoProcessos.ForeColor = System.Drawing.Color.White;
            this.botaoProcessos.Location = new System.Drawing.Point(12, 343);
            this.botaoProcessos.Name = "botaoProcessos";
            this.botaoProcessos.Size = new System.Drawing.Size(176, 53);
            this.botaoProcessos.TabIndex = 5;
            this.botaoProcessos.Text = "Processos";
            this.botaoProcessos.UseVisualStyleBackColor = false;
            this.botaoProcessos.Click += new System.EventHandler(this.botaoProcessos_Click);
            // 
            // botaoEtapas
            // 
            this.botaoEtapas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoEtapas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.botaoEtapas.FlatAppearance.BorderSize = 0;
            this.botaoEtapas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoEtapas.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoEtapas.ForeColor = System.Drawing.Color.White;
            this.botaoEtapas.Location = new System.Drawing.Point(12, 402);
            this.botaoEtapas.Name = "botaoEtapas";
            this.botaoEtapas.Size = new System.Drawing.Size(176, 53);
            this.botaoEtapas.TabIndex = 6;
            this.botaoEtapas.Text = "Etapas";
            this.botaoEtapas.UseVisualStyleBackColor = false;
            this.botaoEtapas.Click += new System.EventHandler(this.botaoEtapas_Click);
            // 
            // PaginaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(869, 534);
            this.Controls.Add(this.panelConteudo);
            this.Controls.Add(this.barraLateral);
            this.Controls.Add(this.painelCabecalho);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PaginaPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaPrincipal";
            this.Load += new System.EventHandler(this.PaginaPrincipal_Load);
            this.painelCabecalho.ResumeLayout(false);
            this.painelCabecalho.PerformLayout();
            this.barraLateral.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel painelCabecalho;
        private System.Windows.Forms.Label labelTitulo;
        private System.Windows.Forms.Panel barraLateral;
        private System.Windows.Forms.Button botaoCliente;
        private System.Windows.Forms.Panel panelConteudo;
        private System.Windows.Forms.Button botaoEtapas;
        private System.Windows.Forms.Button botaoProcessos;
        private System.Windows.Forms.Button botaoSetores;
        private System.Windows.Forms.Button botaoOrdemProducao;
        private System.Windows.Forms.Button botaoProdutos;
        private System.Windows.Forms.Button botaoLinhaProducao;
    }
}