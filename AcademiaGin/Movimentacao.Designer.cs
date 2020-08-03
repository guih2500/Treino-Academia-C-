namespace AcademiaGin
{
    partial class Movimentacao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Movimentacao));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dataVencimento = new System.Windows.Forms.MaskedTextBox();
            this.ComboOp = new System.Windows.Forms.ComboBox();
            this.comboTipo = new System.Windows.Forms.ComboBox();
            this.Descri = new System.Windows.Forms.TextBox();
            this.Classi = new System.Windows.Forms.TextBox();
            this.ForCli = new System.Windows.Forms.TextBox();
            this.Reg = new System.Windows.Forms.Button();
            this.valor = new System.Windows.Forms.MaskedTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label6 = new System.Windows.Forms.Label();
            this.MovimenGridView = new System.Windows.Forms.DataGridView();
            this.buscMov = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.buscID = new System.Windows.Forms.TextBox();
            this.GerarRec = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovimenGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Operação: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(339, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(88, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição: \r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Classificação:\r\n";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(339, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Fornecedor/Cliente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(26, 177);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "data de vencimento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(672, 133);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(39, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "tipo:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(672, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(50, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Valor:";
            // 
            // dataVencimento
            // 
            this.dataVencimento.Location = new System.Drawing.Point(184, 177);
            this.dataVencimento.Mask = "0000-00-00";
            this.dataVencimento.Name = "dataVencimento";
            this.dataVencimento.Size = new System.Drawing.Size(162, 20);
            this.dataVencimento.TabIndex = 8;
            // 
            // ComboOp
            // 
            this.ComboOp.FormattingEnabled = true;
            this.ComboOp.Location = new System.Drawing.Point(119, 89);
            this.ComboOp.Name = "ComboOp";
            this.ComboOp.Size = new System.Drawing.Size(162, 21);
            this.ComboOp.TabIndex = 9;
            // 
            // comboTipo
            // 
            this.comboTipo.FormattingEnabled = true;
            this.comboTipo.Location = new System.Drawing.Point(748, 132);
            this.comboTipo.Name = "comboTipo";
            this.comboTipo.Size = new System.Drawing.Size(162, 21);
            this.comboTipo.TabIndex = 10;
            // 
            // Descri
            // 
            this.Descri.Location = new System.Drawing.Point(433, 92);
            this.Descri.Name = "Descri";
            this.Descri.Size = new System.Drawing.Size(162, 20);
            this.Descri.TabIndex = 11;
            // 
            // Classi
            // 
            this.Classi.Location = new System.Drawing.Point(138, 135);
            this.Classi.Name = "Classi";
            this.Classi.Size = new System.Drawing.Size(162, 20);
            this.Classi.TabIndex = 12;
            // 
            // ForCli
            // 
            this.ForCli.Location = new System.Drawing.Point(493, 133);
            this.ForCli.Name = "ForCli";
            this.ForCli.Size = new System.Drawing.Size(162, 20);
            this.ForCli.TabIndex = 13;
            // 
            // Reg
            // 
            this.Reg.Location = new System.Drawing.Point(30, 239);
            this.Reg.Name = "Reg";
            this.Reg.Size = new System.Drawing.Size(148, 41);
            this.Reg.TabIndex = 15;
            this.Reg.Text = "Registrar";
            this.Reg.UseVisualStyleBackColor = true;
            this.Reg.Click += new System.EventHandler(this.Reg_Click);
            // 
            // valor
            // 
            this.valor.Location = new System.Drawing.Point(748, 92);
            this.valor.Mask = "0000,00";
            this.valor.Name = "valor";
            this.valor.Size = new System.Drawing.Size(162, 20);
            this.valor.TabIndex = 16;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicialToolStripMenuItem.Text = "Inicial";
            this.inicialToolStripMenuItem.Click += new System.EventHandler(this.inicialToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(403, 25);
            this.label6.TabIndex = 18;
            this.label6.Text = "Registrar Movimentação de finanças:";
            // 
            // MovimenGridView
            // 
            this.MovimenGridView.AllowUserToAddRows = false;
            this.MovimenGridView.AllowUserToDeleteRows = false;
            this.MovimenGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MovimenGridView.Location = new System.Drawing.Point(30, 302);
            this.MovimenGridView.Name = "MovimenGridView";
            this.MovimenGridView.ReadOnly = true;
            this.MovimenGridView.Size = new System.Drawing.Size(880, 385);
            this.MovimenGridView.TabIndex = 19;
            // 
            // buscMov
            // 
            this.buscMov.Location = new System.Drawing.Point(249, 239);
            this.buscMov.Name = "buscMov";
            this.buscMov.Size = new System.Drawing.Size(148, 41);
            this.buscMov.TabIndex = 20;
            this.buscMov.Text = "Buscar Movimentação";
            this.buscMov.UseVisualStyleBackColor = true;
            this.buscMov.Click += new System.EventHandler(this.buscMov_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(374, 177);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 20);
            this.label9.TabIndex = 21;
            this.label9.Text = "ID para buscar: ";
            // 
            // buscID
            // 
            this.buscID.Location = new System.Drawing.Point(493, 179);
            this.buscID.Name = "buscID";
            this.buscID.Size = new System.Drawing.Size(100, 20);
            this.buscID.TabIndex = 22;
            // 
            // GerarRec
            // 
            this.GerarRec.Location = new System.Drawing.Point(461, 239);
            this.GerarRec.Name = "GerarRec";
            this.GerarRec.Size = new System.Drawing.Size(148, 41);
            this.GerarRec.TabIndex = 23;
            this.GerarRec.Text = "Gerar Recibo";
            this.GerarRec.UseVisualStyleBackColor = true;
            this.GerarRec.Click += new System.EventHandler(this.GerarRec_Click);
            // 
            // Movimentacao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 763);
            this.Controls.Add(this.GerarRec);
            this.Controls.Add(this.buscID);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.buscMov);
            this.Controls.Add(this.MovimenGridView);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.valor);
            this.Controls.Add(this.Reg);
            this.Controls.Add(this.ForCli);
            this.Controls.Add(this.Classi);
            this.Controls.Add(this.Descri);
            this.Controls.Add(this.comboTipo);
            this.Controls.Add(this.ComboOp);
            this.Controls.Add(this.dataVencimento);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Movimentacao";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Movimentacao";
            this.Load += new System.EventHandler(this.Movimentacao_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MovimenGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MaskedTextBox dataVencimento;
        private System.Windows.Forms.ComboBox ComboOp;
        private System.Windows.Forms.ComboBox comboTipo;
        private System.Windows.Forms.TextBox Descri;
        private System.Windows.Forms.TextBox Classi;
        private System.Windows.Forms.TextBox ForCli;
        private System.Windows.Forms.Button Reg;
        private System.Windows.Forms.MaskedTextBox valor;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView MovimenGridView;
        public System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.Button buscMov;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox buscID;
        private System.Windows.Forms.Button GerarRec;
    }
}