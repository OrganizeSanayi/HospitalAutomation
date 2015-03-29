namespace HospitalAutomation
{
    partial class Login
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
            this.tabPageScanner = new System.Windows.Forms.TabPage();
            this.btnScannerLogin = new System.Windows.Forms.Button();
            this.txtScannerPassword = new System.Windows.Forms.TextBox();
            this.txtScannerUserName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tabPageDoctor = new System.Windows.Forms.TabPage();
            this.btnDoctorLogin = new System.Windows.Forms.Button();
            this.txtDoctorPassword = new System.Windows.Forms.TextBox();
            this.txtDoctorUserName = new System.Windows.Forms.TextBox();
            this.lblDoctorUserPassword = new System.Windows.Forms.Label();
            this.lblDoctorUserName = new System.Windows.Forms.Label();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageScanner.SuspendLayout();
            this.tabPageDoctor.SuspendLayout();
            this.tabControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPageScanner
            // 
            this.tabPageScanner.Controls.Add(this.btnScannerLogin);
            this.tabPageScanner.Controls.Add(this.txtScannerPassword);
            this.tabPageScanner.Controls.Add(this.txtScannerUserName);
            this.tabPageScanner.Controls.Add(this.label1);
            this.tabPageScanner.Controls.Add(this.label3);
            this.tabPageScanner.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageScanner.Location = new System.Drawing.Point(4, 34);
            this.tabPageScanner.Name = "tabPageScanner";
            this.tabPageScanner.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageScanner.Size = new System.Drawing.Size(426, 281);
            this.tabPageScanner.TabIndex = 1;
            this.tabPageScanner.Text = "TARAYICI GİRİŞİ";
            this.tabPageScanner.UseVisualStyleBackColor = true;
            // 
            // btnScannerLogin
            // 
            this.btnScannerLogin.Location = new System.Drawing.Point(185, 168);
            this.btnScannerLogin.Name = "btnScannerLogin";
            this.btnScannerLogin.Size = new System.Drawing.Size(154, 35);
            this.btnScannerLogin.TabIndex = 9;
            this.btnScannerLogin.Text = "GİRİŞ";
            this.btnScannerLogin.UseVisualStyleBackColor = true;
            this.btnScannerLogin.Click += new System.EventHandler(this.btnScannerLogin_Click);
            // 
            // txtScannerPassword
            // 
            this.txtScannerPassword.Location = new System.Drawing.Point(185, 120);
            this.txtScannerPassword.MaxLength = 15;
            this.txtScannerPassword.Name = "txtScannerPassword";
            this.txtScannerPassword.PasswordChar = '*';
            this.txtScannerPassword.Size = new System.Drawing.Size(154, 23);
            this.txtScannerPassword.TabIndex = 8;
            // 
            // txtScannerUserName
            // 
            this.txtScannerUserName.Location = new System.Drawing.Point(185, 81);
            this.txtScannerUserName.MaxLength = 15;
            this.txtScannerUserName.Name = "txtScannerUserName";
            this.txtScannerUserName.Size = new System.Drawing.Size(154, 23);
            this.txtScannerUserName.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(76, 120);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "Şifre            :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(76, 81);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Kullanıcı Adı :";
            // 
            // tabPageDoctor
            // 
            this.tabPageDoctor.Controls.Add(this.btnDoctorLogin);
            this.tabPageDoctor.Controls.Add(this.txtDoctorPassword);
            this.tabPageDoctor.Controls.Add(this.txtDoctorUserName);
            this.tabPageDoctor.Controls.Add(this.lblDoctorUserPassword);
            this.tabPageDoctor.Controls.Add(this.lblDoctorUserName);
            this.tabPageDoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPageDoctor.Location = new System.Drawing.Point(4, 34);
            this.tabPageDoctor.Name = "tabPageDoctor";
            this.tabPageDoctor.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageDoctor.Size = new System.Drawing.Size(426, 281);
            this.tabPageDoctor.TabIndex = 0;
            this.tabPageDoctor.Text = "DOKTOR GİRİŞİ";
            this.tabPageDoctor.UseVisualStyleBackColor = true;
            // 
            // btnDoctorLogin
            // 
            this.btnDoctorLogin.Location = new System.Drawing.Point(185, 168);
            this.btnDoctorLogin.Name = "btnDoctorLogin";
            this.btnDoctorLogin.Size = new System.Drawing.Size(154, 35);
            this.btnDoctorLogin.TabIndex = 4;
            this.btnDoctorLogin.Text = "GİRİŞ";
            this.btnDoctorLogin.UseVisualStyleBackColor = true;
            this.btnDoctorLogin.Click += new System.EventHandler(this.btnDoctorLogin_Click);
            // 
            // txtDoctorPassword
            // 
            this.txtDoctorPassword.Location = new System.Drawing.Point(185, 120);
            this.txtDoctorPassword.MaxLength = 15;
            this.txtDoctorPassword.Name = "txtDoctorPassword";
            this.txtDoctorPassword.PasswordChar = '*';
            this.txtDoctorPassword.Size = new System.Drawing.Size(154, 23);
            this.txtDoctorPassword.TabIndex = 3;
            // 
            // txtDoctorUserName
            // 
            this.txtDoctorUserName.Location = new System.Drawing.Point(185, 81);
            this.txtDoctorUserName.MaxLength = 15;
            this.txtDoctorUserName.Name = "txtDoctorUserName";
            this.txtDoctorUserName.Size = new System.Drawing.Size(154, 23);
            this.txtDoctorUserName.TabIndex = 2;
            // 
            // lblDoctorUserPassword
            // 
            this.lblDoctorUserPassword.AutoSize = true;
            this.lblDoctorUserPassword.Location = new System.Drawing.Point(76, 120);
            this.lblDoctorUserPassword.Name = "lblDoctorUserPassword";
            this.lblDoctorUserPassword.Size = new System.Drawing.Size(89, 17);
            this.lblDoctorUserPassword.TabIndex = 1;
            this.lblDoctorUserPassword.Text = "Şifre            :";
            // 
            // lblDoctorUserName
            // 
            this.lblDoctorUserName.AutoSize = true;
            this.lblDoctorUserName.Location = new System.Drawing.Point(76, 81);
            this.lblDoctorUserName.Name = "lblDoctorUserName";
            this.lblDoctorUserName.Size = new System.Drawing.Size(92, 17);
            this.lblDoctorUserName.TabIndex = 0;
            this.lblDoctorUserName.Text = "Kullanıcı Adı :";
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.tabPageDoctor);
            this.tabControl.Controls.Add(this.tabPageScanner);
            this.tabControl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl.ItemSize = new System.Drawing.Size(110, 30);
            this.tabControl.Location = new System.Drawing.Point(12, 12);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(434, 319);
            this.tabControl.TabIndex = 0;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(456, 342);
            this.Controls.Add(this.tabControl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kocaeli Üniversitesi Tıp Fakültesi Arşiv Otomasyonu";
            this.tabPageScanner.ResumeLayout(false);
            this.tabPageScanner.PerformLayout();
            this.tabPageDoctor.ResumeLayout(false);
            this.tabPageDoctor.PerformLayout();
            this.tabControl.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPageScanner;
        private System.Windows.Forms.TabPage tabPageDoctor;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.Label lblDoctorUserPassword;
        private System.Windows.Forms.Label lblDoctorUserName;
        private System.Windows.Forms.Button btnDoctorLogin;
        private System.Windows.Forms.TextBox txtDoctorPassword;
        private System.Windows.Forms.TextBox txtDoctorUserName;
        private System.Windows.Forms.Button btnScannerLogin;
        private System.Windows.Forms.TextBox txtScannerPassword;
        private System.Windows.Forms.TextBox txtScannerUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;

    }
}

