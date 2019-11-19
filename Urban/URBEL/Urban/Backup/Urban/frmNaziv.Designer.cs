namespace Urban
{
    partial class frmNaziv
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
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.prikaz = new System.Windows.Forms.DataGrid();
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(21, 12);
            this.txtNaziv.Multiline = true;
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaziv.Size = new System.Drawing.Size(696, 145);
            this.txtNaziv.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(418, 416);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(102, 35);
            this.button2.TabIndex = 1;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(239, 416);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(102, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prikaz
            // 
            this.prikaz.CaptionText = "Izmene i dopune plana";
            this.prikaz.DataMember = "";
            this.prikaz.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.prikaz.Location = new System.Drawing.Point(21, 163);
            this.prikaz.Name = "prikaz";
            this.prikaz.ReadOnly = true;
            this.prikaz.Size = new System.Drawing.Size(696, 121);
            this.prikaz.TabIndex = 3;
            this.prikaz.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.prikaz;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "izdop";
            this.dataGridTableStyle1.ReadOnly = true;
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Opis izmene/dopune";
            this.dataGridTextBoxColumn1.MappingName = "opis";
            this.dataGridTextBoxColumn1.ReadOnly = true;
            this.dataGridTextBoxColumn1.Width = 600;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 287);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Opis:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(60, 290);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(307, 120);
            this.txtOpis.TabIndex = 5;
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(523, 290);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 8;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(373, 290);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 7;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(373, 338);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 6;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // frmNaziv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(750, 454);
            this.ControlBox = false;
            this.Controls.Add(this.dugme_novi);
            this.Controls.Add(this.dugme_brisi);
            this.Controls.Add(this.dugme_snimi);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikaz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtNaziv);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmNaziv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "                                                                        Izmene i " +
                "dopune plana";
            this.Load += new System.EventHandler(this.frmNaziv_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGrid prikaz;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_snimi;
    }
}