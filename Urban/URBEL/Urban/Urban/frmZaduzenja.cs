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
    public partial class frmZaduzenja : Form
    {
        ArrayList duznik,sifre;
        public dsZaduzenja podaci=new dsZaduzenja();
        bool novi;
        public bool ok;
        public DataRow korisnik;
        DataTable pom = new DataTable();
        public ZaduzenjaPamcenje pp = new ZaduzenjaPamcenje();
        public UrbanDataSet glavni;
        string filter;
       
        public frmZaduzenja()
        {
            InitializeComponent();

            pom.Columns.Add("id", typeof(Int32));
            pom.Columns.Add("naziv", typeof(String));
            DataRow prvi = pom.NewRow();
            prvi[0] = 0;
            prvi[1] = "NIJE";
            pom.Rows.Add(prvi);
            DataRow drugi = pom.NewRow();
            drugi[0] = -1;
            drugi[1] = "JESTE";
            pom.Rows.Add(drugi);
            cbRazduzen.DataSource = pom;
            cbRazduzen.DisplayMember = "naziv";
            cbRazduzen.ValueMember = "id";
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from zaduzenje ";
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
            txtSifra.DataBindings.Add("Text", izvor, "sifra");
            txtNaziv.DataBindings.Add("Text", izvor, "naziv");
            txtDuznik.DataBindings.Add("Text", izvor, "duznik");
            txtNapomena.DataBindings.Add("Text", izvor, "napom");
            dtDATUM.DataBindings.Add("Value", izvor, "datum");
            cbRazduzen.DataBindings.Add("SelectedValue", izvor, "raz");
        }

        private void RazveziKontrole()
        {
            txtSifra.DataBindings.Clear();
            txtSifra.Text = "";
            txtNaziv.DataBindings.Clear();
            txtNaziv.Text = "";
            txtDuznik.DataBindings.Clear();
            txtDuznik.Text = "";
            txtNapomena.DataBindings.Clear();
            txtNapomena.Text = "";
            dtDATUM.DataBindings.Clear();
            dtDATUM.Value = DateTime.Now;
            cbRazduzen.DataBindings.Clear();
            cbRazduzen.SelectedValue = 0;
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

        private void frmZaduzenja_Load(object sender, EventArgs e)
        {
            dsZaduzenjaTableAdapters.ZaduzenjeTableAdapter pa = new Urban.dsZaduzenjaTableAdapters.ZaduzenjeTableAdapter();
            pa.Fill(podaci.Zaduzenje);
            podaci.AcceptChanges();
            izvor.DataSource = podaci.Zaduzenje;
            pregled.DataSource = izvor;

            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            duznik = DajKolonu(veza, "duznik");
            sifre = DajKolonu(veza, "sifra");
            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in duznik)
                asc60.Add(s);
            txtDuznik.AutoCompleteCustomSource = asc60;

            AutoCompleteStringCollection asc61 = new AutoCompleteStringCollection();
            foreach (string s in sifre)
                asc61.Add(s);
            txtSifra.AutoCompleteCustomSource = asc61;

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

                        DataGridCell dc = new DataGridCell(pregled.CurrentRowIndex, 6);
                        int id = Convert.ToInt32(pregled[dc]);
                        dsZaduzenja.ZaduzenjeRow kandidat = podaci.Zaduzenje.FindByid(id);
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
            btnStampa.Visible = false;
            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
            if (txtSifra.DataBindings.Count == 0)
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

                dsZaduzenja.ZaduzenjeRow novi = podaci.Zaduzenje.NewZaduzenjeRow();
               
                novi.datum = Convert.ToDateTime(dtDATUM.Text);
                novi.duznik = txtDuznik.Text;
                novi.napom = txtNapomena.Text;
                novi.naziv = txtNaziv.Text;
                novi.raz = Convert.ToInt16(cbRazduzen.SelectedValue);
                novi.sifra = txtSifra.Text;
                podaci.Zaduzenje.Rows.Add(novi);
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
                izlaz = "Naziv predmeta mora da se unese!";
            if (txtSifra.Text.Length == 0)
                izlaz = "Sifra predmeta mora da se unese!";
            if (txtDuznik.Text.Length == 0)
                izlaz = "Ime duznika mora da se unese!";

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
                    dsZaduzenja promene = (dsZaduzenja)this.podaci.GetChanges();

                    if (this.podaci.HasChanges())
                    {
                        dsZaduzenjaTableAdapters.ZaduzenjeTableAdapter filter = new Urban.dsZaduzenjaTableAdapters.ZaduzenjeTableAdapter();
                        filter.Update(promene.Zaduzenje);

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

        private void frmZaduzenja_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToBoolean(korisnik["zadw"]) || Convert.ToBoolean(korisnik["admi"]) || Convert.ToBoolean(korisnik["azur"]))
            {
                SrediGrid();
                Snimi();
            }
           // izvor.Filter = "";
        }

        private void DajFokus(Control c, bool fokus)
        {
            if (fokus)
                c.BackColor = Color.Yellow;
            else
                c.BackColor = Color.White;
        }

        private void txtSifra_Enter(object sender, EventArgs e)
        {
            DajFokus(txtSifra, true);
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

        private void txtSifra_Leave(object sender, EventArgs e)
        {
            DajFokus(txtSifra, false);
            
            
                DataRow[] niz = glavni.REGUPR.Select("bblbrprp='" + txtSifra.Text.Trim() + "'");
                if (niz.Length > 0 && niz[0]["nazprp"]!=null)
                    txtNaziv.Text = ObradiNaziv(niz[0]["nazprp"].ToString());
            
              
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, false);
        }

        private void txtNaziv_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, true);
        }

        private void dtDATUM_Enter(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, true);
        }

        private void dtDATUM_Leave(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, false);
        }

        private void txtDuznik_Layout(object sender, LayoutEventArgs e)
        {
           
        }

        private void txtDuznik_Enter(object sender, EventArgs e)
        {
            DajFokus(txtDuznik, true);
        }

        private void cbRazduzen_Enter(object sender, EventArgs e)
        {
            DajFokus(cbRazduzen, true);
        }

        private void cbRazduzen_Leave(object sender, EventArgs e)
        {
            DajFokus(cbRazduzen, false);
        }

        private void txtNapomena_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNapomena, false);
        }

        private void txtNapomena_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNapomena, true);
        }

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmPretragaZaduzenja fp = new frmPretragaZaduzenja();
            fp.pp = pp;
            fp.duznik = duznik;
            fp.sifre = sifre;
            if (fp.ShowDialog() == DialogResult.OK)
            {


                pp = fp.pp;
                DataRow[] redovi = podaci.Zaduzenje.Select(fp.filter);
                filter = fp.filter;
                if (redovi.Length > 0)
                {
                    btnStampa.Visible = true;
                    btnExcel.Visible = true;
                    izvor.Filter = fp.filter;

                    natpis_filter.BackColor = Color.Azure;

                    natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);
                   
                }
                else
                {
                    izvor.Filter = "";
                    btnStampa.Visible = false;
                    btnExcel.Visible = false;
                    MessageBox.Show("Pretraga nije vratila ni jedan zapis. Pokusajte ponovo.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    natpis_filter.BackColor = Color.Orange;
                    natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
                }

            }
        }

        private void txtDuznik_Leave(object sender, EventArgs e)
        {
            DajFokus(txtDuznik, false);
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            DataRow[] redovi = podaci.Zaduzenje.Select(filter);
            dsZaduzenja dz = (dsZaduzenja)podaci.Clone();
            foreach (DataRow red in redovi)
                dz.Zaduzenje.ImportRow(red);

            frmIzvestaj fi = new frmIzvestaj();
            fi.dz = dz;
            fi.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow[] redovi = podaci.Zaduzenje.Select(filter);
                dsZaduzenja dz = (dsZaduzenja)podaci.Clone();
    
                SaveFileDialog sf = new SaveFileDialog();
                    sf.DefaultExt = "csv";
                    if (sf.ShowDialog() == DialogResult.OK)
                    {
                        foreach (DataRow red in redovi)
                        {
                            red[0] = " " + red[0].ToString().Trim();
                            dz.Zaduzenje.ImportRow(red);
                        }

                        Pomocna.SrediExcel(dz.Zaduzenje);
                        StreamWriter sw = new StreamWriter(sf.FileName);
                        DataTableHelper.ProduceCSV(dz.Zaduzenje, sw, true);
                        sw.Close();
                    }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void txtSifra_TextChanged(object sender, EventArgs e)
        {
            if (pregled.CurrentRowIndex >= 0)
            {
                dsZaduzenja.ZaduzenjeRow trenutni = podaci.Zaduzenje[pregled.CurrentRowIndex];
                TimeSpan period = DateTime.Now.Subtract(trenutni.datum);
                if (period.TotalDays > 60 && trenutni.raz == 0)
                    lblAlarm.Visible = true;
                else
                    lblAlarm.Visible = false;
            }
        }
    }
}