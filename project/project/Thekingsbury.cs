using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Thekingsbury : Form
    {
        public Thekingsbury()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotelmainpage hotel_page = new Hotelmainpage();
            this.Hide();
            hotel_page.Show();
        }
    }
}
