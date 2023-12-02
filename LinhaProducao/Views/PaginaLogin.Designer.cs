namespace LinhaProducao.Views
{
    partial class PaginaLogin
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
            this.TextBoxEmail = new System.Windows.Forms.TextBox();
            this.TextBoxSenha = new System.Windows.Forms.TextBox();
            this.Login = new System.Windows.Forms.Label();
            this.BotaoEntrar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // TextBoxEmail
            // 
            this.TextBoxEmail.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxEmail.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBoxEmail.Location = new System.Drawing.Point(10, 97);
            this.TextBoxEmail.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TextBoxEmail.Name = "TextBoxEmail";
            this.TextBoxEmail.Size = new System.Drawing.Size(391, 44);
            this.TextBoxEmail.TabIndex = 0;
            this.TextBoxEmail.Tag = "";
            this.TextBoxEmail.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // TextBoxSenha
            // 
            this.TextBoxSenha.Font = new System.Drawing.Font("Times New Roman", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxSenha.Location = new System.Drawing.Point(10, 149);
            this.TextBoxSenha.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.TextBoxSenha.Name = "TextBoxSenha";
            this.TextBoxSenha.PasswordChar = '•';
            this.TextBoxSenha.Size = new System.Drawing.Size(391, 44);
            this.TextBoxSenha.TabIndex = 1;
            this.TextBoxSenha.TextChanged += new System.EventHandler(this.TextBoxSenha_TextChanged);
            // 
            // Login
            // 
            this.Login.AutoSize = true;
            this.Login.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login.Location = new System.Drawing.Point(153, 32);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(104, 40);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Login.Click += new System.EventHandler(this.Login_Click);
            // 
            // BotaoEntrar
            // 
            this.BotaoEntrar.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BotaoEntrar.Location = new System.Drawing.Point(10, 205);
            this.BotaoEntrar.Name = "BotaoEntrar";
            this.BotaoEntrar.Size = new System.Drawing.Size(391, 49);
            this.BotaoEntrar.TabIndex = 3;
            this.BotaoEntrar.Text = "Entrar";
            this.BotaoEntrar.UseVisualStyleBackColor = true;
            this.BotaoEntrar.Click += new System.EventHandler(this.BotaoEntrar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(104, 281);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Todos os direitos reservados ©  2023";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // PaginaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(19F, 40F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(420, 322);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BotaoEntrar);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.TextBoxSenha);
            this.Controls.Add(this.TextBoxEmail);
            this.Font = new System.Drawing.Font("Times New Roman", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.Name = "PaginaLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PaginaLogin";
            this.Load += new System.EventHandler(this.PaginaLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TextBoxEmail;
        private System.Windows.Forms.TextBox TextBoxSenha;
        private System.Windows.Forms.Label Login;
        private System.Windows.Forms.Button BotaoEntrar;
        private System.Windows.Forms.Label label1;
    }
}