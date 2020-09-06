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

            int sinal = Sinal.Next(1, 4);

            if (sinal == 1)
            {
                Sinal_lbl.Text = "+";
            }else if(sinal == 2)
            {
                Sinal_lbl.Text = "-";
            }
            else if(sinal == 3)
            {
                Sinal_lbl.Text = "/";
            }
            else if(sinal == 4)
            {
                Sinal_lbl.Text = "X";
            }

            
           

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            GerarNúmero();
        }
    }
}
