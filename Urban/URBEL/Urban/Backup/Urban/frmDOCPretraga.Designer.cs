namespace Urban
{
    partial class frmDOCPretraga
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
            this.btnOcisti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtARHBR = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBIB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtREGB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtARHBRDOC = new System.Windows.Forms.TextBox();
            this.txtNAPOMENA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOPSTINA = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBRKAT = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtKATOPST = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtMatr = new System.Windows.Forms.TextBox();
            this.optDATUMI = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datumDO = new System.Windows.Forms.MaskedTextBox();
            this.datumOD = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbINREF = new System.Windows.Forms.ListBox();
            this.cbINREF = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbTIPDOC = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.lbTIPDOC = new System.Windows.Forms.ListBox();
            this.label16 = new System.Windows.Forms.Label();
            this.txtOsnov = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtID = new System.Windows.Forms.TextBox();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(522, 379);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(106, 40);
            this.btnOcisti.TabIndex = 168;
            this.btnOcisti.Text = "Ocisti pretragu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(333, 382);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 167;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(198, 382);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 166;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 15);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 17);
            this.label7.TabIndex = 170;
            this.label7.Text = "BR";
            this.tt.SetToolTip(this.label7, "Redni broj");
            // 
            // txtBR
            // 
            this.txtBR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBR.Location = new System.Drawing.Point(38, 12);
            this.txtBR.Name = "txtBR";
            this.txtBR.Size = new System.Drawing.Size(54, 23);
            this.txtBR.TabIndex = 169;
            this.txtBR.Leave += new System.EventHandler(this.txtBR_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(350, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 17);
            this.label4.TabIndex = 176;
            this.label4.Text = "ARHBR";
            this.tt.SetToolTip(this.label4, "Arhivski broj");
            // 
            // txtARHBR
            // 
            this.txtARHBR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtARHBR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtARHBR.Location = new System.Drawing.Point(401, 12);
            this.txtARHBR.Name = "txtARHBR";
            this.txtARHBR.Size = new System.Drawing.Size(104, 23);
            this.txtARHBR.TabIndex = 175;
            this.txtARHBR.Leave += new System.EventHandler(this.txtARHBR_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 174;
            this.label2.Text = "BIB";
            this.tt.SetToolTip(this.label2, "Bibliotecki broj");
            // 
            // txtBIB
            // 
            this.txtBIB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBIB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBIB.Location = new System.Drawing.Point(273, 12);
            this.txtBIB.Name = "txtBIB";
            this.txtBIB.Size = new System.Drawing.Size(71, 23);
            this.txtBIB.TabIndex = 173;
            this.txtBIB.Leave += new System.EventHandler(this.txtBIB_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(99, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 172;
            this.label1.Text = "REGB";
            this.tt.SetToolTip(this.label1, "Registarski broj");
            // 
            // txtREGB
            // 
            this.txtREGB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtREGB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtREGB.Location = new System.Drawing.Point(148, 12);
            this.txtREGB.Name = "txtREGB";
            this.txtREGB.Size = new System.Drawing.Size(80, 23);
            this.txtREGB.TabIndex = 171;
            this.txtREGB.Leave += new System.EventHandler(this.txtREGB_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(525, 18);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 17);
            this.label5.TabIndex = 178;
            this.label5.Text = "ARHBRDOC";
            this.tt.SetToolTip(this.label5, "Arhivski broj dozvole");
            // 
            // txtARHBRDOC
            // 
            this.txtARHBRDOC.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtARHBRDOC.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtARHBRDOC.Location = new System.Drawing.Point(607, 15);
            this.txtARHBRDOC.Name = "txtARHBRDOC";
            this.txtARHBRDOC.Size = new System.Drawing.Size(104, 23);
            this.txtARHBRDOC.TabIndex = 177;
            this.txtARHBRDOC.Leave += new System.EventHandler(this.txtARHBRDOC_Leave);
            // 
            // txtNAPOMENA
            // 
            this.txtNAPOMENA.Location = new System.Drawing.Point(359, 52);
            this.txtNAPOMENA.Multiline = true;
            this.txtNAPOMENA.Name = "txtNAPOMENA";
            this.txtNAPOMENA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNAPOMENA.Size = new System.Drawing.Size(211, 68);
            this.txtNAPOMENA.TabIndex = 181;
            this.txtNAPOMENA.Leave += new System.EventHandler(this.txtNAPOMENA_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(277, 52);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 17);
            this.label9.TabIndex = 182;
            this.label9.Text = "NAPOMENA";
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(60, 52);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(211, 68);
            this.txtNaziv.TabIndex = 179;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(10, 52);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 180;
            this.label14.Text = "NAZIV";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 17);
            this.label3.TabIndex = 184;
            this.label3.Text = "OPSTINA";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // txtOPSTINA
            // 
            this.txtOPSTINA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOPSTINA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOPSTINA.Location = new System.Drawing.Point(76, 139);
            this.txtOPSTINA.Name = "txtOPSTINA";
            this.txtOPSTINA.Size = new System.Drawing.Size(195, 23);
            this.txtOPSTINA.TabIndex = 183;
            this.txtOPSTINA.Leave += new System.EventHandler(this.txtOPSTINA_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(487, 142);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 17);
            this.label11.TabIndex = 188;
            this.label11.Text = "BRKATPAR";
            this.tt.SetToolTip(this.label11, "Broj katastarske parcele");
            // 
            // txtBRKAT
            // 
            this.txtBRKAT.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBRKAT.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBRKAT.Location = new System.Drawing.Point(565, 142);
            this.txtBRKAT.Name = "txtBRKAT";
            this.txtBRKAT.Size = new System.Drawing.Size(179, 23);
            this.txtBRKAT.TabIndex = 187;
            this.txtBRKAT.Leave += new System.EventHandler(this.txtBRKAT_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(277, 142);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 17);
            this.label10.TabIndex = 186;
            this.label10.Text = "KATOPST";
            this.tt.SetToolTip(this.label10, "Sifra katastarske opstine");
            // 
            // txtKATOPST
            // 
            this.txtKATOPST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtKATOPST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKATOPST.Location = new System.Drawing.Point(344, 142);
            this.txtKATOPST.Name = "txtKATOPST";
            this.txtKATOPST.Size = new System.Drawing.Size(141, 23);
            this.txtKATOPST.TabIndex = 185;
            this.txtKATOPST.Leave += new System.EventHandler(this.txtKATOPST_Leave);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(12, 191);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 190;
            this.label12.Text = "MATR";
            this.tt.SetToolTip(this.label12, "Broj arhiva matrica");
            // 
            // txtMatr
            // 
            this.txtMatr.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtMatr.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtMatr.Location = new System.Drawing.Point(60, 191);
            this.txtMatr.Name = "txtMatr";
            this.txtMatr.Size = new System.Drawing.Size(74, 23);
            this.txtMatr.TabIndex = 189;
            this.txtMatr.Leave += new System.EventHandler(this.txtMatr_Leave);
            // 
            // optDATUMI
            // 
            this.optDATUMI.AutoSize = true;
            this.optDATUMI.Location = new System.Drawing.Point(176, 176);
            this.optDATUMI.Name = "optDATUMI";
            this.optDATUMI.Size = new System.Drawing.Size(88, 21);
            this.optDATUMI.TabIndex = 192;
            this.optDATUMI.Text = "DATUMI";
            this.optDATUMI.UseVisualStyleBackColor = true;
            this.optDATUMI.CheckedChanged += new System.EventHandler(this.optDATUMI_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datumDO);
            this.panel2.Controls.Add(this.datumOD);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Location = new System.Drawing.Point(176, 196);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 63);
            this.panel2.TabIndex = 191;
            this.panel2.Visible = false;
            // 
            // datumDO
            // 
            this.datumDO.Location = new System.Drawing.Point(345, 17);
            this.datumDO.Mask = "00/00/0000";
            this.datumDO.Name = "datumDO";
            this.datumDO.Size = new System.Drawing.Size(113, 23);
            this.datumDO.TabIndex = 148;
            this.datumDO.ValidatingType = typeof(System.DateTime);
            this.datumDO.Leave += new System.EventHandler(this.datumDO_Leave);
            // 
            // datumOD
            // 
            this.datumOD.Location = new System.Drawing.Point(100, 17);
            this.datumOD.Mask = "00/00/0000";
            this.datumOD.Name = "datumOD";
            this.datumOD.Size = new System.Drawing.Size(113, 23);
            this.datumOD.TabIndex = 147;
            this.datumOD.ValidatingType = typeof(System.DateTime);
            this.datumOD.Leave += new System.EventHandler(this.datumOD_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(247, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(90, 17);
            this.label6.TabIndex = 105;
            this.label6.Text = "DATUM DO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(90, 17);
            this.label8.TabIndex = 103;
            this.label8.Text = "DATUM OD";
            // 
            // lbINREF
            // 
            this.lbINREF.FormattingEnabled = true;
            this.lbINREF.ItemHeight = 17;
            this.lbINREF.Location = new System.Drawing.Point(139, 277);
            this.lbINREF.Name = "lbINREF";
            this.lbINREF.Size = new System.Drawing.Size(98, 55);
            this.lbINREF.TabIndex = 193;
            this.lbINREF.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbINREF_KeyDown);
            // 
            // cbINREF
            // 
            this.cbINREF.FormattingEnabled = true;
            this.cbINREF.Items.AddRange(new object[] {
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
            this.cbINREF.Location = new System.Drawing.Point(55, 277);
            this.cbINREF.Name = "cbINREF";
            this.cbINREF.Size = new System.Drawing.Size(79, 25);
            this.cbINREF.TabIndex = 194;
            this.cbINREF.Text = "---";
            this.cbINREF.SelectedIndexChanged += new System.EventHandler(this.cbINREF_SelectedIndexChanged);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(5, 280);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(53, 17);
            this.label13.TabIndex = 195;
            this.label13.Text = "INREF";
            this.tt.SetToolTip(this.label13, "Predmet obradio\\la");
            // 
            // cbTIPDOC
            // 
            this.cbTIPDOC.FormattingEnabled = true;
            this.cbTIPDOC.Items.AddRange(new object[] {
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
            this.cbTIPDOC.Location = new System.Drawing.Point(321, 277);
            this.cbTIPDOC.Name = "cbTIPDOC";
            this.cbTIPDOC.Size = new System.Drawing.Size(79, 25);
            this.cbTIPDOC.TabIndex = 196;
            this.cbTIPDOC.Text = "---";
            this.cbTIPDOC.SelectedIndexChanged += new System.EventHandler(this.cbTIPDOC_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(247, 280);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(65, 17);
            this.label15.TabIndex = 197;
            this.label15.Text = "TIPDOC";
            this.label15.MouseHover += new System.EventHandler(this.label15_MouseHover);
            // 
            // lbTIPDOC
            // 
            this.lbTIPDOC.FormattingEnabled = true;
            this.lbTIPDOC.ItemHeight = 17;
            this.lbTIPDOC.Location = new System.Drawing.Point(407, 277);
            this.lbTIPDOC.Name = "lbTIPDOC";
            this.lbTIPDOC.Size = new System.Drawing.Size(98, 55);
            this.lbTIPDOC.TabIndex = 198;
            this.lbTIPDOC.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbTIPDOC_KeyDown);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(525, 276);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(63, 17);
            this.label16.TabIndex = 200;
            this.label16.Text = "OSNOV";
            this.tt.SetToolTip(this.label16, "Planski i pravni osnov");
            // 
            // txtOsnov
            // 
            this.txtOsnov.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOsnov.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOsnov.Location = new System.Drawing.Point(581, 273);
            this.txtOsnov.Name = "txtOsnov";
            this.txtOsnov.Size = new System.Drawing.Size(194, 23);
            this.txtOsnov.TabIndex = 199;
            this.txtOsnov.Leave += new System.EventHandler(this.txtOsnov_Leave);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(542, 316);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(23, 17);
            this.label17.TabIndex = 202;
            this.label17.Text = "ID";
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(581, 313);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(71, 23);
            this.txtID.TabIndex = 201;
            this.txtID.Leave += new System.EventHandler(this.txtID_Leave);
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 10000;
            this.tt.InitialDelay = 500;
            this.tt.IsBalloon = true;
            this.tt.ReshowDelay = 100;
            // 
            // frmDOCPretraga
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(803, 431);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtOsnov);
            this.Controls.Add(this.lbTIPDOC);
            this.Controls.Add(this.cbTIPDOC);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.cbINREF);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.lbINREF);
            this.Controls.Add(this.optDATUMI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtMatr);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.txtBRKAT);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtKATOPST);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtOPSTINA);
            this.Controls.Add(this.txtNAPOMENA);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtARHBRDOC);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtARHBR);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBIB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtREGB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtBR);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDOCPretraga";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "URBDOC pretraga";
            this.Load += new System.EventHandler(this.frmDOCPretraga_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtARHBR;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBIB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtREGB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtARHBRDOC;
        private System.Windows.Forms.TextBox txtNAPOMENA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOPSTINA;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBRKAT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtKATOPST;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtMatr;
        private System.Windows.Forms.CheckBox optDATUMI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox datumDO;
        private System.Windows.Forms.MaskedTextBox datumOD;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListBox lbINREF;
        private System.Windows.Forms.ComboBox cbINREF;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbTIPDOC;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ListBox lbTIPDOC;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtOsnov;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.ToolTip tt;
    }
}