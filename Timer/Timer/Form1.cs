using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Timer
{
    public partial class Vrijeme : Form
    {
        public Vrijeme()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text = DateTime.Now.ToShortTimeString() + " "  DateTime.Now.ToLongTimeString();
        }

        private void Vrijeme_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
