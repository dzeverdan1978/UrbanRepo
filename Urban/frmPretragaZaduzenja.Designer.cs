namespace Urban
{
    partial class frmPretragaZaduzenja
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
            this.btnOcisti = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDuznik = new System.Windows.Forms.TextBox();
            this.txtNapomena = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.optDATUMI = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.datumDO = new System.Windows.Forms.MaskedTextBox();
            this.datumOD = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOcisti
            // 
            this.btnOcisti.Location = new System.Drawing.Point(476, 223);
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
            this.button2.Location = new System.Drawing.Point(287, 226);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(112, 37);
            this.button2.TabIndex = 167;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(152, 226);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 37);
            this.button1.TabIndex = 166;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(15, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 17);
            this.label6.TabIndex = 170;
            this.label6.Text = "ŠIFRA";
            // 
            // txtSifra
            // 
            this.txtSifra.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtSifra.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtSifra.Location = new System.Drawing.Point(64, 12);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(148, 23);
            this.txtSifra.TabIndex = 169;
            this.txtSifra.Leave += new System.EventHandler(this.txtSifra_Leave);
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(299, 12);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(231, 55);
            this.txtNaziv.TabIndex = 171;
            this.txtNaziv.Leave += new System.EventHandler(this.txtNaziv_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(236, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 17);
            this.label14.TabIndex = 172;
            this.label14.Text = "NAZIV";
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.LightGray;
            this.groupBox4.Controls.Add(this.r3);
            this.groupBox4.Controls.Add(this.r2);
            this.groupBox4.Controls.Add(this.r1);
            this.groupBox4.Location = new System.Drawing.Point(563, 12);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(130, 95);
            this.groupBox4.TabIndex = 173;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "RAZDUŽEN";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 17);
            this.label1.TabIndex = 175;
            this.label1.Text = "DUŽNIK";
            // 
            // txtDuznik
            // 
            this.txtDuznik.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDuznik.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDuznik.Location = new System.Drawing.Point(75, 87);
            this.txtDuznik.Name = "txtDuznik";
            this.txtDuznik.Size = new System.Drawing.Size(216, 23);
            this.txtDuznik.TabIndex = 174;
            this.txtDuznik.Leave += new System.EventHandler(this.txtDuznik_Leave);
            // 
            // txtNapomena
            // 
            this.txtNapomena.Location = new System.Drawing.Point(556, 144);
            this.txtNapomena.Multiline = true;
            this.txtNapomena.Name = "txtNapomena";
            this.txtNapomena.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNapomena.Size = new System.Drawing.Size(210, 56);
            this.txtNapomena.TabIndex = 176;
            this.txtNapomena.Leave += new System.EventHandler(this.txtNapomena_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(553, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 17);
            this.label4.TabIndex = 177;
            this.label4.Text = "NAPOMENA";
            // 
            // optDATUMI
            // 
            this.optDATUMI.AutoSize = true;
            this.optDATUMI.Location = new System.Drawing.Point(18, 117);
            this.optDATUMI.Name = "optDATUMI";
            this.optDATUMI.Size = new System.Drawing.Size(88, 21);
            this.optDATUMI.TabIndex = 179;
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
            this.panel2.Location = new System.Drawing.Point(18, 137);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(508, 63);
            this.panel2.TabIndex = 178;
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
            // frmPretragaZaduzenja
            // 
            this.AcceptButton = this.button1;
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(778, 266);
            this.Controls.Add(this.optDATUMI);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.txtNapomena);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDuznik);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtSifra);
            this.Controls.Add(this.btnOcisti);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPretragaZaduzenja";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "PRETRAGA ZADUŽENJA";
            this.Load += new System.EventHandler(this.frmPretragaZaduzenja_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOcisti;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDuznik;
        private System.Windows.Forms.TextBox txtNapomena;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox optDATUMI;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.MaskedTextBox datumDO;
        private System.Windows.Forms.MaskedTextBox datumOD;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}