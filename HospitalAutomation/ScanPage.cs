using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation
{
    public partial class formScanPage : Form
    {
        public formScanPage()
        {
            InitializeComponent();
        }

        private void btnPatientExamination_Click(object sender, EventArgs e)
        {
            ReportsRadioButtonsVisibleFalse();
            PatientsExaminationsRadioButtonsVisibleTrue();
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            PatientsExaminationsRadioButtonsVisibleFalse();
            ReportsRadioButtonsVisibleTrue();
        }

        public void ReportsRadioButtonsVisibleTrue()
        {
            radioBtnPathology.Visible = true;
            radioBtnRadiological.Visible = true;
            radioBtnEndoscopic.Visible = true;
            radioBtnNuclearMedicine.Visible = true;
            radioBtnLab.Visible = true;
            radioBtnOther.Visible = true;
        }

        public void ReportsRadioButtonsVisibleFalse()
        {
            radioBtnPathology.Visible = false;
            radioBtnRadiological.Visible = false;
            radioBtnEndoscopic.Visible = false;
            radioBtnNuclearMedicine.Visible = false;
            radioBtnLab.Visible = false;
            radioBtnOther.Visible = false;
        }

        public void PatientsExaminationsRadioButtonsVisibleTrue()
        {
            radioBtnPatientAdmissionForm.Visible = true;
            radioBtnConsents.Visible = true;
            radioBtnOperationNote.Visible = true;
            radioBtnAnesthesiaNote.Visible = true;
            radioBtnClinicalObservation.Visible = true;
            radioBtnPatientExamination.Visible = true;
            radioBtnConsultation.Visible = true;
            radioBtnEpikriz.Visible = true;
        }

        public void PatientsExaminationsRadioButtonsVisibleFalse()
        {
            radioBtnPatientAdmissionForm.Visible = false;
            radioBtnConsents.Visible = false;
            radioBtnOperationNote.Visible = false;
            radioBtnAnesthesiaNote.Visible = false;
            radioBtnClinicalObservation.Visible = false;
            radioBtnPatientExamination.Visible = false;
            radioBtnConsultation.Visible = false;
            radioBtnEpikriz.Visible = false;
        }

        private void btnScanFile_Click(object sender, EventArgs e)
        {
            //RadioButton Seçimleri yapılmadan dosya tarama işlemi yapılmasın.
        }
    }
}
