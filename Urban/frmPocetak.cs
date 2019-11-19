using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Urban
{
    public partial class frmPocetak : Form
    {
        public frmPocetak()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmSignOn fs = new frmSignOn();
            fs.pocetna = this;
            fs.Show();
            this.Hide();
        }
    }
}