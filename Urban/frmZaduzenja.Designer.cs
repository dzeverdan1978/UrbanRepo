namespace Urban
{
    partial class frmZaduzenja
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
            this.components = new System.ComponentModel.Container();
            this.natpis_filter = new System.Windows.Forms.Label();
            this.pregled = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbRazduzen = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuznik = new System.Windows.Forms.TextBox();
            this.dtDATUM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.dugme_svi = new System.Windows.Forms.Button();
            this.dugme_pretraga = new System.Windows.Forms.Button();
            this.izvor = new System.Windows.Forms.BindingSource(this.components);
            this.btnStampa = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.lblAlarm = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).BeginInit();
            this.SuspendLayout();
            // 
            // natpis_filter
            // 
            this.natpis_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.natpis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpis_filter.Location = new System.Drawing.Point(169, 9);
            this.natpis_filter.Name = "natpis_filter";
            this.natpis_filter.Size = new System.Drawing.Size(471, 25);
            this.natpis_filter.TabIndex = 11;
            this.natpis_filter.Text = "label17";
            this.natpis_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pregled
            // 
            this.pregled.AllowSorting = false;
            this.pregled.DataMember = "";
            this.pregled.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pregled.Location = new System.Drawing.Point(14, 37);
            this.pregled.Name = "pregled";
            this.pregled.ReadOnly = true;
            this.pregled.Size = new System.Drawing.Size(779, 172);
            this.pregled.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblAlarm);
            this.panel1.Controls.Add(this.txtNapomena);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.cbRazduzen);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtDuznik);
            this.panel1.Controls.Add(this.dtDATUM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSifra);
            this.panel1.Location = new System.Drawing.Point(14, 215);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 178);
            this.panel1.TabIndex = 13;
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(564, 77);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNapomena.Size = new System.Drawing.Size(210, 56);
            this.txtNapomena.TabIndex = 79;
            this.txtNapomena.Leave += new System.EventHandler(this.txtNapomena_Leave);
            this.txtNapomena.Enter += new System.EventHandler(this.txtNapomena_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(561, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 80;
            this.label4.Text = "NAPOMENA";
            // 
            // cbRazduzen
            // 
            this.cbRazduzen.FormattingEnabled = true;
            this.cbRazduzen.Location = new System.Drawing.Point(370, 80);
            this.cbRazduzen.Name = "cbRazduzen";
            this.cbRazduzen.Size = new System.Drawing.Size(138, 25);
            this.cbRazduzen.TabIndex = 77;
            this.cbRazduzen.Leave += new System.EventHandler(this.cbRazduzen_Leave);
            this.cbRazduzen.Enter += new System.EventHandler(this.cbRazduzen_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "RAZDUŽEN";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "DUŽNIK";
            // 
            // txtDuznik
            // 
            this.txtDuznik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDuznik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDuznik.Location = new System.Drawing.Point(64, 85);
            this.txtDuznik.Name = "txtDuznik";
            this.txtDuznik.Size = new System.Drawing.Size(216, 23);
            this.txtDuznik.TabIndex = 75;
            this.txtDuznik.Layout += new System.Windows.Forms.LayoutEventHandler(this.txtDuznik_Layout);
            this.txtDuznik.Leave += new System.EventHandler(this.txtDuznik_Leave);
            this.txtDuznik.Enter += new System.EventHandler(this.txtDuznik_Enter);
            // 
            // dtDATUM
            // 
            this.dtDATUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDATUM.Location = new System.Drawing.Point(588, 8);
            this.dtDATUM.Name = "dtDATUM";
            this.dtDATUM.Size = new System.Drawing.Size(133, 23);
            this.dtDATUM.TabIndex = 74;
            this.dtDATUM.Leave += new System.EventHandler(this.dtDATUM_Leave);
            this.dtDATUM.Enter += new System.EventHandler(this.dtDATUM_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(525, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 73;
            this.label3.Text = "DATUM";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(277, 15);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(231, 55);
            this.txtNaziv.TabIndex = 71;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            this.txtNaziv.Enter += new System.EventHandler(this.txtNaziv_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(214, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 72;
            this.label14.Text = "NAZIV";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "ŠIFRA";
            // 
            // txtSifra
            // 
            this.txtSifra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSifra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSifra.Location = new System.Drawing.Point(53, 12);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(148, 23);
            this.txtSifra.TabIndex = 64;
            this.txtSifra.TextChanged += new System.EventHandler(this.txtSifra_TextChanged);
            this.txtSifra.Leave += new System.EventHandler(this.txtSifra_Leave);
            this.txtSifra.Enter += new System.EventHandler(this.txtSifra_Enter);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(297, 403);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 16;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(153, 403);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 15;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(12, 403);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 14;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // dugme_svi
            // 
            this.dugme_svi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_svi.Image = global::Urban.Properties.Resources.globe;
            this.dugme_svi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_svi.Location = new System.Drawing.Point(669, 399);
            this.dugme_svi.Name = "dugme_svi";
            this.dugme_svi.Size = new System.Drawing.Size(135, 40);
            this.dugme_svi.TabIndex = 18;
            this.dugme_svi.Text = "Svi podaci";
            this.dugme_svi.UseVisualStyleBackColor = true;
            this.dugme_svi.Click += new System.EventHandler(this.dugme_svi_Click);
            // 
            // dugme_pretraga
            // 
            this.dugme_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_pretraga.Image = global::Urban.Properties.Resources.search;
            this.dugme_pretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_pretraga.Location = new System.Drawing.Point(519, 399);
            this.dugme_pretraga.Name = "dugme_pretraga";
            this.dugme_pretraga.Size = new System.Drawing.Size(135, 40);
            this.dugme_pretraga.TabIndex = 17;
            this.dugme_pretraga.Text = "Pretraga";
            this.dugme_pretraga.UseVisualStyleBackColor = true;
            this.dugme_pretraga.Click += new System.EventHandler(this.dugme_pretraga_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Image = global::Urban.Properties.Resources.search4printer;
            this.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampa.Location = new System.Drawing.Point(14, 3);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(135, 31);
            this.btnStampa.TabIndex = 19;
            this.btnStampa.Text = "Štampanje";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Visible = false;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::Urban.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(755, -2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(38, 40);
            this.btnExcel.TabIndex = 20;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // lblAlarm
            // 
            this.lblAlarm.AutoSize = true;
            this.lblAlarm.BackColor = System.Drawing.Color.Red;
            this.lblAlarm.Location = new System.Drawing.Point(4, 143);
            this.lblAlarm.Name = "lblAlarm";
            this.lblAlarm.Size = new System.Drawing.Size(233, 17);
            this.lblAlarm.TabIndex = 81;
            this.lblAlarm.Text = "Zaduženje je duže od 60 dana!";
            this.lblAlarm.Visible = false;
            // 
            // frmZaduzenja
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(807, 442);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.dugme_svi);
            this.Controls.Add(this.dugme_pretraga);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.natpis_filter);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmZaduzenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EVIDENCIJA ZADUZENJA";
            this.Load += new System.EventHandler(this.frmZaduzenja_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmZaduzenja_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label natpis_filter;
        private System.Windows.Forms.DataGrid pregled;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuznik;
        private System.Windows.Forms.DateTimePicker dtDATUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbRazduzen;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.Button dugme_svi;
        private System.Windows.Forms.Button dugme_pretraga;
        private System.Windows.Forms.BindingSource izvor;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Label lblAlarm;
    }
}