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
    public partial class Hotelmainpage : Form
    {
        
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");
        public Hotelmainpage()
        {
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
        }

        string passport_ID;
        private void button5_Click(object sender, EventArgs e)
        {
            symptoms sym = new symptoms(passport_ID);
            this.Hide();
            sym.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string quarantine_center;

            if (radioButton1.Checked == true)
            {
                quarantine_center = "Shangri-la Hotel";
            }
            else if (radioButton2.Checked == true)
                {
                quarantine_center = "The Kingsbury";
            }
            else if (radioButton3.Checked == true)
            {
                quarantine_center = "Cinnamon Grand";
            }
            else
            {
                quarantine_center = "Government Center";
            }

            string qry = String.Format("UPDATE personal_details SET Quarantine_center='{0}'", quarantine_center);
            SqlCommand cmd = new SqlCommand(qry, con);

            if(!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked && !radioButton4.Checked)
            {
                MessageBox.Show("Please select your Quarantine center");
            }
            else
            {
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


                Vaccine vac_page = new Vaccine();
                this.Hide();
                vac_page.Show();
            }
         
            
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

        private void Hotelmainpage_Load(object sender, EventArgs e)
        {

        }
    }
}
