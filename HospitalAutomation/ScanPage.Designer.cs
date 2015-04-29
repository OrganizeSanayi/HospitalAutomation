namespace HospitalAutomation
{
    partial class formScanPage
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
            this.btnPatientExamination = new System.Windows.Forms.Button();
            this.btnReports = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.radioBtnPatientAdmissionForm = new System.Windows.Forms.RadioButton();
            this.radioBtnConsents = new System.Windows.Forms.RadioButton();
            this.radioBtnOperationNote = new System.Windows.Forms.RadioButton();
            this.radioBtnPatientExamination = new System.Windows.Forms.RadioButton();
            this.radioBtnClinicalObservation = new System.Windows.Forms.RadioButton();
            this.radioBtnEpikriz = new System.Windows.Forms.RadioButton();
            this.radioBtnConsultation = new System.Windows.Forms.RadioButton();
            this.radioBtnAnesthesiaNote = new System.Windows.Forms.RadioButton();
            this.radioBtnPathology = new System.Windows.Forms.RadioButton();
            this.radioBtnOther = new System.Windows.Forms.RadioButton();
            this.radioBtnLab = new System.Windows.Forms.RadioButton();
            this.radioBtnNuclearMedicine = new System.Windows.Forms.RadioButton();
            this.radioBtnEndoscopic = new System.Windows.Forms.RadioButton();
            this.radioBtnRadiological = new System.Windows.Forms.RadioButton();
            this.btnScanFile = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSaveFile = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPatientExamination
            // 
            this.btnPatientExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPatientExamination.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnPatientExamination.Location = new System.Drawing.Point(14, 12);
            this.btnPatientExamination.Name = "btnPatientExamination";
            this.btnPatientExamination.Size = new System.Drawing.Size(263, 74);
            this.btnPatientExamination.TabIndex = 0;
            this.btnPatientExamination.Text = "HASTA MUAYENE ve EPİKRİZ";
            this.btnPatientExamination.UseVisualStyleBackColor = true;
            this.btnPatientExamination.Click += new System.EventHandler(this.btnPatientExamination_Click);
            // 
            // btnReports
            // 
            this.btnReports.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReports.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnReports.Location = new System.Drawing.Point(14, 101);
            this.btnReports.Name = "btnReports";
            this.btnReports.Size = new System.Drawing.Size(263, 74);
            this.btnReports.TabIndex = 1;
            this.btnReports.Text = "TETKİK ve RAPORLAR";
            this.btnReports.UseVisualStyleBackColor = true;
            this.btnReports.Click += new System.EventHandler(this.btnReports_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.panel1.Controls.Add(this.btnScanFile);
            this.panel1.Controls.Add(this.radioBtnRadiological);
            this.panel1.Controls.Add(this.radioBtnEndoscopic);
            this.panel1.Controls.Add(this.radioBtnNuclearMedicine);
            this.panel1.Controls.Add(this.radioBtnLab);
            this.panel1.Controls.Add(this.radioBtnOther);
            this.panel1.Controls.Add(this.radioBtnPathology);
            this.panel1.Controls.Add(this.radioBtnAnesthesiaNote);
            this.panel1.Controls.Add(this.radioBtnConsultation);
            this.panel1.Controls.Add(this.radioBtnEpikriz);
            this.panel1.Controls.Add(this.radioBtnClinicalObservation);
            this.panel1.Controls.Add(this.radioBtnPatientExamination);
            this.panel1.Controls.Add(this.radioBtnOperationNote);
            this.panel1.Controls.Add(this.radioBtnConsents);
            this.panel1.Controls.Add(this.radioBtnPatientAdmissionForm);
            this.panel1.Controls.Add(this.btnPatientExamination);
            this.panel1.Controls.Add(this.btnReports);
            this.panel1.Location = new System.Drawing.Point(26, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1247, 193);
            this.panel1.TabIndex = 2;
            // 
            // radioBtnPatientAdmissionForm
            // 
            this.radioBtnPatientAdmissionForm.AutoSize = true;
            this.radioBtnPatientAdmissionForm.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPatientAdmissionForm.Location = new System.Drawing.Point(296, 27);
            this.radioBtnPatientAdmissionForm.Name = "radioBtnPatientAdmissionForm";
            this.radioBtnPatientAdmissionForm.Size = new System.Drawing.Size(142, 21);
            this.radioBtnPatientAdmissionForm.TabIndex = 2;
            this.radioBtnPatientAdmissionForm.TabStop = true;
            this.radioBtnPatientAdmissionForm.Text = "Hasta Yatış Formu";
            this.radioBtnPatientAdmissionForm.UseVisualStyleBackColor = true;
            this.radioBtnPatientAdmissionForm.Visible = false;
            // 
            // radioBtnConsents
            // 
            this.radioBtnConsents.AutoSize = true;
            this.radioBtnConsents.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnConsents.Location = new System.Drawing.Point(296, 54);
            this.radioBtnConsents.Name = "radioBtnConsents";
            this.radioBtnConsents.Size = new System.Drawing.Size(80, 21);
            this.radioBtnConsents.TabIndex = 3;
            this.radioBtnConsents.TabStop = true;
            this.radioBtnConsents.Text = "Onamlar";
            this.radioBtnConsents.UseVisualStyleBackColor = true;
            this.radioBtnConsents.Visible = false;
            // 
            // radioBtnOperationNote
            // 
            this.radioBtnOperationNote.AutoSize = true;
            this.radioBtnOperationNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOperationNote.Location = new System.Drawing.Point(471, 27);
            this.radioBtnOperationNote.Name = "radioBtnOperationNote";
            this.radioBtnOperationNote.Size = new System.Drawing.Size(113, 21);
            this.radioBtnOperationNote.TabIndex = 4;
            this.radioBtnOperationNote.TabStop = true;
            this.radioBtnOperationNote.Text = "Ameliyat Notu";
            this.radioBtnOperationNote.UseVisualStyleBackColor = true;
            this.radioBtnOperationNote.Visible = false;
            // 
            // radioBtnPatientExamination
            // 
            this.radioBtnPatientExamination.AutoSize = true;
            this.radioBtnPatientExamination.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPatientExamination.Location = new System.Drawing.Point(607, 54);
            this.radioBtnPatientExamination.Name = "radioBtnPatientExamination";
            this.radioBtnPatientExamination.Size = new System.Drawing.Size(135, 21);
            this.radioBtnPatientExamination.TabIndex = 5;
            this.radioBtnPatientExamination.TabStop = true;
            this.radioBtnPatientExamination.Text = "Hasta Muayenesi";
            this.radioBtnPatientExamination.UseVisualStyleBackColor = true;
            this.radioBtnPatientExamination.Visible = false;
            // 
            // radioBtnClinicalObservation
            // 
            this.radioBtnClinicalObservation.AutoSize = true;
            this.radioBtnClinicalObservation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnClinicalObservation.Location = new System.Drawing.Point(607, 27);
            this.radioBtnClinicalObservation.Name = "radioBtnClinicalObservation";
            this.radioBtnClinicalObservation.Size = new System.Drawing.Size(114, 21);
            this.radioBtnClinicalObservation.TabIndex = 6;
            this.radioBtnClinicalObservation.TabStop = true;
            this.radioBtnClinicalObservation.Text = "Klinik Gözlemi";
            this.radioBtnClinicalObservation.UseVisualStyleBackColor = true;
            this.radioBtnClinicalObservation.Visible = false;
            // 
            // radioBtnEpikriz
            // 
            this.radioBtnEpikriz.AutoSize = true;
            this.radioBtnEpikriz.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEpikriz.Location = new System.Drawing.Point(769, 54);
            this.radioBtnEpikriz.Name = "radioBtnEpikriz";
            this.radioBtnEpikriz.Size = new System.Drawing.Size(68, 21);
            this.radioBtnEpikriz.TabIndex = 7;
            this.radioBtnEpikriz.TabStop = true;
            this.radioBtnEpikriz.Text = "Epikriz";
            this.radioBtnEpikriz.UseVisualStyleBackColor = true;
            this.radioBtnEpikriz.Visible = false;
            // 
            // radioBtnConsultation
            // 
            this.radioBtnConsultation.AutoSize = true;
            this.radioBtnConsultation.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnConsultation.Location = new System.Drawing.Point(769, 27);
            this.radioBtnConsultation.Name = "radioBtnConsultation";
            this.radioBtnConsultation.Size = new System.Drawing.Size(111, 21);
            this.radioBtnConsultation.TabIndex = 8;
            this.radioBtnConsultation.TabStop = true;
            this.radioBtnConsultation.Text = "Konsültasyon";
            this.radioBtnConsultation.UseVisualStyleBackColor = true;
            this.radioBtnConsultation.Visible = false;
            // 
            // radioBtnAnesthesiaNote
            // 
            this.radioBtnAnesthesiaNote.AutoSize = true;
            this.radioBtnAnesthesiaNote.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnAnesthesiaNote.Location = new System.Drawing.Point(470, 54);
            this.radioBtnAnesthesiaNote.Name = "radioBtnAnesthesiaNote";
            this.radioBtnAnesthesiaNote.Size = new System.Drawing.Size(114, 21);
            this.radioBtnAnesthesiaNote.TabIndex = 9;
            this.radioBtnAnesthesiaNote.TabStop = true;
            this.radioBtnAnesthesiaNote.Text = "Anestezi Notu";
            this.radioBtnAnesthesiaNote.UseVisualStyleBackColor = true;
            this.radioBtnAnesthesiaNote.Visible = false;
            // 
            // radioBtnPathology
            // 
            this.radioBtnPathology.AutoSize = true;
            this.radioBtnPathology.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnPathology.Location = new System.Drawing.Point(296, 120);
            this.radioBtnPathology.Name = "radioBtnPathology";
            this.radioBtnPathology.Size = new System.Drawing.Size(72, 21);
            this.radioBtnPathology.TabIndex = 10;
            this.radioBtnPathology.TabStop = true;
            this.radioBtnPathology.Text = "Patoloji";
            this.radioBtnPathology.UseVisualStyleBackColor = true;
            this.radioBtnPathology.Visible = false;
            // 
            // radioBtnOther
            // 
            this.radioBtnOther.AutoSize = true;
            this.radioBtnOther.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnOther.Location = new System.Drawing.Point(607, 143);
            this.radioBtnOther.Name = "radioBtnOther";
            this.radioBtnOther.Size = new System.Drawing.Size(60, 21);
            this.radioBtnOther.TabIndex = 11;
            this.radioBtnOther.TabStop = true;
            this.radioBtnOther.Text = "Diğer";
            this.radioBtnOther.UseVisualStyleBackColor = true;
            this.radioBtnOther.Visible = false;
            // 
            // radioBtnLab
            // 
            this.radioBtnLab.AutoSize = true;
            this.radioBtnLab.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnLab.Location = new System.Drawing.Point(607, 120);
            this.radioBtnLab.Name = "radioBtnLab";
            this.radioBtnLab.Size = new System.Drawing.Size(103, 21);
            this.radioBtnLab.TabIndex = 12;
            this.radioBtnLab.TabStop = true;
            this.radioBtnLab.Text = "Laboratuvar";
            this.radioBtnLab.UseVisualStyleBackColor = true;
            this.radioBtnLab.Visible = false;
            // 
            // radioBtnNuclearMedicine
            // 
            this.radioBtnNuclearMedicine.AutoSize = true;
            this.radioBtnNuclearMedicine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnNuclearMedicine.Location = new System.Drawing.Point(471, 143);
            this.radioBtnNuclearMedicine.Name = "radioBtnNuclearMedicine";
            this.radioBtnNuclearMedicine.Size = new System.Drawing.Size(99, 21);
            this.radioBtnNuclearMedicine.TabIndex = 13;
            this.radioBtnNuclearMedicine.TabStop = true;
            this.radioBtnNuclearMedicine.Text = "Nükleer Tıp";
            this.radioBtnNuclearMedicine.UseVisualStyleBackColor = true;
            this.radioBtnNuclearMedicine.Visible = false;
            // 
            // radioBtnEndoscopic
            // 
            this.radioBtnEndoscopic.AutoSize = true;
            this.radioBtnEndoscopic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnEndoscopic.Location = new System.Drawing.Point(471, 120);
            this.radioBtnEndoscopic.Name = "radioBtnEndoscopic";
            this.radioBtnEndoscopic.Size = new System.Drawing.Size(99, 21);
            this.radioBtnEndoscopic.TabIndex = 14;
            this.radioBtnEndoscopic.TabStop = true;
            this.radioBtnEndoscopic.Text = "Endoskobik";
            this.radioBtnEndoscopic.UseVisualStyleBackColor = true;
            this.radioBtnEndoscopic.Visible = false;
            // 
            // radioBtnRadiological
            // 
            this.radioBtnRadiological.AutoSize = true;
            this.radioBtnRadiological.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBtnRadiological.Location = new System.Drawing.Point(296, 143);
            this.radioBtnRadiological.Name = "radioBtnRadiological";
            this.radioBtnRadiological.Size = new System.Drawing.Size(84, 21);
            this.radioBtnRadiological.TabIndex = 15;
            this.radioBtnRadiological.TabStop = true;
            this.radioBtnRadiological.Text = "Radyoloji";
            this.radioBtnRadiological.UseVisualStyleBackColor = true;
            this.radioBtnRadiological.Visible = false;
            // 
            // btnScanFile
            // 
            this.btnScanFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnScanFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnScanFile.Location = new System.Drawing.Point(1069, 101);
            this.btnScanFile.Name = "btnScanFile";
            this.btnScanFile.Size = new System.Drawing.Size(127, 74);
            this.btnScanFile.TabIndex = 16;
            this.btnScanFile.Text = "DOSYA TARA";
            this.btnScanFile.UseVisualStyleBackColor = true;
            this.btnScanFile.Click += new System.EventHandler(this.btnScanFile_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pictureBox1.Location = new System.Drawing.Point(26, 267);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(455, 315);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(23, 246);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 4;
            this.label1.Text = "TARANAN DOSYA :";
            // 
            // btnSaveFile
            // 
            this.btnSaveFile.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveFile.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnSaveFile.Location = new System.Drawing.Point(1095, 218);
            this.btnSaveFile.Name = "btnSaveFile";
            this.btnSaveFile.Size = new System.Drawing.Size(127, 74);
            this.btnSaveFile.TabIndex = 17;
            this.btnSaveFile.Text = "DOSYAYI KAYDET";
            this.btnSaveFile.UseVisualStyleBackColor = true;
            // 
            // formScanPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1289, 594);
            this.Controls.Add(this.btnSaveFile);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Name = "formScanPage";
            this.Text = "Dosya Tarama";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPatientExamination;
        private System.Windows.Forms.Button btnReports;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioBtnAnesthesiaNote;
        private System.Windows.Forms.RadioButton radioBtnConsultation;
        private System.Windows.Forms.RadioButton radioBtnEpikriz;
        private System.Windows.Forms.RadioButton radioBtnClinicalObservation;
        private System.Windows.Forms.RadioButton radioBtnPatientExamination;
        private System.Windows.Forms.RadioButton radioBtnOperationNote;
        private System.Windows.Forms.RadioButton radioBtnConsents;
        private System.Windows.Forms.RadioButton radioBtnPatientAdmissionForm;
        private System.Windows.Forms.RadioButton radioBtnRadiological;
        private System.Windows.Forms.RadioButton radioBtnEndoscopic;
        private System.Windows.Forms.RadioButton radioBtnNuclearMedicine;
        private System.Windows.Forms.RadioButton radioBtnLab;
        private System.Windows.Forms.RadioButton radioBtnOther;
        private System.Windows.Forms.RadioButton radioBtnPathology;
        private System.Windows.Forms.Button btnScanFile;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSaveFile;
    }
}