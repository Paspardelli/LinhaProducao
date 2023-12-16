namespace LinhaProducao.Views
{
    partial class PaginaSetores
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
            this.botaoCadastroSetor = new System.Windows.Forms.Button();
            this.listViewSetores = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroSetor
            // 
            this.botaoCadastroSetor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroSetor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroSetor.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroSetor.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroSetor.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroSetor.Name = "botaoCadastroSetor";
            this.botaoCadastroSetor.Size = new System.Drawing.Size(283, 50);
            this.botaoCadastroSetor.TabIndex = 3;
            this.botaoCadastroSetor.Text = "Cadastrar novo setor";
            this.botaoCadastroSetor.UseVisualStyleBackColor = false;
            this.botaoCadastroSetor.Click += new System.EventHandler(this.botaoCadastroSetor_Click);
            // 
            // listViewSetores
            // 
            this.listViewSetores.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewSetores.AutoArrange = false;
            this.listViewSetores.BackColor = System.Drawing.SystemColors.Info;
            this.listViewSetores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewSetores.HideSelection = false;
            this.listViewSetores.Location = new System.Drawing.Point(12, 70);
            this.listViewSetores.Name = "listViewSetores";
            this.listViewSetores.Size = new System.Drawing.Size(583, 368);
            this.listViewSetores.TabIndex = 2;
            this.listViewSetores.TileSize = new System.Drawing.Size(1, 1);
            this.listViewSetores.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaSetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroSetor);
            this.Controls.Add(this.listViewSetores);
            this.Name = "PaginaSetores";
            this.Text = "PaginaSetores";
            this.Load += new System.EventHandler(this.PaginaSetores_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroSetor;
        private System.Windows.Forms.ListView listViewSetores;
    }
}