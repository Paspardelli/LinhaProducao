namespace LinhaProducao.Views
{
    partial class PaginaLinhaProducao
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
            this.botaoCadastroLinhaProducao = new System.Windows.Forms.Button();
            this.listViewLinhaProducao = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroLinhaProducao
            // 
            this.botaoCadastroLinhaProducao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroLinhaProducao.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroLinhaProducao.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroLinhaProducao.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroLinhaProducao.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroLinhaProducao.Name = "botaoCadastroLinhaProducao";
            this.botaoCadastroLinhaProducao.Size = new System.Drawing.Size(381, 50);
            this.botaoCadastroLinhaProducao.TabIndex = 3;
            this.botaoCadastroLinhaProducao.Text = "Cadastrar nova Linha de Produção";
            this.botaoCadastroLinhaProducao.UseVisualStyleBackColor = false;
            this.botaoCadastroLinhaProducao.Click += new System.EventHandler(this.botaoCadastroLinhaProducao_Click);
            // 
            // listViewLinhaProducao
            // 
            this.listViewLinhaProducao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewLinhaProducao.AutoArrange = false;
            this.listViewLinhaProducao.BackColor = System.Drawing.SystemColors.Info;
            this.listViewLinhaProducao.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewLinhaProducao.HideSelection = false;
            this.listViewLinhaProducao.Location = new System.Drawing.Point(12, 70);
            this.listViewLinhaProducao.Name = "listViewLinhaProducao";
            this.listViewLinhaProducao.Size = new System.Drawing.Size(583, 368);
            this.listViewLinhaProducao.TabIndex = 2;
            this.listViewLinhaProducao.TileSize = new System.Drawing.Size(1, 1);
            this.listViewLinhaProducao.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaLinhaProducao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroLinhaProducao);
            this.Controls.Add(this.listViewLinhaProducao);
            this.Name = "PaginaLinhaProducao";
            this.Text = "PaginaLinhaProducao";
            this.Load += new System.EventHandler(this.PaginaLinhaProducao_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroLinhaProducao;
        private System.Windows.Forms.ListView listViewLinhaProducao;
    }
}