using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace project
{
    public partial class welcome : Form
    {
        public welcome()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pedetail objpedetail = new pedetail();
            objpedetail.Show();
            this.Hide();


        }

        private void welcome_Load(object sender, EventArgs e)
        {

        }
    }
}
