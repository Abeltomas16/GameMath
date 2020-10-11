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
    public partial class secand : Form
    {
        public secand()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void xuiColorPane1_ColorChanged(object sender, EventArgs e)
        {
            Properties.Settings.Default.CorApp = xuiColorPane1.SelectedColor;
            this.BackColor = Properties.Settings.Default.CorApp;
            Properties.Settings.Default.Save();
        }

        private void secand_Load(object sender, EventArgs e)
        {
            this.BackColor = Properties.Settings.Default.CorApp;
            
        }
    }
}
