using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Database : Form
    {
        public Database()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(130, Color.White);
            panel3.BackColor = Color.FromArgb(130, Color.White);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Admin_Page adm_page = new Admin_Page();
            this.Hide();
            adm_page.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }
    }
}
