namespace Urban
{
    partial class frmIzvSettings
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
            this.dataGridBoolColumn1 = new System.Windows.Forms.DataGridBoolColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.unos_tekst = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // prikaz
            // 
            this.prikaz.DataMember = "";
            this.prikaz.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.prikaz.Location = new System.Drawing.Point(14, 2);
            this.prikaz.Name = "prikaz";
            this.prikaz.Size = new System.Drawing.Size(769, 112);
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
            this.dataGridBoolColumn1});
            this.dataGridTableStyle1.HeaderForeColor = System.Drawing.SystemColors.ControlText;
            this.dataGridTableStyle1.MappingName = "Napomena";
            // 
            // dataGridTextBoxColumn1
            // 
            this.dataGridTextBoxColumn1.Format = "";
            this.dataGridTextBoxColumn1.FormatInfo = null;
            this.dataGridTextBoxColumn1.HeaderText = "ID";
            this.dataGridTextBoxColumn1.MappingName = "id";
            this.dataGridTextBoxColumn1.Width = 150;
            // 
            // dataGridTextBoxColumn2
            // 
            this.dataGridTextBoxColumn2.Format = "";
            this.dataGridTextBoxColumn2.FormatInfo = null;
            this.dataGridTextBoxColumn2.HeaderText = "Opis";
            this.dataGridTextBoxColumn2.MappingName = "opis";
            this.dataGridTextBoxColumn2.Width = 500;
            // 
            // dataGridBoolColumn1
            // 
            this.dataGridBoolColumn1.HeaderText = "Prikazuje se";
            this.dataGridBoolColumn1.MappingName = "prikazuje";
            this.dataGridBoolColumn1.NullText = "";
            this.dataGridBoolColumn1.NullValue = "False";
            this.dataGridBoolColumn1.Width = 75;
            // 
            // button2
            // 
            this.button2.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button2.Location = new System.Drawing.Point(206, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(119, 35);
            this.button2.TabIndex = 3;
            this.button2.Text = "Odustani";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.button1.Location = new System.Drawing.Point(70, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 35);
            this.button1.TabIndex = 2;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(313, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tekst napomene";
            // 
            // unos_tekst
            // 
            this.unos_tekst.Location = new System.Drawing.Point(422, 120);
            this.unos_tekst.Multiline = true;
            this.unos_tekst.Name = "unos_tekst";
            this.unos_tekst.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.unos_tekst.Size = new System.Drawing.Size(361, 123);
            this.unos_tekst.TabIndex = 5;
            // 
            // frmIzvSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(797, 255);
            this.Controls.Add(this.unos_tekst);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.prikaz);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmIzvSettings";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Podesavanja izvestaja";
            this.Load += new System.EventHandler(this.frmIzvSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.prikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGrid prikaz;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridTableStyle dataGridTableStyle1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn1;
        private System.Windows.Forms.DataGridTextBoxColumn dataGridTextBoxColumn2;
        private System.Windows.Forms.DataGridBoolColumn dataGridBoolColumn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox unos_tekst;
    }
}