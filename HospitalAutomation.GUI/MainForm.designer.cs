namespace HospitalAutomation.GUI
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("TC Numarası");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Dosya Numarası");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Dosya Bilgisi", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Dosya Açılış Tarihi");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Dosya Kapanış Tarihi");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Bölüm");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Öğretim Üyesi");
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Hasta Tanısı");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("Hasta Statüsü");
            System.Windows.Forms.TreeNode treeNode10 = new System.Windows.Forms.TreeNode("Kayıt Bilgisi", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5,
            treeNode6,
            treeNode7,
            treeNode8,
            treeNode9});
            System.Windows.Forms.TreeNode treeNode11 = new System.Windows.Forms.TreeNode("Hasta Yatış Formu");
            System.Windows.Forms.TreeNode treeNode12 = new System.Windows.Forms.TreeNode("Ameliyat Notu");
            System.Windows.Forms.TreeNode treeNode13 = new System.Windows.Forms.TreeNode("Klinik Gözlem");
            System.Windows.Forms.TreeNode treeNode14 = new System.Windows.Forms.TreeNode("Konsültasyon");
            System.Windows.Forms.TreeNode treeNode15 = new System.Windows.Forms.TreeNode("Onamlar");
            System.Windows.Forms.TreeNode treeNode16 = new System.Windows.Forms.TreeNode("Anestezi Notu");
            System.Windows.Forms.TreeNode treeNode17 = new System.Windows.Forms.TreeNode("Hasta Muayenesi");
            System.Windows.Forms.TreeNode treeNode18 = new System.Windows.Forms.TreeNode("Epikriz");
            System.Windows.Forms.TreeNode treeNode19 = new System.Windows.Forms.TreeNode("Hasta Muayene ve Ekipriz", new System.Windows.Forms.TreeNode[] {
            treeNode11,
            treeNode12,
            treeNode13,
            treeNode14,
            treeNode15,
            treeNode16,
            treeNode17,
            treeNode18});
            System.Windows.Forms.TreeNode treeNode20 = new System.Windows.Forms.TreeNode("Radyoloji");
            System.Windows.Forms.TreeNode treeNode21 = new System.Windows.Forms.TreeNode("Patoloji");
            System.Windows.Forms.TreeNode treeNode22 = new System.Windows.Forms.TreeNode("Laboratuvar");
            System.Windows.Forms.TreeNode treeNode23 = new System.Windows.Forms.TreeNode("Nükleer Tıp");
            System.Windows.Forms.TreeNode treeNode24 = new System.Windows.Forms.TreeNode("Endoskobik");
            System.Windows.Forms.TreeNode treeNode25 = new System.Windows.Forms.TreeNode("Tetkik ve Raporlar", new System.Windows.Forms.TreeNode[] {
            treeNode20,
            treeNode21,
            treeNode22,
            treeNode23,
            treeNode24});
            System.Windows.Forms.TreeNode treeNode26 = new System.Windows.Forms.TreeNode("Adli ve Sağlık Kurulu");
            System.Windows.Forms.TreeNode treeNode27 = new System.Windows.Forms.TreeNode("Diğer");
            System.Windows.Forms.TreeNode treeNode28 = new System.Windows.Forms.TreeNode("Rapor Bilgisi", new System.Windows.Forms.TreeNode[] {
            treeNode19,
            treeNode25,
            treeNode26,
            treeNode27});
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.yrdDoçDrSuhapŞAHİNToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arşGörHikmetcanÖZCANToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arşGörTanerGÜVENToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.gbKayit = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dtpKapanisTarih = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pHastaStatu = new System.Windows.Forms.Panel();
            this.rbYatan = new System.Windows.Forms.RadioButton();
            this.rbAyakta = new System.Windows.Forms.RadioButton();
            this.txtBolum = new System.Windows.Forms.TextBox();
            this.txtOgretimUyesi = new System.Windows.Forms.TextBox();
            this.txtHastaTanisi = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.gbDosya = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTcNo = new System.Windows.Forms.TextBox();
            this.txtDosyaNo = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbResim = new System.Windows.Forms.PictureBox();
            this.flpResimler = new System.Windows.Forms.FlowLayoutPanel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblRaporBilgi = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnPc = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.btnTara = new System.Windows.Forms.Button();
            this.tvKayit = new System.Windows.Forms.TreeView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ayarlarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tanıBilgisiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.öğretimÜyesiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bölümToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ofdDigital = new System.Windows.Forms.OpenFileDialog();
            this.errorProviderHomePage = new System.Windows.Forms.ErrorProvider(this.components);
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.gbKayit.SuspendLayout();
            this.pHastaStatu.SuspendLayout();
            this.gbDosya.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel6.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHomePage)).BeginInit();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.yrdDoçDrSuhapŞAHİNToolStripMenuItem,
            this.arşGörHikmetcanÖZCANToolStripMenuItem,
            this.arşGörTanerGÜVENToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(219, 70);
            // 
            // yrdDoçDrSuhapŞAHİNToolStripMenuItem
            // 
            this.yrdDoçDrSuhapŞAHİNToolStripMenuItem.Name = "yrdDoçDrSuhapŞAHİNToolStripMenuItem";
            this.yrdDoçDrSuhapŞAHİNToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.yrdDoçDrSuhapŞAHİNToolStripMenuItem.Text = "Yrd. Doç. Dr. Suhap ŞAHİN";
            // 
            // arşGörHikmetcanÖZCANToolStripMenuItem
            // 
            this.arşGörHikmetcanÖZCANToolStripMenuItem.Name = "arşGörHikmetcanÖZCANToolStripMenuItem";
            this.arşGörHikmetcanÖZCANToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.arşGörHikmetcanÖZCANToolStripMenuItem.Text = "Arş.Gör Hikmetcan ÖZCAN";
            // 
            // arşGörTanerGÜVENToolStripMenuItem
            // 
            this.arşGörTanerGÜVENToolStripMenuItem.Name = "arşGörTanerGÜVENToolStripMenuItem";
            this.arşGörTanerGÜVENToolStripMenuItem.Size = new System.Drawing.Size(218, 22);
            this.arşGörTanerGÜVENToolStripMenuItem.Text = "Arş.Gör Taner GÜVEN";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(272, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 485);
            this.panel1.TabIndex = 2;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.gbKayit);
            this.panel2.Controls.Add(this.gbDosya);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(10);
            this.panel2.Size = new System.Drawing.Size(435, 483);
            this.panel2.TabIndex = 1;
            // 
            // gbKayit
            // 
            this.gbKayit.Controls.Add(this.textBox1);
            this.gbKayit.Controls.Add(this.label10);
            this.gbKayit.Controls.Add(this.label8);
            this.gbKayit.Controls.Add(this.label9);
            this.gbKayit.Controls.Add(this.label6);
            this.gbKayit.Controls.Add(this.label7);
            this.gbKayit.Controls.Add(this.dtpKapanisTarih);
            this.gbKayit.Controls.Add(this.label4);
            this.gbKayit.Controls.Add(this.label5);
            this.gbKayit.Controls.Add(this.pHastaStatu);
            this.gbKayit.Controls.Add(this.txtBolum);
            this.gbKayit.Controls.Add(this.txtOgretimUyesi);
            this.gbKayit.Controls.Add(this.txtHastaTanisi);
            this.gbKayit.Controls.Add(this.dtpTarih);
            this.gbKayit.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbKayit.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbKayit.Location = new System.Drawing.Point(10, 107);
            this.gbKayit.Margin = new System.Windows.Forms.Padding(0);
            this.gbKayit.Name = "gbKayit";
            this.gbKayit.Size = new System.Drawing.Size(415, 368);
            this.gbKayit.TabIndex = 1;
            this.gbKayit.TabStop = false;
            this.gbKayit.Text = "Kayıt Bilgisi";
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(123, 211);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBox1.Size = new System.Drawing.Size(269, 79);
            this.textBox1.TabIndex = 19;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(36, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 18);
            this.label10.TabIndex = 18;
            this.label10.Text = "ICD 10 :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(5, 305);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(108, 18);
            this.label8.TabIndex = 17;
            this.label8.Text = "H. Statüsü :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(41, 103);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 18);
            this.label9.TabIndex = 16;
            this.label9.Text = "Bölüm :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(94, 18);
            this.label6.TabIndex = 15;
            this.label6.Text = "H. Tanısı :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(107, 18);
            this.label7.TabIndex = 14;
            this.label7.Text = "Öğr. Üyesi :";
            // 
            // dtpKapanisTarih
            // 
            this.dtpKapanisTarih.Enabled = false;
            this.dtpKapanisTarih.Location = new System.Drawing.Point(123, 63);
            this.dtpKapanisTarih.Name = "dtpKapanisTarih";
            this.dtpKapanisTarih.Size = new System.Drawing.Size(269, 27);
            this.dtpKapanisTarih.TabIndex = 1;
            this.dtpKapanisTarih.ValueChanged += new System.EventHandler(this.dtpKapanisTarih_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 69);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(108, 18);
            this.label4.TabIndex = 13;
            this.label4.Text = "Kapanış T. :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(86, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Açılış T. :";
            // 
            // pHastaStatu
            // 
            this.pHastaStatu.Controls.Add(this.rbYatan);
            this.pHastaStatu.Controls.Add(this.rbAyakta);
            this.pHastaStatu.Location = new System.Drawing.Point(123, 300);
            this.pHastaStatu.Name = "pHastaStatu";
            this.pHastaStatu.Size = new System.Drawing.Size(228, 33);
            this.pHastaStatu.TabIndex = 6;
            // 
            // rbYatan
            // 
            this.rbYatan.AutoSize = true;
            this.rbYatan.Location = new System.Drawing.Point(117, 3);
            this.rbYatan.Name = "rbYatan";
            this.rbYatan.Size = new System.Drawing.Size(74, 22);
            this.rbYatan.TabIndex = 5;
            this.rbYatan.Text = "Yatan";
            this.rbYatan.UseVisualStyleBackColor = true;
            // 
            // rbAyakta
            // 
            this.rbAyakta.AutoSize = true;
            this.rbAyakta.Checked = true;
            this.rbAyakta.Location = new System.Drawing.Point(17, 3);
            this.rbAyakta.Name = "rbAyakta";
            this.rbAyakta.Size = new System.Drawing.Size(82, 22);
            this.rbAyakta.TabIndex = 4;
            this.rbAyakta.TabStop = true;
            this.rbAyakta.Text = "Ayakta";
            this.rbAyakta.UseVisualStyleBackColor = true;
            // 
            // txtBolum
            // 
            this.txtBolum.Enabled = false;
            this.txtBolum.Location = new System.Drawing.Point(123, 100);
            this.txtBolum.Name = "txtBolum";
            this.txtBolum.Size = new System.Drawing.Size(269, 27);
            this.txtBolum.TabIndex = 2;
            // 
            // txtOgretimUyesi
            // 
            this.txtOgretimUyesi.Enabled = false;
            this.txtOgretimUyesi.Location = new System.Drawing.Point(123, 137);
            this.txtOgretimUyesi.Name = "txtOgretimUyesi";
            this.txtOgretimUyesi.Size = new System.Drawing.Size(269, 27);
            this.txtOgretimUyesi.TabIndex = 3;
            // 
            // txtHastaTanisi
            // 
            this.txtHastaTanisi.Enabled = false;
            this.txtHastaTanisi.Location = new System.Drawing.Point(123, 174);
            this.txtHastaTanisi.MaxLength = 25;
            this.txtHastaTanisi.Name = "txtHastaTanisi";
            this.txtHastaTanisi.Size = new System.Drawing.Size(269, 27);
            this.txtHastaTanisi.TabIndex = 4;
            // 
            // dtpTarih
            // 
            this.dtpTarih.Enabled = false;
            this.dtpTarih.Location = new System.Drawing.Point(123, 26);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(269, 27);
            this.dtpTarih.TabIndex = 0;
            // 
            // gbDosya
            // 
            this.gbDosya.Controls.Add(this.label2);
            this.gbDosya.Controls.Add(this.label1);
            this.gbDosya.Controls.Add(this.txtTcNo);
            this.gbDosya.Controls.Add(this.txtDosyaNo);
            this.gbDosya.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbDosya.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gbDosya.Location = new System.Drawing.Point(10, 10);
            this.gbDosya.Name = "gbDosya";
            this.gbDosya.Size = new System.Drawing.Size(415, 97);
            this.gbDosya.TabIndex = 0;
            this.gbDosya.TabStop = false;
            this.gbDosya.Text = "Dosya Bilgisi";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 18);
            this.label2.TabIndex = 11;
            this.label2.Text = "TC No :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 18);
            this.label1.TabIndex = 10;
            this.label1.Text = "Dosya No :";
            // 
            // txtTcNo
            // 
            this.txtTcNo.BackColor = System.Drawing.Color.RoyalBlue;
            this.txtTcNo.Enabled = false;
            this.txtTcNo.Location = new System.Drawing.Point(123, 26);
            this.txtTcNo.MaxLength = 11;
            this.txtTcNo.Name = "txtTcNo";
            this.txtTcNo.Size = new System.Drawing.Size(269, 27);
            this.txtTcNo.TabIndex = 9;
            this.txtTcNo.TextChanged += new System.EventHandler(this.txtTcNo_TextChanged);
            this.txtTcNo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTcNo_KeyPress);
            // 
            // txtDosyaNo
            // 
            this.txtDosyaNo.Enabled = false;
            this.txtDosyaNo.Location = new System.Drawing.Point(123, 59);
            this.txtDosyaNo.MaxLength = 25;
            this.txtDosyaNo.Name = "txtDosyaNo";
            this.txtDosyaNo.Size = new System.Drawing.Size(269, 27);
            this.txtDosyaNo.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.pbResim);
            this.panel3.Controls.Add(this.flpResimler);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel3.Location = new System.Drawing.Point(433, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(529, 483);
            this.panel3.TabIndex = 2;
            // 
            // pbResim
            // 
            this.pbResim.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbResim.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pbResim.Location = new System.Drawing.Point(99, 28);
            this.pbResim.Name = "pbResim";
            this.pbResim.Size = new System.Drawing.Size(428, 404);
            this.pbResim.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbResim.TabIndex = 10;
            this.pbResim.TabStop = false;
            // 
            // flpResimler
            // 
            this.flpResimler.AutoScroll = true;
            this.flpResimler.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpResimler.Dock = System.Windows.Forms.DockStyle.Left;
            this.flpResimler.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpResimler.Location = new System.Drawing.Point(0, 28);
            this.flpResimler.Name = "flpResimler";
            this.flpResimler.Size = new System.Drawing.Size(99, 404);
            this.flpResimler.TabIndex = 9;
            this.flpResimler.WrapContents = false;
            this.flpResimler.ControlAdded += new System.Windows.Forms.ControlEventHandler(this.flpResimler_ControlAdded);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.lblRaporBilgi);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(527, 28);
            this.panel4.TabIndex = 8;
            // 
            // lblRaporBilgi
            // 
            this.lblRaporBilgi.AutoSize = true;
            this.lblRaporBilgi.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblRaporBilgi.Location = new System.Drawing.Point(138, 5);
            this.lblRaporBilgi.Name = "lblRaporBilgi";
            this.lblRaporBilgi.Size = new System.Drawing.Size(0, 18);
            this.lblRaporBilgi.TabIndex = 10;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.Location = new System.Drawing.Point(14, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 18);
            this.label3.TabIndex = 9;
            this.label3.Text = "Rapor Bilgisi :";
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel6.Controls.Add(this.btnKaydet);
            this.panel6.Controls.Add(this.btnPc);
            this.panel6.Controls.Add(this.btnIptal);
            this.panel6.Controls.Add(this.btnTara);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 432);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(527, 49);
            this.panel6.TabIndex = 11;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnKaydet.Location = new System.Drawing.Point(432, 5);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(92, 41);
            this.btnKaydet.TabIndex = 3;
            this.btnKaydet.Text = "kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click_1);
            // 
            // btnPc
            // 
            this.btnPc.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnPc.Location = new System.Drawing.Point(148, 3);
            this.btnPc.Name = "btnPc";
            this.btnPc.Size = new System.Drawing.Size(136, 43);
            this.btnPc.TabIndex = 1;
            this.btnPc.Text = "PC";
            this.btnPc.UseVisualStyleBackColor = true;
            this.btnPc.Click += new System.EventHandler(this.btnPc_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnIptal.Location = new System.Drawing.Point(290, 3);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(136, 43);
            this.btnIptal.TabIndex = 2;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // btnTara
            // 
            this.btnTara.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.btnTara.Location = new System.Drawing.Point(6, 3);
            this.btnTara.Name = "btnTara";
            this.btnTara.Size = new System.Drawing.Size(136, 43);
            this.btnTara.TabIndex = 0;
            this.btnTara.Text = "Tara";
            this.btnTara.UseVisualStyleBackColor = true;
            this.btnTara.Click += new System.EventHandler(this.btnTara_Click);
            // 
            // tvKayit
            // 
            this.tvKayit.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.tvKayit.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tvKayit.CheckBoxes = true;
            this.tvKayit.Dock = System.Windows.Forms.DockStyle.Left;
            this.tvKayit.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvKayit.HideSelection = false;
            this.tvKayit.HotTracking = true;
            this.tvKayit.Location = new System.Drawing.Point(0, 24);
            this.tvKayit.Name = "tvKayit";
            treeNode1.Name = "D1";
            treeNode1.Tag = "txtTcNo";
            treeNode1.Text = "TC Numarası";
            treeNode2.Name = "D2";
            treeNode2.Tag = "txtDosyaNo";
            treeNode2.Text = "Dosya Numarası";
            treeNode3.Name = "D0";
            treeNode3.Tag = "";
            treeNode3.Text = "Dosya Bilgisi";
            treeNode3.ToolTipText = "Hastanın TC si ve Dosya Numarası";
            treeNode4.Name = "K1";
            treeNode4.Tag = "dtpTarih";
            treeNode4.Text = "Dosya Açılış Tarihi";
            treeNode5.Name = "Node1";
            treeNode5.Tag = "dtpKapanisTarih";
            treeNode5.Text = "Dosya Kapanış Tarihi";
            treeNode6.Name = "K2";
            treeNode6.Tag = "txtBolum";
            treeNode6.Text = "Bölüm";
            treeNode7.Name = "K3";
            treeNode7.Tag = "txtOgretimUyesi";
            treeNode7.Text = "Öğretim Üyesi";
            treeNode8.Name = "K4";
            treeNode8.Tag = "txtHastaTanisi";
            treeNode8.Text = "Hasta Tanısı";
            treeNode9.Name = "K5";
            treeNode9.Tag = "pHastaStatu";
            treeNode9.Text = "Hasta Statüsü";
            treeNode10.Name = "K0";
            treeNode10.Tag = "";
            treeNode10.Text = "Kayıt Bilgisi";
            treeNode10.ToolTipText = "Hastanın Kayıt Bilgileri";
            treeNode11.Name = "H1";
            treeNode11.Tag = "Rapor";
            treeNode11.Text = "Hasta Yatış Formu";
            treeNode12.Name = "H2";
            treeNode12.Tag = "Rapor";
            treeNode12.Text = "Ameliyat Notu";
            treeNode13.Name = "H3";
            treeNode13.Tag = "Rapor";
            treeNode13.Text = "Klinik Gözlem";
            treeNode14.Name = "H4";
            treeNode14.Tag = "Rapor";
            treeNode14.Text = "Konsültasyon";
            treeNode15.Name = "H5";
            treeNode15.Tag = "Rapor";
            treeNode15.Text = "Onamlar";
            treeNode16.Name = "H6";
            treeNode16.Tag = "Rapor";
            treeNode16.Text = "Anestezi Notu";
            treeNode17.Name = "H7";
            treeNode17.Tag = "Rapor";
            treeNode17.Text = "Hasta Muayenesi";
            treeNode18.Name = "H8";
            treeNode18.Tag = "Rapor";
            treeNode18.Text = "Epikriz";
            treeNode19.Name = "R1";
            treeNode19.Text = "Hasta Muayene ve Ekipriz";
            treeNode20.Name = "T1";
            treeNode20.Tag = "Rapor";
            treeNode20.Text = "Radyoloji";
            treeNode21.Name = "T2";
            treeNode21.Tag = "Rapor";
            treeNode21.Text = "Patoloji";
            treeNode22.Name = "T3";
            treeNode22.Tag = "Rapor";
            treeNode22.Text = "Laboratuvar";
            treeNode23.Name = "T4";
            treeNode23.Tag = "Rapor";
            treeNode23.Text = "Nükleer Tıp";
            treeNode24.Name = "T5";
            treeNode24.Tag = "Rapor";
            treeNode24.Text = "Endoskobik";
            treeNode25.Name = "R1";
            treeNode25.Text = "Tetkik ve Raporlar";
            treeNode26.Name = "R2";
            treeNode26.Text = "Adli ve Sağlık Kurulu";
            treeNode27.Name = "Node0";
            treeNode27.Tag = "Rapor";
            treeNode27.Text = "Diğer";
            treeNode28.Name = "R0";
            treeNode28.Text = "Rapor Bilgisi";
            treeNode28.ToolTipText = "Hastaya Verilen Rapor Bilgileri";
            this.tvKayit.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode10,
            treeNode28});
            this.tvKayit.Size = new System.Drawing.Size(272, 485);
            this.tvKayit.TabIndex = 0;
            this.tvKayit.AfterCheck += new System.Windows.Forms.TreeViewEventHandler(this.tvKayit_AfterCheck);
            this.tvKayit.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvKayit_AfterSelect);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ayarlarToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1236, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ayarlarToolStripMenuItem
            // 
            this.ayarlarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tanıBilgisiToolStripMenuItem,
            this.öğretimÜyesiToolStripMenuItem,
            this.bölümToolStripMenuItem});
            this.ayarlarToolStripMenuItem.Name = "ayarlarToolStripMenuItem";
            this.ayarlarToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.ayarlarToolStripMenuItem.Text = "Ayarlar";
            // 
            // tanıBilgisiToolStripMenuItem
            // 
            this.tanıBilgisiToolStripMenuItem.Name = "tanıBilgisiToolStripMenuItem";
            this.tanıBilgisiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.tanıBilgisiToolStripMenuItem.Text = "Tanı Bilgisi ( ICD 10 )";
            this.tanıBilgisiToolStripMenuItem.Click += new System.EventHandler(this.tanıBilgisiToolStripMenuItem_Click);
            // 
            // öğretimÜyesiToolStripMenuItem
            // 
            this.öğretimÜyesiToolStripMenuItem.Name = "öğretimÜyesiToolStripMenuItem";
            this.öğretimÜyesiToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.öğretimÜyesiToolStripMenuItem.Text = "Öğretim Üyesi";
            this.öğretimÜyesiToolStripMenuItem.Click += new System.EventHandler(this.öğretimÜyesiToolStripMenuItem_Click);
            // 
            // bölümToolStripMenuItem
            // 
            this.bölümToolStripMenuItem.Name = "bölümToolStripMenuItem";
            this.bölümToolStripMenuItem.Size = new System.Drawing.Size(182, 22);
            this.bölümToolStripMenuItem.Text = "Bölüm";
            this.bölümToolStripMenuItem.Click += new System.EventHandler(this.bölümToolStripMenuItem_Click);
            // 
            // ofdDigital
            // 
            this.ofdDigital.FileName = "openFileDialog1";
            this.ofdDigital.Multiselect = true;
            // 
            // errorProviderHomePage
            // 
            this.errorProviderHomePage.ContainerControl = this;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 509);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tvKayit);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.gbKayit.ResumeLayout(false);
            this.gbKayit.PerformLayout();
            this.pHastaStatu.ResumeLayout(false);
            this.pHastaStatu.PerformLayout();
            this.gbDosya.ResumeLayout(false);
            this.gbDosya.PerformLayout();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pbResim)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderHomePage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbKayit;
        private System.Windows.Forms.GroupBox gbDosya;
        private System.Windows.Forms.RadioButton rbYatan;
        private System.Windows.Forms.RadioButton rbAyakta;
        private System.Windows.Forms.TextBox txtHastaTanisi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem yrdDoçDrSuhapŞAHİNToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arşGörHikmetcanÖZCANToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arşGörTanerGÜVENToolStripMenuItem;
        private System.Windows.Forms.TreeView tvKayit;
        public System.Windows.Forms.TextBox txtOgretimUyesi;
        public System.Windows.Forms.TextBox txtBolum;
        public System.Windows.Forms.TextBox txtTcNo;
        public System.Windows.Forms.TextBox txtDosyaNo;
        private System.Windows.Forms.Panel pHastaStatu;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ayarlarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tanıBilgisiToolStripMenuItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Button btnPc;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Button btnTara;
        private System.Windows.Forms.PictureBox pbResim;
        private System.Windows.Forms.FlowLayoutPanel flpResimler;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblRaporBilgi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpKapanisTarih;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripMenuItem öğretimÜyesiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bölümToolStripMenuItem;
        private System.Windows.Forms.OpenFileDialog ofdDigital;
        private System.Windows.Forms.ErrorProvider errorProviderHomePage;
        private System.Windows.Forms.Button btnKaydet;
    }
}

