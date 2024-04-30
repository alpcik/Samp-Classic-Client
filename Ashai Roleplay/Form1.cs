using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ashai_Roleplay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            panel2.Width += 1;
            if (panel2.Width >= 750)
            {
                timer1.Stop();
                Client c = new Client();
                c.Show();
                Hide();
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            panel4.Width += 2;
            if (panel4.Width >= 750)
            {

            }
        }
    }
}
