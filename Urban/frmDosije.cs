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
using System.IO;

namespace Urban
{
    public partial class frmDosije : Form
    {
        ArrayList opstina, cr;
        public dsDosije podaci = new dsDosije();
        bool novi;
        public bool ok;
        public DataRow korisnik;
        DataTable pom = new DataTable();
        public DosijePamcenje pp = new DosijePamcenje();
        public UrbanDataSet glavni;
        string filter;

        public frmDosije()
        {
            InitializeComponent();
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

        private void PoveziKontrole()
        {
            txtDOS.DataBindings.Add("Text", izvor, "DOS");
            txtREG.DataBindings.Add("Text", izvor, "REG");
            txtKart.DataBindings.Add("Text", izvor, "KART");
            txtNaslov.DataBindings.Add("Text", izvor, "NASLOV");
            txtOpstina.DataBindings.Add("Text", izvor, "OPSTINA");
            txtIZM.DataBindings.Add("Text", izvor, "IZM");
            txtCR.DataBindings.Add("Text", izvor, "CR");
            cbAzur.DataBindings.Add("Checked", izvor, "AZUR");
            
        }

        private void RazveziKontrole()
        {
            txtDOS.DataBindings.Clear();
            txtDOS.Text = "";
            txtREG.DataBindings.Clear();
            txtREG.Text = "";
            txtKart.DataBindings.Clear();
            txtKart.Text = "";
            txtNaslov.DataBindings.Clear();
            txtNaslov.Text = "";
            txtOpstina.DataBindings.Clear();
            txtOpstina.Text = "";
            txtIZM.DataBindings.Clear();
            txtIZM.Text = "";
            txtCR.DataBindings.Clear();
            txtCR.Text = "";
            cbAzur.DataBindings.Clear();
            cbAzur.Checked = false;
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

        private void frmDosije_Load(object sender, EventArgs e)
        {
            dsDosijeTableAdapters.DOSIJETableAdapter pa = new Urban.dsDosijeTableAdapters.DOSIJETableAdapter();
            pa.Fill(podaci.DOSIJE);
            podaci.AcceptChanges();
            izvor.DataSource = podaci.DOSIJE;
            pregled.DataSource = izvor;

            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            opstina = DajKolonu(veza, "opstina");
            cr = DajKolonu(veza, "cr");
            AutoCompleteStringCollection asc60 = new AutoCompleteStringCollection();
            foreach (string s in opstina)
                asc60.Add(s);
            txtOpstina.AutoCompleteCustomSource = asc60;

            AutoCompleteStringCollection asc61 = new AutoCompleteStringCollection();
            foreach (string s in cr)
                asc61.Add(s);
            txtCR.AutoCompleteCustomSource = asc61;

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

                        DataGridCell dc = new DataGridCell(pregled.CurrentRowIndex, 0);
                        string dos = Convert.ToString(pregled[dc]);
                        dsDosije.DOSIJERow kandidat = podaci.DOSIJE.FindByDOS(dos);
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
            if (txtDOS.DataBindings.Count == 0)
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

                dsDosije.DOSIJERow novi = podaci.DOSIJE.NewDOSIJERow();

                novi.AZUR = cbAzur.Checked;
                novi.CR = txtCR.Text;
                novi.DOS = txtDOS.Text;
                novi.IZM = txtIZM.Text;
                novi.KART = txtKart.Text;
                novi.NASLOV = txtNaslov.Text;
                novi.OPSTINA = txtOpstina.Text;
                novi.REG = txtREG.Text;
                podaci.DOSIJE.Rows.Add(novi);
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
            if (txtDOS.Text.Length == 0)
                izlaz = "Dosije mora da se unese!";
            if (txtREG.Text.Length == 0)
                izlaz = "Registarski broj mora da se unese!";
            if (txtKart.Text.Length == 0)
                izlaz = "Kartografski broj mora da se unese!";
            if (txtNaslov.Text.Length == 0)
                izlaz = "Naslov mora da se unese!";
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
                    dsDosije promene = (dsDosije)this.podaci.GetChanges();

                    if (this.podaci.HasChanges())
                    {
                        dsDosijeTableAdapters.DOSIJETableAdapter filter = new Urban.dsDosijeTableAdapters.DOSIJETableAdapter();
                        filter.Update(promene.DOSIJE);

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

        private void frmDosije_FormClosing(object sender, FormClosingEventArgs e)
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

        private void txtDOS_Enter(object sender, EventArgs e)
        {
            DajFokus(txtDOS, true);
        }

        private string Rimski(string ulaz)
        {
            string[] rimski = { "/I/", "/II/", "/III/", "/IV/", "/V/", "/VI", "/VII/", "/VIII/", "/IX/", "/X/", "/XI/", "/XII/" };
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

        private void txtDOS_Leave(object sender, EventArgs e)
        {
            DajFokus(txtDOS, false);


            DataRow[] niz = glavni.REGUPR.Select("dosije='" + txtDOS.Text.Trim() + "'");
            if (niz.Length > 0 && niz[0]["nazprp"] != null)
                txtNaslov.Text = ObradiNaziv(niz[0]["nazprp"].ToString());
        }

        private void txtREG_Enter(object sender, EventArgs e)
        {
            DajFokus(txtREG, true);
        }

        private void txtREG_Leave(object sender, EventArgs e)
        {
            DajFokus(txtREG, false);
        }

        private void txtKart_Enter(object sender, EventArgs e)
        {
            DajFokus(txtKart, true);
        }

        private void txtKart_Leave(object sender, EventArgs e)
        {
            DajFokus(txtKart, false);
        }

        private void txtNaslov_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNaslov, true);
        }

        private void txtNaslov_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNaslov, false);
        }

        private void txtOpstina_Enter(object sender, EventArgs e)
        {
            DajFokus(txtOpstina, true);
        }

        private void txtOpstina_Leave(object sender, EventArgs e)
        {
            DajFokus(txtOpstina, false);
        }

        private void txtIZM_Enter(object sender, EventArgs e)
        {
            DajFokus(txtIZM, true);
        }

        private void txtIZM_Leave(object sender, EventArgs e)
        {
            DajFokus(txtIZM, false);
        }

        private void txtCR_Enter(object sender, EventArgs e)
        {
            DajFokus(txtCR, true);
        }

        private void txtCR_Leave(object sender, EventArgs e)
        {
            DajFokus(txtCR, false);
        }

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmPretragaDosije fp = new frmPretragaDosije();
            fp.pp = pp;
            
            if (fp.ShowDialog() == DialogResult.OK)
            {


                pp = fp.pp;
                DataRow[] redovi = podaci.DOSIJE.Select(fp.filter);
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

        private void btnStampa_Click(object sender, EventArgs e)
        {
            DataRow[] redovi = podaci.DOSIJE.Select(filter);
            dsDosije dz = (dsDosije)podaci.Clone();
            foreach (DataRow red in redovi)
                dz.DOSIJE.ImportRow(red);

            frmIzvestaj fi = new frmIzvestaj();
            fi.dd = dz;
            fi.dosije = true;
            fi.ShowDialog();
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow[] redovi = podaci.DOSIJE.Select(filter);
                dsDosije dz = (dsDosije)podaci.Clone();

                SaveFileDialog sf = new SaveFileDialog();
                sf.DefaultExt = "csv";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataRow red in redovi)
                    {
                        red[0] = " " + red[0].ToString().Trim();
                        dz.DOSIJE.ImportRow(red);
                    }

                    Pomocna.SrediExcel(dz.DOSIJE);
                    StreamWriter sw = new StreamWriter(sf.FileName);
                    DataTableHelper.ProduceCSV(dz.DOSIJE, sw, true);
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
            string caption = "Broj dosijea";
            tip.SetToolTip(label6, caption);
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Registarski broj";
            tip.SetToolTip(label1, caption);
        }

        private void label2_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Kartografski broj";
            tip.SetToolTip(label2, caption);
        }

        private void label14_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Naziv planskog dokumenta";
            tip.SetToolTip(label14, caption);
        }

        private void cbAzur_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Ažurirano";
            tip.SetToolTip(cbAzur, caption);
        }

        private void label4_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Izmene i dopune";
            tip.SetToolTip(label4, caption);
        }

        private void label5_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "Inicijali obrađivača";
            tip.SetToolTip(label5, caption);
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
}
