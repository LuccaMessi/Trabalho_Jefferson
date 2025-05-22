namespace Farmacia
{
    partial class GrntLoginForm
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.vltGrt = new System.Windows.Forms.Button();
            this.btnLoginGrt = new System.Windows.Forms.Button();
            this.txtSenhaGrt = new System.Windows.Forms.TextBox();
            this.txtGrt = new System.Windows.Forms.TextBox();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.txtCodLojaGrt = new System.Windows.Forms.TextBox();
            this.codLojaGrt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // vltGrt
            // 
            this.vltGrt.Location = new System.Drawing.Point(12, 12);
            this.vltGrt.Name = "vltGrt";
            this.vltGrt.Size = new System.Drawing.Size(132, 23);
            this.vltGrt.TabIndex = 11;
            this.vltGrt.Text = "<- Voltar";
            this.vltGrt.UseVisualStyleBackColor = true;
            this.vltGrt.Click += new System.EventHandler(this.vltGrt_Click);
            // 
            // btnLoginGrt
            // 
            this.btnLoginGrt.Location = new System.Drawing.Point(364, 252);
            this.btnLoginGrt.Name = "btnLoginGrt";
            this.btnLoginGrt.Size = new System.Drawing.Size(75, 23);
            this.btnLoginGrt.TabIndex = 10;
            this.btnLoginGrt.Text = "Entrar";
            this.btnLoginGrt.UseVisualStyleBackColor = true;
            this.btnLoginGrt.Click += new System.EventHandler(this.btnLoginGrt_Click);
            // 
            // txtSenhaGrt
            // 
            this.txtSenhaGrt.Location = new System.Drawing.Point(322, 156);
            this.txtSenhaGrt.Name = "txtSenhaGrt";
            this.txtSenhaGrt.Size = new System.Drawing.Size(157, 22);
            this.txtSenhaGrt.TabIndex = 9;
            this.txtSenhaGrt.UseSystemPasswordChar = true;
            // 
            // txtGrt
            // 
            this.txtGrt.Location = new System.Drawing.Point(322, 101);
            this.txtGrt.Name = "txtGrt";
            this.txtGrt.Size = new System.Drawing.Size(157, 22);
            this.txtGrt.TabIndex = 8;
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(377, 137);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(46, 16);
            this.lblSenha.TabIndex = 7;
            this.lblSenha.Text = "Senha";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(361, 82);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(81, 16);
            this.lblUsuario.TabIndex = 6;
            this.lblUsuario.Text = "GerenteCPF";
            // 
            // txtCodLojaGrt
            // 
            this.txtCodLojaGrt.Location = new System.Drawing.Point(322, 214);
            this.txtCodLojaGrt.Name = "txtCodLojaGrt";
            this.txtCodLojaGrt.Size = new System.Drawing.Size(157, 22);
            this.txtCodLojaGrt.TabIndex = 12;
            this.txtCodLojaGrt.UseSystemPasswordChar = true;
            // 
            // codLojaGrt
            // 
            this.codLojaGrt.AutoSize = true;
            this.codLojaGrt.Location = new System.Drawing.Point(352, 195);
            this.codLojaGrt.Name = "codLojaGrt";
            this.codLojaGrt.Size = new System.Drawing.Size(99, 16);
            this.codLojaGrt.TabIndex = 13;
            this.codLojaGrt.Text = "Codigo da Loja";
            // 
            // GrntLoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.codLojaGrt);
            this.Controls.Add(this.txtCodLojaGrt);
            this.Controls.Add(this.vltGrt);
            this.Controls.Add(this.btnLoginGrt);
            this.Controls.Add(this.txtSenhaGrt);
            this.Controls.Add(this.txtGrt);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblUsuario);
            this.Name = "GrntLoginForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button vltGrt;
        private System.Windows.Forms.Button btnLoginGrt;
        private System.Windows.Forms.TextBox txtSenhaGrt;
        private System.Windows.Forms.TextBox txtGrt;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.TextBox txtCodLojaGrt;
        private System.Windows.Forms.Label codLojaGrt;
    }
}

