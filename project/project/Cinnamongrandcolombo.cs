using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Cinnamongrandcolombo : Form
    {
        public Cinnamongrandcolombo()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotelmainpage hotel_page = new Hotelmainpage();
            this.Hide();
            hotel_page.Show();
        }
    }
}
