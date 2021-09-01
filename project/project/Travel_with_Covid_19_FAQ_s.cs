using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Travel_with_Covid_19_FAQ_s : Form
    {
        string q1 = "Hello world";
        public Travel_with_Covid_19_FAQ_s()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.Black);
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void Travel_with_Covid_19_FAQ_s_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + 2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 homepage = new Form1();
            this.Hide();
            homepage.Show();

        }






    }
}
