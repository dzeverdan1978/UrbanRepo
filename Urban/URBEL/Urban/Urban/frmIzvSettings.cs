using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Urban
{
    public partial class frmIzvSettings : Form
    {
        public dsIzvestaj di;

        public frmIzvSettings()
        {
            InitializeComponent();
        }

        private void frmIzvSettings_Load(object sender, EventArgs e)
        {
            prikaz.DataSource = di.Napomena;
            unos_tekst.DataBindings.Add("Text", di.Napomena, "opis");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            dsIzvestajTableAdapters.NapomenaTableAdapter na = new Urban.dsIzvestajTableAdapters.NapomenaTableAdapter();
            SrediGrid();
            if (di.HasChanges())
            {
                na.Update(di.Napomena);
                di.AcceptChanges();
            }
        }

        private void SrediGrid()
        {
            int brr = di.Napomena.Rows.Count;
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
    }
}