namespace HospitalAutomation
{
    partial class FormEnterReports
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
            this.comboBoxReports = new System.Windows.Forms.ComboBox();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(175, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tetkik - Raporları Giriniz :";
            // 
            // comboBoxReports
            // 
            this.comboBoxReports.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxReports.FormattingEnabled = true;
            this.comboBoxReports.Items.AddRange(new object[] {
            "Patoloji",
            "Radyoloji",
            "Endoskobik",
            "Nükleer Tıp",
            "Laboratuvar",
            "Diğer"});
            this.comboBoxReports.Location = new System.Drawing.Point(45, 90);
            this.comboBoxReports.Name = "comboBoxReports";
            this.comboBoxReports.Size = new System.Drawing.Size(291, 21);
            this.comboBoxReports.TabIndex = 1;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(340, 170);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 46);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "TAMAM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormEnterReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.comboBoxReports);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEnterReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "7-Kocaeli Üniversitesi Tıp Fakültesi Arşiv Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxReports;
        private System.Windows.Forms.Button btnOk;
    }
}