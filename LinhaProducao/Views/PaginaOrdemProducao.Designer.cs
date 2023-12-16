namespace LinhaProducao.Views
{
    partial class PaginaOrdemProducao
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
            this.botaoCadastroOrdemProducao = new System.Windows.Forms.Button();
            this.listViewOrdemProducoes = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroOrdemProducao
            // 
            this.botaoCadastroOrdemProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroOrdemProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroOrdemProducao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroOrdemProducao.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroOrdemProducao.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroOrdemProducao.Name = "botaoCadastroOrdemProducao";
            this.botaoCadastroOrdemProducao.Size = new System.Drawing.Size(341, 50);
            this.botaoCadastroOrdemProducao.TabIndex = 3;
            this.botaoCadastroOrdemProducao.Text = "Cadastrar nova ordem produção";
            this.botaoCadastroOrdemProducao.UseVisualStyleBackColor = false;
            this.botaoCadastroOrdemProducao.Click += new System.EventHandler(this.botaoCadastroOrdemProducao_Click);
            // 
            // listViewOrdemProducoes
            // 
            this.listViewOrdemProducoes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewOrdemProducoes.AutoArrange = false;
            this.listViewOrdemProducoes.BackColor = System.Drawing.SystemColors.Info;
            this.listViewOrdemProducoes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewOrdemProducoes.HideSelection = false;
            this.listViewOrdemProducoes.Location = new System.Drawing.Point(12, 70);
            this.listViewOrdemProducoes.Name = "listViewOrdemProducoes";
            this.listViewOrdemProducoes.Size = new System.Drawing.Size(583, 368);
            this.listViewOrdemProducoes.TabIndex = 2;
            this.listViewOrdemProducoes.TileSize = new System.Drawing.Size(1, 1);
            this.listViewOrdemProducoes.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaOrdemProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroOrdemProducao);
            this.Controls.Add(this.listViewOrdemProducoes);
            this.Name = "PaginaOrdemProducao";
            this.Text = "PaginaOrdemProducao";
            this.Load += new System.EventHandler(this.PaginaOrdemProducao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroOrdemProducao;
        private System.Windows.Forms.ListView listViewOrdemProducoes;
    }
}