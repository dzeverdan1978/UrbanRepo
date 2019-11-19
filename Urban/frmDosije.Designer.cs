namespace Urban
{
    partial class frmDosije
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbAzur = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtIZM = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtOpstina = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKart = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtREG = new System.Windows.Forms.TextBox();
            this.txtNaslov = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDOS = new System.Windows.Forms.TextBox();
            this.pregled = new System.Windows.Forms.DataGrid();
            this.natpis_filter = new System.Windows.Forms.Label();
            this.btnExcel = new System.Windows.Forms.Button();
            this.btnStampa = new System.Windows.Forms.Button();
            this.dugme_svi = new System.Windows.Forms.Button();
            this.dugme_pretraga = new System.Windows.Forms.Button();
            this.dugme_brisi = new System.Windows.Forms.Button();
            this.dugme_novi = new System.Windows.Forms.Button();
            this.dugme_snimi = new System.Windows.Forms.Button();
            this.izvor = new System.Windows.Forms.BindingSource(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.cbAzur);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.txtCR);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtIZM);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtOpstina);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtKart);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.txtREG);
            this.panel1.Controls.Add(this.txtNaslov);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtDOS);
            this.panel1.Location = new System.Drawing.Point(3, 212);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(779, 178);
            this.panel1.TabIndex = 23;
            // 
            // cbAzur
            // 
            this.cbAzur.AutoSize = true;
            this.cbAzur.Location = new System.Drawing.Point(507, 79);
            this.cbAzur.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbAzur.Name = "cbAzur";
            this.cbAzur.Size = new System.Drawing.Size(68, 21);
            this.cbAzur.TabIndex = 85;
            this.cbAzur.Text = "AZUR";
            this.cbAzur.UseVisualStyleBackColor = true;
            this.cbAzur.MouseHover += new System.EventHandler(this.cbAzur_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(235, 142);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(27, 17);
            this.label5.TabIndex = 84;
            this.label5.Text = "CR";
            this.label5.MouseHover += new System.EventHandler(this.label5_MouseHover);
            // 
            // txtCR
            // 
            this.txtCR.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtCR.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtCR.Location = new System.Drawing.Point(296, 142);
            this.txtCR.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtCR.Name = "txtCR";
            this.txtCR.Size = new System.Drawing.Size(137, 22);
            this.txtCR.TabIndex = 83;
            this.txtCR.Enter += new System.EventHandler(this.txtCR_Enter);
            this.txtCR.Leave += new System.EventHandler(this.txtCR_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(236, 107);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 17);
            this.label4.TabIndex = 82;
            this.label4.Text = "IZM";
            this.label4.MouseHover += new System.EventHandler(this.label4_MouseHover);
            // 
            // txtIZM
            // 
            this.txtIZM.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtIZM.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtIZM.Location = new System.Drawing.Point(296, 103);
            this.txtIZM.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtIZM.Name = "txtIZM";
            this.txtIZM.Size = new System.Drawing.Size(137, 22);
            this.txtIZM.TabIndex = 81;
            this.txtIZM.Enter += new System.EventHandler(this.txtIZM_Enter);
            this.txtIZM.Leave += new System.EventHandler(this.txtIZM_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(221, 79);
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
            this.txtOpstina.Location = new System.Drawing.Point(296, 76);
            this.txtOpstina.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtOpstina.Name = "txtOpstina";
            this.txtOpstina.Size = new System.Drawing.Size(137, 22);
            this.txtOpstina.TabIndex = 79;
            this.txtOpstina.Enter += new System.EventHandler(this.txtOpstina_Enter);
            this.txtOpstina.Leave += new System.EventHandler(this.txtOpstina_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(4, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 17);
            this.label2.TabIndex = 78;
            this.label2.Text = "KART";
            this.label2.MouseHover += new System.EventHandler(this.label2_MouseHover);
            // 
            // txtKart
            // 
            this.txtKart.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtKart.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtKart.Location = new System.Drawing.Point(64, 87);
            this.txtKart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtKart.Name = "txtKart";
            this.txtKart.Size = new System.Drawing.Size(137, 22);
            this.txtKart.TabIndex = 77;
            this.txtKart.Enter += new System.EventHandler(this.txtKart_Enter);
            this.txtKart.Leave += new System.EventHandler(this.txtKart_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 76;
            this.label1.Text = "REG";
            this.label1.MouseHover += new System.EventHandler(this.label1_MouseHover);
            // 
            // txtREG
            // 
            this.txtREG.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtREG.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtREG.Location = new System.Drawing.Point(64, 48);
            this.txtREG.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtREG.Name = "txtREG";
            this.txtREG.Size = new System.Drawing.Size(137, 22);
            this.txtREG.TabIndex = 75;
            this.txtREG.Enter += new System.EventHandler(this.txtREG_Enter);
            this.txtREG.Leave += new System.EventHandler(this.txtREG_Leave);
            // 
            // txtNaslov
            // 
            this.txtNaslov.Location = new System.Drawing.Point(277, 15);
            this.txtNaslov.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtNaslov.Multiline = true;
            this.txtNaslov.Name = "txtNaslov";
            this.txtNaslov.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtNaslov.Size = new System.Drawing.Size(332, 54);
            this.txtNaslov.TabIndex = 71;
            this.txtNaslov.Enter += new System.EventHandler(this.txtNaslov_Enter);
            this.txtNaslov.Leave += new System.EventHandler(this.txtNaslov_Leave);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(213, 15);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 17);
            this.label14.TabIndex = 72;
            this.label14.Text = "NASLOV";
            this.label14.MouseHover += new System.EventHandler(this.label14_MouseHover);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(4, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(38, 17);
            this.label6.TabIndex = 65;
            this.label6.Text = "DOS";
            this.label6.MouseHover += new System.EventHandler(this.label6_MouseHover);
            // 
            // txtDOS
            // 
            this.txtDOS.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtDOS.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtDOS.Location = new System.Drawing.Point(53, 12);
            this.txtDOS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txtDOS.Name = "txtDOS";
            this.txtDOS.Size = new System.Drawing.Size(148, 22);
            this.txtDOS.TabIndex = 64;
            this.txtDOS.Enter += new System.EventHandler(this.txtDOS_Enter);
            this.txtDOS.Leave += new System.EventHandler(this.txtDOS_Leave);
            // 
            // pregled
            // 
            this.pregled.AllowSorting = false;
            this.pregled.DataMember = "";
            this.pregled.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.pregled.Location = new System.Drawing.Point(3, 34);
            this.pregled.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pregled.Name = "pregled";
            this.pregled.ReadOnly = true;
            this.pregled.Size = new System.Drawing.Size(779, 172);
            this.pregled.TabIndex = 22;
            // 
            // natpis_filter
            // 
            this.natpis_filter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.natpis_filter.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.natpis_filter.Location = new System.Drawing.Point(157, 6);
            this.natpis_filter.Name = "natpis_filter";
            this.natpis_filter.Size = new System.Drawing.Size(471, 25);
            this.natpis_filter.TabIndex = 21;
            this.natpis_filter.Text = "label17";
            this.natpis_filter.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnExcel
            // 
            this.btnExcel.Image = global::Urban.Properties.Resources.excel;
            this.btnExcel.Location = new System.Drawing.Point(744, -5);
            this.btnExcel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnExcel.Name = "btnExcel";
            this.btnExcel.Size = new System.Drawing.Size(37, 39);
            this.btnExcel.TabIndex = 30;
            this.btnExcel.UseVisualStyleBackColor = true;
            this.btnExcel.Visible = false;
            this.btnExcel.Click += new System.EventHandler(this.btnExcel_Click);
            // 
            // btnStampa
            // 
            this.btnStampa.Image = global::Urban.Properties.Resources.search4printer;
            this.btnStampa.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnStampa.Location = new System.Drawing.Point(3, 0);
            this.btnStampa.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnStampa.Name = "btnStampa";
            this.btnStampa.Size = new System.Drawing.Size(135, 31);
            this.btnStampa.TabIndex = 29;
            this.btnStampa.Text = "Štampanje";
            this.btnStampa.UseVisualStyleBackColor = true;
            this.btnStampa.Visible = false;
            this.btnStampa.Click += new System.EventHandler(this.btnStampa_Click);
            // 
            // dugme_svi
            // 
            this.dugme_svi.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_svi.Image = global::Urban.Properties.Resources.globe;
            this.dugme_svi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_svi.Location = new System.Drawing.Point(661, 396);
            this.dugme_svi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_svi.Name = "dugme_svi";
            this.dugme_svi.Size = new System.Drawing.Size(135, 39);
            this.dugme_svi.TabIndex = 28;
            this.dugme_svi.Text = "Svi podaci";
            this.dugme_svi.UseVisualStyleBackColor = true;
            this.dugme_svi.Click += new System.EventHandler(this.dugme_svi_Click);
            // 
            // dugme_pretraga
            // 
            this.dugme_pretraga.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dugme_pretraga.Image = global::Urban.Properties.Resources.search;
            this.dugme_pretraga.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_pretraga.Location = new System.Drawing.Point(511, 396);
            this.dugme_pretraga.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_pretraga.Name = "dugme_pretraga";
            this.dugme_pretraga.Size = new System.Drawing.Size(135, 39);
            this.dugme_pretraga.TabIndex = 27;
            this.dugme_pretraga.Text = "Pretraga";
            this.dugme_pretraga.UseVisualStyleBackColor = true;
            this.dugme_pretraga.Click += new System.EventHandler(this.dugme_pretraga_Click);
            // 
            // dugme_brisi
            // 
            this.dugme_brisi.Image = global::Urban.Properties.Resources.delete_16x;
            this.dugme_brisi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_brisi.Location = new System.Drawing.Point(285, 400);
            this.dugme_brisi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_brisi.Name = "dugme_brisi";
            this.dugme_brisi.Size = new System.Drawing.Size(135, 31);
            this.dugme_brisi.TabIndex = 26;
            this.dugme_brisi.Text = "Obriši zapis";
            this.dugme_brisi.UseVisualStyleBackColor = true;
            this.dugme_brisi.Click += new System.EventHandler(this.dugme_brisi_Click);
            // 
            // dugme_novi
            // 
            this.dugme_novi.Image = global::Urban.Properties.Resources.db;
            this.dugme_novi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_novi.Location = new System.Drawing.Point(141, 400);
            this.dugme_novi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_novi.Name = "dugme_novi";
            this.dugme_novi.Size = new System.Drawing.Size(135, 31);
            this.dugme_novi.TabIndex = 25;
            this.dugme_novi.Text = "Novi zapis";
            this.dugme_novi.UseVisualStyleBackColor = true;
            this.dugme_novi.Click += new System.EventHandler(this.dugme_novi_Click);
            // 
            // dugme_snimi
            // 
            this.dugme_snimi.Image = global::Urban.Properties.Resources.DISK06;
            this.dugme_snimi.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.dugme_snimi.Location = new System.Drawing.Point(1, 400);
            this.dugme_snimi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dugme_snimi.Name = "dugme_snimi";
            this.dugme_snimi.Size = new System.Drawing.Size(135, 31);
            this.dugme_snimi.TabIndex = 24;
            this.dugme_snimi.Text = "Snimi promene";
            this.dugme_snimi.UseVisualStyleBackColor = true;
            this.dugme_snimi.Click += new System.EventHandler(this.dugme_snimi_Click);
            // 
            // frmDosije
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.ClientSize = new System.Drawing.Size(797, 441);
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
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmDosije";
            this.Text = "Evidencija za DOSIJE";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmDosije_FormClosing);
            this.Load += new System.EventHandler(this.frmDosije_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pregled)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.izvor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnExcel;
        private System.Windows.Forms.Button btnStampa;
        private System.Windows.Forms.Button dugme_svi;
        private System.Windows.Forms.Button dugme_pretraga;
        private System.Windows.Forms.Button dugme_brisi;
        private System.Windows.Forms.Button dugme_novi;
        private System.Windows.Forms.Button dugme_snimi;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtREG;
        private System.Windows.Forms.TextBox txtNaslov;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDOS;
        private System.Windows.Forms.DataGrid pregled;
        private System.Windows.Forms.Label natpis_filter;
        private System.Windows.Forms.CheckBox cbAzur;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtIZM;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOpstina;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKart;
        private System.Windows.Forms.BindingSource izvor;
    }
}