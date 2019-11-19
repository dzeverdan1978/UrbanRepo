namespace Urban
{
    partial class frmSearchProg
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
            this.lbTIPPLAKT = new System.Windows.Forms.ListBox();
            this.cbTipPlakt = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbInicijat = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbINICIJAT = new System.Windows.Forms.ListBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtArh = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.optDATUMI = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datumDO = new System.Windows.Forms.MaskedTextBox();
            this.datumOD = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.tt = new System.Windows.Forms.ToolTip(this.components);
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.txtObrad = new System.Windows.Forms.TextBox();
            this.txtVeza = new System.Windows.Forms.TextBox();
            this.btnOcisti = new System.Windows.Forms.Button();
            this.SKENIRAN = new System.Windows.Forms.GroupBox();
            this.s3 = new System.Windows.Forms.RadioButton();
            this.s2 = new System.Windows.Forms.RadioButton();
            this.s1 = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.d3 = new System.Windows.Forms.RadioButton();
            this.d2 = new System.Windows.Forms.RadioButton();
            this.d1 = new System.Windows.Forms.RadioButton();
            this.panel2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SKENIRAN.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbTIPPLAKT
            // 
            this.lbTIPPLAKT.FormattingEnabled = true;
            this.lbTIPPLAKT.ItemHeight = 17;
            this.lbTIPPLAKT.Location = new System.Drawing.Point(197, 2);
            this.lbTIPPLAKT.Name = "lbTIPPLAKT";
            this.lbTIPPLAKT.Size = new System.Drawing.Size(98, 55);
            this.lbTIPPLAKT.TabIndex = 142;
            this.lbTIPPLAKT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbTIPPLAKT_KeyDown);
            // 
            // cbTipPlakt
            // 
            this.cbTipPlakt.FormattingEnabled = true;
            this.cbTipPlakt.Location = new System.Drawing.Point(98, 17);
            this.cbTipPlakt.Name = "cbTipPlakt";
            this.cbTipPlakt.Size = new System.Drawing.Size(91, 25);
            this.cbTipPlakt.TabIndex = 141;
            this.cbTipPlakt.Text = "---";
            this.cbTipPlakt.SelectedIndexChanged += new System.EventHandler(this.cbTipPlakt_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 140;
            this.label1.Text = "TIPPLAKT";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
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
            this.cbInicijat.Location = new System.Drawing.Point(375, 2);
            this.cbInicijat.Name = "cbInicijat";
            this.cbInicijat.Size = new System.Drawing.Size(204, 25);
            this.cbInicijat.TabIndex = 143;
            this.cbInicijat.Text = "---";
            this.cbInicijat.SelectedIndexChanged += new System.EventHandler(this.cbInicijat_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(301, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 144;
            this.label2.Text = "INICIJAT";
            this.tt.SetToolTip(this.label2, "INICIJATOR");
            // 
            // lbINICIJAT
            // 
            this.lbINICIJAT.FormattingEnabled = true;
            this.lbINICIJAT.ItemHeight = 17;
            this.lbINICIJAT.Location = new System.Drawing.Point(595, 2);
            this.lbINICIJAT.Name = "lbINICIJAT";
            this.lbINICIJAT.Size = new System.Drawing.Size(179, 55);
            this.lbINICIJAT.TabIndex = 145;
            this.lbINICIJAT.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lbINICIJAT_KeyDown);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 85);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 147;
            this.label5.Text = "OBTADJIVAC";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(539, 85);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(61, 17);
            this.label8.TabIndex = 150;
            this.label8.Text = "ARHBR";
            this.tt.SetToolTip(this.label8, "ARHIVSKI BROJ");
            // 
            // txtArh
            // 
            this.txtArh.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtArh.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtArh.Location = new System.Drawing.Point(595, 85);
            this.txtArh.Name = "txtArh";
            this.txtArh.Size = new System.Drawing.Size(123, 23);
            this.txtArh.TabIndex = 149;
            this.txtArh.Leave += new System.EventHandler(this.txtArh_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 149);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 17);
            this.label4.TabIndex = 152;
            this.label4.Text = "OPSTINA";
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // txtOpstina
            // 
            this.txtOpstina.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtOpstina.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtOpstina.Location = new System.Drawing.Point(74, 149);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(180, 23);
            this.txtOpstina.TabIndex = 151;
            this.txtOpstina.Leave += new System.EventHandler(this.txtOpstina_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(262, 152);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 154;
            this.label6.Text = "KARTBR";
            this.tt.SetToolTip(this.label6, "KARTOGRAFSKI BROJ");
            // 
            // txtKart
            // 
            this.txtKart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtKart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKart.Location = new System.Drawing.Point(325, 146);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(130, 23);
            this.txtKart.TabIndex = 153;
            this.txtKart.Leave += new System.EventHandler(this.txtKart_Leave);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(543, 152);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(232, 115);
            this.txtNaziv.TabIndex = 155;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(480, 152);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 156;
            this.label14.Text = "NAZIV";
            // 
            // optDATUMI
            // 
            this.optDATUMI.AutoSize = true;
            this.optDATUMI.Location = new System.Drawing.Point(15, 184);
            this.optDATUMI.Name = "optDATUMI";
            this.optDATUMI.Size = new System.Drawing.Size(88, 21);
            this.optDATUMI.TabIndex = 158;
            this.optDATUMI.Text = "DATUMI";
            this.optDATUMI.UseVisualStyleBackColor = true;
            this.optDATUMI.CheckedChanged += new System.EventHandler(this.optDATUMI_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.datumDO);
            this.panel2.Controls.Add(this.datumOD);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Location = new System.Drawing.Point(15, 204);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 63);
            this.panel2.TabIndex = 157;
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
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(247, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(90, 17);
            this.label3.TabIndex = 105;
            this.label3.Text = "DATUM DO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 20);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(90, 17);
            this.label7.TabIndex = 103;
            this.label7.Text = "DATUM OD";
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(343, 400);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 160;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(208, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 159;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tt
            // 
            this.tt.AutoPopDelay = 10000;
            this.tt.InitialDelay = 500;
            this.tt.ReshowDelay = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(23, 292);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 17);
            this.label9.TabIndex = 163;
            this.label9.Text = "VEZA";
            this.tt.SetToolTip(this.label9, "KARTOGRAFSKI BROJ");
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.r3);
            this.groupBox4.Controls.Add(this.r2);
            this.groupBox4.Controls.Add(this.r1);
            this.groupBox4.Location = new System.Drawing.Point(223, 292);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 95);
            this.groupBox4.TabIndex = 164;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "REALIZOVAN";
            this.tt.SetToolTip(this.groupBox4, "Plan realizovan");
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Location = new System.Drawing.Point(8, 65);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(68, 21);
            this.r3.TabIndex = 2;
            this.r3.Text = "Jeste";
            this.r3.UseVisualStyleBackColor = true;
            this.r3.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Location = new System.Drawing.Point(8, 42);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(57, 21);
            this.r2.TabIndex = 1;
            this.r2.Text = "Nije";
            this.r2.UseVisualStyleBackColor = true;
            this.r2.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Checked = true;
            this.r1.Location = new System.Drawing.Point(7, 20);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(56, 21);
            this.r1.TabIndex = 0;
            this.r1.TabStop = true;
            this.r1.Text = "Sva";
            this.r1.UseVisualStyleBackColor = true;
            this.r1.CheckedChanged += new System.EventHandler(this.r1_CheckedChanged);
            // 
            // txtObrad
            // 
            this.txtObrad.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtObrad.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtObrad.Location = new System.Drawing.Point(98, 82);
            this.txtObrad.Name = "txtObrad";
            this.txtObrad.Size = new System.Drawing.Size(391, 23);
            this.txtObrad.TabIndex = 161;
            this.txtObrad.Leave += new System.EventHandler(this.txtObrad_Leave);
            // 
            // txtVeza
            // 
            this.txtVeza.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtVeza.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtVeza.Location = new System.Drawing.Point(74, 285);
            this.txtVeza.Name = "txtVeza";
            this.txtVeza.Size = new System.Drawing.Size(130, 23);
            this.txtVeza.TabIndex = 162;
            this.txtVeza.Leave += new System.EventHandler(this.txtVeza_Leave);
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(532, 397);
            this.btnOcisti.Name = "btnOcisti";
            this.btnOcisti.Size = new System.Drawing.Size(106, 40);
            this.btnOcisti.TabIndex = 165;
            this.btnOcisti.Text = "Ocisti pretragu";
            this.btnOcisti.UseVisualStyleBackColor = true;
            this.btnOcisti.Click += new System.EventHandler(this.btnOcisti_Click);
            // 
            // SKENIRAN
            // 
            this.SKENIRAN.BackColor = System.Drawing.Color.LightGray;
            this.SKENIRAN.Controls.Add(this.s3);
            this.SKENIRAN.Controls.Add(this.s2);
            this.SKENIRAN.Controls.Add(this.s1);
            this.SKENIRAN.Location = new System.Drawing.Point(542, 292);
            this.SKENIRAN.Name = "SKENIRAN";
            this.SKENIRAN.Size = new System.Drawing.Size(130, 95);
            this.SKENIRAN.TabIndex = 167;
            this.SKENIRAN.TabStop = false;
            this.SKENIRAN.Text = "SKEN";
            this.tt.SetToolTip(this.SKENIRAN, "Plan skeniran");
            // 
            // s3
            // 
            this.s3.AutoSize = true;
            this.s3.Location = new System.Drawing.Point(8, 65);
            this.s3.Name = "s3";
            this.s3.Size = new System.Drawing.Size(68, 21);
            this.s3.TabIndex = 2;
            this.s3.Text = "Jeste";
            this.s3.UseVisualStyleBackColor = true;
            // 
            // s2
            // 
            this.s2.AutoSize = true;
            this.s2.Location = new System.Drawing.Point(8, 42);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(57, 21);
            this.s2.TabIndex = 1;
            this.s2.Text = "Nije";
            this.s2.UseVisualStyleBackColor = true;
            // 
            // s1
            // 
            this.s1.AutoSize = true;
            this.s1.Checked = true;
            this.s1.Location = new System.Drawing.Point(7, 20);
            this.s1.Name = "s1";
            this.s1.Size = new System.Drawing.Size(56, 21);
            this.s1.TabIndex = 0;
            this.s1.TabStop = true;
            this.s1.Text = "Sva";
            this.s1.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.BackColor = System.Drawing.Color.LightGray;
            this.groupBox5.Controls.Add(this.d3);
            this.groupBox5.Controls.Add(this.d2);
            this.groupBox5.Controls.Add(this.d1);
            this.groupBox5.Location = new System.Drawing.Point(393, 292);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(130, 95);
            this.groupBox5.TabIndex = 166;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "VEKTOR";
            this.tt.SetToolTip(this.groupBox5, "Plan u vektorskom obliku");
            // 
            // d3
            // 
            this.d3.AutoSize = true;
            this.d3.Location = new System.Drawing.Point(8, 65);
            this.d3.Name = "d3";
            this.d3.Size = new System.Drawing.Size(68, 21);
            this.d3.TabIndex = 2;
            this.d3.Text = "Jeste";
            this.d3.UseVisualStyleBackColor = true;
            // 
            // d2
            // 
            this.d2.AutoSize = true;
            this.d2.Location = new System.Drawing.Point(8, 42);
            this.d2.Name = "d2";
            this.d2.Size = new System.Drawing.Size(57, 21);
            this.d2.TabIndex = 1;
            this.d2.Text = "Nije";
            this.d2.UseVisualStyleBackColor = true;
            // 
            // d1
            // 
            this.d1.AutoSize = true;
            this.d1.Checked = true;
            this.d1.Location = new System.Drawing.Point(7, 20);
            this.d1.Name = "d1";
            this.d1.Size = new System.Drawing.Size(56, 21);
            this.d1.TabIndex = 0;
            this.d1.TabStop = true;
            this.d1.Text = "Sva";
            this.d1.UseVisualStyleBackColor = true;
            // 
            // frmSearchProg
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(787, 449);
            this.Controls.Add(this.SKENIRAN);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtVeza);
            this.Controls.Add(this.txtObrad);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.optDATUMI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtKart);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpstina);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtArh);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lbINICIJAT);
            this.Controls.Add(this.cbInicijat);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbTIPPLAKT);
            this.Controls.Add(this.cbTipPlakt);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSearchProg";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRETRAGA PROGRAMA";
            this.Load += new System.EventHandler(this.frmSearchProg_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.SKENIRAN.ResumeLayout(false);
            this.SKENIRAN.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbTIPPLAKT;
        private System.Windows.Forms.ComboBox cbTipPlakt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbInicijat;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbINICIJAT;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtArh;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtKart;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox optDATUMI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox datumDO;
        private System.Windows.Forms.MaskedTextBox datumOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ToolTip tt;
        private System.Windows.Forms.TextBox txtObrad;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVeza;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.GroupBox SKENIRAN;
        private System.Windows.Forms.RadioButton s3;
        private System.Windows.Forms.RadioButton s2;
        private System.Windows.Forms.RadioButton s1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.RadioButton d3;
        private System.Windows.Forms.RadioButton d2;
        private System.Windows.Forms.RadioButton d1;
    }
}