using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalAutomation.GUI.Properties;
using HospitalAutomation.Services;
using HospitalAutomation.Util;
using Scannerapplication;
using HospitalAutomation.Model;
using System.IO;
namespace HospitalAutomation.GUI
{

    public partial class FormHomePage : Form
    {
        FrmScnr frmScanner = new FrmScnr();
        private readonly Point _visibleDockPoint = new Point(395, 165);
        private bool _isMemberSelected;
        private bool _isSectionSelected;
        private bool _isStateSelected;
        private bool _isReportSelected;
        private bool _isDiagnoseSelected;
        int secilenEpikriz = 0;
        int secilenTetkikRapor = 0;
        int secilenAdliSaglik = 0;
        string resimYolu;
        string resimAdi;
        private string tcNo = string.Empty;

        string klasorTarih;
        string klasorTC;
        string klasorBolum;

        public FormHomePage()
        {
            InitializeComponent();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {
            btnIslemiTamamla.Visible = false;
            btnScan.Visible = false;
            Populater.Fill(cbFacultyMembers, DataFillingService.GatherDoctors);
            Populater.Fill(cbSurgery, DataFillingService.GatherSections);
            Populater.Fill(cbState, DataFillingService.GatherState);
            Populater.Fill(cbPatientExaminationEpicrisis, DataFillingService.GatherPatientExaminationEpicrisis);
            Populater.Fill(cbExaminationAndReports, DataFillingService.GatherExaminationAndReports);
            Populater.Fill(cbCriminalAndMedicalBoard, DataFillingService.GatherCriminalAndMedicalBoard);

            EventHandler reportsHandler = (o, args) =>
            {
                var cb = (ComboBox)o;
                if (!cb.Focused) return;
                lblReports.Text = GetSelectedText(cb);
                _isReportSelected = true;
            };
            cbCriminalAndMedicalBoard.SelectedIndexChanged += reportsHandler;
            cbPatientExaminationEpicrisis.SelectedIndexChanged += reportsHandler;
            cbExaminationAndReports.SelectedIndexChanged += reportsHandler;
            cbState.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblPatientStatus, (ComboBox)o, ref _isStateSelected); };
            cbSurgery.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblSection, (ComboBox)o, ref _isSectionSelected); };
            cbFacultyMembers.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblFacultyMember, (ComboBox)o, ref _isMemberSelected); };
        }

        private static void SetControlTextDependsOnCb(Control lbl, ComboBox cb, ref bool isSelected)
        {
            lbl.Text = GetSelectedText(cb);
            if (!cb.Focused) return;
            isSelected = true;
        }

        private static string GetSelectedText(ComboBox cb)
        {
            return cb.GetItemText(cb.SelectedItem);
        }

        // Dosya Bilgileri Sayfası İşlemleri
        private void linkLblFileInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetAllPanelVisibility(false);
            panelFileInformation.Visible = true;
            panelFileInformation.Location = _visibleDockPoint;
            panelFileInformation.Size = new Size(415, 230);
        }

        private void btnOkFileInformationPage_Click(object sender, EventArgs e)
        {
            var eTracker = new ErrorTracker(errorProvider);
            eTracker.Clear();

            if (txtTcNo.Text.Length < 11)
            {
                eTracker.SetError(txtTcNo, "TC Kimlik No eksik veya hatalı");
            }
            else if (txtTcNo.Text.Length == 11) //Kontroller Gerçek TC numarası girilmiş mi onun kontrolü yapılmaktadır.
            {
                tcNo = txtTcNo.Text;
                if (!TCNoKontrol(tcNo))
                {

                    eTracker.SetError(txtTcNo, "TC Kimlik No eksik veya hatalı");
                }
                else if (!TCNoKontrol2(tcNo))
                {
                    eTracker.SetError(txtTcNo, "TC Kimlik No eksik veya hatalı");
                }

            }

            if (string.IsNullOrWhiteSpace(txtFileNumber.Text))
            {
                eTracker.SetError(txtFileNumber, "Dosya numarası boş bırakılamaz");
            }

            if (eTracker.Count != 0) return;

            linkLblRegisterInformation.Enabled = true;
            SetAllPanelVisibility(false);
            panelRegisterInformation.Visible = true;
            panelRegisterInformation.Location = _visibleDockPoint;
            panelRegisterInformation.Size = new Size(910, 485);
        }

        private void btnRegisterInformationDone_Click(object sender, EventArgs e)
        {
            var eTracker = new ErrorTracker(errorProvider);
            eTracker.Clear();

            if (monthCalendar.SelectionRange.Start.Date == DateTime.MinValue)
            {
                eTracker.SetError(lblDate, "Tarih seçiniz");
            }

            // TODO : tablo kategorize edilince degistir
            if (!_isSectionSelected)
            {
                eTracker.SetError(lblSection, "Bölüm seçiniz");
            }

            if (!_isMemberSelected)
            {
                eTracker.SetError(lblFacultyMember, "Öğretim üyesi seçiniz");
            }

            if (!_isDiagnoseSelected)
            {
                eTracker.SetError(lblPatientDiagnose, "Tanı giriniz");
            }

            if (!_isStateSelected)
            {
                eTracker.SetError(lblPatientStatus, "Statü seçiniz");
            }

            if (eTracker.Count != 0) return;

            SetAllPanelVisibility(false);
            linkLblReports.Enabled = true;
            panelReports.Visible = true;
            panelReports.Location = _visibleDockPoint;
        }

        private void txtTcNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void txtTcNo_TextChanged(object sender, EventArgs e)
        {
            lblTcNo.Text = txtTcNo.Text;
        }

        private void txtFileNumber_TextChanged(object sender, EventArgs e)
        {
            lblFileNo.Text = txtFileNumber.Text;
        }

        // Kayıt Bilgisi Sayfası İşlemleri   
        private void linkLblRegisterInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetAllPanelVisibility(false);
            panelRegisterInformation.Visible = true;
            panelRegisterInformation.Location = _visibleDockPoint;
            panelRegisterInformation.Size = new Size(910, 485);
        }

        //-- Tarih Seçim İşlemi
        private void linkLblEnterDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetRegisterInfoVisibility(false);
            monthCalendar.Visible = true;
            monthCalendar.Location = new Point(210, 66);
            lblDate.Text = monthCalendar.SelectionRange.Start.Date.ToShortDateString();
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = e.Start.Date.ToShortDateString();
        }

        //-- Bölüm Seçim İşlemi
        private void linkLabelEnterSection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetRegisterInfoVisibility(false);
            groupBoxSection.Visible = true;
            groupBoxSection.Location = new Point(210, 112);
        }

        //-- İlgili Öğretim Üyesi Seçim İşlemi
        //-- (KONTROL)  İlgili Öğretim Üyesi Seçilmek Zorunda
        private void linkLblEnterFacultyMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetRegisterInfoVisibility(false);
            groupBoxFacultyMember.Visible = true;
            groupBoxFacultyMember.Location = new Point(210, 148);
        }

        //-- Hasta Tanısı Giriş
        //-- (KONTROL)  Hasta Tanısı Seçilmek Zorunda
        private void linkLblPatientDiagnosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetRegisterInfoVisibility(false);
            txtPatientDiagnose.Visible = true;
            cbDiagnoses.Visible = true;
            txtPatientDiagnose.Location = new Point(210, 200);
        }

        private void cbDiagnoses_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblPatientDiagnose.Text = GetSelectedText(cbDiagnoses);
            _isDiagnoseSelected = true;
        }

        private void txtPatientDiagnosed_TextChanged(object sender, EventArgs e)
        {
            Populater.Fill(cbDiagnoses, () => DataFillingService.GatherDiagnoses(txtPatientDiagnose.Text));
        }

        //-- Hasta Statüsü
        private void linkLblPatientStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetRegisterInfoVisibility(false);
            groupBoxPatientStatus.Visible = true;
            groupBoxPatientStatus.Location = new Point(210, 244);
        }

        //-- Kayıt Bilgisi Visible Kontrolleri
        private void SetRegisterInfoVisibility(bool visibility)
        {
            monthCalendar.Visible = visibility;
            groupBoxSection.Visible = visibility;
            groupBoxFacultyMember.Visible = visibility;
            txtPatientDiagnose.Visible = visibility;
            cbDiagnoses.Visible = visibility;
            groupBoxPatientStatus.Visible = visibility;
        }

        private void SetAllPanelVisibility(bool state)
        {
            panelRegisterInformation.Visible = state;
            panelFileInformation.Visible = state;
            panelReports.Visible = state;
        }

        // Raporlar
        private void linkLblReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SetAllPanelVisibility(false);
            panelReports.Visible = true;
            panelReports.Location = _visibleDockPoint;
        }
        //Muayene epikriz butonu işlemleri
        private void btnPatientExamination_Click(object sender, EventArgs e)
        {
            secilenTetkikRapor = 0; // Hangi rapor butonuna tıklanmış ise ona 1 verilir. Amaç tarayıcıda tarattığımız raporun veri tabanına kayıt edilirken ilgili tabloya kaydı içindir.
            secilenAdliSaglik = 0;
            secilenEpikriz = 1;
            if (lblReports.Text != null)
                btnScan.Visible = true;
            groupBoxPatientExamination.Visible = true;
            groupBoxReports.Visible = false;
            gbCriminalAndMedicalBoard.Visible = false;

        }
        // Tetkik raporu butonu
        private void btnReports_Click(object sender, EventArgs e)
        {
            secilenTetkikRapor = 1;
            secilenAdliSaglik = 0;
            secilenEpikriz = 0;
            groupBoxReports.Visible = true;
            groupBoxPatientExamination.Visible = false;
            gbCriminalAndMedicalBoard.Visible = false;
            btnScan.Visible = true;
        }
        // Adli sağlık raporu butonu
        private void btnJudicialReports_Click(object sender, EventArgs e)
        {
            secilenTetkikRapor = 0;
            secilenAdliSaglik = 1;
            secilenEpikriz = 0;
            groupBoxPatientExamination.Visible = false;
            groupBoxReports.Visible = false;
            gbCriminalAndMedicalBoard.Visible = true;
            btnScan.Visible = true;
        }
        // Tarayıcı formunu açmaktadır.
        private void btnScan_Click(object sender, EventArgs e)
        {
            klasorTC = txtTcNo.Text;
            klasorBolum = cbSurgery.SelectedValue.ToString();
            klasorTarih = monthCalendar.SelectionRange.Start.Date.ToString("yyyy-MM-dd HH-mm-ss");




            if (secilenEpikriz == 1)
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
            else if (secilenAdliSaglik == 1)
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
            else if (secilenTetkikRapor == 1)
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

            FrmScnr.klasorYolu = resimYolu;

            // resimYolu = FrmScnr.sillinecekDosya;


            var dialogResult = MessageBox.Show(Resources.TO_SCAN_MESSAGE, Resources.WARNING, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            switch (dialogResult)
            {
                case DialogResult.Yes:

                    frmScanner.ShowDialog();
                    if (FrmScnr.taramaBittimi == 1)
                        btnIslemiTamamla.Visible = true;

                    btnScan.Visible = false;
                    break;
                case DialogResult.No:
                    //do something else
                    break;
            }
        }

        private void panelReports_Paint(object sender, PaintEventArgs e)
        {

        }


        /*
         * Dosyalar tablosuna kayıt etme işlemidir. Ayrıca tarayıcıda taranan dosyanın yoluda ilgili tabloya kayıt edilmektedir.
         * Örneğin adli sağlık kurulu dosyası ise (raporlar kısmında adli sağlık kurulu butonuna basılmıştır) kayıt işlemleri bilgileri(TCNo, dosya No diğer bilgiler.)
         * alındıktan sonra hangi rapor ise sorgu yapılıp ilgili tablodan adli sağlık kurulu yol id çekilip bilgiler dosyalar tablosuna gönderiliyor.  
         * */
        private void btnIslemiTamamla_Click(object sender, EventArgs e)
        {
            int criminalPath;
            int examinationPath;
            int epicrisisPath;

            var fileNo = txtFileNumber.Text;
            var sectionId = int.Parse(cbSurgery.SelectedValue.ToString());
            var date = monthCalendar.SelectionRange.Start.Date;
            var memberId = int.Parse(cbFacultyMembers.SelectedValue.ToString());
            var diagnosisId = int.Parse(cbDiagnoses.SelectedValue.ToString());
            var stateId = int.Parse(cbState.SelectedValue.ToString());
            
            if (FrmScnr.taramaBittimi == 1)
            {
                //resimAdi = FrmScnr.sillinecekDosya;


                if (secilenEpikriz == 1)
                {
                    if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim"))
                    {
                        resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\epikrizResim\\" ;
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
                    //
                else if (secilenAdliSaglik == 1)
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
                else if (secilenTetkikRapor == 1)
                {
                    if (File.Exists(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor"))
                    {
                        resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor\\" ;
                    }
                    else
                    {
                        Directory.CreateDirectory(@"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor");
                        resimYolu = @"D:\" + klasorTC + "\\" + klasorBolum + "\\" + klasorTarih + "\\tetkikRapor\\";
                    }
                    
                }

                FrmScnr.klasorYolu = resimYolu;

              // resimYolu = FrmScnr.sillinecekDosya;

            }


            if (secilenEpikriz == 1)
            {
                // MessageBox.Show("epikriz");
                EpikrizYol.Persist(resimYolu);
                using (var context = new HospitalAutomationEntities())
                {
                    int query = context.MUAYENEEPIKRIZYOL.Where(p => p.MuayeneEpikrizYolKayit.Contains(resimYolu)).Single().MuayeneEpikrizYolID;
                    epicrisisPath = query;
                }
                var epicrisisId = int.Parse(cbPatientExaminationEpicrisis.SelectedValue.ToString());
                var criminalYol = 1;
                var criminalId = 1;
                var examinationYol = 1;
                var examinationID = 1;
                PatientDataStoreService.Persist(
                fileNo, sectionId, date, memberId, diagnosisId, stateId,
                epicrisisId, epicrisisPath,
                examinationID, examinationYol,
                criminalId, criminalYol);
            }
            else if (secilenTetkikRapor == 1)
            {
                //   MessageBox.Show("tetkikrapor");
                TetkikRaporYol.Persist(resimYolu);
                using (var context = new HospitalAutomationEntities())
                {
                    int query = context.TETKIKRAPORYOL.Where(p => p.TetkikRaporYolKayit.Contains(resimYolu)).Single().TetkikRaporYolID;
                    examinationPath = query;
                }
                var examinationId = int.Parse(cbExaminationAndReports.SelectedValue.ToString());
                var epicrisisId = 1;
                var epikrizYol = 1;
                var criminalId = 1;
                var criminalYol = 1;
                PatientDataStoreService.Persist(
                fileNo, sectionId, date, memberId, diagnosisId, stateId,
                epicrisisId, epikrizYol,
                examinationId, examinationPath,
                criminalId, criminalYol);
            }
            else if (secilenAdliSaglik == 1)
            {
                // MessageBox.Show("adlisağlık");
                AdliSaglikYol.Persist(resimYolu);
                using (var context = new HospitalAutomationEntities())
                {
                    int query = context.ADLISAGLIKKURULUYOL.Where(p => p.AdliSaglikKuruluYolKayit.Contains(resimYolu)).Single().AdliSaglikKuruluYolID;

                    criminalPath = query;
                }
                var criminalId = int.Parse(cbCriminalAndMedicalBoard.SelectedValue.ToString());
                var epicrisisId = 1;
                var epikrizYol = 1;
                var examinationId = 1;
                var raporYol = 1;
                PatientDataStoreService.Persist(
            fileNo, sectionId, date, memberId, diagnosisId, stateId,
            epicrisisId, epikrizYol,
            examinationId, raporYol,
            criminalId, criminalPath);
            }

        }
        /**
        * Bu fonksiyon TC numarasının 0 ile baslama durumu ve mod10 kontrolünü yapmaktadır. bool değer dönderir.
        * */
        public bool TCNoKontrol(string paramTCno)
        {
            int toplam = 0;
            char[] array1 = paramTCno.ToCharArray();
            if (paramTCno[0] == 0)
            {
                return false;
            }
            else
            {
                for (int i = 0; i < array1.Length - 1; i++)
                {
                    toplam += (int)Char.GetNumericValue(array1[i]);

                }
                if (toplam % 10 == (int)Char.GetNumericValue(array1[10]))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }

        }
        /**
         * Bu fonksiyon 1,3,5,7 ve 9.cu hanelerin toplamının 7 ile çarpımından 2,4,6, ve 8. haneler çıkartıldığında geriye kalan sayının 10'a göre modu 10. haneyi veriyor mu kontrol.
         * bool değer dönderir.
         * */
        public bool TCNoKontrol2(string paramTCNo2)
        {
            int toplam = 0;
            int toplam2 = 0;
            char[] array2 = paramTCNo2.ToCharArray();
            toplam = (int)Char.GetNumericValue(array2[0]) + (int)Char.GetNumericValue(array2[2]) + (int)Char.GetNumericValue(array2[4]) + (int)Char.GetNumericValue(array2[6]) + (int)Char.GetNumericValue(array2[8]);
            toplam *= 7;
            toplam2 = (int)Char.GetNumericValue(array2[1]) + (int)Char.GetNumericValue(array2[3]) + (int)Char.GetNumericValue(array2[5]) + (int)Char.GetNumericValue(array2[7]);
            if ((toplam - toplam2) % 10 == (int)Char.GetNumericValue(array2[9]))
            {
                return true;
            }
            else
                return false;

        }
    }
}