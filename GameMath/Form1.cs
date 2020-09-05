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
        public Form1()
        {
            InitializeComponent();
        }

        private void tb1_TextChanged(object sender, EventArgs e)
        {
            int Num1 = Convert.ToInt16(tb1.Text);

            if (Num1 == 4)
            {
                secand indo = new secand();
                indo.Show();
                this.Visible = false;
            }

        
        }
    }
}
