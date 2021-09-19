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
    public partial class Vaccine : Form
    {
        string passport_ID;
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Vaccine()
        {
            this.passport_ID = passport_ID;
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
            panel2.BackColor = Color.FromArgb(130, Color.White);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
        
        
        private void button1_Click(object sender, EventArgs e)
        {
            Hotelmainpage hotels = new Hotelmainpage();
            this.Hide();
            hotels.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string check_Vaccination;

            if (radioButton1.Checked == true)
            {
                check_Vaccination = "Yes";
            }
            else
            {
                check_Vaccination = "No";
            }

            string dateOfVaccination = dateTimePicker1.Text;

            if (!radioButton1.Checked && !radioButton2.Checked)
            {
                MessageBox.Show("Please fill the form");
            }
            else
            {
                string qry = String.Format("UPDATE personal_details SET Vaccination_status='{0}', Date_of_vaccination='{1}'", check_Vaccination, dateOfVaccination);
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


                Form1 main_page = new Form1();
                this.Hide();
                main_page.Show();
            }

           
        }
    }
}
