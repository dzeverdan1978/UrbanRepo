namespace Urban
{
    partial class frmDOC
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
            this.txtTIPDOC = new System.Windows.Forms.TextBox();
            this.txtInref = new System.Windows.Forms.TextBox();
            this.txtOsnov = new System.Windows.Forms.TextBox();
            this.txtOPSTINA = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMatr = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBRKAT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKATOPST = new System.Windows.Forms.TextBox();
            this.txtNAPOMENA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtARHBRDOC = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtARHBR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtREGB = new System.Windows.Forms.TextBox();
            this.dtDATUM = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBR = new System.Windows.Forms.TextBox();
            this.dugme_svi = new System.Windows.Forms.Button();
            this.dugme_pretraga = new System.Windows.Forms.Button();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.izvor = new System.Windows.Forms.BindingSource(this.components);
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.btnExcel = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).BeginInit();
            this.SuspendLayout();
            // 
            // natpis_filter
            // 
            this.natpis_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.natpis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpis_filter.Location = new System.Drawing.Point(223, 9);
            this.natpis_filter.Name = "natpis_filter";
            this.natpis_filter.Size = new System.Drawing.Size(404, 25);
            this.natpis_filter.TabIndex = 12;
            this.natpis_filter.Text = "label17";
            this.natpis_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pregled
            // 
            this.pregled.AllowSorting = false;
            this.pregled.DataMember = "";
            this.pregled.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pregled.Location = new System.Drawing.Point(11, 37);
            this.pregled.Name = "pregled";
            this.pregled.ReadOnly = true;
            this.pregled.Size = new System.Drawing.Size(912, 199);
            this.pregled.TabIndex = 11;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txtTIPDOC);
            this.panel1.Controls.Add(this.txtInref);
            this.panel1.Controls.Add(this.txtOsnov);
            this.panel1.Controls.Add(this.txtOPSTINA);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtMatr);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtBRKAT);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtKATOPST);
            this.panel1.Controls.Add(this.txtNAPOMENA);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtARHBRDOC);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtARHBR);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtBIB);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtREGB);
            this.panel1.Controls.Add(this.dtDATUM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBR);
            this.panel1.Location = new System.Drawing.Point(11, 242);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(912, 185);
            this.panel1.TabIndex = 13;
            // 
            // txtTIPDOC
            // 
            this.txtTIPDOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTIPDOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTIPDOC.Location = new System.Drawing.Point(234, 143);
            this.txtTIPDOC.Name = "txtTIPDOC";
            this.txtTIPDOC.Size = new System.Drawing.Size(80, 23);
            this.txtTIPDOC.TabIndex = 14;
            this.txtTIPDOC.Enter += new System.EventHandler(this.txtTIPDOC_Enter);
            this.txtTIPDOC.Leave += new System.EventHandler(this.txtTIPDOC_Leave);
            // 
            // txtInref
            // 
            this.txtInref.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtInref.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtInref.Location = new System.Drawing.Point(75, 143);
            this.txtInref.Name = "txtInref";
            this.txtInref.Size = new System.Drawing.Size(80, 23);
            this.txtInref.TabIndex = 13;
            this.txtInref.Enter += new System.EventHandler(this.txtInref_Enter);
            this.txtInref.Leave += new System.EventHandler(this.txtInref_Leave);
            // 
            // txtOsnov
            // 
            this.txtOsnov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOsnov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOsnov.Location = new System.Drawing.Point(61, 84);
            this.txtOsnov.Name = "txtOsnov";
            this.txtOsnov.Size = new System.Drawing.Size(273, 23);
            this.txtOsnov.TabIndex = 7;
            this.txtOsnov.Enter += new System.EventHandler(this.txtOsnov_Enter);
            this.txtOsnov.Leave += new System.EventHandler(this.txtOsnov_Leave);
            // 
            // txtOPSTINA
            // 
            this.txtOPSTINA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOPSTINA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOPSTINA.Location = new System.Drawing.Point(86, 33);
            this.txtOPSTINA.Name = "txtOPSTINA";
            this.txtOPSTINA.Size = new System.Drawing.Size(223, 23);
            this.txtOPSTINA.TabIndex = 6;
            this.txtOPSTINA.Enter += new System.EventHandler(this.txtOPSTINA_Enter);
            this.txtOPSTINA.Leave += new System.EventHandler(this.txtOPSTINA_Leave);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(175, 146);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 99;
            this.label15.Text = "TIPDOC";
            this.label15.MouseHover += new System.EventHandler(this.label15_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(26, 146);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 97;
            this.label13.Text = "INREF";
            this.tt.SetToolTip(this.label13, "Predmet obradio/la");
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(517, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 95;
            this.label12.Text = "MATR";
            this.tt.SetToolTip(this.label12, "Broj arhiva matrica");
            // 
            // txtMatr
            // 
            this.txtMatr.Location = new System.Drawing.Point(565, 114);
            this.txtMatr.Name = "txtMatr";
            this.txtMatr.Size = new System.Drawing.Size(74, 23);
            this.txtMatr.TabIndex = 12;
            this.txtMatr.Enter += new System.EventHandler(this.txtMatr_Enter);
            this.txtMatr.Leave += new System.EventHandler(this.txtMatr_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(219, 117);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 93;
            this.label11.Text = "BRKATPAR";
            this.tt.SetToolTip(this.label11, "Broj katastarske parcele");
            // 
            // txtBRKAT
            // 
            this.txtBRKAT.Location = new System.Drawing.Point(297, 117);
            this.txtBRKAT.Name = "txtBRKAT";
            this.txtBRKAT.Size = new System.Drawing.Size(207, 23);
            this.txtBRKAT.TabIndex = 11;
            this.txtBRKAT.Enter += new System.EventHandler(this.txtBRKAT_Enter);
            this.txtBRKAT.Leave += new System.EventHandler(this.txtBRKAT_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 91;
            this.label10.Text = "KATOPST";
            this.tt.SetToolTip(this.label10, "Šifra katastarske opštine");
            // 
            // txtKATOPST
            // 
            this.txtKATOPST.Location = new System.Drawing.Point(76, 117);
            this.txtKATOPST.Name = "txtKATOPST";
            this.txtKATOPST.Size = new System.Drawing.Size(141, 23);
            this.txtKATOPST.TabIndex = 10;
            this.txtKATOPST.Enter += new System.EventHandler(this.txtKATOPST_Enter);
            this.txtKATOPST.Leave += new System.EventHandler(this.txtKATOPST_Leave);
            // 
            // txtNAPOMENA
            // 
            this.txtNAPOMENA.Location = new System.Drawing.Point(664, 39);
            this.txtNAPOMENA.Multiline = true;
            this.txtNAPOMENA.Name = "txtNAPOMENA";
            this.txtNAPOMENA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNAPOMENA.Size = new System.Drawing.Size(211, 68);
            this.txtNAPOMENA.TabIndex = 9;
            this.txtNAPOMENA.Enter += new System.EventHandler(this.txtNAPOMENA_Enter);
            this.txtNAPOMENA.Leave += new System.EventHandler(this.txtNAPOMENA_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(582, 39);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 89;
            this.label9.Text = "NAPOMENA";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(365, 39);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(211, 68);
            this.txtNaziv.TabIndex = 8;
            this.txtNaziv.Enter += new System.EventHandler(this.txtNaziv_Enter);
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(315, 39);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 87;
            this.label14.Text = "NAZIV";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 87);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 85;
            this.label8.Text = "OSNOV";
            this.tt.SetToolTip(this.label8, "Planski i pravni osnov");
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 39);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 17);
            this.label6.TabIndex = 83;
            this.label6.Text = "OPSTINA";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(719, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 81;
            this.label5.Text = "ARHBRDOC";
            this.tt.SetToolTip(this.label5, "Arhivski broj dozvole, predmeta");
            // 
            // txtARHBRDOC
            // 
            this.txtARHBRDOC.Location = new System.Drawing.Point(801, 2);
            this.txtARHBRDOC.Name = "txtARHBRDOC";
            this.txtARHBRDOC.Size = new System.Drawing.Size(104, 23);
            this.txtARHBRDOC.TabIndex = 5;
            this.txtARHBRDOC.Enter += new System.EventHandler(this.txtARHBRDOC_Enter);
            this.txtARHBRDOC.Leave += new System.EventHandler(this.txtARHBRDOC_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(560, 6);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 79;
            this.label4.Text = "ARHBR";
            this.tt.SetToolTip(this.label4, "Arhivski broj");
            // 
            // txtARHBR
            // 
            this.txtARHBR.Location = new System.Drawing.Point(611, 3);
            this.txtARHBR.Name = "txtARHBR";
            this.txtARHBR.Size = new System.Drawing.Size(104, 23);
            this.txtARHBR.TabIndex = 4;
            this.txtARHBR.Enter += new System.EventHandler(this.txtARHBR_Enter);
            this.txtARHBR.Leave += new System.EventHandler(this.txtARHBR_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(444, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 77;
            this.label2.Text = "BIB";
            this.tt.SetToolTip(this.label2, "Bibliotecki broj");
            // 
            // txtBIB
            // 
            this.txtBIB.Location = new System.Drawing.Point(483, 3);
            this.txtBIB.Name = "txtBIB";
            this.txtBIB.Size = new System.Drawing.Size(71, 23);
            this.txtBIB.TabIndex = 3;
            this.txtBIB.Enter += new System.EventHandler(this.txtBIB_Enter);
            this.txtBIB.Leave += new System.EventHandler(this.txtBIB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(309, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 75;
            this.label1.Text = "REGB";
            this.tt.SetToolTip(this.label1, "Registarski broj");
            // 
            // txtREGB
            // 
            this.txtREGB.Location = new System.Drawing.Point(358, 3);
            this.txtREGB.Name = "txtREGB";
            this.txtREGB.Size = new System.Drawing.Size(80, 23);
            this.txtREGB.TabIndex = 2;
            this.txtREGB.Enter += new System.EventHandler(this.txtREGB_Enter);
            this.txtREGB.Leave += new System.EventHandler(this.txtREGB_Leave);
            // 
            // dtDATUM
            // 
            this.dtDATUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDATUM.Location = new System.Drawing.Point(167, 2);
            this.dtDATUM.Name = "dtDATUM";
            this.dtDATUM.Size = new System.Drawing.Size(133, 23);
            this.dtDATUM.TabIndex = 1;
            this.dtDATUM.Enter += new System.EventHandler(this.dtDATUM_Enter);
            this.dtDATUM.Leave += new System.EventHandler(this.dtDATUM_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 17);
            this.label3.TabIndex = 72;
            this.label3.Text = "DATUM";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(10, 6);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 67;
            this.label7.Text = "BR";
            this.tt.SetToolTip(this.label7, "Redni broj");
            // 
            // txtBR
            // 
            this.txtBR.Location = new System.Drawing.Point(40, 3);
            this.txtBR.Name = "txtBR";
            this.txtBR.Size = new System.Drawing.Size(54, 23);
            this.txtBR.TabIndex = 0;
            this.txtBR.Enter += new System.EventHandler(this.txtBR_Enter);
            this.txtBR.Leave += new System.EventHandler(this.txtBR_Leave);
            // 
            // dugme_svi
            // 
            this.dugme_svi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_svi.Image = global::Urban.Properties.Resources.globe;
            this.dugme_svi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_svi.Location = new System.Drawing.Point(788, 446);
            this.dugme_svi.Name = "dugme_svi";
            this.dugme_svi.Size = new System.Drawing.Size(135, 40);
            this.dugme_svi.TabIndex = 25;
            this.dugme_svi.Text = "Svi podaci";
            this.dugme_svi.UseVisualStyleBackColor = true;
            this.dugme_svi.Click += new System.EventHandler(this.dugme_svi_Click);
            // 
            // dugme_pretraga
            // 
            this.dugme_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_pretraga.Image = global::Urban.Properties.Resources.search;
            this.dugme_pretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_pretraga.Location = new System.Drawing.Point(638, 446);
            this.dugme_pretraga.Name = "dugme_pretraga";
            this.dugme_pretraga.Size = new System.Drawing.Size(135, 40);
            this.dugme_pretraga.TabIndex = 24;
            this.dugme_pretraga.Text = "Pretraga";
            this.dugme_pretraga.UseVisualStyleBackColor = true;
            this.dugme_pretraga.Click += new System.EventHandler(this.dugme_pretraga_Click);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(303, 451);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 23;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(159, 451);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 22;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(18, 451);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 21;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Image = global::Urban.Properties.Resources.search4printer;
            this.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampa.Location = new System.Drawing.Point(12, 6);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(135, 31);
            this.btnStampa.TabIndex = 20;
            this.btnStampa.Text = "Štampanje";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Visible = false;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 10000;
            this.tt.InitialDelay = 500;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 100;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::Urban.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(879, 1);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(38, 40);
            this.btnExcel.TabIndex = 26;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // frmDOC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(935, 494);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dugme_svi);
            this.Controls.Add(this.dugme_pretraga);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.btnStampa);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.natpis_filter);
            this.Controls.Add(this.pregled);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "frmDOC";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "URBDOC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDOC_FormClosing);
            this.Load += new System.EventHandler(this.frmDOC_Load);
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
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtREGB;
        private System.Windows.Forms.DateTimePicker dtDATUM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtARHBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtARHBRDOC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNAPOMENA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBRKAT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKATOPST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMatr;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button dugme_svi;
        private System.Windows.Forms.Button dugme_pretraga;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.BindingSource izvor;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.TextBox txtOsnov;
        private System.Windows.Forms.TextBox txtOPSTINA;
        private System.Windows.Forms.TextBox txtTIPDOC;
        private System.Windows.Forms.TextBox txtInref;
        private System.Windows.Forms.Button btnExcel;
    }
}