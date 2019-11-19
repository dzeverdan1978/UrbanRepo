namespace Urban
{
    partial class frmUticaji
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUticaji));
            this.label1 = new System.Windows.Forms.Label();
            this.prikaz = new System.Windows.Forms.DataGrid();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.natpis_plan = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.izbor_datum = new System.Windows.Forms.DateTimePicker();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.izbor_tip = new System.Windows.Forms.ComboBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.txtIdut = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.dugme_deltip = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Utice na:";
            // 
            // prikaz
            // 
            this.prikaz.DataMember = "";
            this.prikaz.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.prikaz.Location = new System.Drawing.Point(12, 30);
            this.prikaz.Name = "prikaz";
            this.prikaz.ReadOnly = true;
            this.prikaz.Size = new System.Drawing.Size(814, 117);
            this.prikaz.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(13, 238);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Plan:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(53, 232);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(45, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "...";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // natpis_plan
            // 
            this.natpis_plan.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.natpis_plan.Location = new System.Drawing.Point(104, 237);
            this.natpis_plan.Name = "natpis_plan";
            this.natpis_plan.Size = new System.Drawing.Size(328, 18);
            this.natpis_plan.TabIndex = 4;
            this.natpis_plan.Text = "Plan:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(13, 267);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 18);
            this.label3.TabIndex = 5;
            this.label3.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(53, 265);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(327, 73);
            this.txtOpis.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(386, 268);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 18);
            this.label4.TabIndex = 7;
            this.label4.Text = "Datum:";
            // 
            // izbor_datum
            // 
            this.izbor_datum.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.izbor_datum.Location = new System.Drawing.Point(438, 267);
            this.izbor_datum.Name = "izbor_datum";
            this.izbor_datum.Size = new System.Drawing.Size(126, 20);
            this.izbor_datum.TabIndex = 8;
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(680, 307);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 11;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(539, 307);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 10;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(396, 307);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 9;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(454, 238);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Tip uticaja:";
            // 
            // izbor_tip
            // 
            this.izbor_tip.FormattingEnabled = true;
            this.izbor_tip.Location = new System.Drawing.Point(530, 234);
            this.izbor_tip.Name = "izbor_tip";
            this.izbor_tip.Size = new System.Drawing.Size(287, 21);
            this.izbor_tip.TabIndex = 13;
            this.izbor_tip.SelectedIndexChanged += new System.EventHandler(this.izbor_tip_SelectedIndexChanged);
            this.izbor_tip.Leave += new System.EventHandler(this.izbor_tip_Leave);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(603, 4);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 14;
            // 
            // txtIdut
            // 
            this.txtIdut.Location = new System.Drawing.Point(716, 4);
            this.txtIdut.Name = "txtIdut";
            this.txtIdut.ReadOnly = true;
            this.txtIdut.Size = new System.Drawing.Size(100, 20);
            this.txtIdut.TabIndex = 15;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(175, 153);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ReadOnly = true;
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNaziv.Size = new System.Drawing.Size(327, 73);
            this.txtNaziv.TabIndex = 16;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(64, 156);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(105, 38);
            this.label6.TabIndex = 17;
            this.label6.Text = "Naziv izabranog predmeta:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(518, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 21);
            this.label7.TabIndex = 18;
            this.label7.Text = "Kartografski broj:";
            // 
            // txtKart
            // 
            this.txtKart.Location = new System.Drawing.Point(626, 153);
            this.txtKart.Name = "txtKart";
            this.txtKart.ReadOnly = true;
            this.txtKart.Size = new System.Drawing.Size(100, 20);
            this.txtKart.TabIndex = 19;
            // 
            // dugme_deltip
            // 
            this.dugme_deltip.Location = new System.Drawing.Point(680, 261);
            this.dugme_deltip.Name = "dugme_deltip";
            this.dugme_deltip.Size = new System.Drawing.Size(135, 23);
            this.dugme_deltip.TabIndex = 20;
            this.dugme_deltip.Text = "Obrisi tip";
            this.dugme_deltip.UseVisualStyleBackColor = true;
            this.dugme_deltip.Click += new System.EventHandler(this.dugme_deltip_Click);
            // 
            // frmUticaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(838, 352);
            this.Controls.Add(this.dugme_deltip);
            this.Controls.Add(this.txtKart);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtIdut);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.izbor_tip);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.izbor_datum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.natpis_plan);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUticaji";
            this.Text = "Uticaji na druge planove";
            this.Load += new System.EventHandler(this.frmUticaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid prikaz;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label natpis_plan;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker izbor_datum;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox izbor_tip;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.TextBox txtIdut;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtKart;
        private System.Windows.Forms.Button dugme_deltip;
    }
}