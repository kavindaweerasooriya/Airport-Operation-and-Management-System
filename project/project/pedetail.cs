using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace project
{
    public partial class pedetail : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");


        public pedetail()
        {

            InitializeComponent();
            panel1.BackColor = Color.FromArgb(200, Color.White);
        }

        private void pedetail_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            
            string nationality;

            if (radioButton1.Checked == true)
            {
                nationality = "Sri Lankan";
            }
            else
            {
                nationality = "Foreigner";
            }

            string passport_ID = passportnotxt.Text;
            string fname = fnametxt.Text;
            string lname = lnametxt.Text;
            string seat_no = seatnotxt.Text;
            string flight_no = flightnotxt.Text;
            string p_age =agetxt.Text;
            string p_email = emailtxt.Text;

            string DateOfArrival = dateTimePicker1.Text;

            Regex email = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            bool emailvalide = email.IsMatch(p_email);

            if (passport_ID == "" || fname == "" || lname == ""|| seat_no == ""|| flight_no ==""|| p_age ==""|| !emailvalide || !tickbox.Checked||(!radioButton1.Checked && !radioButton2.Checked))
            {
                MessageBox.Show("Please fill all the data and check the correct format of email");
            }
            else
            {
                string qry = "INSERT INTO personal_details(passport_ID,fname,lname,seat_no,flight_no,nationality,age,email,Date_of_Arrival) values ('" + passport_ID + "','" + fname + "','" + lname + "','" + seat_no + "','" + flight_no + "','" + nationality + "','" + p_age + "','" + p_email + "','" + DateOfArrival + "' )";
                SqlCommand cmd = new SqlCommand(qry, con);

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();        
                }
                catch (SqlException ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    con.Close();
                }

                RulesnRegulations RNR = new RulesnRegulations();
                this.Hide();
                RNR.Show();
            }

           






        }
        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void fnametxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
        private void label9_Click(object sender, EventArgs e)
        {

        }
        private void agetxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void passportnotxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void seatnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void flightnotxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void agetxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void fnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void lnametxt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }

}
