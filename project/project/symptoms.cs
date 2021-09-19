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
    public partial class symptoms : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\HP\Desktop\new\SystemDatabase.mdf;Integrated Security=True;Connect Timeout=30");

        string fever;
        string dry_cough;
        string tiredness;
        string shortness_of_breath;

        string passport_ID;
        public symptoms(string passport_ID)
        {
            this.passport_ID = passport_ID;
            InitializeComponent();
            panel1.BackColor = Color.FromArgb(130, Color.White);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            pic_symptoms pic = new pic_symptoms();
            this.Hide();
            pic.Show();
        }
        private void getvaluefromfever(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                fever = rdoButton.Text;
            }
        }

        private void getvaluefromDryCough(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                dry_cough = rdoButton.Text;
            }
        }
        private void getvaluefromTiredness(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                tiredness = rdoButton.Text;
            }
        }
        private void getvaluefromBreath(RadioButton rdoButton)
        {
            if (rdoButton.Checked)
            {
                shortness_of_breath = rdoButton.Text;
            }
        }
        




        private void button3_Click(object sender, EventArgs e)
        {
            if((!radioButton1.Checked && !radioButton2.Checked)|| (!radioButton3.Checked && !radioButton4.Checked) || (!radioButton5.Checked && !radioButton6.Checked) || (!radioButton7.Checked && !radioButton8.Checked))
            {
                MessageBox.Show("Please select all");
            }
            else
            {
                getvaluefromfever(radioButton1);
                getvaluefromfever(radioButton2);
                getvaluefromDryCough(radioButton3);
                getvaluefromDryCough(radioButton4);
                getvaluefromTiredness(radioButton5);
                getvaluefromTiredness(radioButton6);
                getvaluefromBreath(radioButton7);
                getvaluefromBreath(radioButton8);

                string qry = String.Format("UPDATE personal_details SET Fever='{0}',Dry_cough='{1}',Tiredness='{2}',Shortness_of_breath='{3}'", fever, dry_cough, tiredness, shortness_of_breath);
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
                Hotelmainpage hotels = new Hotelmainpage();
                this.Hide();
                hotels.Show();
            }


            







            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
