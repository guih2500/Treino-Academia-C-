namespace AcademiaGin
{
    partial class Cliente
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Cliente));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCad = new System.Windows.Forms.Button();
            this.btnAlt = new System.Windows.Forms.Button();
            this.nome = new System.Windows.Forms.TextBox();
            this.ativo = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.academiaDataSet = new AcademiaGin.academiaDataSet();
            this.academiaDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnBusCli = new System.Windows.Forms.Button();
            this.ClientesGridView = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtpeso = new System.Windows.Forms.TextBox();
            this.txtalt = new System.Windows.Forms.TextBox();
            this.btnIMC = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cpf = new System.Windows.Forms.MaskedTextBox();
            this.dataNasc = new System.Windows.Forms.MaskedTextBox();
            this.txtimc = new System.Windows.Forms.MaskedTextBox();
            this.FMPagamento = new System.Windows.Forms.ComboBox();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Cadastrar Clientes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(45, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nome: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(45, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "CPF:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(45, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(161, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "data de nascismento:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(45, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(166, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Forma de pagamento:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 282);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ativo?";
            // 
            // btnCad
            // 
            this.btnCad.Location = new System.Drawing.Point(12, 331);
            this.btnCad.Name = "btnCad";
            this.btnCad.Size = new System.Drawing.Size(108, 37);
            this.btnCad.TabIndex = 6;
            this.btnCad.Text = "Cadastrar";
            this.btnCad.UseVisualStyleBackColor = true;
            this.btnCad.Click += new System.EventHandler(this.btnCad_Click);
            // 
            // btnAlt
            // 
            this.btnAlt.Location = new System.Drawing.Point(126, 331);
            this.btnAlt.Name = "btnAlt";
            this.btnAlt.Size = new System.Drawing.Size(110, 37);
            this.btnAlt.TabIndex = 7;
            this.btnAlt.Text = "Alterar";
            this.btnAlt.UseVisualStyleBackColor = true;
            this.btnAlt.Click += new System.EventHandler(this.btnAlt_Click);
            // 
            // nome
            // 
            this.nome.Location = new System.Drawing.Point(49, 117);
            this.nome.Name = "nome";
            this.nome.Size = new System.Drawing.Size(142, 20);
            this.nome.TabIndex = 10;
            // 
            // ativo
            // 
            this.ativo.Location = new System.Drawing.Point(49, 305);
            this.ativo.Name = "ativo";
            this.ativo.Size = new System.Drawing.Size(146, 20);
            this.ativo.TabIndex = 14;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 15;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // inicialToolStripMenuItem
            // 
            this.inicialToolStripMenuItem.Name = "inicialToolStripMenuItem";
            this.inicialToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.inicialToolStripMenuItem.Text = "Inicial";
            this.inicialToolStripMenuItem.Click += new System.EventHandler(this.inicialToolStripMenuItem_Click);
            // 
            // movimentaçãoToolStripMenuItem
            // 
            this.movimentaçãoToolStripMenuItem.Name = "movimentaçãoToolStripMenuItem";
            this.movimentaçãoToolStripMenuItem.Size = new System.Drawing.Size(99, 20);
            this.movimentaçãoToolStripMenuItem.Text = "Movimentação";
            this.movimentaçãoToolStripMenuItem.Click += new System.EventHandler(this.movimentaçãoToolStripMenuItem_Click);
            // 
            // sairToolStripMenuItem
            // 
            this.sairToolStripMenuItem.Name = "sairToolStripMenuItem";
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.sairToolStripMenuItem.Text = "sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // academiaDataSet
            // 
            this.academiaDataSet.DataSetName = "academiaDataSet";
            this.academiaDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // academiaDataSetBindingSource
            // 
            this.academiaDataSetBindingSource.DataSource = this.academiaDataSet;
            this.academiaDataSetBindingSource.Position = 0;
            // 
            // btnBusCli
            // 
            this.btnBusCli.Location = new System.Drawing.Point(69, 374);
            this.btnBusCli.Name = "btnBusCli";
            this.btnBusCli.Size = new System.Drawing.Size(110, 37);
            this.btnBusCli.TabIndex = 16;
            this.btnBusCli.Text = "Buscar";
            this.btnBusCli.UseVisualStyleBackColor = true;
            this.btnBusCli.Click += new System.EventHandler(this.btnBusCli_Click);
            // 
            // ClientesGridView
            // 
            this.ClientesGridView.AllowUserToAddRows = false;
            this.ClientesGridView.AllowUserToDeleteRows = false;
            this.ClientesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesGridView.Location = new System.Drawing.Point(242, 39);
            this.ClientesGridView.Name = "ClientesGridView";
            this.ClientesGridView.ReadOnly = true;
            this.ClientesGridView.Size = new System.Drawing.Size(680, 629);
            this.ClientesGridView.TabIndex = 17;
            this.ClientesGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ClientesGridView_CellContentClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 236);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "IMC:";
            // 
            // txtpeso
            // 
            this.txtpeso.Location = new System.Drawing.Point(36, 478);
            this.txtpeso.Name = "txtpeso";
            this.txtpeso.Size = new System.Drawing.Size(100, 20);
            this.txtpeso.TabIndex = 20;
            // 
            // txtalt
            // 
            this.txtalt.Location = new System.Drawing.Point(36, 543);
            this.txtalt.Name = "txtalt";
            this.txtalt.Size = new System.Drawing.Size(100, 20);
            this.txtalt.TabIndex = 21;
            // 
            // btnIMC
            // 
            this.btnIMC.Location = new System.Drawing.Point(36, 596);
            this.btnIMC.Name = "btnIMC";
            this.btnIMC.Size = new System.Drawing.Size(128, 59);
            this.btnIMC.TabIndex = 22;
            this.btnIMC.Text = "Calcular IMC";
            this.btnIMC.UseVisualStyleBackColor = true;
            this.btnIMC.Click += new System.EventHandler(this.btnIMC_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(36, 446);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(49, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Peso:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(33, 512);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 24;
            this.label9.Text = "Altura:";
            // 
            // cpf
            // 
            this.cpf.Location = new System.Drawing.Point(49, 72);
            this.cpf.Mask = "000.000.000-00";
            this.cpf.Name = "cpf";
            this.cpf.Size = new System.Drawing.Size(142, 20);
            this.cpf.TabIndex = 25;
            this.cpf.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cpf_KeyPress);
            // 
            // dataNasc
            // 
            this.dataNasc.Location = new System.Drawing.Point(49, 163);
            this.dataNasc.Mask = "0000-00-00";
            this.dataNasc.Name = "dataNasc";
            this.dataNasc.Size = new System.Drawing.Size(142, 20);
            this.dataNasc.TabIndex = 26;
            this.dataNasc.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.dataNasc_MaskInputRejected);
            // 
            // txtimc
            // 
            this.txtimc.Location = new System.Drawing.Point(49, 260);
            this.txtimc.Mask = "00";
            this.txtimc.Name = "txtimc";
            this.txtimc.Size = new System.Drawing.Size(142, 20);
            this.txtimc.TabIndex = 27;
            // 
            // FMPagamento
            // 
            this.FMPagamento.FormattingEnabled = true;
            this.FMPagamento.Location = new System.Drawing.Point(49, 209);
            this.FMPagamento.Name = "FMPagamento";
            this.FMPagamento.Size = new System.Drawing.Size(142, 21);
            this.FMPagamento.TabIndex = 28;
            // 
            // Cliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 680);
            this.Controls.Add(this.FMPagamento);
            this.Controls.Add(this.txtimc);
            this.Controls.Add(this.dataNasc);
            this.Controls.Add(this.cpf);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnIMC);
            this.Controls.Add(this.txtalt);
            this.Controls.Add(this.txtpeso);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ClientesGridView);
            this.Controls.Add(this.btnBusCli);
            this.Controls.Add(this.btnAlt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnCad);
            this.Controls.Add(this.ativo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nome);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.label4);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Cliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cliente";
            this.Load += new System.EventHandler(this.Cliente_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.academiaDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCad;
        private System.Windows.Forms.Button btnAlt;
        private System.Windows.Forms.TextBox nome;
        private System.Windows.Forms.TextBox ativo;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private academiaDataSet academiaDataSet;
        private System.Windows.Forms.BindingSource academiaDataSetBindingSource;
        private System.Windows.Forms.Button btnBusCli;
        private System.Windows.Forms.DataGridView ClientesGridView;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtpeso;
        private System.Windows.Forms.TextBox txtalt;
        private System.Windows.Forms.Button btnIMC;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox cpf;
        private System.Windows.Forms.MaskedTextBox dataNasc;
        private System.Windows.Forms.MaskedTextBox txtimc;
        public System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        private System.Windows.Forms.ComboBox FMPagamento;
    }
}