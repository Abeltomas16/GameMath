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
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 indo = new Form1();
            indo.Show();
            this.Visible = false;
        }

        private void definições_btn_Click(object sender, EventArgs e)
        {
            Form def = new secand();
            def.Show();
        }

        private void welcome_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.CorApp;
            definições_btn.BackColor = Properties.Settings.Default.CorApp;
        }

        private void welcome_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
