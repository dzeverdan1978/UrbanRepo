using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using System.Data.SqlClient;
using System.Configuration;

namespace Urban
{
    public partial class frmNaziv : Form
    {
        DataTable izdop=new DataTable("izdop");
        public int plan;
        bool novi;
        public bool azur = true;

        public frmNaziv()
        {
            InitializeComponent();
        }

        public string NazivText
        {
            get
            {
                return txtNaziv.Text;
            }
            set
            {
                txtNaziv.Text = value;
            }
        }

        private void frmNaziv_Load(object sender, EventArgs e)
        {
            ProcitajPodatke();
            txtOpis.DataBindings.Add("Text", izdop, "opis");
            if (!azur)
            {
                dugme_brisi.Enabled = false;
                dugme_novi.Enabled = false;
                dugme_snimi.Enabled = false;
            }
        }

        private void ProcitajPodatke()
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand("DajIzdop", veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                kom.Parameters.Add("@kombinovani", SqlDbType.Bit).Value = 0;
                SqlDataAdapter filter = new SqlDataAdapter();
                filter.SelectCommand = kom;
                if (izdop.Rows.Count > 0)
                    izdop.Rows.Clear();
                filter.Fill(izdop);
                prikaz.DataSource = izdop;
                
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

        private void dugme_novi_Click(object sender, EventArgs e)
        {
            novi = true;
            txtOpis.DataBindings.Clear();
            txtOpis.Text = "";
        }

        private void dugme_snimi_Click(object sender, EventArgs e)
        {
            string naredba = "";
            if (novi)
                naredba = "UbaciIzdop";
            else
                naredba = "IzmeniIzdop";
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand(naredba, veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                kom.Parameters.Add("@opis", SqlDbType.NVarChar).Value = txtOpis.Text;
                if (!novi)
                    kom.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(izdop.Rows[prikaz.CurrentRowIndex]["id"]);
                kom.ExecuteNonQuery();

                if (txtOpis.DataBindings.Count > 0)
                    txtOpis.DataBindings.Clear();
                ProcitajPodatke();
                txtOpis.DataBindings.Add("Text", izdop, "opis");
                novi = false;

            }
            catch (SqlException)
            {
                MessageBox.Show("Greska u snimanju izmene/dopune!");
            }
            finally
            {
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }

        }

        private void dugme_brisi_Click(object sender, EventArgs e)
        {
            if (prikaz.CurrentRowIndex >= 0)
            {
                string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
                SqlConnection veza = null;
                try
                {
                    veza = new SqlConnection(cs);
                    veza.Open();
                    SqlCommand kom = new SqlCommand("BrisiIzdop", veza);
                    kom.CommandType = CommandType.StoredProcedure;
                    kom.Parameters.Add("@id", SqlDbType.Int).Value = Convert.ToInt32(izdop.Rows[prikaz.CurrentRowIndex]["id"]);
                    kom.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                    kom.ExecuteNonQuery();

                    if (txtOpis.DataBindings.Count > 0)
                        txtOpis.DataBindings.Clear();
                    ProcitajPodatke();
                    txtOpis.DataBindings.Add("Text", izdop, "opis");
                }
                catch (SqlException)
                {
                    MessageBox.Show("Greska u brisanju izmene/dopune!");
                }
                finally
                {
                    if (veza.State == ConnectionState.Open)
                        veza.Close();
                }
            }
            else
                MessageBox.Show("Nije izabran ni jedan zapis!");
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}