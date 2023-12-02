namespace LinhaProducao.Views
{
    partial class PaginaProdutos
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
            this.botaoCadastroProduto = new System.Windows.Forms.Button();
            this.listViewProdutos = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // botaoCadastroProduto
            // 
            this.botaoCadastroProduto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(46)))), ((int)(((byte)(59)))));
            this.botaoCadastroProduto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botaoCadastroProduto.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.botaoCadastroProduto.ForeColor = System.Drawing.Color.White;
            this.botaoCadastroProduto.Location = new System.Drawing.Point(12, 13);
            this.botaoCadastroProduto.Name = "botaoCadastroProduto";
            this.botaoCadastroProduto.Size = new System.Drawing.Size(283, 50);
            this.botaoCadastroProduto.TabIndex = 3;
            this.botaoCadastroProduto.Text = "Cadastrar novo produto";
            this.botaoCadastroProduto.UseVisualStyleBackColor = false;
            // 
            // listViewProdutos
            // 
            this.listViewProdutos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewProdutos.AutoArrange = false;
            this.listViewProdutos.BackColor = System.Drawing.SystemColors.Info;
            this.listViewProdutos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listViewProdutos.HideSelection = false;
            this.listViewProdutos.Location = new System.Drawing.Point(12, 70);
            this.listViewProdutos.Name = "listViewProdutos";
            this.listViewProdutos.Size = new System.Drawing.Size(583, 368);
            this.listViewProdutos.TabIndex = 2;
            this.listViewProdutos.TileSize = new System.Drawing.Size(1, 1);
            this.listViewProdutos.UseCompatibleStateImageBehavior = false;
            // 
            // PaginaProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.botaoCadastroProduto);
            this.Controls.Add(this.listViewProdutos);
            this.Name = "PaginaProdutos";
            this.Text = "PaginaProdutos";
            this.Load += new System.EventHandler(this.PaginaProdutos_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botaoCadastroProduto;
        private System.Windows.Forms.ListView listViewProdutos;
    }
}