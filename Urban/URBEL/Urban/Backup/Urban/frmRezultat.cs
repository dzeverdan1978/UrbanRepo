using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Urban
{
    public partial class frmRezultat : Form
    {
        public BindingSource izvor;
        public string id;
        
        public frmRezultat()
        {
            InitializeComponent();
        }

        private void frmRezultat_Load(object sender, EventArgs e)
        {
            prikaz.DataSource = izvor;

            txtID.DataBindings.Add("Text", izvor, "id");
            txtNaziv.DataBindings.Add("Text", izvor, "nazprp");
        }

        private void frmRezultat_FormClosed(object sender, FormClosedEventArgs e)
        {
            izvor.Filter = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (prikaz.CurrentRowIndex >= 0)
                id = txtID.Text;
        }

        private void frmRezultat_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (id.Length == 0)
            {
                MessageBox.Show("Ni jedan plan nije izabran!!!");
                e.Cancel = true;
            }
        }
    }
}