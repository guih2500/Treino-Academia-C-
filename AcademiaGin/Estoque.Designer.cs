namespace AcademiaGin
{
    partial class Estoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Estoque));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.inicialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sairToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CadProd = new System.Windows.Forms.Button();
            this.AltProd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.idProd = new System.Windows.Forms.TextBox();
            this.NomeProd = new System.Windows.Forms.TextBox();
            this.qtde = new System.Windows.Forms.TextBox();
            this.prodCat = new System.Windows.Forms.TextBox();
            this.categoria = new System.Windows.Forms.Label();
            this.btnBusca = new System.Windows.Forms.Button();
            this.ProdutosGridView = new System.Windows.Forms.DataGridView();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.inicialToolStripMenuItem,
            this.sairToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(934, 24);
            this.menuStrip1.TabIndex = 0;
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
            // CadProd
            // 
            this.CadProd.Location = new System.Drawing.Point(12, 305);
            this.CadProd.Name = "CadProd";
            this.CadProd.Size = new System.Drawing.Size(106, 38);
            this.CadProd.TabIndex = 1;
            this.CadProd.Text = "Cadastrar";
            this.CadProd.UseVisualStyleBackColor = true;
            this.CadProd.Click += new System.EventHandler(this.CadProd_Click);
            // 
            // AltProd
            // 
            this.AltProd.Location = new System.Drawing.Point(125, 305);
            this.AltProd.Name = "AltProd";
            this.AltProd.Size = new System.Drawing.Size(108, 38);
            this.AltProd.TabIndex = 2;
            this.AltProd.Text = "Alterar";
            this.AltProd.UseVisualStyleBackColor = true;
            this.AltProd.Click += new System.EventHandler(this.AltProd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 24);
            this.label1.TabIndex = 3;
            this.label1.Text = "Cadastro de produtos:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(52, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Id:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(49, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Nome:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(184, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Quantidade em estoque:";
            // 
            // idProd
            // 
            this.idProd.Location = new System.Drawing.Point(53, 115);
            this.idProd.Name = "idProd";
            this.idProd.Size = new System.Drawing.Size(141, 20);
            this.idProd.TabIndex = 7;
            // 
            // NomeProd
            // 
            this.NomeProd.Location = new System.Drawing.Point(53, 161);
            this.NomeProd.Name = "NomeProd";
            this.NomeProd.Size = new System.Drawing.Size(141, 20);
            this.NomeProd.TabIndex = 8;
            // 
            // qtde
            // 
            this.qtde.Location = new System.Drawing.Point(53, 217);
            this.qtde.Name = "qtde";
            this.qtde.Size = new System.Drawing.Size(141, 20);
            this.qtde.TabIndex = 9;
            // 
            // prodCat
            // 
            this.prodCat.Location = new System.Drawing.Point(50, 267);
            this.prodCat.Name = "prodCat";
            this.prodCat.Size = new System.Drawing.Size(144, 20);
            this.prodCat.TabIndex = 10;
            // 
            // categoria
            // 
            this.categoria.AutoSize = true;
            this.categoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoria.Location = new System.Drawing.Point(53, 244);
            this.categoria.Name = "categoria";
            this.categoria.Size = new System.Drawing.Size(82, 20);
            this.categoria.TabIndex = 11;
            this.categoria.Text = "Categoria:";
            // 
            // btnBusca
            // 
            this.btnBusca.Location = new System.Drawing.Point(57, 349);
            this.btnBusca.Name = "btnBusca";
            this.btnBusca.Size = new System.Drawing.Size(108, 38);
            this.btnBusca.TabIndex = 12;
            this.btnBusca.Text = "Buscar";
            this.btnBusca.UseVisualStyleBackColor = true;
            this.btnBusca.Click += new System.EventHandler(this.btnBusca_Click);
            // 
            // ProdutosGridView
            // 
            this.ProdutosGridView.AllowUserToAddRows = false;
            this.ProdutosGridView.AllowUserToDeleteRows = false;
            this.ProdutosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ProdutosGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ProdutosGridView.Location = new System.Drawing.Point(255, 52);
            this.ProdutosGridView.Name = "ProdutosGridView";
            this.ProdutosGridView.ReadOnly = true;
            this.ProdutosGridView.Size = new System.Drawing.Size(667, 616);
            this.ProdutosGridView.TabIndex = 13;
            // 
            // Estoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(934, 680);
            this.Controls.Add(this.ProdutosGridView);
            this.Controls.Add(this.btnBusca);
            this.Controls.Add(this.categoria);
            this.Controls.Add(this.prodCat);
            this.Controls.Add(this.qtde);
            this.Controls.Add(this.NomeProd);
            this.Controls.Add(this.idProd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AltProd);
            this.Controls.Add(this.CadProd);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Estoque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.Estoque_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProdutosGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem sairToolStripMenuItem;
        private System.Windows.Forms.Button CadProd;
        private System.Windows.Forms.Button AltProd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox idProd;
        private System.Windows.Forms.TextBox NomeProd;
        private System.Windows.Forms.TextBox qtde;
        private System.Windows.Forms.TextBox prodCat;
        private System.Windows.Forms.Label categoria;
        private System.Windows.Forms.Button btnBusca;
        private System.Windows.Forms.DataGridView ProdutosGridView;
        public System.Windows.Forms.ToolStripMenuItem inicialToolStripMenuItem;
    }
}