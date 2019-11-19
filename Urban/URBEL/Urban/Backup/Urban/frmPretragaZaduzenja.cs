using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace Urban
{
    public partial class frmPretragaZaduzenja : Form
    {
        public ArrayList duznik,sifre;
        public string filter;
        public ZaduzenjaPamcenje pp;

        public frmPretragaZaduzenja()
        {
            InitializeComponent();
        }

        private void frmPretragaZaduzenja_Load(object sender, EventArgs e)
        {
            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in duznik)
                asc60.Add(s);
            txtDuznik.AutoCompleteCustomSource = asc60;

            AutoCompleteStringCollection asc61 = new AutoCompleteStringCollection();
            foreach (string s in sifre)
                asc61.Add(s);
            txtSifra.AutoCompleteCustomSource = asc61;

            if (pp != null)
            {
                txtSifra.Text = pp.sifra;
                txtNapomena.Text = pp.napomena;
                txtNaziv.Text = pp.naziv;
                txtDuznik.Text = pp.duznik;
                if (pp.opcija != null)
                {
                    switch (pp.opcija.Name)
                    {
                        case "r1":
                            r1.Checked = true;
                            break;
                        case "r2":
                            r2.Checked = true;
                            break;
                        case "r4":
                            r3.Checked = true;
                            break;
                    }
                }
                optDATUMI.Checked = pp.optDatumi;
            }
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            txtSifra.Text = "";
            txtNaziv.Text = "";
            txtDuznik.Text = "";
            txtNapomena.Text = "";
            r1.Checked = true;
            optDATUMI.Checked = false;
            datumDO.Text = "";
            datumOD.Text = "";

            pp = new ZaduzenjaPamcenje();
        }

        private void optDATUMI_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            pp.optDatumi = optDATUMI.Checked;
        }

        private string Prefix
        {
            get
            {
                string izlaz = (filter == null || filter.Length == 0) ? " " : " AND";
                return izlaz;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter += (txtSifra.Text == "") ? "" : Prefix + " " + "sifra='" + txtSifra.Text + "'";
            filter += (txtNaziv.Text == "") ? "" : Prefix + " " + "NAZIV LIKE '%" + txtNaziv.Text + "%'";
            filter += (txtNapomena.Text == "") ? "" : Prefix + " " + "NAPOM LIKE '%" + txtNapomena.Text + "%'";
            filter += (txtDuznik.Text == "") ? "" : Prefix + " " + "duznik LIKE '%" + txtDuznik.Text + "%'";
            if (optDATUMI.Checked && datumOD.Text.Length > 0 && datumDO.Text.Length > 0)
            {
                filter += Prefix + " DATUM>='" + datumOD.Text + "' AND DATUM<='" + datumDO.Text + "'";
            }
            if (!r1.Checked)
            {
                filter += (r3.Checked) ? Prefix + " " + "RAZ=-1" : Prefix + " " + "RAZ=0";
            }
        }

        private void txtSifra_Leave(object sender, EventArgs e)
        {
            pp.sifra = txtSifra.Text;
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            pp.naziv = txtNaziv.Text;
        }

        private void txtDuznik_Leave(object sender, EventArgs e)
        {
            pp.duznik = txtDuznik.Text;
        }

        private void txtNapomena_Leave(object sender, EventArgs e)
        {
            pp.napomena = txtNapomena.Text;
        }

        private void datumOD_Leave(object sender, EventArgs e)
        {
            pp.datpoc = datumOD.Text;
        }

        private void datumDO_Leave(object sender, EventArgs e)
        {
            pp.datkraj = datumDO.Text;
        }

        private void r1_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton rb = (RadioButton)sender;
            if (rb.Checked)
                pp.opcija = rb;
        }
    }

    public class ZaduzenjaPamcenje
    {
        public string sifra, naziv, napomena, duznik;
        public bool optDatumi;
        public string datpoc, datkraj;
        public RadioButton opcija;
    }
}