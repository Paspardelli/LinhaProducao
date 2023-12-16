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
            this.botaoCadastroEtapa = new System.Windows.Forms.Button();
            this.listViewEtapas = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroEtapa
            // 
            this.botaoCadastroEtapa.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroEtapa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroEtapa.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroEtapa.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroEtapa.Location = new System.Drawing.Point(14, 14);
            this.botaoCadastroEtapa.Name = "botaoCadastroEtapa";
            this.botaoCadastroEtapa.Size = new System.Drawing.Size(283, 50);
            this.botaoCadastroEtapa.TabIndex = 3;
            this.botaoCadastroEtapa.Text = "Cadastrar nova etapa";
            this.botaoCadastroEtapa.UseVisualStyleBackColor = false;
            // 
            // listViewEtapas
            // 
            this.listViewEtapas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewEtapas.AutoArrange = false;
            this.listViewEtapas.BackColor = System.Drawing.SystemColors.Info;
            this.listViewEtapas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewEtapas.HideSelection = false;
            this.listViewEtapas.Location = new System.Drawing.Point(12, 70);
            this.listViewEtapas.Name = "listViewEtapas";
            this.listViewEtapas.Size = new System.Drawing.Size(583, 368);
            this.listViewEtapas.TabIndex = 2;
            this.listViewEtapas.TileSize = new System.Drawing.Size(1, 1);
            this.listViewEtapas.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaEtapas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroEtapa);
            this.Controls.Add(this.listViewEtapas);
            this.Name = "PaginaEtapas";
            this.Text = "PaginaEtapas";
            this.Load += new System.EventHandler(this.PaginaEtapas_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroEtapa;
        private System.Windows.Forms.ListView listViewEtapas;
    }
}