using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class Hotelmainpage : Form
    {
        public Hotelmainpage()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            pedetail personal_details = new pedetail();
            this.Hide();
            personal_details.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form1 fm = new Form1();
            this.Hide();
            fm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            shangrila shan_hotel = new shangrila();
            this.Hide();
            shan_hotel.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Thekingsbury kin_hotel = new Thekingsbury();
            this.Hide();
            kin_hotel.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cinnamongrandcolombo cin_hotel = new Cinnamongrandcolombo();
            this.Hide();
            cin_hotel.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Governmentcenter free_center = new Governmentcenter();
            this.Hide();
            free_center.Show();
        }
    }
}
