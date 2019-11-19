namespace Urban
{
    partial class frmBUD
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
            this.btnExcel = new System.Windows.Forms.Button();
            this.dugme_svi = new System.Windows.Forms.Button();
            this.dugme_pretraga = new System.Windows.Forms.Button();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtDATUM = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.nuKOM = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBBLBRPRP = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtCUVA = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPRIMEDBA = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVRSBIB = new System.Windows.Forms.TextBox();
            this.cbPOZ = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtPROSPOL = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBRTA = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtVEZARUP = new System.Windows.Forms.TextBox();
            this.LABEL666 = new System.Windows.Forms.Label();
            this.txtOBLIK = new System.Windows.Forms.TextBox();
            this.cbPECACEN = new System.Windows.Forms.CheckBox();
            this.cbPOTPISAN = new System.Windows.Forms.CheckBox();
            this.cbURADJEN = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtARHBR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTIP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtGODNAST = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtREDBR = new System.Windows.Forms.TextBox();
            this.pregled = new System.Windows.Forms.DataGrid();
            this.natpis_filter = new System.Windows.Forms.Label();
            this.izvor = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKOM)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::Urban.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(925, -3);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(37, 39);
            this.btnExcel.TabIndex = 40;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // dugme_svi
            // 
            this.dugme_svi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_svi.Image = global::Urban.Properties.Resources.globe;
            this.dugme_svi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_svi.Location = new System.Drawing.Point(665, 490);
            this.dugme_svi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_svi.Name = "dugme_svi";
            this.dugme_svi.Size = new System.Drawing.Size(135, 39);
            this.dugme_svi.TabIndex = 38;
            this.dugme_svi.Text = "Svi podaci";
            this.dugme_svi.UseVisualStyleBackColor = true;
            this.dugme_svi.Click += new System.EventHandler(this.dugme_svi_Click);
            // 
            // dugme_pretraga
            // 
            this.dugme_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_pretraga.Image = global::Urban.Properties.Resources.search;
            this.dugme_pretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_pretraga.Location = new System.Drawing.Point(515, 490);
            this.dugme_pretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_pretraga.Name = "dugme_pretraga";
            this.dugme_pretraga.Size = new System.Drawing.Size(135, 39);
            this.dugme_pretraga.TabIndex = 37;
            this.dugme_pretraga.Text = "Pretraga";
            this.dugme_pretraga.UseVisualStyleBackColor = true;
            this.dugme_pretraga.Click += new System.EventHandler(this.dugme_pretraga_Click);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(290, 498);
            this.dugme_brisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 36;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(146, 498);
            this.dugme_novi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 35;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(6, 498);
            this.dugme_snimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 34;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.dtDATUM);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.nuKOM);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtBBLBRPRP);
            this.panel1.Controls.Add(this.label11);
            this.panel1.Controls.Add(this.txtCUVA);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.txtPRIMEDBA);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txtVRSBIB);
            this.panel1.Controls.Add(this.cbPOZ);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtPROSPOL);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtBRTA);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtVEZARUP);
            this.panel1.Controls.Add(this.LABEL666);
            this.panel1.Controls.Add(this.txtOBLIK);
            this.panel1.Controls.Add(this.cbPECACEN);
            this.panel1.Controls.Add(this.cbPOTPISAN);
            this.panel1.Controls.Add(this.cbURADJEN);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtARHBR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtTIP);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOpstina);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtGODNAST);
            this.panel1.Controls.Add(this.txtNaziv);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtREDBR);
            this.panel1.Location = new System.Drawing.Point(12, 217);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(950, 273);
            this.panel1.TabIndex = 33;
            // 
            // dtDATUM
            // 
            this.dtDATUM.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtDATUM.Location = new System.Drawing.Point(392, 236);
            this.dtDATUM.Name = "dtDATUM";
            this.dtDATUM.Size = new System.Drawing.Size(133, 22);
            this.dtDATUM.TabIndex = 108;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(296, 241);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(76, 17);
            this.label15.TabIndex = 107;
            this.label15.Text = "DATUPISA";
            this.label15.MouseHover += new System.EventHandler(this.label15_MouseHover);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(298, 201);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(39, 17);
            this.label13.TabIndex = 106;
            this.label13.Text = "KOM";
            this.label13.MouseHover += new System.EventHandler(this.label13_MouseHover);
            // 
            // nuKOM
            // 
            this.nuKOM.Location = new System.Drawing.Point(343, 199);
            this.nuKOM.Name = "nuKOM";
            this.nuKOM.Size = new System.Drawing.Size(48, 22);
            this.nuKOM.TabIndex = 105;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(697, 215);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(84, 17);
            this.label12.TabIndex = 104;
            this.label12.Text = "BIBLBRPRP";
            // 
            // txtBBLBRPRP
            // 
            this.txtBBLBRPRP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBBLBRPRP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBBLBRPRP.Location = new System.Drawing.Point(784, 215);
            this.txtBBLBRPRP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBBLBRPRP.Name = "txtBBLBRPRP";
            this.txtBBLBRPRP.Size = new System.Drawing.Size(137, 22);
            this.txtBBLBRPRP.TabIndex = 103;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(705, 170);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(45, 17);
            this.label11.TabIndex = 102;
            this.label11.Text = "CUVA";
            this.label11.MouseHover += new System.EventHandler(this.label11_MouseHover);
            // 
            // txtCUVA
            // 
            this.txtCUVA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCUVA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCUVA.Location = new System.Drawing.Point(784, 170);
            this.txtCUVA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCUVA.Name = "txtCUVA";
            this.txtCUVA.Size = new System.Drawing.Size(137, 22);
            this.txtCUVA.TabIndex = 101;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(684, 73);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 17);
            this.label10.TabIndex = 100;
            this.label10.Text = "PRIMEDBA";
            // 
            // txtPRIMEDBA
            // 
            this.txtPRIMEDBA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPRIMEDBA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPRIMEDBA.Location = new System.Drawing.Point(768, 73);
            this.txtPRIMEDBA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPRIMEDBA.Multiline = true;
            this.txtPRIMEDBA.Name = "txtPRIMEDBA";
            this.txtPRIMEDBA.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtPRIMEDBA.Size = new System.Drawing.Size(153, 75);
            this.txtPRIMEDBA.TabIndex = 99;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(705, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 17);
            this.label9.TabIndex = 98;
            this.label9.Text = "VRSBIB";
            // 
            // txtVRSBIB
            // 
            this.txtVRSBIB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVRSBIB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVRSBIB.Location = new System.Drawing.Point(784, 28);
            this.txtVRSBIB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVRSBIB.Name = "txtVRSBIB";
            this.txtVRSBIB.Size = new System.Drawing.Size(137, 22);
            this.txtVRSBIB.TabIndex = 97;
            // 
            // cbPOZ
            // 
            this.cbPOZ.AutoSize = true;
            this.cbPOZ.Location = new System.Drawing.Point(328, 175);
            this.cbPOZ.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPOZ.Name = "cbPOZ";
            this.cbPOZ.Size = new System.Drawing.Size(59, 21);
            this.cbPOZ.TabIndex = 96;
            this.cbPOZ.Text = "POZ";
            this.cbPOZ.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(462, 206);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 17);
            this.label8.TabIndex = 95;
            this.label8.Text = "PROSPOL";
            this.label8.MouseHover += new System.EventHandler(this.label8_MouseHover);
            // 
            // txtPROSPOL
            // 
            this.txtPROSPOL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtPROSPOL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtPROSPOL.Location = new System.Drawing.Point(541, 206);
            this.txtPROSPOL.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtPROSPOL.Name = "txtPROSPOL";
            this.txtPROSPOL.Size = new System.Drawing.Size(137, 22);
            this.txtPROSPOL.TabIndex = 94;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(480, 164);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 17);
            this.label7.TabIndex = 93;
            this.label7.Text = "BRTA";
            this.label7.MouseHover += new System.EventHandler(this.label7_MouseHover);
            // 
            // txtBRTA
            // 
            this.txtBRTA.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBRTA.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBRTA.Location = new System.Drawing.Point(541, 164);
            this.txtBRTA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtBRTA.Name = "txtBRTA";
            this.txtBRTA.Size = new System.Drawing.Size(137, 22);
            this.txtBRTA.TabIndex = 92;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(462, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(73, 17);
            this.label2.TabIndex = 91;
            this.label2.Text = "VEZARUP";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // txtVEZARUP
            // 
            this.txtVEZARUP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVEZARUP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVEZARUP.Location = new System.Drawing.Point(541, 126);
            this.txtVEZARUP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtVEZARUP.Name = "txtVEZARUP";
            this.txtVEZARUP.Size = new System.Drawing.Size(137, 22);
            this.txtVEZARUP.TabIndex = 90;
            // 
            // LABEL666
            // 
            this.LABEL666.AutoSize = true;
            this.LABEL666.Location = new System.Drawing.Point(462, 88);
            this.LABEL666.Name = "LABEL666";
            this.LABEL666.Size = new System.Drawing.Size(48, 17);
            this.LABEL666.TabIndex = 89;
            this.LABEL666.Text = "OBLIK";
            this.LABEL666.MouseHover += new System.EventHandler(this.LABEL666_MouseHover);
            // 
            // txtOBLIK
            // 
            this.txtOBLIK.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOBLIK.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOBLIK.Location = new System.Drawing.Point(541, 88);
            this.txtOBLIK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOBLIK.Name = "txtOBLIK";
            this.txtOBLIK.Size = new System.Drawing.Size(137, 22);
            this.txtOBLIK.TabIndex = 88;
            // 
            // cbPECACEN
            // 
            this.cbPECACEN.AutoSize = true;
            this.cbPECACEN.Location = new System.Drawing.Point(328, 141);
            this.cbPECACEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPECACEN.Name = "cbPECACEN";
            this.cbPECACEN.Size = new System.Drawing.Size(94, 21);
            this.cbPECACEN.TabIndex = 87;
            this.cbPECACEN.Text = "PECACEN";
            this.cbPECACEN.UseVisualStyleBackColor = true;
            this.cbPECACEN.MouseHover += new System.EventHandler(this.cbPECACEN_MouseHover);
            // 
            // cbPOTPISAN
            // 
            this.cbPOTPISAN.AutoSize = true;
            this.cbPOTPISAN.Location = new System.Drawing.Point(328, 116);
            this.cbPOTPISAN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbPOTPISAN.Name = "cbPOTPISAN";
            this.cbPOTPISAN.Size = new System.Drawing.Size(99, 21);
            this.cbPOTPISAN.TabIndex = 86;
            this.cbPOTPISAN.Text = "POTPISAN";
            this.cbPOTPISAN.UseVisualStyleBackColor = true;
            this.cbPOTPISAN.MouseHover += new System.EventHandler(this.cbPOTPISAN_MouseHover);
            // 
            // cbURADJEN
            // 
            this.cbURADJEN.AutoSize = true;
            this.cbURADJEN.Location = new System.Drawing.Point(328, 91);
            this.cbURADJEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbURADJEN.Name = "cbURADJEN";
            this.cbURADJEN.Size = new System.Drawing.Size(95, 21);
            this.cbURADJEN.TabIndex = 85;
            this.cbURADJEN.Text = "URADJEN";
            this.cbURADJEN.UseVisualStyleBackColor = true;
            this.cbURADJEN.MouseHover += new System.EventHandler(this.cbURADJEN_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(25, 179);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "ARHBR";
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // txtARHBR
            // 
            this.txtARHBR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtARHBR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtARHBR.Location = new System.Drawing.Point(86, 179);
            this.txtARHBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtARHBR.Name = "txtARHBR";
            this.txtARHBR.Size = new System.Drawing.Size(137, 22);
            this.txtARHBR.TabIndex = 83;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "TIP";
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // txtTIP
            // 
            this.txtTIP.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtTIP.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtTIP.Location = new System.Drawing.Point(86, 131);
            this.txtTIP.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtTIP.Name = "txtTIP";
            this.txtTIP.Size = new System.Drawing.Size(137, 22);
            this.txtTIP.TabIndex = 81;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 80;
            this.label3.Text = "OPSTINA";
            this.label3.MouseHover += new System.EventHandler(this.label3_MouseHover);
            // 
            // txtOpstina
            // 
            this.txtOpstina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOpstina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOpstina.Location = new System.Drawing.Point(87, 90);
            this.txtOpstina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(137, 22);
            this.txtOpstina.TabIndex = 79;
            this.txtOpstina.Leave += new System.EventHandler(this.txtOpstina_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "GODNAST";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // txtGODNAST
            // 
            this.txtGODNAST.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtGODNAST.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtGODNAST.Location = new System.Drawing.Point(87, 47);
            this.txtGODNAST.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtGODNAST.Name = "txtGODNAST";
            this.txtGODNAST.Size = new System.Drawing.Size(137, 22);
            this.txtGODNAST.TabIndex = 75;
            this.txtGODNAST.Leave += new System.EventHandler(this.txtGODNAST_Leave);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(328, 15);
            this.txtNaziv.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(332, 54);
            this.txtNaziv.TabIndex = 71;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(248, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 17);
            this.label14.TabIndex = 72;
            this.label14.Text = "NAZIV";
            this.label14.MouseHover += new System.EventHandler(this.label14_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "REDBR";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // txtREDBR
            // 
            this.txtREDBR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtREDBR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtREDBR.Location = new System.Drawing.Point(64, 12);
            this.txtREDBR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtREDBR.Name = "txtREDBR";
            this.txtREDBR.Size = new System.Drawing.Size(94, 22);
            this.txtREDBR.TabIndex = 64;
            this.txtREDBR.Leave += new System.EventHandler(this.txtREDBR_Leave);
            // 
            // pregled
            // 
            this.pregled.AllowSorting = false;
            this.pregled.DataMember = "";
            this.pregled.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pregled.Location = new System.Drawing.Point(12, 39);
            this.pregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pregled.Name = "pregled";
            this.pregled.ReadOnly = true;
            this.pregled.Size = new System.Drawing.Size(950, 172);
            this.pregled.TabIndex = 32;
            // 
            // natpis_filter
            // 
            this.natpis_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.natpis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpis_filter.Location = new System.Drawing.Point(166, 11);
            this.natpis_filter.Name = "natpis_filter";
            this.natpis_filter.Size = new System.Drawing.Size(471, 25);
            this.natpis_filter.TabIndex = 31;
            this.natpis_filter.Text = "label17";
            this.natpis_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frmBUD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(979, 533);
            this.Controls.Add(this.btnExcel);
            this.Controls.Add(this.dugme_svi);
            this.Controls.Add(this.dugme_pretraga);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pregled);
            this.Controls.Add(this.natpis_filter);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmBUD";
            this.Text = "Biblioteka Urbanistickih Dokumenata";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmBUD_FormClosing);
            this.Load += new System.EventHandler(this.frmBUD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nuKOM)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button dugme_svi;
        private System.Windows.Forms.Button dugme_pretraga;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox cbURADJEN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtARHBR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTIP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtGODNAST;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtREDBR;
        private System.Windows.Forms.DataGrid pregled;
        private System.Windows.Forms.Label natpis_filter;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.NumericUpDown nuKOM;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtBBLBRPRP;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtCUVA;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPRIMEDBA;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVRSBIB;
        private System.Windows.Forms.CheckBox cbPOZ;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtPROSPOL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBRTA;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtVEZARUP;
        private System.Windows.Forms.Label LABEL666;
        private System.Windows.Forms.TextBox txtOBLIK;
        private System.Windows.Forms.CheckBox cbPECACEN;
        private System.Windows.Forms.CheckBox cbPOTPISAN;
        private System.Windows.Forms.DateTimePicker dtDATUM;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.BindingSource izvor;
    }
}