namespace Urban
{
    partial class frmObrad
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
            this.label1 = new System.Windows.Forms.Label();
            this.lblPostojeci = new System.Windows.Forms.ListBox();
            this.podloga = new System.Windows.Forms.Panel();
            this.lblSvi = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtNovi = new System.Windows.Forms.TextBox();
            this.lblNovi = new System.Windows.Forms.ListBox();
            this.btnDodaj = new System.Windows.Forms.Button();
            this.btnOduzmi = new System.Windows.Forms.Button();
            this.podloga.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "OBRAĐIVAČI PLANA";
            // 
            // lblPostojeci
            // 
            this.lblPostojeci.FormattingEnabled = true;
            this.lblPostojeci.ItemHeight = 16;
            this.lblPostojeci.Location = new System.Drawing.Point(15, 29);
            this.lblPostojeci.Name = "lblPostojeci";
            this.lblPostojeci.Size = new System.Drawing.Size(325, 84);
            this.lblPostojeci.TabIndex = 1;
            this.lblPostojeci.KeyDown += new System.Windows.Forms.KeyEventHandler(this.lblPostojeci_KeyDown);
            // 
            // podloga
            // 
            this.podloga.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.podloga.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.podloga.Controls.Add(this.btnOduzmi);
            this.podloga.Controls.Add(this.btnDodaj);
            this.podloga.Controls.Add(this.lblNovi);
            this.podloga.Controls.Add(this.txtNovi);
            this.podloga.Controls.Add(this.button2);
            this.podloga.Controls.Add(this.button1);
            this.podloga.Controls.Add(this.label3);
            this.podloga.Controls.Add(this.label2);
            this.podloga.Controls.Add(this.lblSvi);
            this.podloga.Location = new System.Drawing.Point(15, 119);
            this.podloga.Name = "podloga";
            this.podloga.Size = new System.Drawing.Size(687, 186);
            this.podloga.TabIndex = 3;
            this.podloga.Visible = false;
            // 
            // lblSvi
            // 
            this.lblSvi.FormattingEnabled = true;
            this.lblSvi.ItemHeight = 16;
            this.lblSvi.Location = new System.Drawing.Point(3, 18);
            this.lblSvi.Name = "lblSvi";
            this.lblSvi.Size = new System.Drawing.Size(325, 100);
            this.lblSvi.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, -2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "SVI OBRAĐIVAČI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 121);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Novi";
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(424, 158);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(505, 158);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // txtNovi
            // 
            this.txtNovi.Location = new System.Drawing.Point(49, 124);
            this.txtNovi.Name = "txtNovi";
            this.txtNovi.Size = new System.Drawing.Size(275, 22);
            this.txtNovi.TabIndex = 8;
            // 
            // lblNovi
            // 
            this.lblNovi.FormattingEnabled = true;
            this.lblNovi.ItemHeight = 16;
            this.lblNovi.Location = new System.Drawing.Point(400, 18);
            this.lblNovi.Name = "lblNovi";
            this.lblNovi.Size = new System.Drawing.Size(282, 100);
            this.lblNovi.TabIndex = 9;
            // 
            // btnDodaj
            // 
            this.btnDodaj.Location = new System.Drawing.Point(336, 33);
            this.btnDodaj.Name = "btnDodaj";
            this.btnDodaj.Size = new System.Drawing.Size(58, 23);
            this.btnDodaj.TabIndex = 10;
            this.btnDodaj.Text = "-->";
            this.btnDodaj.UseVisualStyleBackColor = true;
            this.btnDodaj.Click += new System.EventHandler(this.btnDodaj_Click);
            // 
            // btnOduzmi
            // 
            this.btnOduzmi.Location = new System.Drawing.Point(336, 82);
            this.btnOduzmi.Name = "btnOduzmi";
            this.btnOduzmi.Size = new System.Drawing.Size(58, 23);
            this.btnOduzmi.TabIndex = 11;
            this.btnOduzmi.Text = "<--";
            this.btnOduzmi.UseVisualStyleBackColor = true;
            this.btnOduzmi.Click += new System.EventHandler(this.btnOduzmi_Click);
            // 
            // frmObrad
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(714, 317);
            this.Controls.Add(this.podloga);
            this.Controls.Add(this.lblPostojeci);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObrad";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Obrađivači predmeta";
            this.Load += new System.EventHandler(this.frmObrad_Load);
            this.podloga.ResumeLayout(false);
            this.podloga.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lblPostojeci;
        private System.Windows.Forms.Panel podloga;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lblSvi;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDodaj;
        private System.Windows.Forms.ListBox lblNovi;
        private System.Windows.Forms.TextBox txtNovi;
        private System.Windows.Forms.Button btnOduzmi;
    }
}