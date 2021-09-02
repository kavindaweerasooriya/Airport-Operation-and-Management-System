using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Admin_Page : Form
    {
        public Admin_Page()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
        }

        Database db = new Database();
        private void button1_Click(object sender, EventArgs e)
        {
            string e_name = txtname.Text;
            string password = txtpwrd.Text;

            if (e_name == "sunimal" && password == "12345")
            {
                this.Hide();
                db.Show();
            }
            else
            {
                MessageBox.Show("Invalid User");
            }
        }

        Form1 fm = new Form1();
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
            fm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtname.Clear();
            txtpwrd.Clear();
        }
    }
}
