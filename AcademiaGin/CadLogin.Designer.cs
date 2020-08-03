namespace AcademiaGin
{
    partial class CadLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CadLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.logcad = new System.Windows.Forms.TextBox();
            this.senhacad = new System.Windows.Forms.TextBox();
            this.senhaconf = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.Cad = new System.Windows.Forms.Button();
            this.nvAcesso = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "CADASTRA USUARIOS";
            // 
            // logcad
            // 
            this.logcad.Location = new System.Drawing.Point(106, 88);
            this.logcad.Name = "logcad";
            this.logcad.Size = new System.Drawing.Size(100, 20);
            this.logcad.TabIndex = 1;
            // 
            // senhacad
            // 
            this.senhacad.Location = new System.Drawing.Point(106, 137);
            this.senhacad.Name = "senhacad";
            this.senhacad.PasswordChar = '*';
            this.senhacad.Size = new System.Drawing.Size(100, 20);
            this.senhacad.TabIndex = 2;
            // 
            // senhaconf
            // 
            this.senhaconf.Location = new System.Drawing.Point(106, 187);
            this.senhaconf.Name = "senhaconf";
            this.senhaconf.PasswordChar = '*';
            this.senhaconf.Size = new System.Drawing.Size(100, 20);
            this.senhaconf.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(64, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Login:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(65, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Senha:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(88, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirmar Senha:";
            // 
            // Cad
            // 
            this.Cad.Location = new System.Drawing.Point(106, 275);
            this.Cad.Name = "Cad";
            this.Cad.Size = new System.Drawing.Size(75, 23);
            this.Cad.TabIndex = 7;
            this.Cad.Text = "Cadastrar";
            this.Cad.UseVisualStyleBackColor = true;
            this.Cad.Click += new System.EventHandler(this.Cad_Click);
            // 
            // nvAcesso
            // 
            this.nvAcesso.FormattingEnabled = true;
            this.nvAcesso.Location = new System.Drawing.Point(106, 233);
            this.nvAcesso.Name = "nvAcesso";
            this.nvAcesso.Size = new System.Drawing.Size(100, 21);
            this.nvAcesso.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(54, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Acesso:";
            // 
            // CadLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(314, 321);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.nvAcesso);
            this.Controls.Add(this.Cad);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.senhaconf);
            this.Controls.Add(this.senhacad);
            this.Controls.Add(this.logcad);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "CadLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CadLogin";
            this.Load += new System.EventHandler(this.CadLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox logcad;
        private System.Windows.Forms.TextBox senhacad;
        private System.Windows.Forms.TextBox senhaconf;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button Cad;
        private System.Windows.Forms.ComboBox nvAcesso;
        private System.Windows.Forms.Label label5;
    }
}