namespace AcademiaGin
{
    partial class Inicial
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Inicial));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.cadastroClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clienteMenuS = new System.Windows.Forms.ToolStripMenuItem();
            this.funcionarioMenuS = new System.Windows.Forms.ToolStripMenuItem();
            this.estoqueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.movimentaçãoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.AcabandoView = new System.Windows.Forms.DataGridView();
            this.geraItens = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.ClientesAtView = new System.Windows.Forms.DataGridView();
            this.RelaCliente = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcabandoView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesAtView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastroClienteToolStripMenuItem,
            this.estoqueToolStripMenuItem,
            this.movimentaçãoToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(938, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "MenuIni";
            // 
            // cadastroClienteToolStripMenuItem
            // 
            this.cadastroClienteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clienteMenuS,
            this.funcionarioMenuS});
            this.cadastroClienteToolStripMenuItem.Name = "cadastroClienteToolStripMenuItem";
            this.cadastroClienteToolStripMenuItem.Size = new System.Drawing.Size(69, 20);
            this.cadastroClienteToolStripMenuItem.Text = "Cadastro ";
            this.cadastroClienteToolStripMenuItem.Click += new System.EventHandler(this.cadastroClienteToolStripMenuItem_Click);
            // 
            // clienteMenuS
            // 
            this.clienteMenuS.Name = "clienteMenuS";
            this.clienteMenuS.Size = new System.Drawing.Size(137, 22);
            this.clienteMenuS.Text = "Cliente";
            this.clienteMenuS.Click += new System.EventHandler(this.clienteMenuS_Click);
            // 
            // funcionarioMenuS
            // 
            this.funcionarioMenuS.Name = "funcionarioMenuS";
            this.funcionarioMenuS.Size = new System.Drawing.Size(137, 22);
            this.funcionarioMenuS.Text = "Funcionario";
            this.funcionarioMenuS.Click += new System.EventHandler(this.funcionarioMenuS_Click);
            // 
            // estoqueToolStripMenuItem
            // 
            this.estoqueToolStripMenuItem.Name = "estoqueToolStripMenuItem";
            this.estoqueToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.estoqueToolStripMenuItem.Text = "Estoque";
            this.estoqueToolStripMenuItem.Click += new System.EventHandler(this.estoqueToolStripMenuItem_Click);
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
            this.sairToolStripMenuItem.Size = new System.Drawing.Size(38, 20);
            this.sairToolStripMenuItem.Text = "Sair";
            this.sairToolStripMenuItem.Click += new System.EventHandler(this.sairToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(50, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Itens em Estoque:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(51, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(348, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Itens em estoque com quantidade menor que 3:";
            // 
            // AcabandoView
            // 
            this.AcabandoView.AllowUserToAddRows = false;
            this.AcabandoView.AllowUserToDeleteRows = false;
            this.AcabandoView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AcabandoView.Location = new System.Drawing.Point(74, 119);
            this.AcabandoView.Name = "AcabandoView";
            this.AcabandoView.ReadOnly = true;
            this.AcabandoView.Size = new System.Drawing.Size(243, 416);
            this.AcabandoView.TabIndex = 3;
            // 
            // geraItens
            // 
            this.geraItens.Location = new System.Drawing.Point(135, 570);
            this.geraItens.Name = "geraItens";
            this.geraItens.Size = new System.Drawing.Size(116, 60);
            this.geraItens.TabIndex = 4;
            this.geraItens.Text = "Gerar PDF de Itens em Estoque";
            this.geraItens.UseVisualStyleBackColor = true;
            this.geraItens.Click += new System.EventHandler(this.geraItens_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(527, 38);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Clientes Ativos:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 76);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(271, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Clientes que estão ativos no sistema:";
            // 
            // ClientesAtView
            // 
            this.ClientesAtView.AllowUserToAddRows = false;
            this.ClientesAtView.AllowUserToDeleteRows = false;
            this.ClientesAtView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ClientesAtView.Location = new System.Drawing.Point(574, 119);
            this.ClientesAtView.Name = "ClientesAtView";
            this.ClientesAtView.ReadOnly = true;
            this.ClientesAtView.Size = new System.Drawing.Size(199, 416);
            this.ClientesAtView.TabIndex = 7;
            // 
            // RelaCliente
            // 
            this.RelaCliente.Location = new System.Drawing.Point(612, 570);
            this.RelaCliente.Name = "RelaCliente";
            this.RelaCliente.Size = new System.Drawing.Size(116, 60);
            this.RelaCliente.TabIndex = 8;
            this.RelaCliente.Text = "Gerar PDF de clientes ativos";
            this.RelaCliente.UseVisualStyleBackColor = true;
            this.RelaCliente.Click += new System.EventHandler(this.RelaCliente_Click);
            // 
            // Inicial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(938, 683);
            this.Controls.Add(this.RelaCliente);
            this.Controls.Add(this.ClientesAtView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.geraItens);
            this.Controls.Add(this.AcabandoView);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Inicial";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicial";
            this.Load += new System.EventHandler(this.Inicial_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AcabandoView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClientesAtView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clienteMenuS;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem cadastroClienteToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem estoqueToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem movimentaçãoToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem funcionarioMenuS;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView AcabandoView;
        private System.Windows.Forms.Button geraItens;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView ClientesAtView;
        private System.Windows.Forms.Button RelaCliente;
    }
}