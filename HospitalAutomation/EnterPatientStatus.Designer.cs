namespace HospitalAutomation
{
    partial class FormEnterPatientStatus
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
            this.radioButtonOutpatient = new System.Windows.Forms.RadioButton();
            this.radioButtonInpatient = new System.Windows.Forms.RadioButton();
            this.btnOk = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(40, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hasta Statüsü Giriniz :";
            // 
            // radioButtonOutpatient
            // 
            this.radioButtonOutpatient.AutoSize = true;
            this.radioButtonOutpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonOutpatient.Location = new System.Drawing.Point(211, 50);
            this.radioButtonOutpatient.Name = "radioButtonOutpatient";
            this.radioButtonOutpatient.Size = new System.Drawing.Size(113, 22);
            this.radioButtonOutpatient.TabIndex = 1;
            this.radioButtonOutpatient.TabStop = true;
            this.radioButtonOutpatient.Text = "Ayakta Hasta";
            this.radioButtonOutpatient.UseVisualStyleBackColor = true;
            // 
            // radioButtonInpatient
            // 
            this.radioButtonInpatient.AutoSize = true;
            this.radioButtonInpatient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButtonInpatient.Location = new System.Drawing.Point(211, 90);
            this.radioButtonInpatient.Name = "radioButtonInpatient";
            this.radioButtonInpatient.Size = new System.Drawing.Size(106, 22);
            this.radioButtonInpatient.TabIndex = 2;
            this.radioButtonInpatient.TabStop = true;
            this.radioButtonInpatient.Text = "Yatan Hasta";
            this.radioButtonInpatient.UseVisualStyleBackColor = true;
            // 
            // btnOk
            // 
            this.btnOk.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOk.Location = new System.Drawing.Point(340, 170);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(90, 45);
            this.btnOk.TabIndex = 3;
            this.btnOk.Text = "TAMAM";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // FormEnterPatientStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 261);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.radioButtonInpatient);
            this.Controls.Add(this.radioButtonOutpatient);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FormEnterPatientStatus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "5-Kocaeli Üniversitesi Tıp Fakültesi Arşiv Otomasyonu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton radioButtonOutpatient;
        private System.Windows.Forms.RadioButton radioButtonInpatient;
        private System.Windows.Forms.Button btnOk;
    }
}