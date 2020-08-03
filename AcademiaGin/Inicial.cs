using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;

namespace AcademiaGin
{
    public partial class Inicial : Form
    {
        public Inicial()
        {
            InitializeComponent();

        }

        private void cadastroClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteMenuS_Click(object sender, EventArgs e)
        {
            Cliente _cli;
            _cli = new Cliente();
            _cli.Show();
            Hide();
        }

        private void funcionarioMenuS_Click(object sender, EventArgs e)
        {
            CadLogin _cadl;
            _cadl = new CadLogin();
            _cadl.Show();
            
        }
        

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Estoque _est;
            _est = new Estoque();
            _est.Show();
            Hide();
        }
        
        private void Inicial_Load(object sender, EventArgs e)
        {          
            AcabandoView.DataSource = GetProdutosLista();
            ClientesAtView.DataSource = GetClientesAtLista();
        }
        private DataTable GetProdutosLista()
        {
            DataTable dtProdutos = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("select prod_nome, prod_qtde from produtos where prod_qtde <= 3", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtProdutos.Load(reader);
                }
            }

            return dtProdutos;
        }

        private DataTable GetClientesAtLista()
        {
            DataTable dtClientes = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("select cli_nome from cliente where cli_ativo like '%s%' ", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtClientes.Load(reader);
                }
            }

            return dtClientes;
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacao _mov;
            _mov = new Movimentacao();
            _mov.Show();
            Hide();
        }

        private void Recibo_Click(object sender, EventArgs e)
        {
           
        }

        

        private void btnTreino_Click(object sender, EventArgs e)
        {
            
        }

        private void geraItens_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(AcabandoView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in AcabandoView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in AcabandoView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\\Users\\Public\\Documents\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "EstoqueAcabando.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A6, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Relatório gerado em C:\\Users\\Public\\Documents\"");
        }

        private void RelaCliente_Click(object sender, EventArgs e)
        {
            //Creating iTextSharp Table from the DataTable data
            PdfPTable pdfTable = new PdfPTable(ClientesAtView.ColumnCount);
            pdfTable.DefaultCell.Padding = 3;
            pdfTable.WidthPercentage = 30;
            pdfTable.HorizontalAlignment = Element.ALIGN_LEFT;
            pdfTable.DefaultCell.BorderWidth = 1;

            //Adding Header row
            foreach (DataGridViewColumn column in ClientesAtView.Columns)
            {
                PdfPCell cell = new PdfPCell(new Phrase(column.HeaderText));
                pdfTable.AddCell(cell);
            }

            //Adding DataRow
            foreach (DataGridViewRow row in ClientesAtView.Rows)
            {
                foreach (DataGridViewCell cell in row.Cells)
                {
                    pdfTable.AddCell(cell.Value.ToString());
                }
            }

            //Exporting to PDF
            string folderPath = @"C:\\Users\\Public\\Documents\";
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }
            using (FileStream stream = new FileStream(folderPath + "ClientesAtivos.pdf", FileMode.Create))
            {
                Document pdfDoc = new Document(PageSize.A6, 10f, 10f, 10f, 0f);
                PdfWriter.GetInstance(pdfDoc, stream);
                pdfDoc.Open();
                pdfDoc.Add(pdfTable);
                pdfDoc.Close();
                stream.Close();
            }
            MessageBox.Show("Relatório gerado em C:\\Users\\Public\\Documents\"");
        }
    }
    }

