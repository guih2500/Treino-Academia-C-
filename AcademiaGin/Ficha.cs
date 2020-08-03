using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using Font = iTextSharp.text.Font;

namespace AcademiaGin
{
    public partial class Ficha : Form
    {
        public Ficha()
        {
            InitializeComponent();
        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void GerarF_Click(object sender, EventArgs e)
        {
            /*GerarTreino(@"C:\Users\Public\Documents\treino.pdf");*/
            GerarTreino(@"C:\PDF\Treino.pdf");
        }
        private void GerarTreino(string pCaminhoArquivoPDF)
        {

            Document documento = new Document(PageSize.A5);
            PdfWriter.GetInstance(documento, new FileStream(pCaminhoArquivoPDF, FileMode.Create));
            var boldFont = FontFactory.GetFont(FontFactory.HELVETICA_BOLD, 12);

            try
            {
                Paragraph titulo = new Paragraph(clienteD.Text, boldFont);
                Paragraph cliente = new Paragraph(label1.Text + " " + nomef.Text + " " + label2.Text + " " + alturaf.Text +
                    " " + label3.Text + " " + pesof.Text + " " + label4.Text + " " + idadef.Text + " " + label5.Text + " " +
                    sexof.Text + " " + label6.Text + " " + objficha.Text);
                Paragraph circun = new Paragraph("braços D/E: " + textBox1.Text + "/" + textBox2.Text + "  Antebraços D/E: " + 
                    textBox3.Text + "/" + textBox4.Text + "  Coxas D/E: " + textBox5.Text + "/" + textBox6.Text + "  Panturilhas D/E: " +
                    textBox7.Text + "/" + textBox8.Text);
                Paragraph treino = new Paragraph(label26.Text + "        " + label34.Text, boldFont);
                Paragraph treino1 = new Paragraph(label15.Text + comboBox1.Text + "             " + label35.Text + comboBox7.Text);
                Paragraph treino2 = new Paragraph(label16.Text + comboBox2.Text + "       " + label36.Text + comboBox8.Text);
                Paragraph treino3 = new Paragraph(label21.Text + comboBox3.Text + "       " + label37.Text + comboBox9.Text); 
                Paragraph treino4 = new Paragraph(label17.Text + comboBox4.Text + "       " + label38.Text + comboBox10.Text);
                Paragraph treino5 = new Paragraph(label23.Text + comboBox5.Text + "               " + label39.Text + comboBox11.Text);
                Paragraph treino6 = new Paragraph(label25.Text + comboBox6.Text + "               " + label40.Text + comboBox12.Text);
                Paragraph treino7 = new Paragraph(label27.Text, boldFont);
                Paragraph treino8 = new Paragraph(label28.Text + comboBox13.Text);
                Paragraph treino9 = new Paragraph(label29.Text + comboBox14.Text);
                Paragraph treino10 = new Paragraph(label30.Text + comboBox15.Text);
                Paragraph treino11 = new Paragraph(label33.Text + comboBox16.Text);
                Paragraph treino12 = new Paragraph(label32.Text + comboBox17.Text);
                Paragraph treino13 = new Paragraph(label24.Text + comboBox18.Text);
                Paragraph pollock = new Paragraph(label22.Text, boldFont);
                Paragraph pollock2 = new Paragraph(label20.Text + " " + textBox10.Text);
                Paragraph pollock3 = new Paragraph(label18.Text + " " + textBox12.Text);
                Paragraph pollock4 = new Paragraph(label19.Text + " " + textBox13.Text);

                documento.Open();
                documento.Add(titulo);
                documento.Add(cliente);
                documento.Add(circun);
                documento.Add(treino);
                documento.Add(treino1);
                documento.Add(treino2);
                documento.Add(treino3);
                documento.Add(treino4);
                documento.Add(treino5);
                documento.Add(treino6);
                documento.Add(treino7);
                documento.Add(treino8);
                documento.Add(treino9);
                documento.Add(treino10);
                documento.Add(treino11);
                documento.Add(treino12);
                documento.Add(treino13);
                documento.Add(pollock);
                documento.Add(pollock2);
                documento.Add(pollock3);
                documento.Add(pollock4);
                documento.Close();

                MessageBox.Show("Treino gerado (Local: C:|PDF|Treino.pdf");
            }
            catch (Exception erro)
            {
                MessageBox.Show("Erro ao Gerar Treino" + erro);
            }
        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void inicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Inicial _ini;
            _ini = new Inicial();
            _ini.Show();
            Hide();
        }

        private void Ficha_Load(object sender, EventArgs e)
        {
            sexof.Items.Add("Masculino");
            sexof.Items.Add("Feminino");
            sexof.Items.Add("não Binario");
            sexof.Items.Add("Mulher trans");
            sexof.Items.Add("homem trans");
            objficha.Items.Add("Perca de peso");
            objficha.Items.Add("Ganho de massa");
            comboBox1.Items.Add("N/F");
            comboBox1.Items.Add("3x15");
            comboBox1.Items.Add("3x10");
            comboBox1.Items.Add("2x10");
            comboBox1.Items.Add("2x15");
            comboBox2.Items.Add("N/F");
            comboBox2.Items.Add("3x15");
            comboBox2.Items.Add("3x10");
            comboBox2.Items.Add("2x10");
            comboBox2.Items.Add("2x15");
            comboBox3.Items.Add("N/F");
            comboBox3.Items.Add("3x15");
            comboBox3.Items.Add("3x10");
            comboBox3.Items.Add("2x10");
            comboBox3.Items.Add("2x15");
            comboBox4.Items.Add("N/F");
            comboBox4.Items.Add("3x15");
            comboBox4.Items.Add("3x10");
            comboBox4.Items.Add("2x10");
            comboBox4.Items.Add("2x15");
            comboBox5.Items.Add("N/F");
            comboBox5.Items.Add("3x15");
            comboBox5.Items.Add("3x10");
            comboBox5.Items.Add("2x10");
            comboBox5.Items.Add("2x15");
            comboBox6.Items.Add("N/F");
            comboBox6.Items.Add("3x15");
            comboBox6.Items.Add("3x10");
            comboBox6.Items.Add("2x10");
            comboBox6.Items.Add("2x15");
            comboBox7.Items.Add("N/F");
            comboBox7.Items.Add("3x15");
            comboBox7.Items.Add("3x10");
            comboBox7.Items.Add("2x10");
            comboBox7.Items.Add("2x15");
            comboBox8.Items.Add("N/F");
            comboBox8.Items.Add("3x15");
            comboBox8.Items.Add("3x10");
            comboBox8.Items.Add("2x10");
            comboBox8.Items.Add("2x15");
            comboBox9.Items.Add("N/F");
            comboBox9.Items.Add("3x15");
            comboBox9.Items.Add("3x10");
            comboBox9.Items.Add("2x10");
            comboBox9.Items.Add("2x15");
            comboBox10.Items.Add("N/F");
            comboBox10.Items.Add("3x15");
            comboBox10.Items.Add("3x10");
            comboBox10.Items.Add("2x10");
            comboBox10.Items.Add("2x15");
            comboBox11.Items.Add("N/F");
            comboBox11.Items.Add("3x15");
            comboBox11.Items.Add("3x10");
            comboBox11.Items.Add("2x10");
            comboBox11.Items.Add("2x15");
            comboBox12.Items.Add("N/F");
            comboBox12.Items.Add("3x15");
            comboBox12.Items.Add("3x10");
            comboBox12.Items.Add("2x10");
            comboBox12.Items.Add("2x15");
            comboBox13.Items.Add("N/F");
            comboBox13.Items.Add("3x15");
            comboBox13.Items.Add("3x10");
            comboBox13.Items.Add("2x10");
            comboBox13.Items.Add("2x15");
            comboBox14.Items.Add("N/F");
            comboBox14.Items.Add("3x15");
            comboBox14.Items.Add("3x10");
            comboBox14.Items.Add("2x10");
            comboBox14.Items.Add("2x15");
            comboBox15.Items.Add("N/F");
            comboBox15.Items.Add("3x15");
            comboBox15.Items.Add("3x10");
            comboBox15.Items.Add("2x10");
            comboBox15.Items.Add("2x15");
            comboBox16.Items.Add("N/F");
            comboBox16.Items.Add("3x15");
            comboBox16.Items.Add("3x10");
            comboBox16.Items.Add("2x10");
            comboBox16.Items.Add("2x15");
            comboBox17.Items.Add("N/F");
            comboBox17.Items.Add("3x15");
            comboBox17.Items.Add("3x10");
            comboBox17.Items.Add("2x10");
            comboBox17.Items.Add("2x15");
            comboBox18.Items.Add("N/F");
            comboBox18.Items.Add("3x15");
            comboBox18.Items.Add("3x10");
            comboBox18.Items.Add("2x10");
            comboBox18.Items.Add("2x15");
        }
    }
}
