using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            flowpanelmenu.Hide();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (flowpanelmenu.Visible)
            {
                flowpanelmenu.Hide();
            }
            else
            {
                flowpanelmenu.Show();
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblclosing_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            Travel_with_Covid_19_FAQ_s FAQ = new Travel_with_Covid_19_FAQ_s();
            this.Hide();
            FAQ.Show();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Emergency_Services ES = new Emergency_Services();
            this.Hide();
            ES.Show();
        }

        private bool button1WasClicked = false;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Admin_Page adm = new Admin_Page();

            button1WasClicked = true;
            string message = "ARE YOU AN EMPLOYEE AT CMB, IF NOT PLEASE PRESS 'NO'";
            string title = "Admin window";

            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                adm.Show();
            }
            else
            {

            }
        }
    }
}
