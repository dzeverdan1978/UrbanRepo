namespace Urban
{
    partial class frmProgrami
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
            this.pregled = new System.Windows.Forms.DataGrid();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbSkeniran = new System.Windows.Forms.CheckBox();
            this.CBdIGITALAN = new System.Windows.Forms.CheckBox();
            this.dtDATUM = new System.Windows.Forms.DateTimePicker();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbRealizovan = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtVeza = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.cbObrad = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.cbInicijat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArh = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbTipPlakt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.natpis_filter = new System.Windows.Forms.Label();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.izvor = new System.Windows.Forms.BindingSource(this.components);
            this.dugme_svi = new System.Windows.Forms.Button();
            this.dugme_pretraga = new System.Windows.Forms.Button();
            this.btnDodajPrik = new System.Windows.Forms.Button();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).BeginInit();
            this.SuspendLayout();
            // 
            // pregled
            // 
            this.pregled.AllowSorting = false;
            this.pregled.DataMember = "";
            this.pregled.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pregled.Location = new System.Drawing.Point(14, 37);
            this.pregled.Name = "pregled";
            this.pregled.ReadOnly = true;
            this.pregled.Size = new System.Drawing.Size(856, 199);
            this.pregled.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbSkeniran);
            this.panel1.Controls.Add(this.CBdIGITALAN);
            this.panel1.Controls.Add(this.dtDATUM);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.cbRealizovan);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtVeza);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtKart);
            this.panel1.Controls.Add(this.cbObrad);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtOpstina);
            this.panel1.Controls.Add(this.cbInicijat);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtArh);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.cbTipPlakt);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(14, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(856, 185);
            this.panel1.TabIndex = 1;
            // 
            // cbSkeniran
            // 
            this.cbSkeniran.AutoSize = true;
            this.cbSkeniran.Location = new System.Drawing.Point(730, 132);
            this.cbSkeniran.Name = "cbSkeniran";
            this.cbSkeniran.Size = new System.Drawing.Size(71, 21);
            this.cbSkeniran.TabIndex = 83;
            this.cbSkeniran.Text = "SKEN";
            this.tt.SetToolTip(this.cbSkeniran, "Plan skeniran");
            this.cbSkeniran.UseVisualStyleBackColor = true;
            // 
            // CBdIGITALAN
            // 
            this.CBdIGITALAN.AutoSize = true;
            this.CBdIGITALAN.Location = new System.Drawing.Point(730, 92);
            this.CBdIGITALAN.Name = "CBdIGITALAN";
            this.CBdIGITALAN.Size = new System.Drawing.Size(93, 21);
            this.CBdIGITALAN.TabIndex = 82;
            this.CBdIGITALAN.Text = "VEKTOR";
            this.tt.SetToolTip(this.CBdIGITALAN, "Plan u vektorskom obliku");
            this.CBdIGITALAN.UseVisualStyleBackColor = true;
            // 
            // dtDATUM
            // 
            this.dtDATUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDATUM.Location = new System.Drawing.Point(231, 2);
            this.dtDATUM.Name = "dtDATUM";
            this.dtDATUM.Size = new System.Drawing.Size(133, 23);
            this.dtDATUM.TabIndex = 71;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(463, 96);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(232, 81);
            this.txtNaziv.TabIndex = 69;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            this.txtNaziv.Enter += new System.EventHandler(this.txtNaziv_Enter);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(400, 96);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 70;
            this.label14.Text = "NAZIV";
            // 
            // cbRealizovan
            // 
            this.cbRealizovan.AutoSize = true;
            this.cbRealizovan.Location = new System.Drawing.Point(275, 93);
            this.cbRealizovan.Name = "cbRealizovan";
            this.cbRealizovan.Size = new System.Drawing.Size(127, 21);
            this.cbRealizovan.TabIndex = 66;
            this.cbRealizovan.Text = "REALIZOVAN";
            this.cbRealizovan.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 96);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 17);
            this.label7.TabIndex = 65;
            this.label7.Text = "VEZA";
            // 
            // txtVeza
            // 
            this.txtVeza.Location = new System.Drawing.Point(96, 93);
            this.txtVeza.Name = "txtVeza";
            this.txtVeza.Size = new System.Drawing.Size(148, 23);
            this.txtVeza.TabIndex = 64;
            this.txtVeza.Leave += new System.EventHandler(this.txtVeza_Leave);
            this.txtVeza.Enter += new System.EventHandler(this.txtVeza_Enter);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(599, 48);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 63;
            this.label6.Text = "KARTBR";
            this.tt.SetToolTip(this.label6, "KARTOGRAFSKI BROJ");
            // 
            // txtKart
            // 
            this.txtKart.Location = new System.Drawing.Point(662, 45);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(148, 23);
            this.txtKart.TabIndex = 62;
            this.txtKart.Leave += new System.EventHandler(this.txtKart_Leave);
            this.txtKart.Enter += new System.EventHandler(this.txtKart_Enter);
            // 
            // cbObrad
            // 
            this.cbObrad.FormattingEnabled = true;
            this.cbObrad.Items.AddRange(new object[] {
            "UP",
            "PP",
            "OST",
            "GUP",
            "RP",
            "PAR",
            "DUP",
            "PRIV",
            "PGR",
            "DRUP",
            "STR",
            "GP",
            "UUP",
            "PDR",
            "POU"});
            this.cbObrad.Location = new System.Drawing.Point(369, 45);
            this.cbObrad.Name = "cbObrad";
            this.cbObrad.Size = new System.Drawing.Size(221, 25);
            this.cbObrad.TabIndex = 60;
            this.cbObrad.Leave += new System.EventHandler(this.cbObrad_Leave);
            this.cbObrad.Enter += new System.EventHandler(this.cbObrad_Enter);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(281, 48);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 17);
            this.label5.TabIndex = 61;
            this.label5.Text = "OBRADJIVAC";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 59;
            this.label4.Text = "OPSTINA";
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // txtOpstina
            // 
            this.txtOpstina.Location = new System.Drawing.Point(83, 45);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(180, 23);
            this.txtOpstina.TabIndex = 58;
            this.txtOpstina.Leave += new System.EventHandler(this.txtOpstina_Leave);
            this.txtOpstina.Enter += new System.EventHandler(this.txtOpstina_Enter);
            // 
            // cbInicijat
            // 
            this.cbInicijat.FormattingEnabled = true;
            this.cbInicijat.Items.AddRange(new object[] {
            "UP",
            "PP",
            "OST",
            "GUP",
            "RP",
            "PAR",
            "DUP",
            "PRIV",
            "PGR",
            "DRUP",
            "STR",
            "GP",
            "UUP",
            "PDR",
            "POU"});
            this.cbInicijat.Location = new System.Drawing.Point(631, 5);
            this.cbInicijat.Name = "cbInicijat";
            this.cbInicijat.Size = new System.Drawing.Size(204, 25);
            this.cbInicijat.TabIndex = 56;
            this.cbInicijat.Leave += new System.EventHandler(this.cbInicijat_Leave);
            this.cbInicijat.Enter += new System.EventHandler(this.cbInicijat_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(557, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 57;
            this.label2.Text = "INICIJAT";
            this.tt.SetToolTip(this.label2, "INICIJATOR");
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(366, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 55;
            this.label8.Text = "ARHBR";
            this.tt.SetToolTip(this.label8, "ARHIVSKI BROJ");
            // 
            // txtArh
            // 
            this.txtArh.Location = new System.Drawing.Point(422, 7);
            this.txtArh.Name = "txtArh";
            this.txtArh.Size = new System.Drawing.Size(123, 23);
            this.txtArh.TabIndex = 54;
            this.txtArh.Leave += new System.EventHandler(this.txtArh_Leave);
            this.txtArh.Enter += new System.EventHandler(this.txtArh_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(168, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 43;
            this.label3.Text = "DATUM";
            // 
            // cbTipPlakt
            // 
            this.cbTipPlakt.FormattingEnabled = true;
            this.cbTipPlakt.Items.AddRange(new object[] {
            "UP",
            "PP",
            "OST",
            "GUP",
            "RP",
            "PAR",
            "DUP",
            "PRIV",
            "PGR",
            "DRUP",
            "STR",
            "GP",
            "UUP",
            "PDR",
            "POU"});
            this.cbTipPlakt.Location = new System.Drawing.Point(83, 3);
            this.cbTipPlakt.Name = "cbTipPlakt";
            this.cbTipPlakt.Size = new System.Drawing.Size(79, 25);
            this.cbTipPlakt.TabIndex = 3;
            this.cbTipPlakt.Leave += new System.EventHandler(this.cbTipPlakt_Leave);
            this.cbTipPlakt.Enter += new System.EventHandler(this.cbTipPlakt_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 4;
            this.label1.Text = "TIPPLAKT";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 10000;
            this.tt.InitialDelay = 500;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 100;
            // 
            // natpis_filter
            // 
            this.natpis_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.natpis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpis_filter.Location = new System.Drawing.Point(226, 9);
            this.natpis_filter.Name = "natpis_filter";
            this.natpis_filter.Size = new System.Drawing.Size(404, 25);
            this.natpis_filter.TabIndex = 10;
            this.natpis_filter.Text = "label17";
            this.natpis_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(299, 433);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 6;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(155, 433);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 5;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(14, 433);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 3;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // dugme_svi
            // 
            this.dugme_svi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_svi.Image = global::Urban.Properties.Resources.globe;
            this.dugme_svi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_svi.Location = new System.Drawing.Point(735, 433);
            this.dugme_svi.Name = "dugme_svi";
            this.dugme_svi.Size = new System.Drawing.Size(135, 40);
            this.dugme_svi.TabIndex = 12;
            this.dugme_svi.Text = "Svi podaci";
            this.dugme_svi.UseVisualStyleBackColor = true;
            this.dugme_svi.Click += new System.EventHandler(this.dugme_svi_Click);
            // 
            // dugme_pretraga
            // 
            this.dugme_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_pretraga.Image = global::Urban.Properties.Resources.search;
            this.dugme_pretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_pretraga.Location = new System.Drawing.Point(585, 433);
            this.dugme_pretraga.Name = "dugme_pretraga";
            this.dugme_pretraga.Size = new System.Drawing.Size(135, 40);
            this.dugme_pretraga.TabIndex = 11;
            this.dugme_pretraga.Text = "Pretraga";
            this.dugme_pretraga.UseVisualStyleBackColor = true;
            this.dugme_pretraga.Click += new System.EventHandler(this.dugme_pretraga_Click);
            // 
            // btnDodajPrik
            // 
            this.btnDodajPrik.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.btnDodajPrik.Location = new System.Drawing.Point(440, 440);
            this.btnDodajPrik.Name = "btnDodajPrik";
            this.btnDodajPrik.Size = new System.Drawing.Size(122, 23);
            this.btnDodajPrik.TabIndex = 13;
            this.btnDodajPrik.Text = "Dodaj prikazane";
            this.btnDodajPrik.UseVisualStyleBackColor = true;
            this.btnDodajPrik.Visible = false;
            this.btnDodajPrik.Click += new System.EventHandler(this.btnDodajPrik_Click);
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::Urban.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(832, 1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(38, 40);
            this.btnExcel.TabIndex = 27;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Image = global::Urban.Properties.Resources.search4printer;
            this.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampa.Location = new System.Drawing.Point(14, 3);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(135, 31);
            this.btnStampa.TabIndex = 28;
            this.btnStampa.Text = "Štampanje";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Visible = false;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // frmProgrami
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(884, 475);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.btnDodajPrik);
            this.Controls.Add(this.dugme_svi);
            this.Controls.Add(this.dugme_pretraga);
            this.Controls.Add(this.natpis_filter);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pregled);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmProgrami";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Evidencija programa";
            this.Load += new System.EventHandler(this.frmProgrami_Load);
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProgrami_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid pregled;
        private System.Windows.Forms.BindingSource izvor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cbTipPlakt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbInicijat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.ComboBox cbObrad;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtVeza;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKart;
        private System.Windows.Forms.CheckBox cbRealizovan;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.Label natpis_filter;
        private System.Windows.Forms.Button dugme_svi;
        private System.Windows.Forms.Button dugme_pretraga;
        private System.Windows.Forms.Button btnDodajPrik;
        private System.Windows.Forms.DateTimePicker dtDATUM;
        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.CheckBox cbSkeniran;
        private System.Windows.Forms.CheckBox CBdIGITALAN;
        private System.Windows.Forms.Button btnStampa;
    }
}