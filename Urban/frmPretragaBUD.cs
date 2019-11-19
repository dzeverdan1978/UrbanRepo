using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.SqlClient;
using System.Configuration;

namespace Urban
{
    public partial class frmPretragaBUD : Form
    {
        public BUDPamcenje pp = new BUDPamcenje();
        public string filter;
        ArrayList opstina, redbr, godnast, tip, oblik, cuva;

        public frmPretragaBUD()
        {
            InitializeComponent();
        }

        private void cbOptUradjen_CheckedChanged(object sender, EventArgs e)
        {
            cbURADJEN.Visible = cbOptUradjen.Checked;
        }

        private void cbOptPotpisan_CheckedChanged(object sender, EventArgs e)
        {
            cbPOTPISAN.Visible = cbOptPotpisan.Checked;
        }

        private void cbOptPecacen_CheckedChanged(object sender, EventArgs e)
        {
            cbPECACEN.Visible = cbOptPecacen.Checked;
        }

        private void cbOptPoz_CheckedChanged(object sender, EventArgs e)
        {
            cbPOZ.Visible = cbOptPoz.Checked;
        }

        private void cbOptDatum_CheckedChanged(object sender, EventArgs e)
        {
            pnlDatum.Visible = cbOptDatum.Checked;
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            pp = new BUDPamcenje();

            txtARHBR.Text = "";
            txtBBLBRPRP.Text = "";
            txtBRTA.Text = "";
            txtCUVA.Text = "";
            txtGODNAST.Text = "";
            txtNaziv.Text = "";
            txtOBLIK.Text = "";
            txtOpstina.Text = "";
            txtPRIMEDBA.Text = "";
            txtPROSPOL.Text = "";
            txtREDBR.Text = "";
            txtTIP.Text = "";
            txtVEZARUP.Text = "";
            txtVRSBIB.Text = "";
            cbOptDatum.Checked = false;
            cbOptPecacen.Checked = false;
            cbOptPotpisan.Checked = false;
            cbOptPoz.Checked = false;
            cbOptUradjen.Checked = false;
            cbPECACEN.Checked = false;
            cbPOTPISAN.Checked = false;
            cbPOZ.Checked = false;
            cbURADJEN.Checked = false;
            //nuKOM.Value = 0;
            dtDatumDo.Value = DateTime.Now;
            dtDatumOd.Value = DateTime.Now;
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from BUD ";
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

        private void frmPretragaBUD_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();

            opstina = DajKolonu(veza, "opstina");
            redbr = DajKolonu(veza, "redbr");
            godnast = DajKolonu(veza, "godnast");
            tip = DajKolonu(veza, "tip");
            oblik = DajKolonu(veza, "oblik");
            cuva = DajKolonu(veza, "cuva");

            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in opstina)
                asc60.Add(s);
            txtOpstina.AutoCompleteCustomSource = asc60;

            AutoCompleteStringCollection asc61 = new AutoCompleteStringCollection();
            foreach (string s in redbr)
                asc61.Add(s);
            txtREDBR.AutoCompleteCustomSource = asc61;

            AutoCompleteStringCollection asc62 = new AutoCompleteStringCollection();
            foreach (string s in tip)
                asc62.Add(s);
            txtTIP.AutoCompleteCustomSource = asc62;

            AutoCompleteStringCollection asc63 = new AutoCompleteStringCollection();
            foreach (string s in godnast)
                asc63.Add(s);
            txtGODNAST.AutoCompleteCustomSource = asc63;

            AutoCompleteStringCollection asc64 = new AutoCompleteStringCollection();
            foreach (string s in oblik)
                asc64.Add(s);
            txtOBLIK.AutoCompleteCustomSource = asc64;

            AutoCompleteStringCollection asc65 = new AutoCompleteStringCollection();
            foreach (string s in cuva)
                asc65.Add(s);
            txtCUVA.AutoCompleteCustomSource = asc65;

            if (pp != null)
            {
                txtARHBR.Text = pp.arhbr;
                txtBBLBRPRP.Text = pp.biblbrprp;
                txtBRTA.Text = pp.brta;
                txtCUVA.Text = pp.cuva;
                txtGODNAST.Text = pp.godnast;
                txtNaziv.Text = pp.naziv;
                txtOBLIK.Text = pp.oblik;
                txtOpstina.Text = pp.opstina;
                txtPRIMEDBA.Text = pp.primedba;
                txtPROSPOL.Text = pp.prospol;
                txtREDBR.Text = pp.redbr;
                txtTIP.Text = pp.tip;
                txtVEZARUP.Text = pp.vezarup;
                txtVRSBIB.Text = pp.vrsbib;
                //nuKOM.Value = pp.kom;
                dtDatumOd.Value = pp.dod;
                dtDatumDo.Value = pp.ddo;
                cbOptDatum.Checked = pp.odatum;
                cbOptPecacen.Checked = pp.opecacen;
                cbOptPotpisan.Checked = pp.opotpisan;
                cbOptPoz.Checked = pp.opoz;
                cbOptUradjen.Checked = pp.ouradjen;
                cbPECACEN.Checked = pp.pecacen;
                cbPOTPISAN.Checked = pp.potpisan;
                cbPOZ.Checked = pp.poz;
                cbURADJEN.Checked = pp.uradjen;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter += (txtREDBR.Text == "") ? "" : Prefix + " " + "REDBR='" + txtREDBR.Text + "'";
            filter += (txtGODNAST.Text == "") ? "" : Prefix + " " + "GODNAST='" + txtGODNAST.Text + "'";
            filter += (txtOpstina.Text == "") ? "" : Prefix + " " + "OPSTINA='" + txtOpstina.Text + "'";
            filter += (txtTIP.Text == "") ? "" : Prefix + " " + "TIP='" + txtTIP.Text + "'";
            filter += (txtARHBR.Text == "") ? "" : Prefix + " " + "ARHBR='" + txtARHBR.Text + "'";
            filter += (txtNaziv.Text == "") ? "" : Prefix + " " + "NAZIV LIKE '%" + txtNaziv.Text + "%'";
            filter += (txtOBLIK.Text == "") ? "" : Prefix + " " + "OBLIK='" + txtOBLIK.Text + "'";
            filter += (txtVEZARUP.Text == "") ? "" : Prefix + " " + "VEZARUP='" + txtVEZARUP.Text + "'";
            filter += (txtBRTA.Text == "") ? "" : Prefix + " " + "BRTA='" + txtBRTA.Text + "'";
            filter += (txtPROSPOL.Text == "") ? "" : Prefix + " " + "PROSPOL='" + txtPROSPOL.Text + "'";
            filter += (txtVRSBIB.Text == "") ? "" : Prefix + " " + "VRSBIB='" + txtVRSBIB.Text + "'";
            filter += (txtCUVA.Text == "") ? "" : Prefix + " " + "CUVA='" + txtCUVA.Text + "'";
            filter += (txtBBLBRPRP.Text == "") ? "" : Prefix + " " + "BIBLBRPRP='" + txtBBLBRPRP.Text + "'";
            filter += (txtPRIMEDBA.Text == "") ? "" : Prefix + " " + "PRIMEDBA LIKE '%" + txtPRIMEDBA.Text + "%'";
            //filter += (nuKOM.Value > 0) ? "" : Prefix + " " + "KOM=" + nuKOM.Value.ToString();
            if (cbOptPecacen.Checked)
            {
                filter += (cbPECACEN.Checked) ? Prefix + " " + "PECACEN=1" : Prefix + " " + "PECACEN=0";
            }
            if (cbOptPotpisan.Checked)
            {
                filter += (cbPOTPISAN.Checked) ? Prefix + " " + "POTPISAN=1" : Prefix + " " + "POTPISAN=0";
            }
            if (cbOptPoz.Checked)
            {
                filter += (cbPOZ.Checked) ? Prefix + " " + "POZ=1" : Prefix + " " + "POZ=0";
            }
            if (cbOptUradjen.Checked)
            {
                filter += (cbURADJEN.Checked) ? Prefix + " " + "URADJEN=1" : Prefix + " " + "URADJEN=0";
            }
            if (cbOptDatum.Checked)
            {
                filter += Prefix + " DATUPIS>='" + dtDatumOd.Value.ToShortDateString() + "' AND DATUPIS<='" + dtDatumDo.Value.ToShortDateString() + "'";
            }

            pp.arhbr = txtARHBR.Text;
            pp.biblbrprp = txtBBLBRPRP.Text;
            pp.brta = txtBRTA.Text;
            pp.cuva = txtCUVA.Text;
            pp.ddo = dtDatumDo.Value;
            pp.dod = dtDatumOd.Value;
            pp.godnast = txtGODNAST.Text;
           // pp.kom = Convert.ToInt32(nuKOM.Value);
            pp.naziv = txtNaziv.Text;
            pp.oblik = txtOBLIK.Text;
            pp.odatum = cbOptDatum.Checked;
            pp.opecacen = cbOptPecacen.Checked;
            pp.opotpisan = cbOptPotpisan.Checked;
            pp.opoz = cbOptPoz.Checked;
            pp.opstina = txtOpstina.Text;
            pp.ouradjen = cbOptUradjen.Checked;
            pp.pecacen = cbPECACEN.Checked;
            pp.potpisan = cbPOTPISAN.Checked;
            pp.poz = cbPOZ.Checked;
            pp.primedba = txtPRIMEDBA.Text;
            pp.prospol = txtPROSPOL.Text;
            pp.redbr = txtREDBR.Text;
            pp.tip = txtTIP.Text;
            pp.uradjen = cbURADJEN.Checked;
            pp.vezarup = txtVEZARUP.Text;
            pp.vrsbib = txtVRSBIB.Text;
        }
    }

    public class BUDPamcenje
    {
        public string redbr, godnast, opstina, naziv, arhbr,tip,oblik,vezarup,brta,prospol,vrsbib,primedba,cuva,biblbrprp;
        public int kom;
        public bool uradjen, potpisan, pecacen, poz, ouradjen, opotpisan, opecacen, opoz, odatum;
        public DateTime dod=DateTime.Now, ddo=DateTime.Now;

    }
}
