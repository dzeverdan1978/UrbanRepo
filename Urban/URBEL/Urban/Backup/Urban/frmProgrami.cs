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
    public partial class frmProgrami : Form
    {
        string filter;
        ArrayList tipplakt,inicijat,obrad;
        public dsProgrami podaci;
        bool novi;
        public bool ok;
        public DataRow korisnik;
        public ArrayList zaubac = new ArrayList();
        public ProgramiPamcenje pp;

        public frmProgrami()
        {
            InitializeComponent();
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from program ";
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
            txtArh.DataBindings.Add("Text", izvor, "ARHBR");
            txtKart.DataBindings.Add("Text", izvor, "KARTBR");
            txtNaziv.DataBindings.Add("Text", izvor, "NAZIV");
            txtOpstina.DataBindings.Add("Text", izvor, "OPSTINA");
            txtVeza.DataBindings.Add("Text", izvor, "VEZA");
            cbTipPlakt.DataBindings.Add("SelectedItem", izvor, "TIPPLAKT");
            cbInicijat.DataBindings.Add("SelectedItem", izvor, "INICIJAT");
            cbObrad.DataBindings.Add("SelectedItem", izvor, "OBRADJIVAC");
            dtDATUM.DataBindings.Add("Value", izvor, "DATUM");
           
            cbRealizovan.DataBindings.Add("Checked", izvor, "realizovan");
            CBdIGITALAN.DataBindings.Add("Checked", izvor, "VEKTOR");
            cbSkeniran.DataBindings.Add("Checked", izvor, "SKEN");

        }

        private void RazveziKontrole()
        {
            txtArh.DataBindings.Clear();
            txtArh.Text = "";
            txtKart.DataBindings.Clear();
            txtKart.Text = "";
            txtNaziv.DataBindings.Clear();
            txtNaziv.Text = "";
            txtOpstina.DataBindings.Clear();
            txtOpstina.Text = "";
            txtVeza.DataBindings.Clear();
            txtVeza.Text = "";
            cbTipPlakt.DataBindings.Clear();
            cbTipPlakt.SelectedIndex = 0;
            cbInicijat.DataBindings.Clear();
            cbInicijat.SelectedIndex = 0;
            cbObrad.DataBindings.Clear();
            cbObrad.SelectedIndex = 0;
            dtDATUM.DataBindings.Clear();
            dtDATUM.Value = DateTime.Now;
            cbRealizovan.DataBindings.Clear();
            cbRealizovan.Checked = false;
            CBdIGITALAN.DataBindings.Clear();
            CBdIGITALAN.Checked = false;
            cbSkeniran.DataBindings.Clear();
            cbSkeniran.Checked = false;
        }

        private void frmProgrami_Load(object sender, EventArgs e)
        {
            izvor.DataSource = podaci.PROGRAM;
            pregled.DataSource = izvor;

            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            tipplakt=DajKolonu(veza,"tipplakt");
            cbTipPlakt.DataSource = tipplakt;
            inicijat = DajKolonu(veza, "INICIJAT");
            cbInicijat.DataSource = inicijat;
            obrad = DajKolonu(veza, "OBRADJIVAC");
            cbObrad.DataSource = obrad;

            PoveziKontrole();

            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);

            if (!Convert.ToBoolean(korisnik["azur"]))
            {
                dugme_snimi.Enabled = false;
                dugme_novi.Enabled = false;
                dugme_brisi.Enabled = false;
            }

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

        private string ProveriUnos()
        {
            string izlaz = "";
            if (txtNaziv.Text.Length == 0)
                izlaz = "Naziv predmeta mora da se unese!";
            if (txtKart.Text.Length == 0)
                izlaz = "Kartografski broj mora da se unese!";
            if (dtDATUM.Text.Length == 0)
                izlaz = "Datum mora da se unese!";

            return izlaz;
        }

        private void UbaciNovi()
        {
            try
            {
                string ok = ProveriUnos();
                if (ok.Length > 0)
                    throw new Exception(ok);

                dsProgrami.PROGRAMRow novi = podaci.PROGRAM.NewPROGRAMRow();
                novi.ARHBR = txtArh.Text;
                novi.DATUM = Convert.ToDateTime(dtDATUM.Text);
                novi.INICIJAT = cbInicijat.Text;
                novi.KARTBR = txtKart.Text;
                novi.NAZIV = txtNaziv.Text;
                novi.OBRADJIVAC = cbObrad.Text;
                novi.OPSTINA = txtOpstina.Text;
                novi.REALIZOVAN = cbRealizovan.Checked;
                novi.TIPPLAKT = cbTipPlakt.Text;
                novi.VEZA = txtVeza.Text;
                novi.VEKTOR = CBdIGITALAN.Checked;
                novi.SKEN = cbSkeniran.Checked;
                podaci.PROGRAM.Rows.Add(novi);
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

        private void Snimi()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da snimite promene?", "Upozorenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    dsProgrami promene = (dsProgrami)this.podaci.GetChanges();

                    if (this.podaci.HasChanges())
                    {
                        dsProgramiTableAdapters.PROGRAMTableAdapter filter = new Urban.dsProgramiTableAdapters.PROGRAMTableAdapter();
                        filter.Update(promene.PROGRAM);

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

        private void frmProgrami_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToBoolean(korisnik["azur"]) || Convert.ToBoolean(korisnik["admi"]))
            {
                SrediGrid();
                Snimi();
            }
            //izvor.Filter = "";
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

        private void Brisi()
        {
            try
            {
                if (pregled.CurrentRowIndex >= 0)
                {
                    if (MessageBox.Show("Da li ste sigurni da zelite da obrisete zapis?", "Upozorenje",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                      
                        DataGridCell dc = new DataGridCell(pregled.CurrentRowIndex, 10);
                        int id = Convert.ToInt32(pregled[dc]);
                     dsProgrami.PROGRAMRow kandidat = podaci.PROGRAM.FindByid(id);
                     if (kandidat != null)
                     {
                         kandidat.Delete();
                         //podaci.PROGRAM.Rows.Remove(kandidat);
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

        private void DajFokus(Control c, bool fokus)
        {
            if (fokus)
                c.BackColor = Color.Yellow;
            else
                c.BackColor = Color.White;
        }

        private void cbTipPlakt_Enter(object sender, EventArgs e)
        {
            DajFokus(cbTipPlakt, true);
        }

        private void cbTipPlakt_Leave(object sender, EventArgs e)
        {
            SrediCombo(cbTipPlakt);
            DajFokus(cbTipPlakt, false);
        }

        private void dtDATUM_Enter(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, true);
        }

        private void dtDATUM_Leave(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, false);
        }

        private void txtArh_Leave(object sender, EventArgs e)
        {
            DajFokus(txtArh, false);
        }

        private void txtArh_Enter(object sender, EventArgs e)
        {
            DajFokus(txtArh, true);
        }

        private void cbInicijat_Enter(object sender, EventArgs e)
        {
            DajFokus(cbInicijat, true);
        }

        private void cbInicijat_Leave(object sender, EventArgs e)
        {
            SrediCombo(cbInicijat);
            DajFokus(cbInicijat, false);
        }

        private void txtOpstina_Enter(object sender, EventArgs e)
        {
            DajFokus(txtOpstina, true);
        }

        private void txtOpstina_Leave(object sender, EventArgs e)
        {
            DajFokus(txtOpstina, false);
        }

        private void cbObrad_Enter(object sender, EventArgs e)
        {
            DajFokus(cbObrad, true);
        }

        private void cbObrad_Leave(object sender, EventArgs e)
        {
            SrediCombo(cbObrad);
            DajFokus(cbObrad, false);
        }

        private void txtKart_Enter(object sender, EventArgs e)
        {
            DajFokus(txtKart, true);
        }

        private void txtKart_Leave(object sender, EventArgs e)
        {
            DajFokus(txtKart, false);
        }

        private void txtVeza_Enter(object sender, EventArgs e)
        {
            DajFokus(txtVeza, true);
        }

        private void txtVeza_Leave(object sender, EventArgs e)
        {
            DajFokus(txtVeza, false);
        }

        private void txtNaziv_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, true);
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, false);
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

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmSearchProg fp = new frmSearchProg();
            fp.pp = pp;

            if (fp.ShowDialog() == DialogResult.OK)
            {


                pp = fp.pp;
                DataRow[] redovi = podaci.PROGRAM.Select(fp.filter);
                if (redovi.Length > 0)
                {
                    filter = fp.filter;
                    foreach (DataRow red in redovi)
                    {
                        zaubac.Add(red["KARTBR"].ToString());
                    }
                    izvor.Filter = fp.filter;

                    natpis_filter.BackColor = Color.Azure;
                    
                    natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);
                    btnDodajPrik.Visible = true;
                    btnExcel.Visible = true;
                    btnStampa.Visible = true;
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
            izvor.Filter = "";
            if (txtArh.DataBindings.Count == 0)
                PoveziKontrole();
            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
            btnDodajPrik.Visible = false;
            btnExcel.Visible = false;
            zaubac.Clear();
        }

        private void btnDodajPrik_Click(object sender, EventArgs e)
        {
            if (zaubac.Count > 0)
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
                MessageBox.Show("U pretrazi nije pronadjen ni jedan zapis za ubacivanje!");
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow[] redovi = podaci.PROGRAM.Select(filter);
                dsProgrami dz = (dsProgrami)podaci.Clone();

                SaveFileDialog sf = new SaveFileDialog();
                sf.DefaultExt = "csv";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataRow red in redovi)
                        dz.PROGRAM.ImportRow(red);
                    Pomocna.SrediExcel(dz.PROGRAM);
                    StreamWriter sw = new StreamWriter(sf.FileName);
                    DataTableHelper.ProduceCSV(dz.PROGRAM, sw, true);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            DataRow[] redovi = podaci.PROGRAM.Select(filter);
            dsProgrami dz = (dsProgrami)podaci.Clone();
            foreach (DataRow red in redovi)
                dz.PROGRAM.ImportRow(red);

            frmIzvestaj fi = new frmIzvestaj();
            fi.progs = dz;
            fi.programi = true;
            
            fi.ShowDialog();
        }
    }

    
}