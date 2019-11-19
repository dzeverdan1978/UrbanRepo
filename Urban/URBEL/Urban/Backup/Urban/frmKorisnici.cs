using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Urban
{
    public partial class frmKorisnici : Form
    {
        public UrbanDataSet ds;

        public frmKorisnici()
        {
            InitializeComponent();
        }

        private void SrediGrid()
        {
            button1.Focus();
            int brr = ds.Korisnik.Rows.Count;
            if (prikaz.CurrentRowIndex >= 0)
            {
                if (prikaz.CurrentRowIndex == (brr - 1))
                {
                    prikaz.CurrentRowIndex--;
                    prikaz.CurrentRowIndex++;
                }
                else
                {
                    prikaz.CurrentRowIndex++;
                    prikaz.CurrentRowIndex--;
                }
            }
        }

        private void frmKorisnici_Load(object sender, EventArgs e)
        {
            prikaz.DataSource = ds.Korisnik;
        }

        

        private void frmKorisnici_FormClosing(object sender, FormClosingEventArgs e)
        {
            SrediGrid();
        }
    }
}