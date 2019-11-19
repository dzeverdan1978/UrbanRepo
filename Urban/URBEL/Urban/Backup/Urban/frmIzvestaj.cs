using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;


namespace Urban
{
    public partial class frmIzvestaj : Form
    {
        public dsIzvestaj di;
        public string naziv;
        public dsZaduzenja dz;
        public dsDOC docs;
        public dsProgrami progs;
        public bool izvestaj;
        public bool urbdoc;
        public bool programi;

        public frmIzvestaj()
        {
            InitializeComponent();
        }

        private void frmIzvestaj_Load(object sender, EventArgs e)
        {
            try
            {
                ReportDocument rd = new ReportDocument();
                if (izvestaj)
                {
                    rd.Load(@Application.StartupPath + "\\rptRegupr.rpt");
                    rd.SetDataSource(di);
                }
                else if (!urbdoc)
                {
                    if (!programi)
                    {
                        rd.Load(@Application.StartupPath + "\\rptZaduzenja.rpt");
                        rd.SetDataSource(dz);
                    }
                    else
                    {
                        rd.Load(@Application.StartupPath + "\\rptProgrami.rpt");
                        rd.SetDataSource(progs);
                    }
                }
                else
                {
                    rd.Load(@Application.StartupPath + "\\rptDOC.rpt");
                    rd.SetDataSource(docs);
                }


                rv.ReportSource = rd;
                rv.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message+" "+ex.InnerException);
            }
        }
    }
}