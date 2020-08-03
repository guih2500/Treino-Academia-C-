using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace AcademiaGin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void logar_Click(object sender, EventArgs e)
        {
            string log = txtLogin.Text;
            string sen = txtSenha.Text;
            
            MySqlConnection conn = new MySqlConnection("server = localhost; user id = root; database = academia");
            MySqlCommand cmd = new MySqlCommand("select * from Inicial where login = '" + txtLogin.Text + "' and senha = '" + txtSenha.Text + "'", conn);            
            cmd.Parameters.AddWithValue("@login", log);            
            conn.Open();
            MySqlDataReader dados;               
            dados = cmd.ExecuteReader();
                
            if (dados.Read())
            {
             string acesso = dados.GetString("acesso");
             string usuariologado = txtLogin.Text;
                if (acesso.Equals("Gerente"))
                {
                    Inicial _ini; 
                    _ini = new Inicial();
                    _ini.Show();
                    Hide();
                }
                else if (acesso.Equals("Limpeza"))
                {
                    Estoque _est;
                    _est = new Estoque();
                    _est.Show();
                    _est.inicialToolStripMenuItem.Enabled = false;
                    Hide();

                }else if (acesso.Equals("Recepção"))
                {
                    Cliente _cli;
                    _cli = new Cliente();
                    _cli.Show();
                    _cli.inicialToolStripMenuItem.Enabled = false;
                    Hide();
                }
                else if (acesso.Equals("professor"))
                {
                    Ficha _fic;
                    _fic = new Ficha();
                    _fic.Show();
                    _fic.inicialToolStripMenuItem.Enabled = false;
                    Hide();
                }
                else
                {
                    Lincorreto.Text = "Usuario ou senha incorreta, tente novamente";
                }
            }
                conn.Close();               
        }
    }
}
