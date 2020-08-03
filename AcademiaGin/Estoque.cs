using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using MySql.Data;

namespace AcademiaGin
{
    public partial class Estoque : Form
    {
        public Estoque()
        {
            InitializeComponent();
        }

        private void Estoque_Load(object sender, EventArgs e)
        {
            ProdutosGridView.DataSource = GetProdutosLista();
        }

        private DataTable GetProdutosLista()
        {
            DataTable dtProdutos = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from produtos", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtProdutos.Load(reader);
                }
            }

                return dtProdutos;
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicial _ini;
            _ini = new Inicial();
            _ini.Show();
            Hide();
        }

        private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Cliente _cli;
            _cli = new Cliente();
            _cli.Show();
            Hide();*/
        }

        private void funcionarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*CadLogin _cadl;
            _cadl = new CadLogin();
            _cadl.Show();*/
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void CadProd_Click(object sender, EventArgs e)
        {
            string IDprodu = idProd.Text;
            string prodnome = NomeProd.Text;
            string qtdeprod = qtde.Text;
            string categoria = prodCat.Text;


            Conecta con = new Conecta();
            if (IDprodu != "") {
                String cmd = @"INSERT INTO produtos (prod_id, prod_nome, prod_qtde, prod_cat) VALUES ('" + idProd.Text + "'," +
                        "'" + NomeProd.Text + "', '" + qtde.Text + "','" + prodCat.Text + "')";
                string resultado = con.ExecutaComandos(cmd);
                if (resultado.Equals("OK"))
                {                    
                    MessageBox.Show("Produto cadastrado!");
                }
                else
                {
                    MessageBox.Show("Algo deu errado, tente novamente");
                }
            }
            else
            {
                MessageBox.Show("O id do produto deve conter somente número e deve ser preenchido");
            }
        }

        private void AltProd_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("update produtos set prod_nome = ?, prod_qtde = ?, prod_cat = ? where prod_id = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@prod_nome", MySqlDbType.VarChar, 50).Value = NomeProd.Text;
                objCmd.Parameters.Add("@prod_qtde", MySqlDbType.Int32, 3).Value = qtde.Text;
                objCmd.Parameters.Add("@prod_cat", MySqlDbType.VarChar, 20).Value = prodCat.Text;
                objCmd.Parameters.Add("@prod_id", MySqlDbType.Int32).Value = idProd.Text;

                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();

                objcon.Close();

                MessageBox.Show("Produto atualizado");

            }catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar, ERRO: " + erro);
            }

        }

        private void btnBusca_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("select prod_nome, prod_qtde, prod_cat from produtos where prod_id = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@prod_id", MySqlDbType.Int32).Value = idProd.Text;

                objCmd.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();

                NomeProd.Text = dr.GetString(0);
                qtde.Text = dr.GetString(1);
                prodCat.Text = dr.GetString(2);

                objcon.Close();
            }
            catch(Exception erro)
            {
                MessageBox.Show("Erro ao buscar produto" + erro);
            }
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
           /* Movimentacao _mov;
            _mov = new Movimentacao();
            _mov.Show();
            Hide();*/
        }

        private void cadastroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
