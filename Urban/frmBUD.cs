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
using System.IO;

namespace Urban
{
    public partial class frmBUD : Form
    {
        ArrayList opstina, redbr,godnast,tip,oblik,cuva;
        public dsBud podaci = new dsBud();
        bool novi;
        public bool ok;
        public DataRow korisnik;
        DataTable pom = new DataTable();
        public BUDPamcenje pp = new BUDPamcenje();
        public UrbanDataSet glavni;
        string filter;

        public frmBUD()
        {
            InitializeComponent();
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

        private void PoveziKontrole()
        {
            txtREDBR.DataBindings.Add("Text", izvor, "REDBR");
            txtGODNAST.DataBindings.Add("Text", izvor, "GODNAST");
            txtOpstina.DataBindings.Add("Text", izvor, "OPSTINA");
            txtTIP.DataBindings.Add("Text", izvor, "TIP");
            txtARHBR.DataBindings.Add("Text", izvor, "ARHBR");
            txtNaziv.DataBindings.Add("Text", izvor, "NAZIV");
            txtOBLIK.DataBindings.Add("Text", izvor, "OBLIK");
            txtVEZARUP.DataBindings.Add("Text", izvor, "VEZARUP");
            txtBRTA.DataBindings.Add("Text", izvor, "BRTA");
            txtPROSPOL.DataBindings.Add("Text", izvor, "PROSPOL");
            txtVRSBIB.DataBindings.Add("Text", izvor, "VRSBIB");
            txtPRIMEDBA.DataBindings.Add("Text", izvor, "PRIMEDBA");
            txtCUVA.DataBindings.Add("Text", izvor, "CUVA");
            txtBBLBRPRP.DataBindings.Add("Text", izvor, "BIBLBRPRP");
            cbURADJEN.DataBindings.Add("Checked", izvor, "URADJEN");
            cbPOTPISAN.DataBindings.Add("Checked", izvor, "POTPISAN");
            cbPECACEN.DataBindings.Add("Checked", izvor, "PECACEN");
            cbPOZ.DataBindings.Add("Checked", izvor, "POZ");
            nuKOM.DataBindings.Add("Value", izvor, "KOM");
            dtDATUM.DataBindings.Add("Value", izvor, "DATUPIS");

        }

        private void RazveziKontrole()
        {
            txtREDBR.DataBindings.Clear();
            txtREDBR.Text = "";
            txtGODNAST.DataBindings.Clear();
            txtGODNAST.Text = "";
            txtOpstina.DataBindings.Clear();
            txtOpstina.Text = "";
            txtTIP.DataBindings.Clear();
            txtTIP.Text = "";
            txtARHBR.DataBindings.Clear();
            txtARHBR.Text = "";
            txtNaziv.DataBindings.Clear();
            txtNaziv.Text = "";
            txtOBLIK.DataBindings.Clear();
            txtOBLIK.Text = "";
            txtVEZARUP.DataBindings.Clear();
            txtVEZARUP.Text = "";
            txtBRTA.DataBindings.Clear();
            txtBRTA.Text = "";
            txtPROSPOL.DataBindings.Clear();
            txtPROSPOL.Text = "";
            txtVRSBIB.DataBindings.Clear();
            txtVRSBIB.Text = "";
            txtPRIMEDBA.DataBindings.Clear();
            txtPRIMEDBA.Text = "";
            txtCUVA.DataBindings.Clear();
            txtCUVA.Text = "";
            txtBBLBRPRP.DataBindings.Clear();
            txtBBLBRPRP.Text = "";
            cbURADJEN.DataBindings.Clear();
            cbURADJEN.Checked = false;
            cbPOTPISAN.DataBindings.Clear();
            cbPOTPISAN.Checked = false;
            cbPECACEN.DataBindings.Clear();
            cbPECACEN.Checked = false;
            cbPOZ.DataBindings.Clear();
            cbPOZ.Checked = false;
            nuKOM.DataBindings.Clear();
            nuKOM.Value = 0;
            dtDATUM.DataBindings.Clear();
            dtDATUM.Value = DateTime.Now;
        }

        private void SrediGrid()
        {
            int brr = izvor.Count;
            if (pregled.CurrentRowIndex >= 0)
            {
                if (pregled.CurrentRowIndex == (brr - 1))
                {
                    pregled.CurrentRowIndex--;
                    pregled.CurrentRowIndex++;
                }
                else
                {
                    pregled.CurrentRowIndex++;
                    pregled.CurrentRowIndex--;
                }
            }
        }



        private void frmBUD_Load(object sender, EventArgs e)
        {
            dsBudTableAdapters.BUDTableAdapter pa = new Urban.dsBudTableAdapters.BUDTableAdapter();
            pa.Fill(podaci.BUD);
            podaci.AcceptChanges();
            izvor.DataSource = podaci.BUD;
            pregled.DataSource = izvor;

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

            PoveziKontrole();

            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);

            if (!Convert.ToBoolean(korisnik["admi"]))
            {
                if (!Convert.ToBoolean(korisnik["zadw"]))
                {
                    dugme_snimi.Enabled = false;
                    dugme_novi.Enabled = false;
                    dugme_brisi.Enabled = false;
                }
            }
        }

        private void Brisi()
        {
            try
            {
                if (pregled.CurrentRowIndex >= 0)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite da obrisete zapis?", "Upozorenje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {

                        DataGridCell dc = new DataGridCell(pregled.CurrentRowIndex, 20);
                        int dos = Convert.ToInt32(pregled[dc]);
                        dsBud.BUDRow kandidat = podaci.BUD.FindByID(dos);
                        if (kandidat != null)
                        {
                            kandidat.Delete();

                        }

                    }
                }
                else
                    MessageBox.Show("Nije izabran ni jedan zapis", "Greska",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska u brisanju: " + ex.Message);
            }
        }

        private void dugme_svi_Click(object sender, EventArgs e)
        {
            izvor.Filter = "";
            //btnStampa.Visible = false;
            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
            if (txtREDBR.DataBindings.Count == 0)
                PoveziKontrole();
        }

        private void dugme_novi_Click(object sender, EventArgs e)
        {
            novi = true;
            RazveziKontrole();
        }

        private void dugme_brisi_Click(object sender, EventArgs e)
        {
            Brisi();
        }

        private void UbaciNovi()
        {
            try
            {
                string ok = ProveriUnos();
                if (ok.Length > 0)
                    throw new Exception(ok);

                dsBud.BUDRow novi = podaci.BUD.NewBUDRow();

                novi.ARHBR = txtARHBR.Text;
                novi.BIBLBRPRP = txtBBLBRPRP.Text;
                novi.BRTA = txtBRTA.Text;
                novi.CUVA = txtCUVA.Text;
                novi.DATUPIS = dtDATUM.Value;
                novi.GODNAST = txtGODNAST.Text;
                novi.KOM = Convert.ToInt32( nuKOM.Value);
                novi.NAZIV = txtNaziv.Text;
                novi.OBLIK = txtOBLIK.Text;
                novi.OPSTINA = txtOpstina.Text;
                novi.PECACEN = cbPECACEN.Checked;
                novi.POTPISAN = cbPOTPISAN.Checked;
                novi.POZ = cbPOZ.Checked;
                novi.PRIMEDBA = txtPRIMEDBA.Text;
                novi.PROSPOL = txtPROSPOL.Text;
                novi.REDBR = txtREDBR.Text;
                novi.TIP = txtTIP.Text;
                novi.URADJEN = cbURADJEN.Checked;
                novi.VEZARUP = txtVEZARUP.Text;
                novi.VRSBIB = txtVRSBIB.Text;
                podaci.BUD.Rows.Add(novi);
            }
            catch (DataException ex)
            {
                throw new Exception("Greska u upisu podataka!");
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private string ProveriUnos()
        {
            string izlaz = "";
           
            if (txtNaziv.Text.Length == 0)
                izlaz = "Naziv mora da se unese!";
            if (txtOpstina.Text.Length == 0)
                izlaz = "Opstina mora da se unese!";

            return izlaz;
        }

        private void Snimi()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da snimite promene?", "Upozorenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    dsBud promene = (dsBud)this.podaci.GetChanges();

                    if (this.podaci.HasChanges())
                    {
                        dsBudTableAdapters.BUDTableAdapter filter = new Urban.dsBudTableAdapters.BUDTableAdapter();
                        filter.Update(promene.BUD);

                        podaci.AcceptChanges();


                        MessageBox.Show("Podaci uspesno snimljeni u bazu", "Snimanje",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Greska u snimanju: " + ex.Message);
                }
                finally
                {
                    this.Cursor = Cursors.Default;
                }
            }
        }

        private void dugme_snimi_Click(object sender, EventArgs e)
        {
            try
            {
                if (novi)
                {
                    UbaciNovi();
                    izvor.MoveLast();
                    izvor.MovePrevious();
                    izvor.MoveNext();
                    PoveziKontrole();
                    novi = false;
                }
                else
                {

                    SrediGrid();
                }
                RazveziKontrole();
                Snimi();
                if (izvor.Count > 0)
                    PoveziKontrole();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void frmBUD_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToBoolean(korisnik["zadw"]) || Convert.ToBoolean(korisnik["admi"]) || Convert.ToBoolean(korisnik["azur"]))
            {
                SrediGrid();
                Snimi();
            }
            // izvor.Filter = "";
        }

        private void txtREDBR_Leave(object sender, EventArgs e)
        {
            FormirajBBLBR();
        }

        private void FormirajBBLBR()
        {
            if (txtREDBR.Text.Length > 0 && txtGODNAST.Text.Length > 0 && txtOpstina.Text.Length > 0)
            {
                int rbr = Convert.ToInt32(txtREDBR.Text);
                string godina = txtGODNAST.Text.Substring(2, 2);
                string ops = txtOpstina.Text.Substring(0, 2);

                txtBBLBRPRP.Text = rbr.ToString() + "/" + godina + "/" + ops;
            }
        }

        private void txtGODNAST_Leave(object sender, EventArgs e)
        {
            FormirajBBLBR();
        }

        private void txtOpstina_Leave(object sender, EventArgs e)
        {
            FormirajBBLBR();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow[] redovi = podaci.BUD.Select(filter);
                dsBud dz = (dsBud)podaci.Clone();

                SaveFileDialog sf = new SaveFileDialog();
                sf.DefaultExt = "csv";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataRow red in redovi)
                    {
                        red[0] = " " + red[0].ToString().Trim();
                        dz.BUD.ImportRow(red);
                    }

                    Pomocna.SrediExcel(dz.BUD);
                    StreamWriter sw = new StreamWriter(sf.FileName);
                    DataTableHelper.ProduceCSV(dz.BUD, sw, true);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Redni broj";
            tip.SetToolTip(label6, caption);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Godina usvajanja";
            tip.SetToolTip(label1, caption);
        }

        private void label3_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "01 Barajevo, 02 Čukarica, 03 Grocka, 04 Lazarevac, 05 Mladenovac, 06 Novi Beograd, 07 Obrenovac, 08 Palilula, 09 Savski venac, 10 Sopot, 11 Stari grad, 12 Voždovac, 13 Vračar, 14 Zemun, 15 Zvezdara, 16 Rakovica, GRAD  Gradsko područje";
            tip.SetToolTip(label3, caption);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Vrsta planskog dokumenta";
            tip.SetToolTip(label4, caption);
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Naziv predmeta";
            tip.SetToolTip(label14, caption);
        }

        private void cbURADJEN_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Usvojen predmet";
            tip.SetToolTip(cbURADJEN, caption);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Arhivski broj";
            tip.SetToolTip(label5, caption);
        }

        private void cbPOTPISAN_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Overen dokument";
            tip.SetToolTip(cbPOTPISAN, caption);
        }

        private void cbPECACEN_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Pečaćen dokument";
            tip.SetToolTip(cbPECACEN, caption);
        }

        private void LABEL666_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Oblik dokumenta";
            tip.SetToolTip(LABEL666, caption);
        }

        private void label13_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Broj knjiga, elaborata";
            tip.SetToolTip(label13, caption);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "ID broj iz registra planova";
            tip.SetToolTip(label2, caption);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Broj u tehničkoj arhivi";
            tip.SetToolTip(label7, caption);
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Predmet obradjen dana";
            tip.SetToolTip(label15, caption);
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Prostorija - Polica";
            tip.SetToolTip(label8, caption);
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Elaborat se cuva trajno ili privremeno";
            tip.SetToolTip(label11, caption);
        }

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmPretragaBUD fp = new frmPretragaBUD();
            fp.pp = pp;

            if (fp.ShowDialog() == DialogResult.OK)
            {


                pp = fp.pp;
                DataRow[] redovi = podaci.BUD.Select(fp.filter);
                filter = fp.filter;
                if (redovi.Length > 0)
                {
                    //btnStampa.Visible = true;
                    btnExcel.Visible = true;
                    izvor.Filter = fp.filter;

                    natpis_filter.BackColor = Color.Azure;

                    natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);

                }
                else
                {
                    izvor.Filter = "";
                    //btnStampa.Visible = false;
                    btnExcel.Visible = false;
                    MessageBox.Show("Pretraga nije vratila ni jedan zapis. Pokusajte ponovo.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    natpis_filter.BackColor = Color.Orange;
                    natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
                }

            }
        }
    }
}
