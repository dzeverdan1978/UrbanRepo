using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Configuration;

namespace Urban
{
    public partial class frmSnimanje : Form
    {
        bool cancel = false;

        public frmSnimanje()
        {
            InitializeComponent();
        }

        private void frmSnimanje_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (txtNaziv.Text.Length == 0 && !cancel)
            {
                MessageBox.Show("Naziv fajla mora da se unese!");
                e.Cancel = true;
            }
        }

        public string Nazi
        {
            get
            {
                return txtNaziv.Text;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            cancel = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void frmSnimanje_Load(object sender, EventArgs e)
        {
            try
            {
                string[] fajlovi = Directory.GetFiles(ConfigurationManager.AppSettings["putanja"]);
                if (fajlovi.Length > 0)
                {
                    for (int i = 0; i < fajlovi.Length; i++)
                        fajlovi[i] = Path.GetFileName(fajlovi[i]);

                    lista.DataSource = fajlovi;
                }
            }
            catch
            {
                MessageBox.Show("Greska u pristupu putanji za snimanje!!!");
            }
        }

        private void lista_Click(object sender, EventArgs e)
        {
            if (lista.SelectedItem != null)
                txtNaziv.Text = lista.SelectedItem.ToString();
        }
    }
}