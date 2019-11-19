namespace Urban
{
    partial class frmKorisnici
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
            this.dataGridTableStyle1 = new System.Windows.Forms.DataGridTableStyle();
            this.dataGridTextBoxColumn1 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn2 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn3 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridTextBoxColumn4 = new System.Windows.Forms.DataGridTextBoxColumn();
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn2 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn3 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn4 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn5 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn6 = new System.Windows.Forms.DataGridBoolColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridBoolColumn7 = new System.Windows.Forms.DataGridBoolColumn();
            this.dataGridBoolColumn8 = new System.Windows.Forms.DataGridBoolColumn();
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // prikaz
            // 
            this.prikaz.DataMember = "";
            this.prikaz.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.prikaz.Location = new System.Drawing.Point(14, 12);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(719, 192);
            this.prikaz.TabIndex = 0;
            this.prikaz.TableStyles.AddRange(new System.Windows.Forms.DataGridTableStyle[] {
            this.dataGridTableStyle1});
            // 
            // dataGridTableStyle1
            // 
            this.dataGridTableStyle1.DataGrid = this.prikaz;
            this.dataGridTableStyle1.GridColumnStyles.AddRange(new System.Windows.Forms.DataGridColumnStyle[] {
            this.dataGridTextBoxColumn1,
            this.dataGridTextBoxColumn2,
            this.dataGridTextBoxColumn3,
            this.dataGridTextBoxColumn4,
            this.dataGridBoolColumn1,
            this.dataGridBoolColumn2,
            this.dataGridBoolColumn3,
            this.dataGridBoolColumn4,
            this.dataGridBoolColumn5,
            this.dataGridBoolColumn6,
            this.dataGridBoolColumn7,
            this.dataGridBoolColumn8});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "Korisnik";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "Ime";
            this.dataGridTextBoxColumn1.MappingName = "ime";
            this.dataGridTextBoxColumn1.Width = 75;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Prezime";
            this.dataGridTextBoxColumn2.MappingName = "prezime";
            this.dataGridTextBoxColumn2.Width = 75;
            // 
            // dataGridTextBoxColumn3
            // 
            this.dataGridTextBoxColumn3.Format = "";
            this.dataGridTextBoxColumn3.FormatInfo = null;
            this.dataGridTextBoxColumn3.HeaderText = "Korisnicko ime";
            this.dataGridTextBoxColumn3.MappingName = "username";
            this.dataGridTextBoxColumn3.Width = 75;
            // 
            // dataGridTextBoxColumn4
            // 
            this.dataGridTextBoxColumn4.Format = "";
            this.dataGridTextBoxColumn4.FormatInfo = null;
            this.dataGridTextBoxColumn4.HeaderText = "Lozinka";
            this.dataGridTextBoxColumn4.MappingName = "password";
            this.dataGridTextBoxColumn4.Width = 75;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.HeaderText = "Azuriranje";
            this.dataGridBoolColumn1.MappingName = "azur";
            this.dataGridBoolColumn1.NullValue = "False";
            this.dataGridBoolColumn1.Width = 75;
            // 
            // dataGridBoolColumn2
            // 
            this.dataGridBoolColumn2.HeaderText = "Pretraga";
            this.dataGridBoolColumn2.MappingName = "pret";
            this.dataGridBoolColumn2.NullValue = "False";
            this.dataGridBoolColumn2.Width = 75;
            // 
            // dataGridBoolColumn3
            // 
            this.dataGridBoolColumn3.HeaderText = "Izvestaj";
            this.dataGridBoolColumn3.MappingName = "izve";
            this.dataGridBoolColumn3.NullValue = "False";
            this.dataGridBoolColumn3.Width = 75;
            // 
            // dataGridBoolColumn4
            // 
            this.dataGridBoolColumn4.HeaderText = "Admin";
            this.dataGridBoolColumn4.MappingName = "admi";
            this.dataGridBoolColumn4.NullValue = "False";
            this.dataGridBoolColumn4.Width = 75;
            // 
            // dataGridBoolColumn5
            // 
            this.dataGridBoolColumn5.HeaderText = "zadr";
            this.dataGridBoolColumn5.MappingName = "zadr";
            this.dataGridBoolColumn5.NullValue = "false";
            this.dataGridBoolColumn5.Width = 75;
            // 
            // dataGridBoolColumn6
            // 
            this.dataGridBoolColumn6.HeaderText = "zadw";
            this.dataGridBoolColumn6.MappingName = "zadw";
            this.dataGridBoolColumn6.NullValue = "false";
            this.dataGridBoolColumn6.Width = 75;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(339, 221);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(147, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Povratak";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // dataGridBoolColumn7
            // 
            this.dataGridBoolColumn7.HeaderText = "docr";
            this.dataGridBoolColumn7.MappingName = "docr";
            this.dataGridBoolColumn7.NullValue = "False";
            this.dataGridBoolColumn7.Width = 75;
            // 
            // dataGridBoolColumn8
            // 
            this.dataGridBoolColumn8.HeaderText = "docw";
            this.dataGridBoolColumn8.MappingName = "docw";
            this.dataGridBoolColumn8.NullValue = "False";
            this.dataGridBoolColumn8.Width = 75;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(747, 268);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prikaz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmKorisnici";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Korisnici";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmKorisnici_FormClosing);
            this.Load += new System.EventHandler(this.frmKorisnici_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid prikaz;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn3;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn2;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn3;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn4;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn5;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn6;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn7;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn8;
    }
}