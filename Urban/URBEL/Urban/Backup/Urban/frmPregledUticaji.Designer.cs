namespace Urban
{
    partial class frmPregledUticaji
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
            this.prikaz = new System.Windows.Forms.DataGrid();
            this.label1 = new System.Windows.Forms.Label();
            this.txtOpis = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDatum = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTip = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // prikaz
            // 
            this.prikaz.DataMember = "";
            this.prikaz.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.prikaz.Location = new System.Drawing.Point(14, 12);
            this.prikaz.Name = "prikaz";
            this.prikaz.ReadOnly = true;
            this.prikaz.Size = new System.Drawing.Size(783, 148);
            this.prikaz.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 163);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Opis uticaja:";
            // 
            // txtOpis
            // 
            this.txtOpis.Location = new System.Drawing.Point(96, 166);
            this.txtOpis.Multiline = true;
            this.txtOpis.Name = "txtOpis";
            this.txtOpis.ReadOnly = true;
            this.txtOpis.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtOpis.Size = new System.Drawing.Size(268, 97);
            this.txtOpis.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(370, 163);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Datum uticaja:";
            // 
            // txtDatum
            // 
            this.txtDatum.Location = new System.Drawing.Point(465, 166);
            this.txtDatum.Name = "txtDatum";
            this.txtDatum.ReadOnly = true;
            this.txtDatum.Size = new System.Drawing.Size(154, 20);
            this.txtDatum.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(370, 200);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tip uticaja:";
            // 
            // txtTip
            // 
            this.txtTip.Location = new System.Drawing.Point(447, 200);
            this.txtTip.Multiline = true;
            this.txtTip.Name = "txtTip";
            this.txtTip.ReadOnly = true;
            this.txtTip.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTip.Size = new System.Drawing.Size(286, 54);
            this.txtTip.TabIndex = 6;
            // 
            // frmPregledUticaji
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(811, 275);
            this.Controls.Add(this.txtTip);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDatum);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtOpis);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.prikaz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPregledUticaji";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Uticaji drugih planova";
            this.Load += new System.EventHandler(this.frmPregledUticaji_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid prikaz;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOpis;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDatum;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTip;
    }
}