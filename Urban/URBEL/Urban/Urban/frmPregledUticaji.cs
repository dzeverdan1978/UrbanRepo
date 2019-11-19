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
    public partial class frmPregledUticaji : Form
    {
        public int id;
        DataTable na;

        public frmPregledUticaji()
        {
            InitializeComponent();
        }

        private void frmPregledUticaji_Load(object sender, EventArgs e)
        {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                na = new DataTable();
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand("UticajiOd", veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@id", SqlDbType.Int).Value = id;
                SqlDataAdapter filter = new SqlDataAdapter();
                filter.SelectCommand = kom;
                filter.Fill(na);
                prikaz.DataSource = na;

                txtOpis.DataBindings.Add("Text", na, "opisut");
                txtDatum.DataBindings.Add("Text", na, "datut");
                txtTip.DataBindings.Add("Text", na, "opistip");
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
    }
}