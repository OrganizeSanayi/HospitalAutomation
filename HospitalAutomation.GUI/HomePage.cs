using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using HospitalAutomation.GUI.Properties;
using HospitalAutomation.Services;
using HospitalAutomation.Util;

namespace HospitalAutomation.GUI
{
    public partial class FormHomePage : Form
    {
        private readonly Point _visibleDockPoint = new Point(395, 165);
        private bool _isMemberSelected;
        private bool _isSectionSelected;
        private bool _isStateSelected;
        private bool _isReportSelected;
        private bool _isDiagnoseSelected;

        public FormHomePage()
        {
            InitializeComponent();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {
            Populater.Fill(cbFacultyMembers, DataFillingService.GatherDoctors);
            Populater.Fill(cbSurgery, DataFillingService.GatherSections);
            Populater.Fill(cbState, DataFillingService.GatherState);
            Populater.Fill(cbPatientExaminationEpicrisis, DataFillingService.GatherPatientExaminationEpicrisis);
            Populater.Fill(cbExaminationAndReports, DataFillingService.GatherExaminationAndReports);
            Populater.Fill(cbCriminalAndMedicalBoard, DataFillingService.GatherCriminalAndMedicalBoard);

            EventHandler reportsHandler = (o, args) =>
            {
                var cb = (ComboBox) o;
                if (!cb.Focused) return;
                lblReports.Text = GetSelectedText(cb);
                _isReportSelected = true;
            };
            cbCriminalAndMedicalBoard.SelectedIndexChanged += reportsHandler;
            cbPatientExaminationEpicrisis.SelectedIndexChanged += reportsHandler;
            cbExaminationAndReports.SelectedIndexChanged += reportsHandler;
            cbState.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblPatientStatus, (ComboBox) o, ref _isStateSelected); };
            cbSurgery.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblSection, (ComboBox) o, ref _isSectionSelected); };
            cbFacultyMembers.SelectedIndexChanged +=
                (o, args) => { SetControlTextDependsOnCb(lblFacultyMember, (ComboBox) o, ref _isMemberSelected); };
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

        private void btnPatientExamination_Click(object sender, EventArgs e)
        {
            groupBoxPatientExamination.Visible = true;
            groupBoxReports.Visible = false;
            gbCriminalAndMedicalBoard.Visible = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            groupBoxReports.Visible = true;
            groupBoxPatientExamination.Visible = false;
            gbCriminalAndMedicalBoard.Visible = false;
        }

        private void btnJudicialReports_Click(object sender, EventArgs e)
        {
            groupBoxPatientExamination.Visible = false;
            groupBoxReports.Visible = false;
            gbCriminalAndMedicalBoard.Visible = true;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resources.TO_SCAN_MESSAGE, Resources.WARNING, MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    // TODO : Dosya tarama mekanizmasını implement et
                    var fileNo = txtFileNumber.Text;
                    var sectionId = int.Parse(cbSurgery.SelectedValue.ToString());
                    var date = monthCalendar.SelectionRange.Start.Date;
                    var memberId = int.Parse(cbFacultyMembers.SelectedValue.ToString());
                    var diagnosisId = int.Parse(cbDiagnoses.SelectedValue.ToString());
                    var stateId = int.Parse(cbState.SelectedValue.ToString());

                    var epicrisisId = int.Parse(cbPatientExaminationEpicrisis.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var epicrisisPath = 1;
                    //var epicrisisPictureId = 1;

                    var examinationId = int.Parse(cbExaminationAndReports.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var examinationPath = 1;
                    //var examinationPictureId = 1;

                    var criminalId = int.Parse(cbCriminalAndMedicalBoard.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var criminalPath = 1;
                    //var criminalPictureId = 1;
                    PatientDataStoreService.Persist(
                        fileNo, sectionId, date, memberId, diagnosisId, stateId,
                        epicrisisId, epicrisisPath,
                        examinationId, examinationPath,
                        criminalId, criminalPath);
                    break;
                case DialogResult.No:
                    //do something else
                    break;
            }
        }
    }
}