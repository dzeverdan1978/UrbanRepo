namespace Urban
{
    partial class frmIzvestaj
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmIzvestaj));
            this.rv = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // rv
            // 
            this.rv.ActiveViewIndex = -1;
            this.rv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rv.Cursor = System.Windows.Forms.Cursors.Default;
            this.rv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rv.Location = new System.Drawing.Point(0, 0);
            this.rv.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rv.Name = "rv";
            this.rv.SelectionFormula = "";
            this.rv.Size = new System.Drawing.Size(727, 442);
            this.rv.TabIndex = 0;
            this.rv.ToolPanelWidth = 267;
            this.rv.ViewTimeSelectionFormula = "";
            // 
            // frmIzvestaj
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(727, 442);
            this.Controls.Add(this.rv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmIzvestaj";
            this.Text = "Izvestaj";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmIzvestaj_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer rv;
    }
}