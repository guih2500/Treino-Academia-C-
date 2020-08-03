using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AcademiaGin
{
    public partial class CadLogin : Form
    {
        public CadLogin()
        {
            InitializeComponent();
        }

        private void Cad_Click(object sender, EventArgs e)
        {
            string logc = logcad.Text;
            string senhac = senhacad.Text;
            string senhacf = senhaconf.Text;
            string acessonv = nvAcesso.Text;

            Conecta con = new Conecta();

            if (senhac == senhacf)
            {
                String cmd = @"INSERT INTO Inicial(login, senha, acesso) VALUES('" + logcad.Text + "', '" + senhacad.Text + "' , '" + nvAcesso.Text + "')";
                //Ira executar o comando de Inserir no SQL
                string resultado = con.ExecutaComandos(cmd);
                if (resultado.Equals("OK"))
                {
                    MessageBox.Show("Usuario cadastrado");

                }
                else
                {
                    MessageBox.Show(resultado);
                }
            }
            else
            {
                MessageBox.Show ("senhas não conferem, Favor tentar novamente");
            }
        }

        private void CadLogin_Load(object sender, EventArgs e)
        {
            nvAcesso.Items.Add("Gerente");
            nvAcesso.Items.Add("Limpeza");
            nvAcesso.Items.Add("Recepção");
            nvAcesso.Items.Add("professor");
        }
    }
}
