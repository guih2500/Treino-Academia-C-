using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaGin
{
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            string Cnome = nome.Text;
            string Ccpf = cpf.Text;
            string Cdata = dataNasc.Text;
            string Cforma = FMPagamento.Text;
            string Cimc = txtimc.Text;
            string Cativo = ativo.Text;
            
            Conecta con = new Conecta();

            if (Ccpf != "") {
                String cmd = @"INSERT INTO cliente(cli_nome, cli_imc, cli_cpf, cli_data, cli_pag, cli_ativo) VALUES('" + nome.Text + "'," +
                    "'" + txtimc.Text + "', '" + cpf.Text + "','" + dataNasc.Text + "', '" + FMPagamento.Text + "', '" + ativo.Text + "')";
                string resultado = con.ExecutaComandos(cmd);
                if (resultado.Equals("OK"))
                {
                    MessageBox.Show("Cliente cadastrado");
                }
                else
                {
                    MessageBox.Show("Algo deu errado tente novamente(data = 'yyyy-mm-dd')");
                }

            }
            else
            {
                MessageBox.Show("CPF invalido, tente novamente");
            }
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicial _ini;
            _ini = new Inicial();
            _ini.Show();
            Hide();
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnAlt_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();

                MySqlCommand objCmd = new MySqlCommand("update cliente set cli_nome = ?, cli_imc = ?, cli_data = ?, cli_pag = ?, cli_ativo = ?" +
                    " where cli_cpf = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@cli_nome", MySqlDbType.VarChar, 50).Value = nome.Text;
                objCmd.Parameters.Add("@cli_imc", MySqlDbType.Decimal, 10).Value = txtimc.Text;
                objCmd.Parameters.Add("@cli_data", MySqlDbType.Date).Value = dataNasc.Text;
                objCmd.Parameters.Add("@cli_pag", MySqlDbType.VarChar, 20).Value = FMPagamento.Text;
                objCmd.Parameters.Add("@cli_ativo", MySqlDbType.VarChar, 5).Value = ativo.Text;
                objCmd.Parameters.Add("@cli_cpf", MySqlDbType.VarChar, 20).Value = cpf.Text;

                objCmd.CommandType = CommandType.Text;
                objCmd.ExecuteNonQuery();

                objcon.Close();

                MessageBox.Show("Cliente atualizado");

            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao atualizar, ERRO: " + erro);
            }
        }

        private void btnBusCli_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection objcon = new MySqlConnection("server = localhost; user id = root; database = academia");
                objcon.Open();
                MySqlCommand objCmd = new MySqlCommand("select cli_nome, cli_imc, DATE_FORMAT(cli_data,'%Y/%m/%d'), cli_pag, cli_ativo from cliente" +
                    " where cli_cpf = ?", objcon);
                objCmd.Parameters.Clear();
                objCmd.Parameters.Add("@cli_cpf", MySqlDbType.VarChar, 20).Value = cpf.Text;

                objCmd.CommandType = CommandType.Text;
                MySqlDataReader dr;
                dr = objCmd.ExecuteReader();
                dr.Read();
                
                nome.Text = dr.GetString(0);
                txtimc.Text = dr.GetString(1);
                dataNasc.Text = dr.GetString(2);
                FMPagamento.Text = dr.GetString(3);
                ativo.Text = dr.GetString(4);

                objcon.Close();
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao buscar cliente" + erro);
            }
        }

        private void Cliente_Load(object sender, EventArgs e)
        {
            ClientesGridView.DataSource = GetClientesLista();
            FMPagamento.Items.Add("Crédito");
            FMPagamento.Items.Add("Dinheiro");
            FMPagamento.Items.Add("Débito");
        }

        private DataTable GetClientesLista()
        {
            DataTable dtClientes = new DataTable();

            string connString = ConfigurationManager.ConnectionStrings["dbx"].ConnectionString;

            using (MySqlConnection con = new MySqlConnection(connString))
            {
                using (MySqlCommand cmd = new MySqlCommand("select * from cliente", con))
                {
                    con.Open();

                    MySqlDataReader reader = cmd.ExecuteReader();

                    dtClientes.Load(reader);
                }
            }

            return dtClientes;
        }

        private void movimentaçâoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void btnIMC_Click(object sender, EventArgs e)
        {
            Double p, a;
            p = Convert.ToDouble(txtpeso.Text);
            a = Convert.ToDouble(txtalt.Text);
            txtimc.Text = Convert.ToString(p/(a*a));
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void ClientesGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataNasc_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {
            
        }

        private void cpf_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 08)
            {                
                e.Handled = true;
            }
        }

        private void movimentaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Movimentacao _mov;
            _mov = new Movimentacao();
            _mov.Show();
            Hide();
        }
    }
}
