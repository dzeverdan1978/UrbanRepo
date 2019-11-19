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
        }
    }

    public class DosijePamcenje
    {
        public string dos, reg, kart, naslov, cs,opstina,izm;
        public bool azur,opt;
        
    }
}
