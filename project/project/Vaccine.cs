using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Vaccine : Form
    {
        public Vaccine()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
            panel2.BackColor = Color.FromArgb(130, Color.White);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Hotelmainpage hotels = new Hotelmainpage();
            this.Hide();
            hotels.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 main_page = new Form1();
            this.Hide();
            main_page.Show();
        }
    }
}
