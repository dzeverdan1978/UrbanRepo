using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Configuration;
using System.Data.SqlClient;

namespace Urban
{
    public partial class frmDOCPretraga : Form
    {
        public DOCPamcenje pp = new DOCPamcenje();
        public string filter;
        ArrayList opstine, inref, tipdoc,REGBRS,BIBS,ARHBRS,ARHBRDOCS,katopsts,brkatpars,matrs,osnovs;
        bool prvi_put = true;

        public frmDOCPretraga()
        {
            InitializeComponent();
        }

        private void optDATUMI_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            pp.optDatumi = optDATUMI.Checked;
        }

        private void ProveriListu(ListBox lista, ComboBox cb)
        {
            bool nema = true;
            foreach (string stavka in lista.Items)
            {
                if (stavka == cb.Text)
                {
                    nema = false;
                    break;
                }
            }

            if (nema && cb.Text != "---" && !prvi_put)
            {
                lista.Items.Add(cb.Text);
                if (cb.Name == cbINREF.Name)
                    pp.inref.Add(cb.Text);
                else
                    pp.tipdoc.Add(cb.Text);

            }
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from urbdoc ";
                if (naziv == "osnov" || naziv == "REGB")
                    upit = "select distinct isnull(" + naziv + ",0) from urbdoc ";
                SqlCommand kom = new SqlCommand(upit, veza);
                SqlDataReader rd = kom.ExecuteReader();
                ArrayList izlaz = new ArrayList();
                while (rd.Read())
                {
                    try
                    {
                        izlaz.Add(rd.GetString(0));
                    }
                    catch
                    {
                        izlaz.Add(Convert.ToInt32(rd[0]).ToString());
                    }
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

        private void frmDOCPretraga_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();

           
            inref = DajKolonu(veza, "INREF");
            inref.Add("---");
            cbINREF.DataSource = inref;
            cbINREF.Text = "---";

            tipdoc = DajKolonu(veza, "TIPDOC");
            tipdoc.Add("---");
            cbTIPDOC.DataSource = tipdoc;
            cbTIPDOC.Text = "---";


            opstine = DajKolonu(veza, "OPSTINA");
          
            REGBRS = DajKolonu(veza, "REGB");
            BIBS   = DajKolonu(veza, "BIB");
            ARHBRS = DajKolonu(veza, "ARHBR");
            ARHBRDOCS = DajKolonu(veza, "arhbrdoc");
            matrs = DajKolonu(veza, "matr");
            osnovs = DajKolonu(veza, "OSNOV");
            katopsts = DajKolonu(veza, "katopst");
            brkatpars = DajKolonu(veza, "BRKATPAR");

           

            AutoCompleteStringCollection asc5 = new AutoCompleteStringCollection();
            foreach (string s in opstine)
                asc5.Add(s);
            txtOPSTINA.AutoCompleteCustomSource = asc5;

           
            AutoCompleteStringCollection asc52= new AutoCompleteStringCollection();
            foreach (string s in REGBRS)
                asc52.Add(s);
            txtREGB.AutoCompleteCustomSource = asc52;

            AutoCompleteStringCollection asc53 = new AutoCompleteStringCollection();
            foreach (string s in BIBS)
                asc53.Add(s);
            txtBIB.AutoCompleteCustomSource = asc53;

            AutoCompleteStringCollection asc54 = new AutoCompleteStringCollection();
            foreach (string s in ARHBRS)
                asc54.Add(s);
            txtARHBR.AutoCompleteCustomSource = asc54;

            AutoCompleteStringCollection asc55 = new AutoCompleteStringCollection();
            foreach (string s in ARHBRDOCS)
                asc55.Add(s);
           txtARHBRDOC.AutoCompleteCustomSource = asc55;

           AutoCompleteStringCollection asc56 = new AutoCompleteStringCollection();
           foreach (string s in matrs)
               asc56.Add(s);
          txtMatr.AutoCompleteCustomSource = asc56;

          AutoCompleteStringCollection asc57 = new AutoCompleteStringCollection();
          foreach (string s in osnovs)
              asc57.Add(s);
          txtOsnov.AutoCompleteCustomSource = asc57;

          AutoCompleteStringCollection asc58 = new AutoCompleteStringCollection();
          foreach (string s in katopsts)
              asc58.Add(s);
          txtKATOPST.AutoCompleteCustomSource = asc58;

          AutoCompleteStringCollection asc59 = new AutoCompleteStringCollection();
          foreach (string s in brkatpars)
              asc59.Add(s);
          txtBRKAT.AutoCompleteCustomSource = asc59;



         

            prvi_put = false;
            veza.Close();

            if (pp != null)
            {
                if (pp.inref.Count > 0)
                {
                    foreach (string s in pp.inref)
                        lbINREF.Items.Add(s);
                }

                if (pp.tipdoc.Count > 0)
                {
                    foreach (string s in pp.tipdoc)
                        lbTIPDOC.Items.Add(s);
                }

                txtARHBR.Text = pp.arhbr;
                txtARHBRDOC.Text = pp.arhbrdoc;
                txtBIB.Text = pp.bib;
                txtBR.Text = pp.br;
                txtBRKAT.Text = pp.brka;
                txtID.Text = pp.id;
                txtKATOPST.Text = pp.katopst;
                txtMatr.Text = pp.mat;
                txtNAPOMENA.Text = pp.napom;
                txtNaziv.Text = pp.naziv;
                txtOPSTINA.Text = pp.opstina;
                txtOsnov.Text = pp.osnov;
                txtREGB.Text = pp.regb;
               
                
                optDATUMI.Checked = pp.optDatumi;
                datumOD.Text = pp.datpoc;
                datumDO.Text = pp.datkraj;
            }
            else
                pp = new DOCPamcenje();
        }

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            pp = new DOCPamcenje();
            lbINREF.Items.Clear();
            lbTIPDOC.Items.Clear();
            txtARHBR.Text = "";
            txtARHBRDOC.Text = "";
            txtBIB.Text = "";
            txtBR.Text = "";
            txtBRKAT.Text = "";
            txtID.Text = "";
            txtKATOPST.Text = "";
            txtMatr.Text = "";
            txtNAPOMENA.Text = "";
            txtNaziv.Text = "";
            txtOPSTINA.Text = "";
            txtOsnov.Text = "";
            txtREGB.Text = "";
            optDATUMI.Checked = false;
            datumDO.Text = "";
            datumOD.Text = "";
            
        }

        private void cbINREF_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProveriListu(lbINREF, cbINREF);
        }

        private void cbTIPDOC_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProveriListu(lbTIPDOC, cbTIPDOC);
        }

        private void txtBR_Leave(object sender, EventArgs e)
        {
            pp.br = txtBR.Text;
        }

        private void txtREGB_Leave(object sender, EventArgs e)
        {
            pp.regb = txtREGB.Text;
        }

        private void txtBIB_Leave(object sender, EventArgs e)
        {
            pp.bib = txtBIB.Text;
        }

        private void txtARHBR_Leave(object sender, EventArgs e)
        {
            pp.arhbr = txtARHBR.Text;
        }

        private void txtARHBRDOC_Leave(object sender, EventArgs e)
        {
            pp.arhbrdoc = txtARHBRDOC.Text;
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            pp.naziv = txtNaziv.Text;
        }

        private void txtNAPOMENA_Leave(object sender, EventArgs e)
        {
            pp.napom = txtNAPOMENA.Text;
        }

        private void txtOPSTINA_Leave(object sender, EventArgs e)
        {
            pp.opstina = txtOPSTINA.Text;
        }

        private void txtKATOPST_Leave(object sender, EventArgs e)
        {
            pp.katopst = txtKATOPST.Text;
        }

        private void txtBRKAT_Leave(object sender, EventArgs e)
        {
            pp.brka = txtBRKAT.Text;
        }

        private void txtMatr_Leave(object sender, EventArgs e)
        {
            pp.mat = txtMatr.Text;
        }

        private void txtOsnov_Leave(object sender, EventArgs e)
        {
            pp.osnov = txtOsnov.Text;
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            pp.id = txtID.Text;
        }

        private void datumOD_Leave(object sender, EventArgs e)
        {
            pp.datpoc = datumOD.Text;
        }

        private void datumDO_Leave(object sender, EventArgs e)
        {
            pp.datkraj = datumDO.Text;
        }

        private string DajLB(ListBox lb)
        {
            string izlaz = "";
            foreach (string stavka in lb.Items)
                izlaz += "'" + stavka + "',";
            izlaz = izlaz.Substring(0, izlaz.Length - 1);
            return izlaz;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            filter += (lbINREF.Items.Count == 0) ? "" : Prefix + " " + "INREF in (" + DajLB(lbINREF) + ")";
            filter += (lbTIPDOC.Items.Count == 0) ? "" : Prefix + " " + "TIPDOC in (" + DajLB(lbTIPDOC) + ")";

            filter += (txtOsnov.Text == "") ? "" : Prefix + " " + "OSNOV LIKE '%" + txtOsnov.Text+"%'";
            filter += (txtID.Text == "") ? "" : Prefix + " " + "ID=" + txtID.Text;
            filter += (txtBR.Text == "") ? "" : Prefix + " " + "BR=" + txtBR.Text;
            filter += (txtREGB.Text == "") ? "" : Prefix + " " + "REGB=" + txtREGB.Text;
            filter += (txtBIB.Text == "") ? "" : Prefix + " " + "BIB='" + txtBIB.Text+"'";
            filter += (txtARHBR.Text == "") ? "" : Prefix + " " + "ARHBR='" + txtARHBR.Text + "'";
            filter += (txtARHBRDOC.Text == "") ? "" : Prefix + " " + "ARHBRDOC='" + txtARHBRDOC.Text + "'";
            filter += (txtKATOPST.Text == "") ? "" : Prefix + " " + "KATOPST='" + txtKATOPST.Text + "'";
            filter += (txtBRKAT.Text == "") ? "" : Prefix + " " + "BRKATPAR LIKE '%" + txtBRKAT.Text + "%'";
            filter += (txtMatr.Text == "") ? "" : Prefix + " " + "MATR='" + txtMatr.Text + "'"; 
            
            filter += (txtNaziv.Text == "") ? "" : Prefix + " " + "NAZIV LIKE '%" + txtNaziv.Text + "%'";
            filter += (txtNAPOMENA.Text == "") ? "" : Prefix + " " + "NAPOM LIKE '%" + txtNAPOMENA.Text + "%'";
            string[] opstinaSearch = txtOPSTINA.Text.Split(',');
            string kriterijum = "";
            if (opstinaSearch.Length == 1)
                kriterijum = "OPSTINA LIKE '%" + txtOPSTINA.Text + "%'";
            else
            {
                kriterijum = "(OPSTINA LIKE '%" + opstinaSearch[0] + "%'";
                for (int i = 1; i < opstinaSearch.Length; i++)
                {
                    kriterijum += " OR OPSTINA LIKE '%" + opstinaSearch[i] + "%'";
                }
                kriterijum += ")";
                
            }
            filter += (txtOPSTINA.Text == "") ? "" : Prefix + " " + kriterijum;
            if (optDATUMI.Checked && datumOD.Text.Length > 0 && datumDO.Text.Length > 0)
            {
                filter += Prefix + " DATUM>='" + datumOD.Text + "' AND DATUM<='" + datumDO.Text + "'";
            }
            
        }

        private void ObrisiStavku(ListBox cb)
        {
            if (cb.SelectedIndex >= 0)
            {

                cb.Items.RemoveAt(cb.SelectedIndex);

            }
        }

        private void lbINREF_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ObrisiStavku(lbINREF);
        }

        private void lbTIPDOC_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                ObrisiStavku(lbTIPDOC);
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "UP - Urbanisticki projekat\nPP - Prostorni plan\nOST - Ostalo\nGUP - Generalni urbanisticki plan\nRP - Regulacioni plan\nPAR - Plan parcelacije\nDUP - Detaljni urbanisticki plan\nPRIV - Privremene dozvole\nPGR - Plan generalne regulacije\nDRUP - Drugi propisi\nSTR - Strateske procene\nGP - Generalni plan\nUUP - Uslovi za uredjenje prostora\nPDR - Plan detaljne regulacije\nPOU - Plan opsteg uredjenja\nAKT - akt\nUD - Urbanisticka dozvola\nIZV - izvod iz plana\nPOT - potvrda up-a\nPRO - program\nUTU - Urbanisticko tehnicki uslovi";
            tip.SetToolTip(label15, caption);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "01 Barajevo 02 Vozdovac 03 Vracar 04 Grocka\n 05 Zvezdara 06 Zemun 07 Lazarevac 08 Mladenovac\n 09 N.Beograd 10 Obrenovac 11 Palilula 12 S.Venac\n 13 Sopot 14 S.Grad 15 Cukarica 16 Rakovica 17 Surcin";
            tip.SetToolTip(label3, caption);
        }
    }

    public class DOCPamcenje
    {
        public ArrayList inref = new ArrayList(), tipdoc = new ArrayList();
        public string opstina, br, regb, bib,arhbr,arhbrdoc,naziv,napom,katopst,brka,mat,osnov,id;
        public bool optDatumi;
        public string datpoc, datkraj;
        
    }
}