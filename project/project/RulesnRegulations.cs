using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class RulesnRegulations : Form
    {
        public RulesnRegulations()
        {
            InitializeComponent();
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
    }
}
