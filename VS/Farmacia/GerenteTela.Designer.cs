namespace Farmacia
{
    partial class GerenteTela
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
            this.addAdm = new System.Windows.Forms.Button();
            this.grcEst = new System.Windows.Forms.Button();
            this.addFunc = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // addAdm
            // 
            this.addAdm.Location = new System.Drawing.Point(298, 121);
            this.addAdm.Name = "addAdm";
            this.addAdm.Size = new System.Drawing.Size(191, 23);
            this.addAdm.TabIndex = 0;
            this.addAdm.Text = "Adicionar Conta ADM";
            this.addAdm.UseVisualStyleBackColor = true;
            // 
            // grcEst
            // 
            this.grcEst.Location = new System.Drawing.Point(298, 179);
            this.grcEst.Name = "grcEst";
            this.grcEst.Size = new System.Drawing.Size(191, 23);
            this.grcEst.TabIndex = 1;
            this.grcEst.Text = "Gerenciar Estoque";
            this.grcEst.UseVisualStyleBackColor = true;
            // 
            // addFunc
            // 
            this.addFunc.Location = new System.Drawing.Point(298, 150);
            this.addFunc.Name = "addFunc";
            this.addFunc.Size = new System.Drawing.Size(191, 23);
            this.addFunc.TabIndex = 2;
            this.addFunc.Text = "Adicionar Conta Funcionario";
            this.addFunc.UseVisualStyleBackColor = true;
            // 
            // GerenteTela
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.addFunc);
            this.Controls.Add(this.grcEst);
            this.Controls.Add(this.addAdm);
            this.Name = "GerenteTela";
            this.Text = "GerenteTela";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button addAdm;
        private System.Windows.Forms.Button grcEst;
        private System.Windows.Forms.Button addFunc;
    }
}