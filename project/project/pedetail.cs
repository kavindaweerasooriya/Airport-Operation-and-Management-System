using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace project
{
    public partial class pedetail : Form
    {
        public pedetail()
        {
            InitializeComponent();
        }

        private void pedetail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (fnametxt.Text == "")
            {
                MessageBox.Show("Please fill the first name");
            }
            if (lnametxt.Text == "")
            {
                MessageBox.Show("Please fill the lastname");
            }
           if(!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Select a natianality");
            }
        
            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool emailvalide = email.IsMatch(emailtxt.Text);
            if(!emailvalide)
            {
                MessageBox.Show("Invalid Email");
            }

            Regex seat = new Regex("^[1-9]{3}");
            bool seatno = seat.IsMatch(seatnotxt.Text);
            if (!seatno)
            {
                MessageBox.Show("Invalid Seat no");
            }

            Regex flight = new Regex("^[1-9]{5}");
            bool flightno = flight.IsMatch(flightnotxt.Text);
            if (!flightno)
            {
                MessageBox.Show("Invalid flight no");
            }

            Regex age = new Regex("^[1-9]{2}");
            bool agevalidate = age.IsMatch(seatnotxt.Text);
            if (!agevalidate)
            {
                MessageBox.Show("fill age");
            }

           

            if (!tickbox.Checked)
            {
                MessageBox.Show("plese chek the details and tick");
            }

            Hotelmainpage hotel_page = new Hotelmainpage();
            this.Hide();
            hotel_page.Show();


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void fnametxt_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void passportnotxt_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void agetxt_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
