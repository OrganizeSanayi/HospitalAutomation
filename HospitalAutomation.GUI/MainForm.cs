using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalAutomation.GUI;
using HospitalAutomation.Util;
using WIATest;

namespace HospitalAutomation.GUI
{
    public partial class MainForm : Form
    {
        ErrorTracker _eTracker;

        public MainForm()
        {
            InitializeComponent();
        }

        #region Genel Tanımlar

        readonly List<Resimler> _tumResimler = new List<Resimler>();
        Resimler _secilenResim;
        int _i; // PictureBox Name
        PictureBox _pbSecilen = new PictureBox(); 
        #endregion
       
        private void Form1_Load(object sender, EventArgs e)
        {
            tvKayit.ExpandAll();
            RaporKontrol();

            _eTracker = new ErrorTracker(errorProviderHomePage);
        }

        #region Tarama Metotları
        private void btnTara_Click(object sender, EventArgs e)
        {
            if (tvKayit.SelectedNode.Tag != null)
            {
                if (tvKayit.SelectedNode.Tag.ToString() != "Rapor")
                {
                    MessageBox.Show(@"Rapor Bilgisi Seçiniz !");
                    return;
                }
            }
            else
            {
                MessageBox.Show(@"Rapor Bilgisi Seçiniz !");
                return;
            }
            try
            {
                var deneme = "";
                foreach (var device in WIAScanner.GetDevices())
                {
                    deneme = device;
                }

                var images = WIAScanner.Scan(deneme);
                foreach (var image in images)
                {
                    var pb = new PictureBox
                    {
                        Name = "pb" + _i,
                        Size = new Size(70, 50),
                        SizeMode = PictureBoxSizeMode.StretchImage,
                        Image = image
                    };

                    pb.Click += new EventHandler(pb_Click);
                    pb.Tag = tvKayit.SelectedNode.Text;
                    _tumResimler.Add(new Resimler(_i, tvKayit.SelectedNode.Text, pb.Name, pb.Image));
                    flpResimler.Controls.Add(pb);
                    _i++;
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
                _pbSecilen = ((PictureBox)sender);
                pbResim.Image = _pbSecilen.Image;
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
                _secilenResim = (from n in _tumResimler
                                where n.ResimAd == _pbSecilen.Name
                                select n).FirstOrDefault();

                if (_secilenResim == null) return;

                flpResimler.Controls.RemoveByKey(_pbSecilen.Name);
                _tumResimler.Remove(_secilenResim);
                if (_tumResimler.Count > 0)
                {
                    _secilenResim = _tumResimler.First();
                    pbResim.Name = _secilenResim.ResimAd;
                    pbResim.Tag = _secilenResim.RaporAd;
                    pbResim.Image = _secilenResim.Resim;
                    lblRaporBilgi.Text = pbResim.Tag.ToString();

                    _pbSecilen = pbResim;
                }
                else
                {
                    pbResim.Image = null;
                    lblRaporBilgi.Text = "";
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
                        MessageBox.Show(@"Rapor Bilgisi Seçiniz !");
                        return;
                    }
                }
                else
                {
                    MessageBox.Show(@"Rapor Bilgisi Seçiniz !");
                    return;
                }

                if (ofdDigital.ShowDialog() == DialogResult.OK)
                {

                    foreach (var r in ofdDigital.FileNames)
                    {
                        var pb = new PictureBox
                        {
                            Name = "pb" + _i,
                            Size = new Size(70, 50),
                            SizeMode = PictureBoxSizeMode.StretchImage,
                            Image = Image.FromFile(r)
                        };
                        pb.Click += new EventHandler(pb_Click);
                        pb.Tag = tvKayit.SelectedNode.Text;
                        _tumResimler.Add(new Resimler(_i, tvKayit.SelectedNode.Text, pb.Name, pb.Image));
                        flpResimler.Controls.Add(pb);
                        _i++;
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
                switch (e.Node.Text)
                {
                    case "Bölüm":
                        new Bolum().ShowDialog();
                        break;
                    case "Öğretim Üyesi":
                        new OgretimUyesi().ShowDialog();
                        break;
                }
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
        void TagControl(string tag)
        {
            foreach (var item in gbDosya.Controls.Cast<Control>().Where(item => item.Name == tag))
            {
                item.Enabled = true;
                item.BackColor = Color.RoyalBlue;
                return;
            }
            foreach (var item in gbKayit.Controls.Cast<Control>().Where(item => item.Name == tag))
            {
                item.Enabled = true;
                item.BackColor = Color.RoyalBlue;
                return;
            }
        }

        void TagClose()
        {
            foreach (var item in gbDosya.Controls.Cast<Control>().Where(item => !(item is Label)))
            {
                item.Enabled = false;
                item.BackColor = Color.White;
            }
            foreach (var item in gbKayit.Controls.Cast<Control>().Where(item => !(item is Label)))
            {
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
            if (MessageBox.Show(@"Hasta için tüm dosyaları tarattığınıza emin misiniz ?", @"ÖNEMLİ",
                    MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                if (MessageBox.Show(@"Kayit işlemi başarılı ! Bu hasta için başka bir kayit girmek ister misiniz ?",
                        @"YENİ KAYIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
        }
       
        class Resimler
        {
            public int ResimID { get; set; }
            public string RaporAd { get; }
            public string ResimAd { get; }
            public Image Resim { get; }
            public Resimler(int resimId, string raporAd, string resimAd, Image resim)
            {
                ResimID = resimId;
                RaporAd = raporAd;
                ResimAd = resimAd;
                Resim = resim;
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
            _eTracker.Clear();

            var istxtTcNoFieldEmpty = string.IsNullOrWhiteSpace(txtTcNo.Text);
            

            if (istxtTcNoFieldEmpty || txtTcNo.TextLength != 11)
            {
                _eTracker.SetError(txtTcNo, "Geçersiz TC No");
            }

            try
            {
                var result = Validator.TCNoKontrolu(txtTcNo.Text); 
                if(result ==  false)
                {
                    _eTracker.SetError(txtTcNo, "Geçersiz TC No");
                }
            }
            catch (Exception)
            {
                _eTracker.SetError(txtTcNo, "Geçersiz TC No");                
            }
        }

        // Tarihlerin Kontrolü
        private void dtpKapanisTarih_ValueChanged(object sender, EventArgs e)
        {
            _eTracker.Clear();
            if(dtpKapanisTarih.Value < dtpTarih.Value)
            {
                _eTracker.SetError(dtpKapanisTarih, "Açılış Tarihinden Sonraki Günlerden Seçiniz !");
            }

        }        
    }
}
