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
    public partial class formHomePage : Form
    {
        public formHomePage()
        {
            InitializeComponent();
        }

        private void formHomePage_Load(object sender, EventArgs e)
        {

        }

        private void btnOkTcNoFileNumber_Click(object sender, EventArgs e)
        {
            //txtTcNo ve txtFileNumber textboxlarından değerler alınır , bir sonraki adıma geçilir.(Tarih Girişi)
            panelEnterTCNoFileNumber.Visible = false;
            panelEnterDate.Visible = true;
            panelEnterDate.Location = new System.Drawing.Point(12, 12);
        }

        private void btnOkEnterDate_Click(object sender, EventArgs e)
        {
            //dateTimePicker'dan alınan bilgilere göre sonraki aşamaya geçilir
            panelEnterDate.Visible = false;
            panelEnterFacultyMember.Visible = true;
            panelEnterFacultyMember.Location = new System.Drawing.Point(12, 12);
        }

        private void btnOkEnterFacultyMember_Click(object sender, EventArgs e)
        {
            //comboBoxFacultyMember combobox'ından seçilen öğretim üyesine göre işleme devam edilir.(Hasta Tanısı Sayfasına geçilir.)
            panelEnterFacultyMember.Visible = false;
            panelFormEnterPatientDiagnosed.Visible = true;
            panelFormEnterPatientDiagnosed.Location = new System.Drawing.Point(12, 12);
        }

        private void btnSkipEnterFacultyMember_Click(object sender, EventArgs e)
        {
            //Öğretim Üyesi Seçimini Atlamak amacıyla kullanılmıştır.
        }

        private void btnOkEnterPatientDiagnosed_Click(object sender, EventArgs e)
        {
            // Hasta tanısı txtPatientDiagnosed textboxından alınır.Hasta statüsü sayfasına geçilir.
            panelFormEnterPatientDiagnosed.Visible = false;
            panelEnterPatientStatus.Visible = true;
            panelEnterPatientStatus.Location = new System.Drawing.Point(12, 12);
        }

        private void btnSkipEnterPatientDiagnosed_Click(object sender, EventArgs e)
        {
            //Hasta tanısı girişi atlamak amacıyla kullanılmıştır.
        }

        private void btnOkEnterPatientStatus_Click(object sender, EventArgs e)
        {
            //Hasta statüsü bilgisi  radioButtonOutpatient ve radioButtonInpatient radiobuttonlarından alınır.
            //Hasta muayene ve epikriz sayfasına geçilir.
            panelEnterPatientStatus.Visible = false;
            panelEnterPatientExamination.Visible = true;
            panelEnterPatientExamination.Location = new System.Drawing.Point(12, 12);
        }

        private void btnOkEnterPatientExamination_Click(object sender, EventArgs e)
        {
            //Hasta muayene,epikriz bilgileri comboBoxPatientExamination combobox'ından alınır.
            panelEnterPatientExamination.Visible = false;
            panelEnterReports.Visible = true;
            panelEnterReports.Location = new System.Drawing.Point(12, 12);
        }

        private void btnOkEnterReports_Click(object sender, EventArgs e)
        {
            //comboBoxReports combobox'ından veri alınır.
        }
    }
}
