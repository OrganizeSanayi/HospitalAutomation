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
        readonly Point _visibleDockPoint = new Point(395, 165);
        private ErrorTracker _eTracker;

        private bool _isReportsAvailable;
        private bool _isFileAvailable;

        public FormHomePage()
        {
            InitializeComponent();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {
            _eTracker = new ErrorTracker(errorProvider);

            Populater.Fill(cbFacultyMembers, DataFillingService.GatherDoctors);
            Populater.Fill(cbSurgery, DataFillingService.GatherSections);
            Populater.Fill(cbState, DataFillingService.GatherState);
            Populater.Fill(cbPatientExaminationEpicrisis, DataFillingService.GatherPatientExaminationEpicrisis);
            Populater.Fill(cbExaminationAndReports, DataFillingService.GatherExaminationAndReports);
            Populater.Fill(cbCriminalAndMedicalBoard, DataFillingService.GatherCriminalAndMedicalBoard);
            ClearSelections();

            EventHandler reportsHandler = (o, args) => lblReports.Text = GetSelectedText((ComboBox) o);
            cbCriminalAndMedicalBoard.SelectedIndexChanged += reportsHandler;
            cbPatientExaminationEpicrisis.SelectedIndexChanged += reportsHandler;
            cbExaminationAndReports.SelectedIndexChanged += reportsHandler;
            cbState.SelectedIndexChanged += (o, args) => lblPatientStatus.Text = GetSelectedText((ComboBox) o);
            cbSurgery.SelectedIndexChanged += (o, args) => lblSection.Text = GetSelectedText((ComboBox) o);
            cbFacultyMembers.SelectedIndexChanged += (o, args) => lblFacultyMember.Text = GetSelectedText((ComboBox) o);
        }

        private static string GetSelectedText(ComboBox cb)
        {
            return cb.GetItemText(cb.SelectedItem);
        }

        private void ClearSelections()
        {
            foreach (var cb in Controls.OfType<ComboBox>())
            {
                cb.SelectedItem = null;
            }
        }

        // Dosya Bilgileri Sayfası İşlemleri
        private void linkLblFileInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TC No ve dosya numarasının alınması için ilgili panel açılır.
            // TC No ve Dosya Numarası Alınmadan başka adımlara geçilmemeli .(KONTROL)
            PanelVisibleControl();
            panelFileInformation.Visible = true;
            panelFileInformation.Location = _visibleDockPoint;
            panelFileInformation.Size = new Size(415, 230);
        }
       

        private void btnOkFileInformationPage_Click(object sender, EventArgs e)
        {
            // Hasta Dosyasına ait TC No ve Dosya No girilmeden sonraki adıma geçilemez.(KONTROL)
            // Gerekli bilgiler alındıktan sonra Kayıt Bilgisi paneli açılır. ( txtTcNo - txtFileNumber 
            _eTracker.Clear();
            if (txtTcNo.Text.Length < 11)
            {
                _eTracker.SetError(txtTcNo, "TC Kimlik No eksik veya hatalı");
            }

            if (string.IsNullOrWhiteSpace(txtFileNumber.Text))
            {
                _eTracker.SetError(txtFileNumber, "Dosya numarası boş bırakılamaz");
            }

            if (_eTracker.Count != 0)
            {
                return;
            }

            else
            {
                _isFileAvailable = true;
                linkLblRegisterInformation.Enabled = true;
                PanelVisibleControl();
                panelRegisterInformation.Visible = true;
                panelRegisterInformation.Location = _visibleDockPoint;
                panelRegisterInformation.Size = new Size(910, 485);
            }
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
            PanelVisibleControl();
            panelRegisterInformation.Visible = true;
            panelRegisterInformation.Location = _visibleDockPoint;
            panelRegisterInformation.Size = new Size(910, 485);
        }

        //-- Tarih Seçim İşlemi
        private void linkLblEnterDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            monthCalendar.Visible = true;
            monthCalendar.Location = new Point(210, 66);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            lblDate.Text = monthCalendar.SelectionRange.Start.Date.ToShortDateString();
        }

        //-- Bölüm Seçim İşlemi
        private void linkLabelEnterSection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            groupBoxSection.Visible = true;
            groupBoxSection.Location = new Point(210, 112);
        }

        //-- İlgili Öğretim Üyesi Seçim İşlemi
        //-- (KONTROL)  İlgili Öğretim Üyesi Seçilmek Zorunda
        private void linkLblEnterFacultyMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            groupBoxFacultyMember.Visible = true;
            groupBoxFacultyMember.Location = new Point(210, 148);
        }

        private void groupFacultyMember_Enter(object sender, EventArgs e)
        {
            foreach (var radio in groupBoxFacultyMember.Controls.OfType<RadioButton>().Select(control => control).Where(radio => radio.Checked))
            {
                lblFacultyMember.Text = radio.Text;
            }
        }

        //-- Hasta Tanısı Giriş
        //-- (KONTROL)  Hasta Tanısı Seçilmek Zorunda
        private void linkLblPatientDiagnosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            txtPatientDiagnosed.Visible = true;
            txtPatientDiagnosed.Location = new Point(210, 200);
        }

        private void txtPatientDiagnosed_TextChanged(object sender, EventArgs e)
        {
            lblPatientDiagnosed.Text = txtPatientDiagnosed.Text;
        }

        //-- Hasta Statüsü
        private void linkLblPatientStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            groupBoxPatientStatus.Visible = true;
            groupBoxPatientStatus.Location = new Point(210, 244);
        }

        //-- Kayıt Bilgisi Visible Kontrolleri
        private void RegisterIndformationFormVisibleControl()
        {
            monthCalendar.Visible = false;
            groupBoxSection.Visible = false;
            groupBoxFacultyMember.Visible = false;
            txtPatientDiagnosed.Visible = false;
            groupBoxPatientStatus.Visible = false;
        }

        private void PanelVisibleControl()
        {
            panelRegisterInformation.Visible = false;
            panelFileInformation.Visible = false;
            panelReports.Visible = false;
        }

        // Raporlar
        private void linkLblReports_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PanelVisibleControl();
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

        private void groupBoxPatientExamination_Enter(object sender, EventArgs e)
        {
            foreach (var radio in groupBoxPatientExamination.Controls.OfType<RadioButton>().Select(control => control).Where(radio => radio.Checked))
            {
                lblReports.Text = radio.Text;
            }
        }

        //groupBoxReports

        private void groupBoxReports_Enter(object sender, EventArgs e)
        {
            foreach (var radio in groupBoxReports.Controls.OfType<RadioButton>().Select(control => control).Where(radio => radio.Checked))
            {
                lblReports.Text = radio.Text;
            }
        }


        private void btnScan_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show(Resources.TO_SCAN_MESSAGE, Resources.WARNING, MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            switch (dialogResult)
            {
                case DialogResult.Yes:
                    var fileNo = txtFileNumber.Text;
                    var sectionId = int.Parse(cbSurgery.SelectedValue.ToString());
                    var date = monthCalendar.SelectionRange.Start.Date;
                    var memberId = int.Parse(cbFacultyMembers.SelectedValue.ToString());
                    // TODO : Tanıyı bi sor
                    var diagnosisId = int.Parse(txtPatientDiagnosed.Text);

                    var stateId = int.Parse(cbState.SelectedValue.ToString());
                    // TODO : Belgeleri sor
                    var epicrisisId = int.Parse(cbPatientExaminationEpicrisis.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var epicrisisPath = 1;
                    var epicrisisPictureId = 1;

                    var examinationId = int.Parse(cbExaminationAndReports.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var examinationPath = 1;
                    var examinationPictureId = 1;

                    var criminalId = int.Parse(cbCriminalAndMedicalBoard.SelectedValue.ToString());
                    // TODO : Pseudo numara, sonra implement edersin
                    var criminalPath = 1;
                    var criminalPictureId = 1;
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

