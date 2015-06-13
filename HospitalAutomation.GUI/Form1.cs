using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalAutomation.GUI;
using HospitalAutomation.Util;
using WIATest;

namespace HastaneArsiv
{
    public partial class Form1 : Form
    {
        ErrorTracker eTracker;

        public Form1()
        {
            InitializeComponent();
        }

        #region Genel Tanımlar
        List<Resimler> TumResimler = new List<Resimler>();
        Resimler secilenResim;
        int i = 0; // PictureBox Name
        PictureBox pbSecilen = new PictureBox(); 
        #endregion
       
        private void Form1_Load(object sender, EventArgs e)
        {
            tvKayit.ExpandAll();
            RaporKontrol();

            eTracker = new ErrorTracker(errorProviderHomePage);
            errorProviderHomePage.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        #region Tarama Metotları
        private void btnTara_Click(object sender, EventArgs e)
        {
            if (tvKayit.SelectedNode.Tag != null)
            {
                if (tvKayit.SelectedNode.Tag.ToString() != "Rapor")
                {
                    MessageBox.Show("Rapor Bilgisi Seçiniz !");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Rapor Bilgisi Seçiniz !");
                return;
            }
            try
            {
                string deneme = "";
                foreach (string device in WIAScanner.GetDevices())
                {
                    deneme = device;
                }
                List<Image> images = WIAScanner.Scan(deneme);
                foreach (Image image in images)
                {
                    PictureBox pb = new PictureBox();
                    pb.Name = "pb" + i;
                    pb.Size = new Size(70, 50);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Image = image;
                    pb.Click += new EventHandler(pb_Click);
                    pb.Tag = tvKayit.SelectedNode.Text;
                    TumResimler.Add(new Resimler(i, tvKayit.SelectedNode.Text, pb.Name, pb.Image));
                    flpResimler.Controls.Add(pb);
                    i++;
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        void pb_Click(object sender, EventArgs e)
        {
            try
            {
                pbSecilen = ((PictureBox)sender);
                pbResim.Image = pbSecilen.Image;
                lblRaporBilgi.Text = ((PictureBox)sender).Tag.ToString();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void flpResimler_ControlAdded(object sender, ControlEventArgs e)
        {
            pb_Click(e.Control, new EventArgs());
        }
        private void btnIptal_Click(object sender, EventArgs e)
        {
            try
            {
                secilenResim = (from n in TumResimler
                                where n.ResimAd == pbSecilen.Name
                                select n).FirstOrDefault();
                if (secilenResim != null)
                {
                    flpResimler.Controls.RemoveByKey(pbSecilen.Name);
                    TumResimler.Remove(secilenResim);
                    if (TumResimler.Count > 0)
                    {
                        secilenResim = TumResimler.First();
                        pbResim.Name = secilenResim.ResimAd;
                        pbResim.Tag = secilenResim.RaporAd;
                        pbResim.Image = secilenResim.Resim;
                        lblRaporBilgi.Text = pbResim.Tag.ToString();

                        pbSecilen = pbResim;
                    }
                    else
                    {
                        pbResim.Image = null;
                        lblRaporBilgi.Text = "";
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void btnPc_Click(object sender, EventArgs e)
        {
            try
            {
                if (tvKayit.SelectedNode.Tag != null)
                {
                    if (tvKayit.SelectedNode.Tag.ToString() != "Rapor")
                    {
                        MessageBox.Show("Rapor Bilgisi Seçiniz !");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show("Rapor Bilgisi Seçiniz !");
                    return;
                }

                if (ofdDigital.ShowDialog() == DialogResult.OK)
                {

                    foreach (string r in ofdDigital.FileNames)
                    {
                        PictureBox pb = new PictureBox();
                        pb.Name = "pb" + i;
                        pb.Size = new Size(70, 50);
                        pb.SizeMode = PictureBoxSizeMode.StretchImage;
                        pb.Image = Image.FromFile(r);
                        pb.Click += new EventHandler(pb_Click);
                        pb.Tag = tvKayit.SelectedNode.Text;
                        TumResimler.Add(new Resimler(i, tvKayit.SelectedNode.Text, pb.Name, pb.Image));
                        flpResimler.Controls.Add(pb);
                        i++;
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        } 
        #endregion

        #region TreeView Metotları
        private void tvKayit_AfterCheck(object sender, TreeViewEventArgs e)
        {
            try
            {
                if (e.Node.Text == "Bölüm")
                    new Bolum().ShowDialog();
                else if (e.Node.Text == "Öğretim Üyesi")
                    new OgretimUyesi().ShowDialog();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
        private void tvKayit_AfterSelect(object sender, TreeViewEventArgs e)
        {
            try
            {
                TagClose();
                if (e.Node.Tag != null)
                    TagControl(e.Node.Tag.ToString());
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }


        }
        void TagControl(string Tag)
        {
            foreach (Control item in gbDosya.Controls)
            {
                if (item.Name == Tag)
                {
                    item.Enabled = true;
                    item.BackColor = Color.RoyalBlue;
                    return;
                }
            }
            foreach (Control item in gbKayit.Controls)
            {
                if (item.Name == Tag)
                {
                    item.Enabled = true;
                    item.BackColor = Color.RoyalBlue;
                    return;
                }
            }
        }
        void TagClose()
        {
            foreach (Control item in gbDosya.Controls)
            {
                if (item is Label) continue;
                item.Enabled = false;
                item.BackColor = Color.White;
            }
            foreach (Control item in gbKayit.Controls)
            {
                if (item is Label) continue;
                item.BackColor = Color.White;
                item.Enabled = false;
            }
        }
        void RaporKontrol()
        {
            //foreach (TreeNode item in tvKayit.Nodes[2].Nodes[)
            //{

            //    if (item.Tag == "Rapor")
            //        item.Checked = true;
            //}
        } 
        #endregion

        #region Ayar Metotları
        private void tanıBilgisiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new TaniBilgisi().ShowDialog();
        }
        private void öğretimÜyesiToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void bölümToolStripMenuItem_Click(object sender, EventArgs e)
        {

        } 
        #endregion

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Hasta için tüm dosyaları tarattığınıza emin misiniz ?", "ÖNEMLİ", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
                if (MessageBox.Show("Kayit işlemi başarılı ! Bu hasta için başka bir kayit girmek ister misiniz ?", "YENİ KAYIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    return;

        }
       
        class Resimler
        {
            public int ResimID { get; set; }
            public string RaporAd { get; set; }
            public string ResimAd { get; set; }
            public Image Resim { get; set; }
            public Resimler(int _ResimID, string _RaporAd, string _ResimAd, Image _Resim)
            {
                ResimID = _ResimID;
                RaporAd = _RaporAd;
                ResimAd = _ResimAd;
                Resim = _Resim;
            }
        }

        /// change kontrol
        /// 
        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
        

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            errorProviderHomePage.Clear();

            bool istxtTcNoFieldEmpty = string.IsNullOrWhiteSpace(txtTcNo.Text);
            

            if (istxtTcNoFieldEmpty || txtTcNo.TextLength != 11)
            {
                eTracker.SetError(txtTcNo, "Geçersiz TC No");
            }


            try
            {
                bool result = Validator.TCNoKontrolu(txtTcNo.Text); 
                if(result ==  false)
                {
                    eTracker.SetError(txtTcNo, "Geçersiz TC No");
                }
            }
            catch (Exception)
            {
                eTracker.SetError(txtTcNo, "Geçersiz TC No");                
            }
        }

        // Tarihlerin Kontrolü
        private void dtpKapanisTarih_ValueChanged(object sender, EventArgs e)
        {
            errorProviderHomePage.Clear();
            if(dtpKapanisTarih.Value < dtpTarih.Value)
            {
                eTracker.SetError(dtpKapanisTarih, "Açılış Tarihinden Sonraki Günlerden Seçiniz !");
            }

        }        
    }
}
