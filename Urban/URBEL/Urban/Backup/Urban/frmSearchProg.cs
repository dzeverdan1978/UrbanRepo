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
    public partial class frmSearchProg : Form
    {
        ArrayList tipplakt, inicijat, obrad,opstine,arhive,kart,veze;
        bool prvi_put=true;
        public string filter;
        public ProgramiPamcenje pp = new ProgramiPamcenje();

        public frmSearchProg()
        {
            
            InitializeComponent();
            
        }

        private string Prefix
        {
            get
            {
                string izlaz = (filter == null || filter.Length == 0) ? " " : " AND";
                return izlaz;
            }
        }

        private string DajLB(ListBox lb)
        {
            string izlaz = "";
            foreach (string stavka in lb.Items)
                izlaz += "'" + stavka + "',";
            izlaz = izlaz.Substring(0, izlaz.Length - 1);
            return izlaz;
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct " + naziv + " from program where " + naziv + " is not null";
                SqlCommand kom = new SqlCommand(upit, veza);
                SqlDataReader rd = kom.ExecuteReader();
                ArrayList izlaz = new ArrayList();
                while (rd.Read())
                {
                    if (naziv != "KARTBROJ")
                        izlaz.Add(rd.GetString(0));
                    else
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

        private void ObrisiStavku(ListBox cb)
        {
            if (cb.SelectedIndex >= 0)
            {
               
                cb.Items.RemoveAt(cb.SelectedIndex);

            }
        }

        private void frmSearchProg_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();

            kart = DajKolonu(veza, "KARTBR");

            tipplakt = DajKolonu(veza, "TIPPLAKT");
            tipplakt.Add("---");
            cbTipPlakt.DataSource = tipplakt;
            cbTipPlakt.Text = "---";

            inicijat = DajKolonu(veza, "INICIJAT");
            inicijat.Add("---");
            cbInicijat.DataSource = inicijat;
            cbInicijat.Text = "---";

            obrad = DajKolonu(veza, "OBRADJIVAC");
            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in obrad)
                asc60.Add(s);
            txtObrad.AutoCompleteCustomSource = asc60;

            veze= DajKolonu(veza, "VEZA");
            AutoCompleteStringCollection asc66 = new AutoCompleteStringCollection();
            foreach (string s in veze)
                asc66.Add(s);
            txtVeza.AutoCompleteCustomSource = asc66;
           

            opstine = DajKolonu(veza, "OPSTINA");
            arhive = DajKolonu(veza, "ARHBR");

            AutoCompleteStringCollection asc5 = new AutoCompleteStringCollection();
            foreach (string s in opstine)
                asc5.Add(s);
            txtOpstina.AutoCompleteCustomSource = asc5;

            AutoCompleteStringCollection asc6 = new AutoCompleteStringCollection();
            foreach (string s in arhive)
                asc6.Add(s);
            txtArh.AutoCompleteCustomSource = asc6;

            AutoCompleteStringCollection asc7 = new AutoCompleteStringCollection();
            foreach (string s in kart)
                asc7.Add(s);
            txtKart.AutoCompleteCustomSource = asc7;

            prvi_put=false;
            veza.Close();

            if (pp != null)
            {
                if (pp.tipplakt.Count > 0)
                {
                    foreach (string s in pp.tipplakt)
                        lbTIPPLAKT.Items.Add(s);
                }

                if (pp.inicijat.Count > 0)
                {
                    foreach (string s in pp.inicijat)
                        lbINICIJAT.Items.Add(s);
                }

                txtObrad.Text = pp.obradjivac;
                txtArh.Text = pp.arh;
                txtVeza.Text = pp.veza;
                txtNaziv.Text = pp.naziv;
                txtKart.Text = pp.kart;
                txtOpstina.Text = pp.opstina;
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
                datumOD.Text = pp.datpoc;
                datumDO.Text = pp.datkraj;
            }
            else
                pp = new ProgramiPamcenje();
            

        }

        private void cbTipPlakt_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProveriListu(lbTIPPLAKT, cbTipPlakt);
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
               if (cb.Name==cbTipPlakt.Name)
                   pp.tipplakt.Add(cb.Text);
               else
                   pp.inicijat.Add(cb.Text);
              
            }
        }

        private void cbInicijat_SelectedIndexChanged(object sender, EventArgs e)
        {
            ProveriListu(lbINICIJAT, cbInicijat);
        }

       

        private void lbTIPPLAKT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                ObrisiStavku(lbTIPPLAKT);
        }

        private void lbINICIJAT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
                ObrisiStavku(lbINICIJAT);
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            filter += (lbTIPPLAKT.Items.Count==0) ? "" : Prefix + " " + "TIPPLAKT in (" + DajLB(lbTIPPLAKT) + ")";
            filter += (lbINICIJAT.Items.Count == 0) ? "" : Prefix + " " + "INICIJAT in (" + DajLB(lbINICIJAT) + ")";
            filter += (txtObrad.Text == "") ? "" : Prefix + " " + "OBRADJIVAC LIKE '%" + txtObrad.Text + "%'";
            filter += (txtKart.Text == "") ? "" : Prefix + " " + "KARTBR='" + txtKart.Text + "'";
            filter += (txtVeza.Text == "") ? "" : Prefix + " " + "VEZA='" + txtVeza.Text + "'";
            filter += (txtArh.Text == "") ? "" : Prefix + " " + "ARHBR='" + txtArh.Text + "'";
            filter += (txtNaziv.Text == "") ? "" : Prefix + " " + "NAZIV LIKE '%" + txtNaziv.Text + "%'";
            string[] opstinaSearch = txtOpstina.Text.Split(',');
            string kriterijum = "";
            if (opstinaSearch.Length == 1)
                kriterijum = "OPSTINA LIKE '%" + txtOpstina.Text + "%'";
            else
            {
                kriterijum = "(OPSTINA LIKE '%" + opstinaSearch[0] + "%'";
                for (int i = 1; i < opstinaSearch.Length; i++)
                {
                    kriterijum += " OR OPSTINA LIKE '%" + opstinaSearch[i] + "%'";
                }
                kriterijum += ")";
                //kriterijum = kriterijum.Substring(0, kriterijum.Length - 1);
                //kriterijum = "ID IN (" + DajKritsrijum(kriterijum) + ")";
            }
            filter += (txtOpstina.Text == "") ? "" : Prefix + " " + kriterijum;
            if (optDATUMI.Checked && datumOD.Text.Length > 0 && datumDO.Text.Length > 0)
            {
                filter += Prefix + " DATUM>='" + datumOD.Text + "' AND DATUM<='" + datumDO.Text + "'";
            }
            if (!r1.Checked)
            {
                filter += (r3.Checked) ? Prefix + " " + "REALIZOVAN=1" : Prefix + " " + "REALIZOVAN=0";
            }

            if (!d1.Checked)
            {
                filter += (d3.Checked) ? Prefix + " " + "VEKTOR=1" : Prefix + " " + "VEKTOR=0";
            }

            if (!s1.Checked)
            {
                filter += (s3.Checked) ? Prefix + " " + "SKEN=1" : Prefix + " " + "SKEN=0";
            }
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "UP - Urbanisticki projekat\nPP - Prostorni plan\nOST - Ostalo\nGUP - Generalni urbanisticki plan\nRP - Regulacioni plan\nPAR - Plan parcelacije\nDUP - Detaljni urbanisticki plan\nPRIV - Privremene dozvole\nPGR - Plan generalne regulacije\nDRUP - Drugi propisi\nSTR - Strateske procene\nGP - Generalni plan\nUUP - Uslovi za uredjenje prostora\nPDR - Plan detaljne regulacije\nPOU - Plan opsteg uredjenja";
            tip.SetToolTip(label1, caption);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "01 Barajevo 02 Vozdovac 03 Vracar 04 Grocka\n 05 Zvezdara 06 Zemun 07 Lazarevac 08 Mladenovac\n 09 N.Beograd 10 Obrenovac 11 Palilula 12 S.Venac\n 13 Sopot 14 S.Grad 15 Cukarica 16 Rakovica 17 Surcin";
            tip.SetToolTip(label4, caption);
        }

        private void optDATUMI_CheckedChanged(object sender, EventArgs e)
        {
            panel2.Visible = !panel2.Visible;
            pp.optDatumi = optDATUMI.Checked;
        }

        private void txtObrad_Leave(object sender, EventArgs e)
        {
            pp.obradjivac = txtObrad.Text;
        }

        private void txtArh_Leave(object sender, EventArgs e)
        {
            pp.arh = txtArh.Text;
        }

        private void txtOpstina_Leave(object sender, EventArgs e)
        {
            pp.opstina = txtOpstina.Text;
        }

        private void txtKart_Leave(object sender, EventArgs e)
        {
            pp.kart = txtKart.Text;
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            pp.naziv = txtNaziv.Text;
        }

        private void txtVeza_Leave(object sender, EventArgs e)
        {
            pp.veza = txtVeza.Text;
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

        private void btnOcisti_Click(object sender, EventArgs e)
        {
            pp = new ProgramiPamcenje();
            lbTIPPLAKT.Items.Clear();
            lbINICIJAT.Items.Clear();
            txtOpstina.Text = "";
            txtArh.Text = "";
            txtObrad.Text = "";
            txtKart.Text = "";
            txtNaziv.Text = "";
            txtVeza.Text = "";
            optDATUMI.Checked = false;
            datumDO.Text = "";
            datumOD.Text = "";
            r1.Checked = true;
            d1.Checked = true;
            s1.Checked = true;

        }
    }

    public class ProgramiPamcenje
    {
        public ArrayList tipplakt=new ArrayList(), inicijat=new ArrayList();
        public string obradjivac,arh,opstina,kart,naziv,veza;
       public bool optDatumi;
        public string datpoc,datkraj;
        public RadioButton opcija;
       
    }
}