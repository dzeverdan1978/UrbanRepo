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
    public partial class frmDOC : Form
    {
        ArrayList opstine, osnovi, inrefovi, tipdocs;
        public dsDOC podaci;
        bool novi;
        DOCPamcenje pp = new DOCPamcenje();
        string filter;
        public DataRow korisnik;
      
       

        public frmDOC()
        {
            InitializeComponent();
        }

        private ArrayList DajKolonu(SqlConnection veza, string naziv)
        {
            try
            {
                if (veza.State == ConnectionState.Closed)
                    veza.Open();
                string upit = "select distinct isnull(" + naziv + ",'---') from urbdoc ";
                
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
            txtBR.DataBindings.Add("Text", izvor, "BR");
            txtREGB.DataBindings.Add("Text", izvor, "REGB");
            txtBIB.DataBindings.Add("Text", izvor, "BIB");
            txtARHBR.DataBindings.Add("Text", izvor, "ARHBR");
            txtARHBRDOC.DataBindings.Add("Text", izvor, "ARHBRDOC");
            txtNaziv.DataBindings.Add("Text", izvor, "NAZIV");
            txtNAPOMENA.DataBindings.Add("tEXT", izvor, "NAPOM");
            txtKATOPST.DataBindings.Add("Text", izvor, "KATOPST");
            txtBRKAT.DataBindings.Add("Text", izvor, "BRKATPAR");
            txtMatr.DataBindings.Add("Text", izvor, "MATR");
            txtOPSTINA.DataBindings.Add("Text", izvor, "OPSTINA");
            txtOsnov.DataBindings.Add("Text", izvor, "OSNOV");
            txtInref.DataBindings.Add("Text", izvor, "INREF");
            txtTIPDOC.DataBindings.Add("Text", izvor, "TIPDOC");
            dtDATUM.DataBindings.Add("Value", izvor, "DATUM");        

        }

        private void RazveziKontrole()
        {
            txtBR.DataBindings.Clear();
            txtBR.Text = "";
            txtREGB.DataBindings.Clear();
            txtREGB.Text = "";
            txtBIB.DataBindings.Clear();
            txtBIB.Text = "";
            txtARHBR.DataBindings.Clear();
            txtARHBR.Text = "";
            txtARHBRDOC.DataBindings.Clear();
            txtARHBRDOC.Text = "";
            txtNaziv.DataBindings.Clear();
            txtNaziv.Text = "";
            txtNAPOMENA.DataBindings.Clear();
            txtNAPOMENA.Text = "";
            txtKATOPST.DataBindings.Clear();
            txtKATOPST.Text = "";
            txtBRKAT.DataBindings.Clear();
            txtBRKAT.Text = "";
            txtMatr.DataBindings.Clear();
            txtMatr.Text = "";
            txtOPSTINA.DataBindings.Clear();
            txtOPSTINA.Text = "";
            txtOsnov.DataBindings.Clear();
            txtOsnov.Text = "";
            txtInref.DataBindings.Clear();
            txtInref.Text = "";
            txtTIPDOC.DataBindings.Clear();
            txtTIPDOC.Text = "";
            dtDATUM.DataBindings.Clear();
            dtDATUM.Value = DateTime.Now;
            
        }

        private void DajFokus(Control c, bool fokus)
        {
            if (fokus)
                c.BackColor = Color.Yellow;
            else
                c.BackColor = Color.White;
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

        private void frmDOC_Load(object sender, EventArgs e)
        {
            podaci = new dsDOC();
            dsDOCTableAdapters.URBDOCTableAdapter pa = new Urban.dsDOCTableAdapters.URBDOCTableAdapter();
            pa.Fill(podaci.URBDOC);
            podaci.AcceptChanges();
            izvor.DataSource = podaci.URBDOC;
            pregled.DataSource = izvor;

            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = new SqlConnection(cs);
            veza.Open();
            opstine = DajKolonu(veza, "opstina");
            AutoCompleteStringCollection asc61 = new AutoCompleteStringCollection();
            foreach (string s in opstine)
                asc61.Add(s);
            txtOPSTINA.AutoCompleteCustomSource = asc61;
            osnovi = DajKolonu(veza, "osnov");
            AutoCompleteStringCollection asc62 = new AutoCompleteStringCollection();
            foreach (string s in osnovi)
                asc62.Add(s);
            txtOsnov.AutoCompleteCustomSource = asc62;
            inrefovi = DajKolonu(veza, "inref");
            AutoCompleteStringCollection asc63 = new AutoCompleteStringCollection();
            foreach (string s in inrefovi)
                asc63.Add(s);
            txtInref.AutoCompleteCustomSource = asc63;
            tipdocs=DajKolonu(veza,"tipdoc");
            AutoCompleteStringCollection asc64 = new AutoCompleteStringCollection();
            foreach (string s in tipdocs)
                asc64.Add(s);
            txtTIPDOC.AutoCompleteCustomSource = asc64;
           

            PoveziKontrole();

            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);

            if (!(Convert.ToBoolean(korisnik["azur"]) || Convert.ToBoolean(korisnik["docw"])))
            {
                dugme_snimi.Enabled = false;
                dugme_novi.Enabled = false;
                dugme_brisi.Enabled = false;
            }
        }

        private void txtBR_Enter(object sender, EventArgs e)
        {
            DajFokus(txtBR, true);
        }

        private void txtBR_Leave(object sender, EventArgs e)
        {
            DajFokus(txtBR, false);
        }

        private void dtDATUM_Leave(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, false);
        }

        private void dtDATUM_Enter(object sender, EventArgs e)
        {
            DajFokus(dtDATUM, true);
        }

        private void txtREGB_Enter(object sender, EventArgs e)
        {
            DajFokus(txtREGB, true);
        }

        private void txtREGB_Leave(object sender, EventArgs e)
        {
            DajFokus(txtREGB, false);
        }

        private void txtBIB_Leave(object sender, EventArgs e)
        {
            DajFokus(txtBIB, false);
        }

        private void txtBIB_Enter(object sender, EventArgs e)
        {
            DajFokus(txtBIB, true);
        }

        private void txtARHBR_Enter(object sender, EventArgs e)
        {
            DajFokus(txtARHBR, true);
        }

        private void txtARHBR_Leave(object sender, EventArgs e)
        {
            DajFokus(txtARHBR, false);
        }

        private void txtARHBRDOC_Leave(object sender, EventArgs e)
        {
            DajFokus(txtARHBRDOC, false);
        }

        private void txtARHBRDOC_Enter(object sender, EventArgs e)
        {
            DajFokus(txtARHBRDOC, true);
        }

       

        

       

        private void txtNaziv_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, true);
        }

        private void txtNaziv_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNaziv, false);
        }

        private void txtNAPOMENA_Leave(object sender, EventArgs e)
        {
            DajFokus(txtNAPOMENA, false);
        }

        private void txtNAPOMENA_Enter(object sender, EventArgs e)
        {
            DajFokus(txtNAPOMENA, true);
        }

        private void txtKATOPST_Enter(object sender, EventArgs e)
        {
            DajFokus(txtKATOPST, true);
        }

        private void txtKATOPST_Leave(object sender, EventArgs e)
        {
            DajFokus(txtKATOPST, false);
        }

        private void txtBRKAT_Leave(object sender, EventArgs e)
        {
            DajFokus(txtBRKAT, false);
        }

        private void txtBRKAT_Enter(object sender, EventArgs e)
        {
            DajFokus(txtBRKAT, true);
        }

        private void txtMatr_Enter(object sender, EventArgs e)
        {
            DajFokus(txtMatr, true);
        }

        private void txtMatr_Leave(object sender, EventArgs e)
        {
            DajFokus(txtMatr, false);
        }

        

        

        private void dugme_svi_Click(object sender, EventArgs e)
        {
            btnStampa.Visible = false;
            btnExcel.Visible = false;
            izvor.Filter = "";
            if (txtBR.DataBindings.Count == 0)
                PoveziKontrole();
            natpis_filter.BackColor = Color.Orange;
            natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
            
        }

        private void UbaciNovi()
        {
            try
            {


                dsDOC.URBDOCRow novi = podaci.URBDOC.NewURBDOCRow();
                novi.ARHBR = txtARHBR.Text;
                novi.ARHBRDOC = txtARHBRDOC.Text;
                novi.BIB = txtBIB.Text;
                novi.BR = (txtBR.Text.Length>0) ? Convert.ToInt32(txtBR.Text) : 0;
                novi.BRKATPAR = txtBRKAT.Text;
                novi.DATUM = dtDATUM.Value;
                novi.INREF = txtInref.Text;
                novi.KATOPST = txtKATOPST.Text;
                novi.MATR = txtMatr.Text;
                novi.NAPOM = txtNAPOMENA.Text;
                novi.NAZIV = txtNaziv.Text;
                novi.OPSTINA = txtOPSTINA.Text;
                novi.OSNOV = txtOsnov.Text;
                novi.REGB = (txtREGB.Text.Length>0) ? Convert.ToInt32(txtREGB.Text) : 0;
                novi.TIPDOC = txtTIPDOC.Text;
                podaci.URBDOC.Rows.Add(novi);
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

        private void Snimi()
        {
            if (MessageBox.Show("Da li ste sigurni da zelite da snimite promene?", "Upozorenje",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                try
                {

                    this.Cursor = Cursors.WaitCursor;
                    dsDOC promene = (dsDOC)this.podaci.GetChanges();

                    if (this.podaci.HasChanges())
                    {
                        dsDOCTableAdapters.URBDOCTableAdapter filter = new Urban.dsDOCTableAdapters.URBDOCTableAdapter();
                        filter.Update(promene.URBDOC);

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

                        DataGridCell dc = new DataGridCell(pregled.CurrentRowIndex, 15);
                        int id = Convert.ToInt32(pregled[dc]);
                        dsDOC.URBDOCRow kandidat = podaci.URBDOC.FindByid(id);
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

        private void frmDOC_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (Convert.ToBoolean(korisnik["docw"]) || Convert.ToBoolean(korisnik["admi"]) || Convert.ToBoolean(korisnik["azur"]))
            {
                SrediGrid();
                Snimi();
            }
        }

        private void dugme_pretraga_Click(object sender, EventArgs e)
        {
            frmDOCPretraga fp = new frmDOCPretraga();
            fp.pp = pp;

            if (fp.ShowDialog() == DialogResult.OK)
            {


                pp = fp.pp;
                DataRow[] redovi = podaci.URBDOC.Select(fp.filter);
                if (redovi.Length > 0)
                {
                    btnStampa.Visible = true;
                    btnExcel.Visible = true;
                    izvor.Filter = fp.filter;
                    this.filter = fp.filter;
                    natpis_filter.BackColor = Color.Azure;

                    natpis_filter.Text = String.Format("Filtrirani podaci. Trenutno ima {0} zapisa.", izvor.Count);
                    
                }
                else
                {
                    izvor.Filter = "";
                    this.filter = "";
                    MessageBox.Show("Pretraga nije vratila ni jedan zapis. Pokusajte ponovo.", "Upozorenje",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    natpis_filter.BackColor = Color.Orange;
                    natpis_filter.Text = String.Format("Svi podaci. Trenutno ima {0} zapisa.", izvor.Count);
                }

            }
        }

        private void label15_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "UP - Urbanisticki projekat\nPP - Prostorni plan\nOST - Ostalo\nGUP - Generalni urbanisticki plan\nRP - Regulacioni plan\nPAR - Plan parcelacije\nDUP - Detaljni urbanisticki plan\nPRIV - Privremene dozvole\nPGR - Plan generalne regulacije\nDRUP - Drugi propisi\nSTR - Strateske procene\nGP - Generalni plan\nUUP - Uslovi za uredjenje prostora\nPDR - Plan detaljne regulacije\nPOU - Plan opsteg uredjenja\nAKT - akt\nUD - Urbanisticka dozvola\nIZV - izvod iz plana\nPOT - potvrda up-a\nPRO - program\nUTU - Urbanisticko tehnicki uslovi";
            tip.SetToolTip(label15, caption);
        }

        private void label6_MouseHover(object sender, EventArgs e)
        {
            ToolTip tip = new ToolTip();
            tip.IsBalloon = true;
            tip.AutoPopDelay = 10000;
            string caption = "01 Barajevo 02 Vozdovac 03 Vracar 04 Grocka\n 05 Zvezdara 06 Zemun 07 Lazarevac 08 Mladenovac\n 09 N.Beograd 10 Obrenovac 11 Palilula 12 S.Venac\n 13 Sopot 14 S.Grad 15 Cukarica 16 Rakovica 17 Surcin";
            tip.SetToolTip(label6, caption);
        }

        private void btnStampa_Click(object sender, EventArgs e)
        {
            DataRow[] redovi = podaci.URBDOC.Select(filter);
            dsDOC dz = (dsDOC)podaci.Clone();
            foreach (DataRow red in redovi)
                dz.URBDOC.ImportRow(red);

            frmIzvestaj fi = new frmIzvestaj();
            fi.docs = dz;
            fi.urbdoc = true;
            fi.ShowDialog();
        }

        private void txtOPSTINA_Enter(object sender, EventArgs e)
        {
            DajFokus(txtOPSTINA, true);
        }

        private void txtOPSTINA_Leave(object sender, EventArgs e)
        {
            DajFokus(txtOPSTINA, false);
        }

        private void txtOsnov_Leave(object sender, EventArgs e)
        {
            DajFokus(txtOsnov, false);
        }

        private void txtOsnov_Enter(object sender, EventArgs e)
        {
            DajFokus(txtOsnov, true);
        }

        private void txtInref_Enter(object sender, EventArgs e)
        {
            DajFokus(txtInref, true);
        }

        private void txtInref_Leave(object sender, EventArgs e)
        {
            DajFokus(txtInref, false);
        }

        private void txtTIPDOC_Leave(object sender, EventArgs e)
        {
            DajFokus(txtTIPDOC, false);
        }

        private void txtTIPDOC_Enter(object sender, EventArgs e)
        {
            DajFokus(txtTIPDOC, true);
        }

        private void btnExcel_Click(object sender, EventArgs e)
        {
            try
            {

                DataRow[] redovi = podaci.URBDOC.Select(filter);
                dsDOC dz = (dsDOC)podaci.Clone();

                SaveFileDialog sf = new SaveFileDialog();
                sf.DefaultExt = "csv";
                if (sf.ShowDialog() == DialogResult.OK)
                {
                    foreach (DataRow red in redovi)
                    {
                        red[2] = " " + red[2].ToString().Trim();
                        dz.URBDOC.ImportRow(red);

                    }

                    Pomocna.SrediExcel(dz.URBDOC);
                    StreamWriter sw = new StreamWriter(sf.FileName);
                    DataTableHelper.ProduceCSV(dz.URBDOC, sw, true);
                    sw.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}