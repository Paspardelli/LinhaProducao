namespace LinhaProducao.Views
{
    partial class PaginaProcessos
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
            this.botaoCadastroProcesso = new System.Windows.Forms.Button();
            this.listViewProcessos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroProcesso
            // 
            this.botaoCadastroProcesso.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroProcesso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroProcesso.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroProcesso.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroProcesso.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroProcesso.Name = "botaoCadastroProcesso";
            this.botaoCadastroProcesso.Size = new System.Drawing.Size(283, 50);
            this.botaoCadastroProcesso.TabIndex = 3;
            this.botaoCadastroProcesso.Text = "Cadastrar novo processo";
            this.botaoCadastroProcesso.UseVisualStyleBackColor = false;
            this.botaoCadastroProcesso.Click += new System.EventHandler(this.botaoCadastroProcesso_Click);
            // 
            // listViewProcessos
            // 
            this.listViewProcessos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProcessos.AutoArrange = false;
            this.listViewProcessos.BackColor = System.Drawing.SystemColors.Info;
            this.listViewProcessos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProcessos.HideSelection = false;
            this.listViewProcessos.Location = new System.Drawing.Point(12, 70);
            this.listViewProcessos.Name = "listViewProcessos";
            this.listViewProcessos.Size = new System.Drawing.Size(583, 368);
            this.listViewProcessos.TabIndex = 2;
            this.listViewProcessos.TileSize = new System.Drawing.Size(1, 1);
            this.listViewProcessos.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaProcessos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroProcesso);
            this.Controls.Add(this.listViewProcessos);
            this.Name = "PaginaProcessos";
            this.Text = "PaginaProcessos";
            this.Load += new System.EventHandler(this.PaginaProcessos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroProcesso;
        private System.Windows.Forms.ListView listViewProcessos;
    }
}