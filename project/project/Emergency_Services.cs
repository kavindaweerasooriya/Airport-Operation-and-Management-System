using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace project
{
    public partial class Emergency_Services : Form
    {
        public Emergency_Services()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 main = new Form1();
            this.Hide();
            main.Show();
        }

        private void Emergency_Services_Load(object sender, EventArgs e)
        {

        }
    }
}
