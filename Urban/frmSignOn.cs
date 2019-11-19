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
    public partial class frmSignOn : Form
    {
        DataRow korisnik;
        public frmPocetak pocetna;

        public frmSignOn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string greska = "";
            if (unos_un.Text.Length==0)
                greska="Korisnicko ime nije uneto!";
            if (unos_pwd.Text.Length==0)
                greska="Lozinka nije uneta!";
            if (greska.Length==0)
            {
            string cs = ConfigurationManager.ConnectionStrings["Urban.Properties.Settings.UrbanConnectionString"].ConnectionString;
            SqlConnection veza = null;
            try
            {
                veza = new SqlConnection(cs);
                veza.Open();
                SqlCommand kom = new SqlCommand("DajKorisnika", veza);
                kom.CommandType = CommandType.StoredProcedure;
                kom.Parameters.Add("@username", SqlDbType.NVarChar).Value = unos_un.Text;
                kom.Parameters.Add("@password", SqlDbType.NVarChar).Value = unos_pwd.Text;
                SqlDataAdapter filter = new SqlDataAdapter("DajKorisnika",veza);
                filter.SelectCommand = kom;
                DataTable temp = new DataTable();
                filter.Fill(temp);
                if (temp.Rows.Count > 0)
                {
                    korisnik = temp.Rows[0];
                    Form1 f1 = new Form1();
                    f1.korisnik = korisnik;
                    f1.glavna = pocetna;
                    f1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Zadati korisnik ne postoji", "Greska",
                        MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Greska u pristupu bazi:"+ex.Message);
            }
            finally
            {
                if (veza.State == ConnectionState.Open)
                    veza.Close();
            }
            }
            else
            {
                MessageBox.Show(greska,"Greska",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }

        private void frmSignOn_VisibleChanged(object sender, EventArgs e)
        {
            if (this.Visible)
            {
                unos_pwd.Text = "";
                unos_un.Text = "";
                unos_un.Focus();
            }
        }

        private void unos_un_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                unos_pwd.Focus();
        }

        private void unos_pwd_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                button1.Focus();
        }

        private void frmSignOn_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (pocetna.Visible==false)
                pocetna.Show();
        }
    }
}