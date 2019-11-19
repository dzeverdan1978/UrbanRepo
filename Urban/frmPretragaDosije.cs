using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections;
using System.Configuration;

namespace Urban
{
    public partial class frmPretragaDosije : Form
    {
        public DosijePamcenje pp = new DosijePamcenje();
        public string filter;
        ArrayList dos, reg, kart, opstina, izm, cr;

        public frmPretragaDosije()
        {
            InitializeComponent();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            pp = new DosijePamcenje();

            txtDOS.Text = "";
            txtREG.Text = "";
            txtKart.Text = "";
            txtNaslov.Text = "";
            txtOpstina.Text = "";
            txtIZM.Text = "";
            txtCR.Text = "";
            cbOpt.Checked = false;
            cbAzur.Checked = false;
        }

        private void cbOpt_CheckedChanged(object sender, EventArgs e)
        {
            cbAzur.Visible = cbOpt.Checked;
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from Dosije ";
                SqlCommand kom = new SqlCommand(upit, veza);
                SqlDataReader rd = kom.ExecuteReader();
                ArrayList izlaz = new ArrayList();
                while (rd.Read())
                {
                    izlaz.Add(rd.GetString(0));
                }
                rd.Close();
                return izlaz;
            }
            catch (SqlException ex)
            {
                throw new Exception("Greska u citanju " + naziv);
            }
        }

        private string Prefix
        {
            get
            {
                string izlaz = (filter == null || filter.Length == 0) ? " " : " AND";
                return izlaz;
            }
        }

        private void frmPretragaDosije_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();

             opstina = DajKolonu(veza, "opstina");
           
            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in opstina)
                asc60.Add(s);
            txtOpstina.AutoCompleteCustomSource = asc60;

            dos = DajKolonu(veza, "dos");

            AutoCompleteStringCollection asc61= new AutoCompleteStringCollection();
            foreach (string s in dos)
                asc61.Add(s);
            txtDOS.AutoCompleteCustomSource = asc61;

            reg = DajKolonu(veza, "reg");

            AutoCompleteStringCollection asc62 = new AutoCompleteStringCollection();
            foreach (string s in reg)
                asc62.Add(s);
            txtREG.AutoCompleteCustomSource = asc62;

            kart = DajKolonu(veza, "kart");

            AutoCompleteStringCollection asc63 = new AutoCompleteStringCollection();
            foreach (string s in kart)
                asc63.Add(s);
            txtKart.AutoCompleteCustomSource = asc63;

            izm = DajKolonu(veza, "izm");

            AutoCompleteStringCollection asc64 = new AutoCompleteStringCollection();
            foreach (string s in izm)
                asc64.Add(s);
            txtIZM.AutoCompleteCustomSource = asc64;

            cr = DajKolonu(veza, "cr");

            AutoCompleteStringCollection asc65 = new AutoCompleteStringCollection();
            foreach (string s in cr)
                asc65.Add(s);
            txtCR.AutoCompleteCustomSource = asc65;

            if (pp != null)
            {
                txtDOS.Text = pp.dos;
                txtREG.Text = pp.reg;
                txtKart.Text = pp.kart;
                txtNaslov.Text = pp.naslov;
                txtOpstina.Text = pp.opstina;
                txtIZM.Text = pp.izm;
                txtCR.Text = pp.cr;
                cbOpt.Checked = pp.opt;
                cbAzur.Checked = pp.azur;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter += (txtDOS.Text == "") ? "" : Prefix + " " + "DOS='" + txtDOS.Text + "'";
            filter += (txtREG.Text == "") ? "" : Prefix + " " + "REG='" + txtREG.Text + "'";
            filter += (txtKart.Text == "") ? "" : Prefix + " " + "KART='" + txtKart.Text + "'";
            filter += (txtOpstina.Text == "") ? "" : Prefix + " " + "OPSTINA='" + txtOpstina.Text + "'";
            filter += (txtIZM.Text == "") ? "" : Prefix + " " + "IZM='" + txtIZM.Text + "'";
            filter += (txtCR.Text == "") ? "" : Prefix + " " + "CR='" + txtCR.Text + "'";
            filter += (txtNaslov.Text == "") ? "" : Prefix + " " + "NASLOV LIKE '%" + txtNaslov.Text + "%'";
            if (cbOpt.Checked)
            {
                filter += (cbAzur.Checked) ? Prefix + " " + "AZUR=1" : Prefix + " " + "AZUR=0";
            }

            pp.dos = txtDOS.Text;
            pp.reg = txtREG.Text;
            pp.kart = txtKart.Text;
            pp.naslov = txtNaslov.Text;
            pp.opstina = txtOpstina.Text;
            pp.izm = txtIZM.Text;
            pp.cr = txtCR.Text;
            pp.opt = cbOpt.Checked;
            pp.azur = cbAzur.Checked;
        }
    }

    public class DosijePamcenje
    {
        public string dos, reg, kart, naslov, cs,opstina,izm,cr;
        public bool azur,opt;
        
    }
}
