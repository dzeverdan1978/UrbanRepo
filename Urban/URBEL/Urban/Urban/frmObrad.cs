using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Urban
{
    public partial class frmObrad : Form
    {
        public UrbanDataSet podaci;
        public DataRow korisnik;
        public int plan;
        DataTable obradjivaci;
        DataTable novi;

        public frmObrad()
        {
            InitializeComponent();
        }

        private void frmObrad_Load(object sender, EventArgs e)
        {
            if ((bool)korisnik["azur"] || (bool)korisnik["admi"])
                podloga.Visible = true;

            lblSvi.DataSource = podaci.Firma;
            lblSvi.DisplayMember = "naziv";
            lblSvi.ValueMember = "id";

            DajObradjivace();

            novi = podaci.Firma.Clone();
            lblNovi.DataSource = novi;
            lblNovi.DisplayMember="naziv";
                lblNovi.ValueMember="id";
        }

        void DajObradjivace()
        {
            try
            {
                UrbanDataSetTableAdapters.FirmaTableAdapter ta = new Urban.UrbanDataSetTableAdapters.FirmaTableAdapter();
                SqlCommand cmd = new SqlCommand("DajObradjivace", ta.Connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                if (ta.Connection.State == ConnectionState.Closed)
                    ta.Connection.Open();
                SqlDataReader rd = cmd.ExecuteReader();
                obradjivaci = new DataTable();
                obradjivaci.Load(rd);
                rd.Close();
                lblPostojeci.DataSource = obradjivaci;
                lblPostojeci.DisplayMember = "naziv";
                lblPostojeci.ValueMember = "id";
            }
            catch (SqlException)
            {
                MessageBox.Show("Greska u citanju podataka!");
            }
        }

        private void btnOduzmi_Click(object sender, EventArgs e)
        {
            if (lblNovi.SelectedIndex >= 0)
            {
                novi.Rows.RemoveAt(lblNovi.SelectedIndex);
                lblNovi.DataSource = null;
                lblNovi.DataSource = novi;
                lblNovi.DisplayMember = "naziv";
                lblNovi.ValueMember = "id";
                
            }
        }

        private void btnDodaj_Click(object sender, EventArgs e)
        {
            if (txtNovi.Text.Length > 0)
            {
                UrbanDataSet.FirmaRow f = podaci.Firma.NewFirmaRow();
                f.naziv = txtNovi.Text;
                podaci.Firma.Rows.Add(f);
                lblSvi.SelectedIndex = lblSvi.Items.Count - 1;

                UrbanDataSetTableAdapters.FirmaTableAdapter ta = new Urban.UrbanDataSetTableAdapters.FirmaTableAdapter();
                ta.Update(podaci.Firma);
                podaci.Firma.AcceptChanges();

            }

            UrbanDataSet.FirmaRow kandidat = podaci.Firma[lblSvi.SelectedIndex];
            DataRow[] test = novi.Select("id=" + kandidat.id.ToString());
            if (test.Length == 0)
                novi.ImportRow(kandidat);
            else
                MessageBox.Show("Obradjivac je vec dodat za dati plan");
            txtNovi.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlTransaction tran = null;
            try
            {
                if (novi.Rows.Count > 0)
                {
                    UrbanDataSetTableAdapters.FirmaTableAdapter ta = new Urban.UrbanDataSetTableAdapters.FirmaTableAdapter();
                    
                    if (ta.Connection.State == ConnectionState.Closed)
                        ta.Connection.Open();
                    tran = ta.Connection.BeginTransaction();

                    foreach (UrbanDataSet.FirmaRow red in novi.Rows)
                    {
                        SqlCommand cmd = new SqlCommand("DodajObradjivaca", ta.Connection);
                        cmd.CommandType = CommandType.StoredProcedure;
                        cmd.Transaction = tran;
                        cmd.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                        cmd.Parameters.Add("@firma", SqlDbType.Int).Value = red.id;
                        cmd.ExecuteNonQuery();
                    }
                    tran.Commit();
                    DajObradjivace();
                }
            }
            catch (SqlException ex)
            {
                if (tran != null && tran.Connection != null)
                    tran.Rollback();
                MessageBox.Show("Greska u dodavanju obradjivaca!"+ex.Message);
            }
        }

        private void lblPostojeci_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && lblPostojeci.SelectedIndex >= 0 && ((bool)korisnik["azur"] || (bool)korisnik["admi"]))
            {
                try
                {
                    UrbanDataSetTableAdapters.FirmaTableAdapter ta = new Urban.UrbanDataSetTableAdapters.FirmaTableAdapter();
                    SqlCommand cmd = new SqlCommand("BrisiObradjivaca", ta.Connection);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@plan", SqlDbType.Int).Value = plan;
                    cmd.Parameters.Add("@firma", SqlDbType.Int).Value = Convert.ToInt32(lblPostojeci.SelectedValue);
                    if (ta.Connection.State == ConnectionState.Closed)
                        ta.Connection.Open();
                    cmd.ExecuteNonQuery();
                    DajObradjivace();

                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Greska u brisanju podataka!"+ex.Message);
                }
            }
        }
    }
}
