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
        Random Número = new Random();
        Random Sinal = new Random();
        Random N2 = new Random();
        int RespostaCerta;
        int RespostaCertaD;
        int sinal;

        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            //int Num1 = Convert.ToInt16(tb1.Text);

            //if (Num1 == 4)
            //{
            //    secand indo = new secand();
            //    indo.Show();
            //    this.Visible = false;
            //}





        }

        private void GerarNúmero()
        {
            int n1 = Número.Next(100);
            N1_lbl.Text = n1.ToString();

            int n2 = Número.Next(100);
            N2_lbl.Text = n2.ToString();

            sinal = Sinal.Next(1, 4);

            if (sinal == 1)
            {
                Sinal_lbl.Text = "+";
                RespostaCerta = n1 + n2;
                label1.Visible = false;
            }
            else if(sinal == 2)
            {
                Sinal_lbl.Text = "-";
                RespostaCerta = n1 - n2;
                label1.Visible = false;
            }
            else if(sinal == 3)
            {
                Sinal_lbl.Text = "/";
                RespostaCertaD = n1 / n2;
                label1.Visible = true;
            }
            else if(sinal == 4)
            {
                Sinal_lbl.Text = "X";
                RespostaCerta = n1 * n2;
                label1.Visible = false;
            }


            Resposta_txt.Clear();
            Resposta_txt.Mask = "000";

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GerarNúmero();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(sinal == 3)
            {
                if (RespostaCertaD == Convert.ToInt32(Resposta_txt.Text))
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

            
            if(RespostaCerta == Convert.ToInt32(Resposta_txt.Text))
            {
                
                MessageBox.Show(string.Format("Sim, a Resposta está certa, o resultado é {0}", Resposta_txt.Text));
                GerarNúmero();
            }
            else
            {
                MessageBox.Show(string.Format("Não, o resultado é {0}", RespostaCerta.ToString()));
                GerarNúmero();
            }


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
    }
}
