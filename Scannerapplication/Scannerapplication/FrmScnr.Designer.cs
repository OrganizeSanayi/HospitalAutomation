using System.Windows.Forms;
namespace Scannerapplication
{
    partial class FrmScnr
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
            this.showImages = new System.Windows.Forms.Button();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.pnl_capture = new System.Windows.Forms.Panel();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.pic_scan = new System.Windows.Forms.PictureBox();
            this.lbDevices = new System.Windows.Forms.ListBox();
            this.btn_scan = new System.Windows.Forms.Button();
            this.btnTaramayiBitir = new System.Windows.Forms.Button();
            this.pnl_capture.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).BeginInit();
            this.SuspendLayout();
            // 
            // showImages
            // 
            this.showImages.Location = new System.Drawing.Point(242, 216);
            this.showImages.Name = "showImages";
            this.showImages.Size = new System.Drawing.Size(85, 23);
            this.showImages.TabIndex = 5;
            this.showImages.Text = "Show Images";
            this.showImages.UseVisualStyleBackColor = true;
            this.showImages.Visible = false;
            // 
            // splitter1
            // 
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(787, 3);
            this.splitter1.TabIndex = 38;
            this.splitter1.TabStop = false;
            // 
            // pnl_capture
            // 
            this.pnl_capture.BackColor = System.Drawing.Color.Transparent;
            this.pnl_capture.Controls.Add(this.btnTaramayiBitir);
            this.pnl_capture.Controls.Add(this.btnSil);
            this.pnl_capture.Controls.Add(this.btnKaydet);
            this.pnl_capture.Controls.Add(this.pic_scan);
            this.pnl_capture.Controls.Add(this.lbDevices);
            this.pnl_capture.Controls.Add(this.btn_scan);
            this.pnl_capture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnl_capture.Location = new System.Drawing.Point(0, 3);
            this.pnl_capture.Name = "pnl_capture";
            this.pnl_capture.Size = new System.Drawing.Size(787, 712);
            this.pnl_capture.TabIndex = 39;
            this.pnl_capture.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_capture_Paint);
            // 
            // btnSil
            // 
            this.btnSil.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnSil.Location = new System.Drawing.Point(21, 158);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(120, 32);
            this.btnSil.TabIndex = 8;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnKaydet
            // 
            this.btnKaydet.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnKaydet.Location = new System.Drawing.Point(21, 109);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 32);
            this.btnKaydet.TabIndex = 7;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // pic_scan
            // 
            this.pic_scan.BackColor = System.Drawing.Color.White;
            this.pic_scan.Location = new System.Drawing.Point(165, 21);
            this.pic_scan.Name = "pic_scan";
            this.pic_scan.Size = new System.Drawing.Size(450, 600);
            this.pic_scan.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pic_scan.TabIndex = 6;
            this.pic_scan.TabStop = false;
            this.pic_scan.Visible = false;
            // 
            // lbDevices
            // 
            this.lbDevices.FormattingEnabled = true;
            this.lbDevices.Location = new System.Drawing.Point(21, 61);
            this.lbDevices.Name = "lbDevices";
            this.lbDevices.Size = new System.Drawing.Size(120, 30);
            this.lbDevices.TabIndex = 5;
            this.lbDevices.Visible = false;
            // 
            // btn_scan
            // 
            this.btn_scan.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btn_scan.Location = new System.Drawing.Point(21, 17);
            this.btn_scan.Name = "btn_scan";
            this.btn_scan.Size = new System.Drawing.Size(120, 30);
            this.btn_scan.TabIndex = 4;
            this.btn_scan.Text = "Tara";
            this.btn_scan.UseVisualStyleBackColor = true;
            this.btn_scan.Click += new System.EventHandler(this.btn_scan_Click);
            // 
            // btnTaramayiBitir
            // 
            this.btnTaramayiBitir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnTaramayiBitir.Location = new System.Drawing.Point(30, 291);
            this.btnTaramayiBitir.Name = "btnTaramayiBitir";
            this.btnTaramayiBitir.Size = new System.Drawing.Size(100, 40);
            this.btnTaramayiBitir.TabIndex = 9;
            this.btnTaramayiBitir.Text = "Taramayı Bitir";
            this.btnTaramayiBitir.UseVisualStyleBackColor = true;
            this.btnTaramayiBitir.Click += new System.EventHandler(this.btnTaramayiBitir_Click);
            // 
            // FrmScnr
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(787, 715);
            this.Controls.Add(this.pnl_capture);
            this.Controls.Add(this.splitter1);
            this.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.KeyPreview = true;
            this.Name = "FrmScnr";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.SizeChanged += new System.EventHandler(this.Home_SizeChanged);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FrmScnr_KeyDown);
            this.pnl_capture.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic_scan)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion



        //camera
        private System.Windows.Forms.Button showImages;
        private Splitter splitter1;
        private Panel pnl_capture;
        private PictureBox pic_scan;
        private ListBox lbDevices;
        private Button btn_scan;
        private Button btnKaydet;
        private Button btnSil;
        private Button btnTaramayiBitir;
    }
}

