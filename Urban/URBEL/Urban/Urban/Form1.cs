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
    public partial class Form1 : Form
    {
        bool novi;
        public DataRow korisnik;
        public frmPocetak glavna;
        ArrayList tipplakt,dpplakt,donosl,vrsttxt,oznmat,inref;
        dsIzvestaj di = new dsIzvestaj();
        PretragaUslovi pu;
        string guid;
        dsProgrami programi = new dsProgrami();
        ProgramiPamcenje pp;
        bool otvoreni;

        public Form1()
        {
            InitializeComponent();
        }

        private string DajGuid(SqlConnection veza)
        {
            SqlCommand kom = new SqlCommand("select user_code from settings", veza);
            object test=kom.ExecuteScalar();
            if (test == null || Convert.IsDBNull(test))
                return "";
            else
                return test.ToString().Trim();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'urbanDataSet.REGUPR' table. You can move, or remove it, as needed.
            SqlConnection veza = null;
            try
            {
                pu = new PretragaUslovi();
                pu.tip = new ArrayList();
                pu.dp = new ArrayList();
                pu.donos = new ArrayList();
                pu.vrst = new ArrayList();
               
                pu.inr = new ArrayList();

               
               

                natpis_korisnik.Text = String.Format("Korisnik: {0} {1}", korisnik[0], korisnik[1]);
                if (!Convert.ToBoolean(korisnik["admi"]))
                {
                    dugme_korisnici.Enabled = false;
                    btnZaduzenja.Enabled = false;
                    btnDOC.Enabled = false;
                }
                if (Convert.ToBoolean(korisnik["zadr"]))
                    btnZaduzenja.Enabled = true;
                if (Convert.ToBoolean(korisnik["docr"]))
                    btnDOC.Enabled = true;
                if (!Convert.ToBoolean(korisnik["pret"]))
                    dugme_pretraga.Enabled = false;
                if ((bool)korisnik["pret"] || (bool)korisnik["izve"])
                    prikaz.AllowSorting = true;
                if (!Convert.ToBoolean(korisnik["azur"]))
                {
                    dugme_novi.Enabled = false;
                    dugme_snimi.Enabled = false;
                    dugme_brisi.Enabled = false;
                    
                }

                this.Cursor = Cursors.WaitCursor;
                this.rEGUPRTableAdapter.Fill(this.urbanDataSet.REGUPR);
                this.korisnikTableAdapter1.Fill(this.urbanDataSet.Korisnik);
                UrbanDataSetTableAdapters.FirmaTableAdapter fa = new Urban.UrbanDataSetTableAdapters.FirmaTableAdapter();
                fa.Fill(this.urbanDataSet.Firma);
                if (!otvoreni)
                    this.napomenaTableAdapter1.Fill(di.Napomena);
                prikaz.DataSource = izvor;
                
                this.urbanDataSet.AcceptChanges();
                di.AcceptChanges();
                dsProgramiTableAdapters.PROGRAMTableAdapter pa = new Urban.dsProgramiTableAdapters.PROGRAMTableAdapter();
                pa.Fill(programi.PROGRAM);
                programi.AcceptChanges();
                

                natpis_filter.BackColor = Color.Orange;
                natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);

                string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                veza = new SqlConnection(cs);
                veza.Open();
                tipplakt = DajKolonu(veza, "TIPPLAKT");
                cbTipPlakt.DataSource = tipplakt;
                dpplakt = DajKolonu(veza, "DPPLAKT");
                cbDpPlakt.DataSource = dpplakt;
                donosl = DajKolonu(veza, "DONOSL");
                cbDONOSL.DataSource = donosl;
                vrsttxt = DajKolonu(veza, "VRSTTXT");
                cbVrst.DataSource = vrsttxt;
                oznmat = DajKolonu(veza, "OZNMAT");
                
                inref = DajKolonu(veza, "INREF");
                cbInref.DataSource = inref;
                

                PoveziKontrole();

                // Procitaj guid verzije podataka koju si procitao
                guid = DajGuid(veza);
                SAT.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Greska u citanju podataka! "+ex.Message);
            }
            finally
            {
                if (veza!=null && veza.State == ConnectionState.Open)
                    veza.Close();

                this.Cursor = Cursors.Default;
            }

            

        }

        private void DajFokus(Control c, bool fokus)
        {
            if (fokus)
                c.BackColor = Color.Yellow;
            else
                c.BackColor = Color.White;
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct " + naziv + " from regupr where "+naziv+" is not null";
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

        private void SrediCombo(ComboBox cb)
        {
            string provera = cb.Text;
            bool ima = false;
            foreach (string stavka in cb.Items)
            {
                if (stavka.ToUpper() == provera.ToUpper())
                {
                    ima = true;
                    break;
                }
            }

            if (!ima)
            {
                ArrayList al = (ArrayList)cb.DataSource;
                al.Add(provera);
                cb.DataSource = null;
                cb.DataSource = al;
                cb.SelectedIndex = cb.Items.Count - 1;
            }
        }

        private void Snimi()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da snimite promene?", "Upozorenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    
                    this.Cursor = Cursors.WaitCursor;
                    UrbanDataSet promene = (UrbanDataSet)this.urbanDataSet.GetChanges();

                    if (this.urbanDataSet.HasChanges() || di.HasChanges())
                    {
                        this.rEGUPRTableAdapter.Update(promene.REGUPR);
                        this.korisnikTableAdapter1.Update(promene.Korisnik);
                        this.napomenaTableAdapter1.Update(di.Napomena);
                        this.urbanDataSet.AcceptChanges();
                        di.AcceptChanges();

                        // Pri svakom snimanju se upisuje guid za datog korisnika
                        string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                       SqlConnection veza = new SqlConnection(cs);
                        veza.Open();

                        guid = System.Guid.NewGuid().ToString();
                        string naredba = @"update settings set user_code='"+guid+"'";
                        SqlCommand kom = new SqlCommand(naredba, veza);
                        kom.ExecuteNonQuery();
                        veza.Close();


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

        private void Brisi()
        {
            try
            {
                if (prikaz.CurrentRowIndex >= 0)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite da obrisete zapis?", "Upozorenje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //this.urbanDataSet.REGUPR.Rows.RemoveAt(prikaz.CurrentRowIndex);
                        DataGridCell dc = new DataGridCell(prikaz.CurrentRowIndex, 20);
                        int id = Convert.ToInt32(prikaz[dc]);
                        UrbanDataSet.REGUPRRow kandidat = this.urbanDataSet.REGUPR.FindByid(id);
                        if (kandidat!=null)
                            kandidat.Delete();
                        
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

        private void PoveziKontrole()
        {
            txtID.DataBindings.Add("Text", izvor, "id");
            txtSlLst.DataBindings.Add("Text", izvor, "BRSLLST");
            cbTipPlakt.DataBindings.Add("SelectedItem", izvor, "TIPPLAKT");
            dtpDatSlLst.DataBindings.Add("Value", izvor, "DATSLLST");
            cbNaSnz.DataBindings.Add("Checked", izvor, "NASNZ");
            txtBBLBR.DataBindings.Add("Text", izvor, "BBLBRPRP");
            cbDpPlakt.DataBindings.Add("SelectedItem", izvor, "DPPLAKT");
            cbDONOSL.DataBindings.Add("SelectedItem", izvor, "DONOSL");
            cbVrst.DataBindings.Add("SelectedItem", izvor, "VRSTTXT");
            txtOpstina.DataBindings.Add("Text", izvor, "OPSTINA");
            txtDosije.DataBindings.Add("Text", izvor, "DOSIJE");
            txtSekcija.DataBindings.Add("Text", izvor, "SEKCIJA");
            txtOzn.DataBindings.Add("Text", izvor, "OZNMAT");
            cbPreal.DataBindings.Add("Checked", izvor, "PREAL");
            cbTreal.DataBindings.Add("Checked", izvor, "TREAL");
            cbRreal.DataBindings.Add("Checked", izvor, "RREAL");
            cbInref.DataBindings.Add("SelectedItem", izvor, "INREF");
            txtKartBroj.DataBindings.Add("Text", izvor, "KARTBROJ");
            txtNazPrp.DataBindings.Add("Text", izvor, "NAZPRP");
            txtNapom.DataBindings.Add("Text", izvor, "NAPOM");
            txtOCENA.DataBindings.Add("Text", izvor, "OCENA");
            txtCd.DataBindings.Add("Text", izvor, "CD");
            txtKRUG.DataBindings.Add("Text", izvor, "STATKRUG");
            CBdIGITALAN.DataBindings.Add("Checked", izvor, "DIGITALAN");
            cbSkeniran.DataBindings.Add("Checked", izvor, "SKENIRAN");
            cbGUP.DataBindings.Add("Checked", izvor, "GUP");
           
        }

        private void RazveziKontrole()
        {
            txtID.DataBindings.Clear();
            txtID.Text = "";
            txtSlLst.DataBindings.Clear();
            txtSlLst.Text = "";
            cbTipPlakt.DataBindings.Clear();
            cbDONOSL.SelectedIndex = 0;
            dtpDatSlLst.DataBindings.Clear();
            dtpDatSlLst.Value = DateTime.Now;
            cbNaSnz.DataBindings.Clear();
            cbDONOSL.SelectedIndex = 0;
            txtBBLBR.DataBindings.Clear();
            txtBBLBR.Text = "";
            cbDpPlakt.DataBindings.Clear();
            cbDpPlakt.SelectedIndex = 0;
            cbDONOSL.DataBindings.Clear();
            cbDONOSL.SelectedIndex = 0;
            cbVrst.DataBindings.Clear();
            cbVrst.SelectedIndex = 0;
            txtOpstina.DataBindings.Clear();
            txtOpstina.Text = "";
            txtOzn.DataBindings.Clear();
            txtOzn.Text = "";
            txtDosije.DataBindings.Clear();
            txtDosije.Text = "";
            txtSekcija.DataBindings.Clear();
            txtSekcija.Text = "";
           
            cbPreal.DataBindings.Clear();
            cbPreal.Checked = false;
            cbTreal.DataBindings.Clear();
            cbTreal.Checked = false;
            cbRreal.DataBindings.Clear();
            cbRreal.Checked = false;
            cbInref.DataBindings.Clear();
            cbInref.SelectedIndex = 0;
            txtKartBroj.DataBindings.Clear();
            txtKartBroj.Text = "";
            txtNazPrp.DataBindings.Clear();
            txtNazPrp.Text = "";
            txtNapom.DataBindings.Clear();
            txtNapom.Text = "";
            txtOCENA.DataBindings.Clear();
            txtOCENA.Text = "";
            txtCd.DataBindings.Clear();
            txtKRUG.DataBindings.Clear();
            txtCd.Text = "";
            txtKRUG.Text = "";
            txtID.DataBindings.Clear();
            txtID.Text = "";
            CBdIGITALAN.DataBindings.Clear();
            CBdIGITALAN.Checked = false;
            cbSkeniran.DataBindings.Clear();
            cbSkeniran.Checked = false;
            cbGUP.DataBindings.Clear();
            cbGUP.Checked = false;
        }

        private void txtSlLst_TextChanged(object sender, EventArgs e)
        {

        }

        private void SrediGrid()
        {
            int brr = izvor.Count;
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

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SrediGrid();
            if (Convert.ToBoolean(korisnik["azur"]) || Convert.ToBoolean(korisnik["admi"]))
                Snimi();
            else
                Application.Exit();
        }

        private string ProveriUnos()
        {
            
            string izlaz = "";
            if (txtID.Text.Length == 0)
            {
                txtID.Text = DajNoviID();
                if (txtID.Text.Length == 0)
                    return "Greska u dodeli polja ID.";
            }
            else
            {
                try
                {
                    int.Parse(txtID.Text);
                }
                catch (FormatException)
                {
                    return "Pogresan format za ID.";
                }
            }
            if (txtSlLst.Text.Length == 0)
                return "Mora da se unese broj sluzbenog lista!";
            //if (txtOpstina.Text.Length == 0)
              //  return "Mora da se unese jedna ili vise opstina odvojene zarezima!";
            if (txtNazPrp.Text.Length == 0)
                return "Naziv Pr. P. mora da se unese!";
            //if (txtKartBroj.Text.Length > 0)
            //{
            //    try
            //    {
            //        double.Parse(txtKartBroj.Text);
            //    }
            //    catch (FormatException)
            //    {
            //        return "Pogresan format za kartografski broj!";
            //    }
            //}
            return izlaz;
        }

        private void UbaciNovi()
        {
            try
            {
                string ok = ProveriUnos();
                if (ok.Length > 0)
                    throw new Exception(ok);

                Urban.UrbanDataSet.REGUPRRow novi = urbanDataSet.REGUPR.NewREGUPRRow();
                novi.id = Convert.ToInt32(txtID.Text);
                novi.TIPPLAKT = cbTipPlakt.Text;
                novi.BRSLLST = txtSlLst.Text;
                novi.DATSLLST = dtpDatSlLst.Value;
                novi.NASNZ = cbNaSnz.Checked;
                if (Ima(txtBBLBR.Text))
                    novi.BBLBRPRP = txtBBLBR.Text;
                novi.DPPLAKT = cbDpPlakt.Text;
                novi.DONOSL = cbDONOSL.Text;
                novi.VRSTTXT = cbVrst.Text;
                novi.OPSTINA = txtOpstina.Text;
                if (Ima(txtDosije.Text))
                    novi.DOSIJE = txtDosije.Text;
                if (Ima(txtSekcija.Text))
                    novi.SEKCIJA = txtSekcija.Text;
                novi.OZNMAT = txtOzn.Text;
                novi.PREAL = cbPreal.Checked;
                novi.TREAL = cbTreal.Checked;
                novi.RREAL = cbRreal.Checked;
                novi.INREF = cbInref.Text;
                if (Ima(txtKartBroj.Text))
                    novi.KARTBROJ = txtKartBroj.Text;
                novi.NAZPRP = txtNazPrp.Text;
                if (Ima(txtNapom.Text))
                    novi.NAPOM = txtNapom.Text;
                if (Ima(txtOCENA.Text))
                    novi.OCENA = txtOCENA.Text;
                if (Ima(txtCd.Text))
                    novi.CD = txtCd.Text;
                if (Ima(txtKRUG.Text))
                    novi.STATKRUG = txtKRUG.Text;
                novi.DIGITALAN = CBdIGITALAN.Checked;
                novi.SKENIRAN = cbSkeniran.Checked;
                novi.GUP = cbGUP.Checked;
                urbanDataSet.REGUPR.Rows.Add(novi);
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

        private string DajNoviID()
        {
            SqlConnection veza = null;
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                string upit = "select max(id) from regupr";
                SqlCommand kom = new SqlCommand(upit, veza);
                int id = Convert.ToInt32(kom.ExecuteScalar());
                ++id;
                return id.ToString();
            }
            catch (SqlException ex)
            {
                return "";
            }
            finally
            {
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }
        private bool Ima(string vrednost)
        {
            return (vrednost.Length > 0);
        }
        private void dugme_brisi_Click(object sender, EventArgs e)
        {
            Brisi();
        }

        private void dugme_novi_Click(object sender, EventArgs e)
        {
            novi = true;
            RazveziKontrole();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            glavna.Show();
        }

        private void dugme_korisnici_Click(object sender, EventArgs e)
        {
            frmKorisnici fk = new frmKorisnici();
            fk.ds = this.urbanDataSet;
            fk.ShowDialog();
        }

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmPretraga fp = new frmPretraga();
            fp.obradjivaci = (UrbanDataSet.FirmaDataTable) this.urbanDataSet.Firma.Copy();
            fp.pu = this.pu;
            
            if (fp.ShowDialog() == DialogResult.OK)
            {
                
                this.pu = fp.pu;
                
                DataRow[] redovi = urbanDataSet.REGUPR.Select(fp.filter);
                if (redovi.Length > 0)
                {
                    izvor.Filter = fp.filter;
                    
                    natpis_filter.BackColor = Color.Azure;
                    if ((bool)korisnik["admi"] || (bool)korisnik["izve"])
                    {
                        gb.Visible = true;
                        txtIzNaziv.Text = "";
                        lstIzvestaj.Items.Clear();
                    }
                    natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);
                }
                else
                {
                    izvor.Filter = "";
                    MessageBox.Show("Pretraga nije vratila ni jedan zapis. Pokusajte ponovo.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    natpis_filter.BackColor = Color.Orange;
                    natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
                }
                
            }
           
        }

        private void dugme_svi_Click(object sender, EventArgs e)
        {
            di = new dsIzvestaj();
            this.napomenaTableAdapter1.Fill(di.Napomena);
            di.AcceptChanges();
            otvoreni = false;
            izvor.Filter = "";
            if (txtNazPrp.DataBindings.Count == 0)
                PoveziKontrole();
            gb.Visible = false;
            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
        }

        private void cbTipPlakt_Leave(object sender, EventArgs e)
        {
            SrediCombo((ComboBox)sender);
            DajFokus((ComboBox)sender, false);
        }

        private void cbDpPlakt_Leave(object sender, EventArgs e)
        {
            SrediCombo((ComboBox)sender);
            DajFokus((ComboBox)sender, false);
        }

        private void btnUticaji_na_Click(object sender, EventArgs e)
        {
            frmUticaji fu = new frmUticaji();
            fu.pu = this.pu;
            fu.id = int.Parse(txtID.Text);
            fu.izvor = izvor;
            fu.urbanDataSet = urbanDataSet;
            fu.naziv = txtNazPrp.Text;
            if (!(bool)korisnik["azur"])
                fu.azur = false;
            fu.ShowDialog();
        }

        private void btnUticaji_Click(object sender, EventArgs e)
        {
            frmPregledUticaji fp = new frmPregledUticaji();
            fp.id = int.Parse(txtID.Text);
            fp.ShowDialog();
        }

        private void txtNazPrp_DoubleClick(object sender, EventArgs e)
        {
            
            
                frmNaziv fn = new frmNaziv();
                fn.NazivText = txtNazPrp.Text;
                fn.plan = Convert.ToInt32(txtID.Text);
                if (!((bool)korisnik["azur"] || (bool)korisnik["admi"]))
                    fn.azur = false;
                if (fn.ShowDialog() == DialogResult.OK)
                {
                    if (fn.azur)
                        txtNazPrp.Text = fn.NazivText;
                }
            
        }

       

        private void cbTipPlakt_Enter(object sender, EventArgs e)
        {
            DajFokus(cbTipPlakt, true);
        }

        private void txtSlLst_Enter(object sender, EventArgs e)
        {
            DajFokus(txtSlLst, true);
        }

        private void txtSlLst_Leave(object sender, EventArgs e)
        {
            DajFokus(txtSlLst, false);
        }

        private void dtpDatSlLst_Enter(object sender, EventArgs e)
        {
            DajFokus(dtpDatSlLst, true);
        }

        private void dtpDatSlLst_Leave(object sender, EventArgs e)
        {
            DajFokus(dtpDatSlLst, false);
        }

        private void txtID_Enter(object sender, EventArgs e)
        {
            DajFokus(txtID, true);
        }

        private void txtID_Leave(object sender, EventArgs e)
        {
            DajFokus(txtID, false);
        }

        private void txtBBLBR_Enter(object sender, EventArgs e)
        {
            DajFokus(txtBBLBR, true);
        }

        private void txtBBLBR_Leave(object sender, EventArgs e)
        {
            DajFokus(txtBBLBR, false);
        }

        private void cbDpPlakt_Enter(object sender, EventArgs e)
        {
            DajFokus(cbDpPlakt, true);
        }

        private void cbDONOSL_Enter(object sender, EventArgs e)
        {
            DajFokus(cbDONOSL, true);
        }

        private void cbVrst_Enter(object sender, EventArgs e)
        {
            DajFokus((ComboBox)sender, true);
        }

        private void txtOpstina_Enter(object sender, EventArgs e)
        {
            DajFokus((TextBox)sender, true);
        }

        private void txtOpstina_Leave(object sender, EventArgs e)
        {
            DajFokus((TextBox)sender, false);
        }

        private void DodajAutomatske()
        {
            if (di.Predmet.Rows.Count == 0)
            {
                UrbanDataSet.REGUPRRow test = urbanDataSet.REGUPR.FindByid(5287);
                dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                novi.id = 5287;
                novi.naziv = (cbKombinovani.Checked) ? test.NAZPRP : ObradiNaziv(test.NAZPRP);
                novi.kart = (!test.IsKARTBROJNull() && test.KARTBROJ!="0") ? ObradiKart(String.Format("{0}",test.KARTBROJ),test.TIPPLAKT,false) : "";
                novi.grupa = DajGrupu("");
                di.Predmet.Rows.Add(novi);

                DataTable izdop = new DataTable();
                ProcitajIzdop(novi.id, izdop);
                foreach (DataRow red in izdop.Rows)
                {
                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                    ir.id = Convert.ToInt32(red[1]);
                    ir.opis =(cbKombinovani.Checked) ? red[2].ToString() : ObradiNaziv(red[2].ToString());
                    ir.vrsta = red[3].ToString();
                    di.IzDop.Rows.Add(ir);
                }
                lstIzvestaj.Items.Add(5287);

                

                // DODAJ JOS JEDAN ZAKON
                test = urbanDataSet.REGUPR.FindByid(5078);
                dsIzvestaj.PredmetRow dru = di.Predmet.NewPredmetRow();
                dru.id = 5078;
                dru.naziv = ObradiNaziv(test.NAZPRP);
                dru.kart = (!test.IsKARTBROJNull() && test.KARTBROJ != "0") ? ObradiKart(String.Format("{0}", test.KARTBROJ),test.TIPPLAKT,false) : "";
                dru.grupa = DajGrupu("");
                di.Predmet.Rows.Add(dru);

                izdop = new DataTable();
                ProcitajIzdop(dru.id, izdop);
                foreach (DataRow red in izdop.Rows)
                {
                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                    ir.id = Convert.ToInt32(red[1]);
                    ir.opis = ObradiNaziv(red[2].ToString());
                    ir.vrsta = red[3].ToString();
                    di.IzDop.Rows.Add(ir);
                }
                lstIzvestaj.Items.Add(5078);

                test = urbanDataSet.REGUPR.FindByid(4317);
                dsIzvestaj.PredmetRow treci = di.Predmet.NewPredmetRow();
                treci.id = 4317;
                treci.naziv = ObradiNaziv(test.NAZPRP);
                treci.kart = (!test.IsKARTBROJNull() && test.KARTBROJ != "0") ? ObradiKart(String.Format("{0}", test.KARTBROJ),test.TIPPLAKT,false) : "";
                treci.grupa = DajGrupu("*");
                di.Predmet.Rows.Add(treci);

                izdop = new DataTable();
                ProcitajIzdop(treci.id, izdop);
                foreach (DataRow red in izdop.Rows)
                {
                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                    ir.id = Convert.ToInt32(red[1]);
                    ir.opis = ObradiNaziv(red[2].ToString());
                    ir.vrsta = red[3].ToString();
                    di.IzDop.Rows.Add(ir);
                }
                lstIzvestaj.Items.Add(4317);

                //test = urbanDataSet.REGUPR.FindByid(4744);
                //dsIzvestaj.PredmetRow cetvrti = di.Predmet.NewPredmetRow();
                //cetvrti.id = 4744;
                //cetvrti.naziv = ObradiNaziv(test.NAZPRP);
                //cetvrti.kart = (!test.IsKARTBROJNull() && test.KARTBROJ != "0") ? ObradiKart(String.Format("{0}", test.KARTBROJ),test.TIPPLAKT,false) : "";
                //cetvrti.grupa = DajGrupu("*");
                //di.Predmet.Rows.Add(cetvrti);

                //izdop = new DataTable();
                //ProcitajIzdop(cetvrti.id, izdop);
                //foreach (DataRow red in izdop.Rows)
                //{
                //    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                //    ir.id = Convert.ToInt32(red[1]);
                //    ir.opis = ObradiNaziv(red[2].ToString());
                //    ir.vrsta = red[3].ToString();
                //    di.IzDop.Rows.Add(ir);
                //}
                //lstIzvestaj.Items.Add(4744);

                test = urbanDataSet.REGUPR.FindByid(5288);
                dsIzvestaj.PredmetRow peti = di.Predmet.NewPredmetRow();
                peti.id = 5288;
                peti.naziv = ObradiNaziv(test.NAZPRP);
                peti.kart = (!test.IsKARTBROJNull() && test.KARTBROJ != "0") ? ObradiKart(String.Format("{0}", test.KARTBROJ), test.TIPPLAKT, false) : "";
                peti.grupa = DajGrupu("*");
                di.Predmet.Rows.Add(peti);

                izdop = new DataTable();
                ProcitajIzdop(peti.id, izdop);
                foreach (DataRow red in izdop.Rows)
                {
                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                    ir.id = Convert.ToInt32(red[1]);
                    ir.opis = ObradiNaziv(red[2].ToString());
                    ir.vrsta = red[3].ToString();
                    di.IzDop.Rows.Add(ir);
                }
                lstIzvestaj.Items.Add(5288);
            }
        }

        private string DajGrupu(string tip)
        {
            switch (tip)
            {
                case "PP":
                    return "I PROSTORNI PLANOVI";
                case "*":
                    return "I PROSTORNI PLANOVI";
                case "GP":
                    return "II GENERALNI PLANOVI";
                case "POU":
                    return "III URBANISTIČKI PLANOVI";
                case "PGR":
                    return "II GENERALNI PLANOVI";
                case "PDR":
                    return "III URBANISTIČKI PLANOVI";
                case "DUP":
                    return "III URBANISTIČKI PLANOVI";
                case "GUP":
                    return "III URBANISTIČKI PLANOVI";
                case "RP":
                    return "III URBANISTIČKI PLANOVI";
                case "UP":
                    return "III URBANISTIČKI PLANOVI";
                case "PAR":
                    return "III URBANISTIČKI PLANOVI";
                case "":
                    return " ZAKONI";
                case "PROGRAM":
                    return "V KONCEPTI";
                case "PROGRAM1":
                    return "VI UP – Zakon o Planiranju sl.gl.RS 47/03";
                default:
                    return "IV DRUGI PROPISI";
            }
        }

        private string Rimski(string ulaz)
        {
            string[] rimski ={ "/I/", "/II/", "/III/", "/IV/", "/V/", "/VI", "/VII/", "/VIII/", "/IX/", "/X/", "/XI/", "/XII/" };
            foreach (string test in rimski)
            {
                if (ulaz.Contains(test))
                    return test;
            }
            return "";
        }

        private string ObradiNaziv(string ulaz)
        {
            try
            {
                int index = -1;
                string rim = Rimski(ulaz);
                if ((index = ulaz.IndexOf("SL.L.")) >= 0)
                {
                    if (rim.Length == 0)
                        return ulaz.Substring(0, index + 11);
                    else
                        return ulaz.Substring(0, index + 11 + rim.Length);
                }
                else if ((index = ulaz.IndexOf("SL.GL.")) >= 0)
                {
                    if (rim.Length == 0)
                        return ulaz.Substring(0, index + 15);
                    else
                        return ulaz.Substring(0, index + 15 + rim.Length);
                }
                return ulaz;
            }
            catch
            {
                return ulaz;
            }
        }

        private bool Automatski(int id)
        {
            return (id == 3421 || id == 4136 || id == 4317 || id == 4744);
        }

        private void btnDodajSel_Click(object sender, EventArgs e)
        {
            try
            {
                DodajAutomatske();

                dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                novi.id = int.Parse(txtID.Text);

                if (Automatski(novi.id))
                    throw new Exception("Predmet je vec dodat automatski u izvestaj!");
                novi.naziv = (cbKombinovani.Checked) ? txtNazPrp.Text : ObradiNaziv(txtNazPrp.Text);
                novi.kart = (txtKartBroj.Text.Length > 0 && txtKartBroj.Text != "0") ? ObradiKart( txtKartBroj.Text,cbTipPlakt.Text,true) : "";
                novi.grupa = DajGrupu(cbTipPlakt.Text);
                di.Predmet.Rows.Add(novi);

                if (cbKombinovani.Checked || cbTreci.Checked)
                {
                    DataTable izdop = new DataTable();
                    ProcitajIzdop(novi.id, izdop);
                    foreach (DataRow red in izdop.Rows)
                    {
                        dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                        ir.id = Convert.ToInt32(red[1]);
                        ir.opis = (cbKombinovani.Checked) ? red[2].ToString() : ObradiNaziv(red[2].ToString());
                        ir.vrsta = red[3].ToString();
                        if (cbTreci.Checked && red[3].ToString() == "Uticaji")
                            continue;
                        di.IzDop.Rows.Add(ir);
                    }
                }

                lstIzvestaj.Items.Add(novi.id);
            }
            catch (DataException)
            {
                MessageBox.Show("Predmet je vec dodat u izvestaj!!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ProcitajIzdop(int plan,DataTable temp)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand("DajIzdop", veza);
                kom.CommandType = CommandType.StoredProcedure;
                int kombinovani = (cbKombinovani.Checked) ? 0 : 1;
                kom.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                kom.Parameters.Add("kombinovani", SqlDbType.Bit).Value = kombinovani;
                SqlDataAdapter filter = new SqlDataAdapter();
                filter.SelectCommand = kom;
                if (temp.Rows.Count > 0)
                    temp.Rows.Clear();
                filter.Fill(temp);
              

            }
            catch (SqlException)
            {
                MessageBox.Show("Greska u citanju podataka!");
            }
            finally
            {
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            if (txtIzNaziv.Text.Length == 0)
                MessageBox.Show("Naslov izvestaja nije unet", "Greska");
            else
            {
                frmIzvestaj fi = new frmIzvestaj();
                dsIzvestaj.ParamsRow pr= di.Params.NewParamsRow();
                pr.naziv = txtIzNaziv.Text;
                pr.obrad = txtObrad.Text;
                di.Params.Rows.Clear();
                di.Params.Rows.Add(pr);
                fi.izvestaj = true;
                fi.di = di;
                fi.ShowDialog();
            }
        }

        private void lstIzvestaj_KeyDown(object sender, KeyEventArgs e)
        {
            if (lstIzvestaj.SelectedIndex >= 0 && e.KeyCode==Keys.Delete)
            {
                string kriterijum = "";
                for (int i = 0; i < lstIzvestaj.SelectedItems.Count; i++)
                {
                    kriterijum += "id="+lstIzvestaj.SelectedItems[i].ToString().Trim() + " or ";
                }
                kriterijum = kriterijum.Substring(0, kriterijum.Length - 4);
             
                DataRow[] niz=di.Predmet.Select(kriterijum);
                if (niz.Length > 0)
                {
                    for (int i=0;i<niz.Length;i++)
                        di.Predmet.RemovePredmetRow((dsIzvestaj.PredmetRow)niz[i]);
                    
                }

                lstIzvestaj.Items.Clear();
                for (int i=0;i<di.Predmet.Rows.Count;i++)
                    lstIzvestaj.Items.Add(di.Predmet.Rows[i]["id"].ToString());
            }
        }

        private void btnDodajPrik_Click(object sender, EventArgs e)
        {
            try
            {
                DodajAutomatske();

                UrbanDataSet.REGUPRRow[] redovi = (UrbanDataSet.REGUPRRow[])urbanDataSet.REGUPR.Select(izvor.Filter);
                if (redovi.Length > 0)
                {
                    foreach (UrbanDataSet.REGUPRRow red in redovi)
                    {
                        dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                        novi.id = red.id;
                        novi.naziv =(cbKombinovani.Checked) ? red.NAZPRP : ObradiNaziv( red.NAZPRP);
                        novi.kart = (red.IsKARTBROJNull() || red.KARTBROJ=="0") ? "" : ObradiKart( String.Format("{0}", red.KARTBROJ),red.TIPPLAKT,true);
                        novi.grupa = DajGrupu(red.TIPPLAKT);

                        if (!Automatski(novi.id))
                        {
                            di.Predmet.Rows.Add(novi);

                            if (cbKombinovani.Checked || cbTreci.Checked)
                            {
                                DataTable izdop = new DataTable();
                                ProcitajIzdop(novi.id, izdop);
                                foreach (DataRow rd in izdop.Rows)
                                {
                                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                                    ir.id = Convert.ToInt32(rd[1]);
                                    ir.opis = (cbKombinovani.Checked) ? rd[2].ToString() : ObradiNaziv(rd[2].ToString());
                                    ir.vrsta = rd[3].ToString();
                                    if (cbTreci.Checked && rd[3].ToString() == "Uticaji")
                                        continue;
                                    di.IzDop.Rows.Add(ir);
                                }
                            }

                            lstIzvestaj.Items.Add(novi.id);
                        }
                    }
                }
            }
            catch (DataException)
            {
                MessageBox.Show("Predmet je vec dodat u izvestaj!!!");
            }
        }

        private void btnSnimiIzv_Click(object sender, EventArgs e)
        {
            if (di.Predmet.Rows.Count > 0)
            {
                dsIzvestaj.ParamsRow pr = di.Params.NewParamsRow();
                pr.naziv = txtIzNaziv.Text;
                pr.obrad = txtObrad.Text;
                di.Params.Rows.Clear();
                di.Params.Rows.Add(pr);

                frmSnimanje fn = new frmSnimanje();
                try
                {
                    if (fn.ShowDialog() == DialogResult.OK)
                        di.WriteXml(ConfigurationManager.AppSettings["putanja"] + fn.Nazi + ".xml");
                }
                catch
                {
                    MessageBox.Show("Greska u snimanju!. \nProverite da li data putanja postoji ili korisnik ima pravo upisa na toj putanji...");
                }
                
            }
            else
                MessageBox.Show("Izvestaj je prazan!!!");
        }

        private void btnOtvoriIzv_Click(object sender, EventArgs e)
        {
            
                try
                {
                    OpenFileDialog of = new OpenFileDialog();
                    of.DefaultExt = "xml";
                    //of.InitialDirectory = Application.StartupPath + "\\Izvestaji";
                    if (of.ShowDialog() == DialogResult.OK)
                    {
                        di = new dsIzvestaj();
                        di.ReadXml(of.FileName);
                        otvoreni = true;
                        // Zbog greske dodavanja nove napomene
                        //di.Napomena.Clear();
                        //this.napomenaTableAdapter1.Fill(di.Napomena);
                        di.AcceptChanges();

                        txtIzNaziv.Text = (di.Params[0].IsnazivNull()) ? "" : di.Params[0].naziv;
                        txtObrad.Text = (di.Params[0].IsobradNull()) ? "" : di.Params[0].obrad;
                        if (lstIzvestaj.Items.Count > 0)
                            lstIzvestaj.Items.Clear();
                        foreach (dsIzvestaj.PredmetRow pr in di.Predmet.Rows)
                            lstIzvestaj.Items.Add(pr.id.ToString());
                        gb.Visible = true;
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
          
        }

        private void btnIzvPodesavanja_Click(object sender, EventArgs e)
        {
            frmIzvSettings fs = new frmIzvSettings();
            fs.di=di;
            fs.ShowDialog();

        }

        private void txtNapom_DoubleClick(object sender, EventArgs e)
        {
            frmUticaji fu = new frmUticaji();
            fu.id = int.Parse(txtID.Text);
            fu.izvor = izvor;
            fu.rezim = Rezim.UticajiOd;
            fu.urbanDataSet = urbanDataSet;
            fu.naziv = txtNazPrp.Text;
            fu.pu = pu;
            if (!(bool)korisnik["azur"])
                fu.azur = false;
            fu.ShowDialog();
            /*if (fu.ShowDialog() == DialogResult.OK)
            {
                if (fu.azur)
                    txtNapom.Text = fu.naziv;
            } */
        }

        private void btnRucno_Click(object sender, EventArgs e)
        {
            if (txtRucno.Text.Length > 0)
            {
                try
                {
                    string poruka = "";
                    string[] ids = txtRucno.Text.Split(',');

                    DodajAutomatske();
                    foreach (string sifra in ids)
                    {

                        UrbanDataSet.REGUPRRow test = urbanDataSet.REGUPR.FindByid(Convert.ToInt32(sifra));
                        if (test == null)
                            throw new Exception("Zadati predmet nije pronadjen!");


                        dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                        novi.id = test.id;


                        if (Automatski(test.id) || di.Predmet.Rows.Contains(test.id))
                            poruka = "Neki od predmeta su vec dodat u izvestaj. Ostali su uspesno dodati.";
                        else
                        {
                            novi.kart = (test.IsKARTBROJNull() || test.KARTBROJ == "0") ? "" : ObradiKart(String.Format("{0}", test.KARTBROJ),test.TIPPLAKT,true);
                            novi.naziv = (cbKombinovani.Checked) ? test.NAZPRP : ObradiNaziv(test.NAZPRP);
                            novi.grupa = DajGrupu(test.TIPPLAKT);

                            di.Predmet.Rows.Add(novi);

                            if (cbKombinovani.Checked || cbTreci.Checked)
                            {
                                DataTable izdop = new DataTable();
                                ProcitajIzdop(novi.id, izdop);
                                foreach (DataRow red in izdop.Rows)
                                {
                                    dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                                    ir.id = Convert.ToInt32(red[1]);
                                    ir.opis = (cbKombinovani.Checked) ? red[2].ToString() : ObradiNaziv(red[2].ToString());
                                    ir.vrsta = red[3].ToString();
                                    if (cbTreci.Checked && red[3].ToString() == "Uticaji")
                                        continue;
                                    di.IzDop.Rows.Add(ir);
                                }
                            }
                            lstIzvestaj.Items.Add(novi.id);
                        }
                    }

                   
                    if (poruka.Length > 0)
                        MessageBox.Show(poruka, "Obavestenje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (DataException)
                {
                    MessageBox.Show("Predmet je vec dodat u izvestaj!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Greska", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void label8_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "01 Barajevo 02 Vozdovac 03 Vracar 04 Grocka\n 05 Zvezdara 06 Zemun 07 Lazarevac 08 Mladenovac\n 09 N.Beograd 10 Obrenovac 11 Palilula 12 S.Venac\n 13 Sopot 14 S.Grad 15 Cukarica 16 Rakovica 17 Surcin";
            tip.SetToolTip(label8, caption);
        }

        private string ObradiKart(string ulaz,string plakt,bool rucno)
        {
            int koliko = 0;
            if (!ulaz.Contains("-"))
                koliko = 5 - ulaz.Length;
            else
            {
                string test = ulaz.Substring(0, ulaz.IndexOf("-"));
                koliko = 5 - test.Length;
            }
            for (int i = 0; i < koliko; i++)
            {
                ulaz = " " + ulaz;
            }
            if (plakt=="GP")
                ulaz="   "+ulaz;
            if (plakt == "PGR")
                ulaz = "  " + ulaz;
            if (plakt == "GUP")
                ulaz = " " + ulaz;
            if (rucno)
                ulaz = " " + ulaz;
            return ulaz;
        }

        private void btnRucnoKart_Click(object sender, EventArgs e)
        {
            if (txtRucnoKart.Text.Length > 0)
            {
                try
                {
                    bool sok=true;
                    bool sveok = true;
                    DodajAutomatske();
                    bool ima_programa = false;
                    bool ima_obicnih = false;
                    string[] ulaz = txtRucnoKart.Text.Split(',');
                    if (ulaz.Length > 0)
                    {
                        string kriterijum = "kartbroj in (";
                        string drugi_kriterijum = "kartbr in (";
                        foreach (string s in ulaz)
                        {
                            string[] pp = s.Split('-');
                            if (!s.ToUpper().Contains("P"))
                            {
                                if (Convert.ToInt32(pp[0]) < 5000)
                                {
                                    kriterijum += "'" + s + "',";
                                    ima_obicnih = true;
                                }
                                else
                                {
                                    drugi_kriterijum += "'" + s + "',";
                                    ima_programa = true;
                                }
                            }
                            else
                            {
                                drugi_kriterijum += "'" + s + "',";
                                ima_programa = true;
                            }
                        }
                        kriterijum = kriterijum.Substring(0, kriterijum.Length - 1);
                        kriterijum += ")";
                        drugi_kriterijum = drugi_kriterijum.Substring(0, drugi_kriterijum.Length - 1);
                        drugi_kriterijum += ")";
                        if (ima_programa)
                        {
                            DataRow[] drugi_niz = programi.PROGRAM.Select(drugi_kriterijum);
                            if (drugi_niz.Length == 0)
                                throw new Exception("Zadati predmet nije pronadjen!");
                            else
                            {
                                sok = true;
                                for (int i = 0; i < drugi_niz.Length; i++)
                                {
                                    dsProgrami.PROGRAMRow ispit = (dsProgrami.PROGRAMRow)drugi_niz[i];
                                    if (di.Predmet.FindByid(ispit.id + 10000) == null)
                                    {
                                        dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                                        novi.id = ispit.id + 10000;
                                        novi.kart = (ispit.IsKARTBRNull() || ispit.KARTBR == "0") ? "" : ObradiKart(String.Format("{0}", ispit.KARTBR),ispit.TIPPLAKT,true);
                                        novi.naziv = (cbKombinovani.Checked) ? ispit.NAZIV : ObradiNaziv(ispit.NAZIV);
                                        novi.grupa = (novi.kart.ToLower().Contains("p")) ? DajGrupu("PROGRAM1") : DajGrupu("PROGRAM");
                                        di.Predmet.Rows.Add(novi);
                                        lstIzvestaj.Items.Add(novi.id);
                                    }
                                    else
                                        sok = false;
                                }
                            }
                        }
                        if (ima_obicnih)
                        {
                        DataRow[] niz = urbanDataSet.REGUPR.Select(kriterijum);
                        if (niz.Length == 0)
                            throw new Exception("Zadati predmet nije pronadjen!");
                        else
                        {
                           
                            for (int i = 0; i < niz.Length; i++)
                            {
                                UrbanDataSet.REGUPRRow test = (UrbanDataSet.REGUPRRow)niz[i];

                                if (di.Predmet.FindByid(test.id) == null)
                                {
                                    dsIzvestaj.PredmetRow novi = di.Predmet.NewPredmetRow();
                                    novi.id = test.id;

                                    if (!Automatski(novi.id))
                                    {
                                        novi.kart = (test.IsKARTBROJNull() || test.KARTBROJ == "0") ? "" : ObradiKart(String.Format("{0}", test.KARTBROJ),test.TIPPLAKT,true);
                                        novi.naziv = (cbKombinovani.Checked) ? test.NAZPRP : ObradiNaziv(test.NAZPRP);
                                        novi.grupa = DajGrupu(test.TIPPLAKT);
                                        di.Predmet.Rows.Add(novi);

                                        if (cbKombinovani.Checked || cbTreci.Checked)
                                        {
                                            DataTable izdop = new DataTable();
                                            ProcitajIzdop(novi.id, izdop);
                                            foreach (DataRow red in izdop.Rows)
                                            {
                                                dsIzvestaj.IzDopRow ir = di.IzDop.NewIzDopRow();
                                                ir.id = Convert.ToInt32(red[1]);
                                                ir.opis = (cbKombinovani.Checked) ? red[2].ToString() : ObradiNaziv(red[2].ToString());
                                                ir.vrsta = red[3].ToString();
                                                if (cbTreci.Checked && red[3].ToString() == "Uticaji")
                                                    continue;
                                                di.IzDop.Rows.Add(ir);
                                            }
                                        }

                                        lstIzvestaj.Items.Add(novi.id);
                                    }
                                }
                                else
                                    sveok = false;
                            }
                        }
                            if (!sveok || !sok)
                            {
                                MessageBox.Show("Neki od predmeta su vec dodati u izvestaj. Dodace se ostali predmeti bez duplikata",
                                    "Duplikati", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }

                   
                }
                catch (DataException)
                {
                    MessageBox.Show("Predmet je vec dodat u izvestaj!!!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Nema zapisa", MessageBoxButtons.OK,
                        MessageBoxIcon.Exclamation);
                }
            }
        }

        private void natpis_korisnik_Click(object sender, EventArgs e)
        {

        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Faza planskog dokumenta gde je: \n D - Donet, usvojen \n P - pristupanje izradi, priprema";
            tip.SetToolTip(label5, caption);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "G - Grad \nO - opstina \nR - republika \nS - sekretarijat \nI - izvrsni odbor";
            tip.SetToolTip(label6, caption);
        }

        private void label7_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "OSN - Osnovni \nDOP - Dopuna \nISP - Ispravka \nIZD - izmena i dopuna \nIZM - izmena";
            tip.SetToolTip(label7, caption);
        }

        private void label11_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "CEN – Centri, zanatski centri, poslovanje \nELE – Elktro vodovi – podzemni vodovi, struja \nGAS – Gasovodi , gasifikacija, naftovodi, pumpe \nGRB – Groblja \nIND – industijske zone, proizvodnja \nINF – Infrastruktura, trafostanice \nKAN – Kolektori, kanalizacioni sistemi \nKAT – Katastar - premer \nOST – Zaštita područja, zemljišta, komasacije, sanitarne zaštite \nPOL – Poljoprivreda \nPOV – Poverljivi planovi, vojska milicija \nREK – Rekreacija, sport \nSAB – Saobraćaj \nSPE – Posebna, specijalna namena \nSTN – Stanovanje \nSVE – Sve teme se obrađuju, to rade Generalni planovi, Prostorni.... \nTER – Sajmovi, domovi kulture, trgovi, razne privremene lokacije \nTKS – Deponije \nTOP – Toplovod \nTTM – Telekomunikacione mreže,  vodovi \nVIK – Vodovod i kanalizacija, sanitarni čvorovi \nVOD – Samo vodovod \nVPR – Sanitarna zaštita, uređenje obala \n ZEL – Izletišta, parkovi \nZKN – Zakonski akti, zaštićena područja, strateške procene \nSko - Škole, Predškolske ustanove, Obrazovanje";
            tip.SetToolTip(label11, caption);
        }

        private void txtOzn_Enter(object sender, EventArgs e)
        {
            DajFokus((TextBox)sender, true);
        }

        private void txtOzn_Leave(object sender, EventArgs e)
        {
            DajFokus((TextBox)sender, false);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {
                if (di != null && di.Predmet.Rows.Count > 0)
                {
                    SaveFileDialog sf = new SaveFileDialog();
                    sf.DefaultExt = "csv";
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        DataTable izvoz = new DataTable();
                        izvoz.Columns.Add("ID", typeof(String));
                        izvoz.Columns.Add("Kartografski broj", typeof(String));
                        izvoz.Columns.Add("Naziv predmeta", typeof(String));
                        foreach (dsIzvestaj.PredmetRow glavni in di.Predmet.Rows)
                        {
                            DataRow novi = izvoz.NewRow();
                            novi[0] = glavni.id.ToString();
                            novi[1] = (glavni.IskartNull()) ? "" : glavni.kart;
                            novi[2] = glavni.naziv.Replace(","," ").Replace("\r\n","");
                            izvoz.Rows.Add(novi);

                            DataRow[] dopune = glavni.GetChildRows(di.Relations[0]);
                            if (dopune.Length > 0)
                            {
                                foreach (DataRow dete in dopune)
                                {
                                    DataRow dodatak = izvoz.NewRow();
                                    dodatak[0] = glavni.id.ToString();
                                    dodatak[1] = (glavni.IskartNull()) ? "" : glavni.kart;
                                    dodatak[2] = dete[1].ToString().Replace(",", " ").Replace("\r\n", "");
                                    izvoz.Rows.Add(dodatak);

                                }
                            }
                        }

                        StreamWriter sw = new StreamWriter(sf.FileName);
                        DataTableHelper.ProduceCSV(izvoz, sw, true);
                        sw.Close();
                    }
                }
                else
                    MessageBox.Show("Morate prethodno dodati predmete u izvestaj!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SAT_Tick(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            string test = DajGuid(veza);
            if (test.Trim() != guid.Trim())
            {
                natpis_promene.Visible = true;
            }
            veza.Close();
        }

        //private void natpis_promene_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        this.Cursor = Cursors.WaitCursor;
        //        UrbanDataSet promene = (UrbanDataSet)this.urbanDataSet.GetChanges();

        //        if (this.urbanDataSet.HasChanges())
        //        {
        //            this.rEGUPRTableAdapter.Update(promene.REGUPR);
        //            this.korisnikTableAdapter1.Update(promene.Korisnik);
        //            this.napomenaTableAdapter1.Update(di.Napomena);
        //            this.urbanDataSet.AcceptChanges();
        //        }
        //         Ovo je logika za dovlacenje aktuelnih podataka
        //        RazveziKontrole();
        //        this.urbanDataSet.REGUPR.Clear();
        //        this.rEGUPRTableAdapter.Fill(this.urbanDataSet.REGUPR);
        //        this.urbanDataSet.Korisnik.Clear();
        //        this.korisnikTableAdapter1.Fill(this.urbanDataSet.Korisnik);
        //        this.di.Napomena.Clear();
        //        this.napomenaTableAdapter1.Fill(di.Napomena);


        //        this.urbanDataSet.AcceptChanges();
        //        di.AcceptChanges();
        //        PoveziKontrole();
        //        MessageBox.Show(izvor.Filter);
        //        if (izvor.Filter.Length == 0)
        //        {
        //            natpis_filter.BackColor = Color.Orange;
        //            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
        //        }
        //        else
        //        {
        //            natpis_filter.BackColor = Color.Azure;
        //            natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);
        //        }

        //        this.Cursor = Cursors.Default;
        //        natpis_promene.Visible = false;
        //        string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
        //        SqlConnection veza = new SqlConnection(cs);
        //        veza.Open();
        //        guid = DajGuid(veza);
        //        veza.Close();
             
        //        MessageBox.Show("Podaci su uspesno sinhronizovani sa centralnom bazom.", "Obavestenje",
        //            MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    catch (SqlException)
        //    {
        //        MessageBox.Show("Greska u sinhronizaciji podataka!");
        //    }

                      
                      
        //}

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "UP - Urbanisticki projekat\nPP - Prostorni plan\nOST - Ostalo\nGUP - Generalni urbanisticki plan\nRP - Regulacioni plan\nPAR - Plan parcelacije\nDUP - Detaljni urbanisticki plan\nPRIV - Privremene dozvole\nPGR - Plan generalne regulacije\nDRUP - Drugi propisi\nSTR - Strateske procene\nGP - Generalni plan\nUUP - Uslovi za uredjenje prostora\nPDR - Plan detaljne regulacije\nPOU - Plan opsteg uredjenja";
            tip.SetToolTip(label1, caption);
        }

        private void ZatvoreniProgrami(object sender, FormClosedEventArgs e)
        {
            frmProgrami fp = (frmProgrami)sender;
            if (fp.DialogResult == DialogResult.OK)
            {

                pp = fp.pp;
                if (fp.zaubac.Count > 0)
                {
                    if (txtRucnoKart.Text.Length > 0)
                        txtRucnoKart.Text += ",";
                    foreach (string k in fp.zaubac)
                    {
                        txtRucnoKart.Text += k + ",";
                    }
                    txtRucnoKart.Text = txtRucnoKart.Text.Substring(0, txtRucnoKart.Text.Length - 1);
                    gb.Visible = true;
                }
            }
        }

        private void btnProgrami_Click(object sender, EventArgs e)
        {
            frmProgrami fp = new frmProgrami();
            fp.podaci = programi;
            fp.korisnik = korisnik;
            fp.pp = pp;
            fp.Show();
            fp.FormClosed+=new FormClosedEventHandler(ZatvoreniProgrami);
            
        }

        private void btnZaduzenja_Click(object sender, EventArgs e)
        {
            frmZaduzenja fp = new frmZaduzenja();
            
            fp.korisnik = korisnik;
            fp.glavni = urbanDataSet;
            fp.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmDOC fp = new frmDOC();
           
            fp.korisnik = korisnik;
            
            fp.Show();
            
        }

        private void txtRucno_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRucno_Click(btnRucno, EventArgs.Empty);
        }

        private void txtRucnoKart_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                btnRucnoKart_Click(btnRucnoKart, EventArgs.Empty);
        }

       

        private void kopirajPodatkeIzAutoCADaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string acad = Clipboard.GetText();
            if (acad == null || acad.Length == 0)
                MessageBox.Show("Trenutno nema podataka za kopiranje!");
            else
            {
                try
                {
                    List<char> sumnjivi = new List<char>();

                    string[] test = acad.Split('\n');
                    foreach (string s in test)
                    {
                        string test1= s.Trim();
                        foreach (char c in test1)
                        {
                            if (!sumnjivi.Contains(c) && c != '-' && !Char.IsDigit(c))
                            {
                                sumnjivi.Add(c);
                                test1=test1.Replace(c.ToString(),String.Empty);
                            }
                        }
                        if (!test1.Contains("-") && test1!="")
                            int.Parse(test1);
                    }
                    acad = acad.Replace("\n", ",");
                    foreach (char c in sumnjivi)
                        acad = acad.Replace(c.ToString(), String.Empty);
                    if (txtRucnoKart.Text.Length>0 && !txtRucnoKart.Text.EndsWith(","))
                        acad=","+acad;
                    if (acad.EndsWith(","))
                        acad = acad.Substring(0, acad.Length - 1);
                    acad = acad.Replace("\r", String.Empty);
                    txtRucnoKart.Text+= acad;
                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Pogresan format podataka!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnObrad_Click(object sender, EventArgs e)
        {
            if (txtID.Text.Length > 0)
            {
                frmObrad fo = new frmObrad();
                fo.podaci = this.urbanDataSet;
                fo.korisnik = this.korisnik;
                fo.plan = int.Parse(txtID.Text);
                fo.ShowDialog();
            }
            else
                MessageBox.Show("Zapis jos uvek nije snimljen u bazu!");
        }

        private void txtOCENA_DoubleClick(object sender, EventArgs e)
        {

            frmNaziv fn = new frmNaziv();
            fn.NazivText = txtOCENA.Text;
            fn.plan = Convert.ToInt32(txtID.Text);
            if (!((bool)korisnik["azur"] || (bool)korisnik["admi"]))
                fn.azur = false;
            if (fn.ShowDialog() == DialogResult.OK)
            {
                if (fn.azur)
                    txtOCENA.Text = fn.NazivText;
            }
        }

        private void txtBBLBR_DoubleClick(object sender, EventArgs e)
        {
            if (txtBBLBR.Text.Length > 0)
            {
                string rez = "";
                string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                using (SqlConnection veza = new SqlConnection(cs))
                {
                    veza.Open();
                    string upit = "select duznik,raz from Zaduzenje where sifra='" + txtBBLBR.Text.Trim() + "' and raz=0";
                    SqlCommand cmd = new SqlCommand(upit, veza);
                    SqlDataReader rd = cmd.ExecuteReader();
                    
                    if (rd.Read())
                    {
                        if (rd.GetInt16(1) == 0)
                            rez = "Planska dokumentacija je zaduzena od strane " + rd[0].ToString();
                        else
                            rez = "Planska dokumentacija je u centru";

                    }
                    else
                    {
                        rez = "Planska dokumentacija je u centru";
                    }
                    rd.Close();
                }
                if (rez.Length > 0)
                    MessageBox.Show(rez, "Informacija o zaduzenju", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void cbKombinovani_CheckedChanged(object sender, EventArgs e)
        {
            if (cbKombinovani.Checked)
            {
                cbTreci.Checked = false;
            }
        }

        private void cbTreci_CheckedChanged(object sender, EventArgs e)
        {
            if (cbTreci.Checked)
            {
                cbKombinovani.Checked = false;
            }
        }

        private void dOSIJEToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDosije fd = new frmDosije();
            fd.korisnik = korisnik;
            fd.glavni = urbanDataSet;
            fd.ShowDialog();
        }

       
    }
}