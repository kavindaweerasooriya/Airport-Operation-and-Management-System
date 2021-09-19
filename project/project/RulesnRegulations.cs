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
    public partial class RulesnRegulations : Form
    {
        public RulesnRegulations()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
            textBox1.Multiline = true;
            textBox1.ScrollBars = ScrollBars.Vertical;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pic_symptoms pic = new pic_symptoms();
            this.Hide();
            pic.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedetail p_page = new pedetail();
            this.Hide();
            p_page.Show();
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            panel1.Location = new Point(panel1.Location.X + 2);
        }
    }
}
