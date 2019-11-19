using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace Urban
{
    public enum Rezim { UticeNa, UticajiOd };

    public partial class frmUticaji : Form
    {
        public DataTable na=new DataTable();
        public int id;
        public BindingSource izvor;
        UrbanDataSet.REGUPRRow trenutni;
        bool novi;
        public string naziv;
        public UrbanDataSet urbanDataSet;
        public bool azur=true;
        public Rezim rezim=Rezim.UticeNa;
        public PretragaUslovi pu;

        public frmUticaji()
        {
            InitializeComponent();
        }

        private void frmUticaji_Load(object sender, EventArgs e)
        {
            ProcitajPodatke();
            txtID.DataBindings.Add("Text", na, "id");
            txtNaziv.DataBindings.Add("Text", na, "nazprp");
            txtKart.DataBindings.Add("Text", na, "kartbroj");
            PoveziKontrole();
            if (!azur)
            {
                dugme_brisi.Enabled = false;
                dugme_novi.Enabled = false;
                dugme_snimi.Enabled = false;
            }

           /* if (rezim == Rezim.UticajiOd)
            {
                label1.Text = "Uticaji drugih predmeta:";
                this.Text = "Uticaji drugih planova";
            } */
        }

        private void PoveziKontrole()
        {
            if (rezim == Rezim.UticeNa)
            {
                izbor_tip.DataBindings.Add("SelectedValue", na, "idtip");
                txtOpis.DataBindings.Add("Text", na, "opis");
                izbor_datum.DataBindings.Add("Value", na, "datum");
                txtIdut.DataBindings.Add("Text", na, "idut");
            }
            else
            {
                izbor_tip.DataBindings.Add("SelectedValue", na, "idtip");
                txtOpis.DataBindings.Add("Text", na, "opis");
                izbor_datum.DataBindings.Add("Value", na, "datum");
                txtIdut.DataBindings.Add("Text", na, "idut");
            }
        }

        private void OdveziKontrole()
        {
            izbor_tip.DataBindings.Clear();
            txtOpis.DataBindings.Clear();
            izbor_datum.DataBindings.Clear();
            txtIdut.DataBindings.Clear();
        }


        private void ProcitajPodatke()
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                string komanda = "UticajiNa";
                SqlCommand kom = new SqlCommand(komanda, veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter filter = new SqlDataAdapter();
                filter.SelectCommand = kom;
                if (prikaz.DataSource != null)
                    prikaz.DataSource = null;
                if (na.Rows.Count > 0)
                    na.Rows.Clear();
                filter.Fill(na);
                prikaz.DataSource = na;
                if (izbor_tip.DataSource != null)
                    izbor_tip.DataSource = null;
                izbor_tip.DataSource = Tipovi(veza);
                izbor_tip.DisplayMember = "opis";
                izbor_tip.ValueMember = "id";
                
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

        private DataTable Tipovi(SqlConnection veza)
        {
            SqlDataAdapter filter = new SqlDataAdapter("select * from tip_uticaja", veza);
            DataTable temp = new DataTable();
            filter.Fill(temp);
            return temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmPretraga fp = new frmPretraga();
            fp.obradjivaci = (UrbanDataSet.FirmaDataTable)this.urbanDataSet.Firma.Copy();
            fp.pu = pu;
            if (fp.ShowDialog() == DialogResult.OK)
            {
                frmRezultat fr = new frmRezultat();
                DataRow[] redovi = urbanDataSet.REGUPR.Select(fp.filter);
                
                if (fp.filter.Length > 0 && redovi.Length>0)
                {
                    izvor.Filter = fp.filter;
                    fr.izvor = izvor;
                    if (fr.ShowDialog() == DialogResult.OK)
                    {
                        UrbanDataSet uds = (UrbanDataSet)izvor.DataSource;
                        trenutni = uds.REGUPR.FindByid(int.Parse(fr.id));
                        natpis_plan.Text = trenutni.TIPPLAKT + " " + trenutni.BRSLLST;

                    }
                }
                else
                {
                    MessageBox.Show("Nema rezultata pretrage!!!");
                }
            }
        }

        private void dugme_snimi_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                if (rezim == Rezim.UticajiOd)
                {
                    SqlCommand ddl = new SqlCommand("alter table uticaj disable trigger all", veza);
                    ddl.ExecuteNonQuery();
                }
                string komanda = "";
                if (novi)
                    komanda = "UbaciUticaj";
                else
                    komanda = "IzmeniUticaj";
                SqlCommand kom = new SqlCommand(komanda, veza);
                kom.CommandType = CommandType.StoredProcedure;
                if (novi)
                {
                   
                        kom.Parameters.Add("@od", SqlDbType.Int).Value = id;
                        kom.Parameters.Add("@do", SqlDbType.Int).Value = trenutni.id;
                    
                }
                else
                {
                    if (txtIdut.Text.Length > 0)
                    {
                        OdveziKontrole();
                        kom.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtIdut.Text);
                    }
                    else
                        throw new Exception("Nije izabran ni jedan zapis!");
                }
                kom.Parameters.Add("@opis", SqlDbType.NVarChar).Value = txtOpis.Text;
                kom.Parameters.Add("@datum", SqlDbType.SmallDateTime).Value = izbor_datum.Value;
                kom.Parameters.Add("@tip", SqlDbType.Int).Value = Convert.ToInt32(izbor_tip.SelectedValue);

                kom.ExecuteNonQuery();
                if (rezim == Rezim.UticajiOd)
                {
                    SqlCommand ddl = new SqlCommand("alter table uticaj enable trigger all", veza);
                    ddl.ExecuteNonQuery();
                }
                ProcitajPodatke();

                if (novi)
                {

                    novi = false;
                }
                PoveziKontrole();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Greska u upisu podataka! "+ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (veza!=null && veza.State == ConnectionState.Open)
                    veza.Close();
            }
        }

        private void dugme_novi_Click(object sender, EventArgs e)
        {
            novi = true;
            OdveziKontrole();
            izbor_tip.SelectedIndex = 0;
            txtOpis.Text = naziv;
            izbor_datum.Value = DateTime.Now;
        }

        private void dugme_brisi_Click(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                OdveziKontrole();
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand("ObrisiUticaj", veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@id", SqlDbType.Int).Value = int.Parse(txtIdut.Text);
                kom.ExecuteNonQuery();
                ProcitajPodatke();
                PoveziKontrole();
            }
            catch (SqlException)
            {
                MessageBox.Show("Greska u upisu podataka!");
            }
            finally
            {
                if (veza != null && veza.State == ConnectionState.Open)
                    veza.Close();
            }

        }

        private void izbor_tip_SelectedIndexChanged(object sender, EventArgs e)
        {
           
                txtOpis.Text = izbor_tip.Text + " " + naziv;
           
        }

        private void izbor_tip_Leave(object sender, EventArgs e)
        {
            string provera = izbor_tip.Text;
            DataTable tabela = (DataTable)izbor_tip.DataSource;
            bool ima = false;
            foreach (DataRow red in tabela.Rows)
            {
                if (red[1].ToString().ToUpper().Trim() == provera.ToUpper())
                {
                    ima = true;
                    break;
                }
            }

            if (!ima)
            {
                string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                SqlConnection veza = new SqlConnection(cs);
                veza.Open();
                string naredba = "insert into tip_uticaja(opis) values ('" + izbor_tip.Text.ToUpper() + "')";
                SqlCommand kom = new SqlCommand(naredba, veza);
                kom.ExecuteNonQuery();
                izbor_tip.DataSource = null;
                izbor_tip.DataSource = Tipovi(veza);
                izbor_tip.DisplayMember = "opis";
                izbor_tip.ValueMember = "id";
                izbor_tip.SelectedIndex = izbor_tip.Items.Count - 1;
            }

        }

        private void dugme_deltip_Click(object sender, EventArgs e)
        {
            try
            {
                string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                SqlConnection veza = new SqlConnection(cs);
                veza.Open();
                string naredba = "delete from tip_uticaja where id=" + izbor_tip.SelectedValue.ToString();
                SqlCommand kom = new SqlCommand(naredba, veza);
                kom.ExecuteNonQuery();
                izbor_tip.DataSource = null;
                izbor_tip.DataSource = Tipovi(veza);
                izbor_tip.DisplayMember = "opis";
                izbor_tip.ValueMember = "id";
                izbor_tip.SelectedIndex = izbor_tip.Items.Count - 1;
            }
            catch (SqlException)
            {
                MessageBox.Show("Tip ne moze da se obrise jer ima zapise koji su vezani za njega!");
            }
        }
    }
}