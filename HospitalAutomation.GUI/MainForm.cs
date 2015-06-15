using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalAutomation.GUI;
using HospitalAutomation.Util;
using WIATest;
using System.Drawing.Imaging;
using System.IO;
using HospitalAutomation.Services;
using HospitalAutomation.Model;
namespace HospitalAutomation.GUI
{
    public partial class MainForm : Form
    {
        public int SelectedDoctor;
        ErrorTracker _eTracker;
                public MainForm()
        {
            InitializeComponent();
        }

        
        #region Genel Tanımlar

                string klasorTarih;
                string klasorTC;
                string klasorBolum;
                string resimYolu;
                static public int ogretimUyeId;
                Image image1;
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

            klasorTC = txtTcNo.Text;
            klasorBolum = txtBolum.Text;
            klasorTarih = dtpTarih.Value.ToString("yyyy-MM-dd");

            var selectedNode = tvKayit.SelectedNode;
           
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
            if (selectedNode.Parent.Text == "Hasta Muayene ve Ekipriz")
            {
                if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim"))
                {
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim\\";
                }
                else
                {
                    String path = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim\\";
                    //yyyy-MM-dd HH-mm-ss
                    if (!File.Exists(path))
                        System.IO.Directory.CreateDirectory(path);
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim\\";
                }
            }
            else if (selectedNode.Parent.Text == "Tetkik ve Raporlar")
            {

                if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor"))
                {
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor\\";
                }
                else
                {
                    Directory.CreateDirectory(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor");
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor\\";
                }
                    
            }
            else if (selectedNode.Text == "Adli ve Sağlık Kurulu")
            {
                if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\adliSaglik"))
                {
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\adliSaglik\\";
                }
                else
                {
                    Directory.CreateDirectory(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\adliSaglik");
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\adliSaglik\\";
                }
            }
            else if (selectedNode.Text == "Diğer")
            {
                if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\Diğer"))
                {
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\Diğer\\";
                }
                else
                {
                    Directory.CreateDirectory(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\Diğer");
                    resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\Diğer\\";
                }
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
                    _tumResimler.Add(new Resimler(_i, tvKayit.SelectedNode.Text, pb.Name, pb.Image)); // resimId, raporAd, resimAd, resim.
                    flpResimler.Controls.Add(pb);
                    image1 = pb.Image;
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
          
        }
       
        class Resimler
        {
            private int resimId;
            private string raporAd;
            private string resimAd;
            private Image resim;
            public int ResimID
            {
                get
                {
                    return resimId;
                }
                set
                {
                    resimId = value;
                }
            }
            public string RaporAd
            {
                get
                {
                    return raporAd;
                }
                set
                {
                    raporAd = value;
                }
            }
            public string ResimAd
            {
                get
                {
                    return resimAd;
                }
                set
                {
                    resimAd = value;
                }
            }
            public Image Resim
            {
                get
                {
                    return resim;
                }
                set{
                    resim=value;
                }
            }
            
         
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

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {

            int adliYol;
            int adliId;

            int raporYol;
            int raporId;
             
            int ekiprizYol;
            int ekiprizId;

          //  int tetkikRaporId;

            int bolumId;
            int ogretimGorevlisiID;
            int taniId;
            int statuId= 1;
            var fileNo = txtDosyaNo.Text; // Dosya Numarası
            using (var context = new HospitalAutomationEntities())
            {
                int query = context.BOLUMLER.Where(p => p.BolumAdi.Contains(txtBolum.Text)).Single().BolumId;
                bolumId = query; // BölümId
            }

      
            var date = dtpTarih.Value; // tarih bilgisi
            ogretimGorevlisiID = SelectedDoctor; // ogretim Uyesi
            using (var context = new HospitalAutomationEntities())
            {
                int query = context.TANILAR.Where(p => p.TaniAdi.Contains(txtHastaTanisi.Text)).Single().Taniid;
                taniId = query; // tanı id
            }
            if (rbYatan.Checked)
            {
                using (var context = new HospitalAutomationEntities())
                {
                    int query = context.STATU.Where(p => p.Statu.Contains(rbYatan.Text)).Single().StatuId;
                    statuId = query; // statu id
                }
            }
            else if (rbAyakta.Checked)
            {
                using (var context = new HospitalAutomationEntities())
                {
                    int query = context.STATU.Where(p => p.Statu.Contains(rbAyakta.Text)).Single().StatuId;
                    statuId = query; // statü id
                }
            }
         
            if (MessageBox.Show(@"Hasta için tüm dosyaları tarattığınıza emin misiniz ?", @"ÖNEMLİ",
                              MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                string temp = resimYolu + DateTime.Now.ToString("yyyy-MM-dd HHmmss") + ".jpeg";
                image1.Save(temp, ImageFormat.Jpeg); // resim kayıt

                if (tvKayit.SelectedNode.Parent.Text == "Hasta Muayene ve Ekipriz")
                {
                    EpikrizYol.Persist(resimYolu);
                    using (var context = new HospitalAutomationEntities())
                    {
                        int query = context.MUAYENEEPIKRIZYOL.Where(p => p.MuayeneEpikrizYolKayit.Contains(resimYolu)).Single().MuayeneEpikrizYolID;
                        ekiprizYol = query;
                    }
                    using (var context = new HospitalAutomationEntities())
                    {
                        int query = context.MUAYENEEPIKRIZ.Where(p => p.HastaMuayeneEpikriz.Contains(tvKayit.SelectedNode.Text)).Single().Muayeneid;
                        ekiprizId = query;
                    }
                    adliId = 1;
                    adliYol = 1;
                    raporYol = 1;
                    raporId = 1;
                 //   statuId = 1;
                    PatientDataStoreService.Persist(
                    fileNo, bolumId, date, ogretimGorevlisiID, taniId, statuId,
                    ekiprizId, ekiprizYol,
                    raporId, raporYol,
                    adliId, adliYol);
                }


                else if (tvKayit.SelectedNode.Text == "Tetkik ve Raporlar")
                {
                    TetkikRaporYol.Persist(resimYolu);
                    using (var context = new HospitalAutomationEntities())
                    {
                        int query = context.TETKIKRAPORYOL.Where(p => p.TetkikRaporYolKayit.Contains(resimYolu)).Single().TetkikRaporYolID;
                        raporYol = query;
                    }
                    using (var context = new HospitalAutomationEntities())
                    {
                        int query = context.TETKIKRAPORLAR.Where(p => p.TetkikveRapor.Contains(tvKayit.SelectedNode.Text)).Single().TetkikRaporid;
                        raporId = query;
                    }
                    adliYol = 1;
                    adliId = 1;
                    ekiprizId = 1;
                    ekiprizYol = 1;
                   // statuId = 1;
                    PatientDataStoreService.Persist(
                    fileNo, bolumId, date, ogretimGorevlisiID, taniId, statuId,
                    ekiprizId, ekiprizYol,
                    raporId, raporYol,
                    adliId, adliYol);
                }
                else if (tvKayit.SelectedNode.Text == "Adli ve Sağlık Kurulu")
                {
                    AdliSaglikYol.Persist(resimYolu);
                    TetkikRaporYol.Persist(resimYolu);
                    using (var context = new HospitalAutomationEntities())
                    {
                        int query = context.ADLISAGLIKKURULUYOL.Where(p => p.AdliSaglikKuruluYolKayit.Contains(resimYolu)).Single().AdliSaglikKuruluYolID;
                        adliYol = query;
                    }
                    adliId = 1;
                    ekiprizYol = 1;
                    ekiprizId = 1;
                    raporYol = 1;
                    raporId = 1;
                  //  statuId = 1;
                    PatientDataStoreService.Persist(
                    fileNo, bolumId, date, ogretimGorevlisiID, taniId, statuId,
                    ekiprizId, ekiprizYol,
                    raporId, raporYol,
                    adliId, adliYol);
                }

                if (MessageBox.Show(@"Kayit işlemi başarılı ! Bu hasta için başka bir kayit girmek ister misiniz ?",
                        @"YENİ KAYIT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    return;
                }
            }
        }        
    }
}
