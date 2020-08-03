using iTextSharp.text;
using iTextSharp.text.pdf;
using MySql.Data.MySqlClient;
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

namespace AcademiaGin
{
    public partial class Movimentacao : Form
    {
        public Movimentacao()
        {
            InitializeComponent();
        }

        private void Reg_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("insert into movimenta (mov_id, mov_op, mov_desc, mov_clas, mov_for," +
                    "mov_data, mov_tipo, mov_val) values (null, ?, ?, ?, ?, ?, ?, ?)", objcon);
                objCmd.Parameters.Add("@mov_op", MySqlDbType.VarChar, 20).Value = ComboOp.SelectedItem.ToString();
                objCmd.Parameters.Add("@mov_desc", MySqlDbType.VarChar, 50).Value = Descri.Text;
                objCmd.Parameters.Add("@mov_clas", MySqlDbType.VarChar, 50).Value = Classi.Text;
                objCmd.Parameters.Add("@mov_for", MySqlDbType.VarChar, 50).Value = ForCli.Text;
                objCmd.Parameters.Add("@mov_data", MySqlDbType.Date).Value = dataVencimento.Text;
                objCmd.Parameters.Add("@mov_tipo", MySqlDbType.VarChar, 30).Value = comboTipo.SelectedItem.ToString();
                objCmd.Parameters.Add("@mov_val", MySqlDbType.Decimal, 20).Value = valor.Text;

                objCmd.ExecuteNonQuery();

                objcon.Close();

                MessageBox.Show("Movimentação adicionada");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao registrar " + erro);
            }
        }

        private void Movimentacao_Load(object sender, EventArgs e)
        {
            ComboOp.Items.Add("Receber");
            ComboOp.Items.Add("Pagar");
            comboTipo.Items.Add("Dinheiro");
            comboTipo.Items.Add("Crédito");
            comboTipo.Items.Add("Débito");

            MovimenGridView.DataSource = GetMovimenLista();
        }

        private DataTable GetMovimenLista()
        {
            DataTable dtMovimenta = new DataTable();
            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from movimenta", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtMovimenta.Load(reader);
                }
            }

            return dtMovimenta;
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicial _ini;
            _ini = new Inicial();
            _ini.Show();
            Hide();
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
           
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void buscMov_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("select mov_op, mov_desc, mov_clas, mov_for, DATE_FORMAT(mov_data,'%Y/%m/%d')a, mov_tipo, mov_val from movimenta " +
                    " where mov_id = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@mov_id", MySqlDbType.VarChar, 20).Value = buscID.Text;

                objCmd.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                ComboOp.Text = dr.GetString(0);
                Descri.Text = dr.GetString(1);
                Classi.Text = dr.GetString(2);
                ForCli.Text = dr.GetString(3);
                dataVencimento.Text = dr.GetString(4);
                comboTipo.Text = dr.GetString(5);
                valor.Text = dr.GetString(6);

                objcon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar Movimentação" + erro);
            }
        }

        private void GerarRec_Click(object sender, EventArgs e)
        {
            GerarRecibo(@"C:\PDF\Recibo.pdf");
        }
        private void GerarRecibo(string pCaminhoArquivoPDF)
        {
            Document documento = new Document(PageSize.A6);
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);
            PdfWriter.GetInstance(documento, new FileStream(pCaminhoArquivoPDF, FileMode.Create));

            try
            {
                Paragraph titulo = new Paragraph("Recibo de pagamento", boldFont);
                Paragraph operacao = new Paragraph(label1.Text + ""  + ComboOp.Text);
                Paragraph Descricao = new Paragraph(label2.Text + Descri.Text);
                Paragraph val = new Paragraph(label8.Text + "R$" + valor.Text);
                Paragraph classific = new Paragraph(label3.Text + Classi.Text);
                Paragraph For = new Paragraph(label4.Text + "" + ForCli.Text);
                Paragraph oper = new Paragraph(label7.Text + "" + comboTipo.Text);
                Paragraph data = new Paragraph(label5.Text + "" + dataVencimento.Text);
                

                documento.Open();
                documento.Add(titulo);
                documento.Add(operacao);
                documento.Add(Descricao);
                documento.Add(val);
                documento.Add(classific);
                documento.Add(For);
                documento.Add(oper);
                documento.Add(data);;
                documento.Close();

                MessageBox.Show("Recibo Gerado Local: C:|PDF|Recibo.pdf");


            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Gerar recibo" + erro);
            }
        }

    }
}
