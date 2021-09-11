using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace project
{
    public partial class pic_symptoms : Form
    {
        public pic_symptoms()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            RulesnRegulations RNR = new RulesnRegulations();
            this.Hide();
            RNR.Show();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            symptoms sym = new symptoms();
            this.Hide();
            sym.Show();
        }
    }
}
