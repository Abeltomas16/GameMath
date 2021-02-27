

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GameMath
{
    public partial class Form1 : Form
    {
        string[] Sinais = new string[4] { "+", "-", "/", "X" };
        Random Número = new Random();
        Random Sinal = new Random();
        Random N2 = new Random();
        double RespostaCertaD;
        int sinal;

        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
        }

        private void GerarNúmero()
        {
            int n1 = Número.Next(100);
            N1_lbl.Text = n1.ToString();

            int n2 = Número.Next(100);
            N2_lbl.Text = n2.ToString();

            sinal = Sinal.Next(0, 3);

            Func<int, string> func = (int n) =>
            {
                return Sinais[n];
            };

            Sinal_lbl.Text = func(sinal);

            switch (sinal)
            {
                case 0:
                    RespostaCertaD = n1 + n2;
                    label1.Visible = false;
                    break;
                case 1:
                    RespostaCertaD = n1 - n2;
                    label1.Visible = false;
                    break;
                case 2:
                    if (n1 != 0 && n2 != 0)
                        RespostaCertaD = (int)n1 / n2;
                    label1.Visible = true;
                    break;

                case 3:
                    RespostaCertaD = n1 * n2;
                    label1.Visible = false;
                    break;
            }
            Resposta_txt.Clear();
            Resposta_txt.Mask = "000";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GerarNúmero();
            this.BackColor = Properties.Settings.Default.CorApp;
            Resposta_txt.BackColor = Properties.Settings.Default.CorApp;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (Resposta_txt.Text != "")
            {
                if (RespostaCertaD == Convert.ToInt32(Resposta_txt.Text.Replace(" ", "")))
                {
                    MessageBox.Show(string.Format("Sim, a Resposta está certa, o resultado é {0}", Resposta_txt.Text));
                    GerarNúmero();
                }
                else
                {
                    MessageBox.Show(string.Format("Não, o resultado é {0}", RespostaCertaD.ToString()));
                    GerarNúmero();
                }
            }
            else
            {
                MessageBox.Show("Insira um Resultado", "Sem Resultado");
                GerarNúmero();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Resposta_txt.Mask = "-000";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Resposta_txt.Mask = "000";
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Form main = new welcome();
            main.Show();
        }

    }
}


