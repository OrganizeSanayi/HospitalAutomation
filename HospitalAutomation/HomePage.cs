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

        private void linkLblEnterTCNoFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TC No ve dosya numarasının alınması için ilgili panel açılır.
            // TC No ve Dosya Numarası Alınmadan başka adımlara geçilmemeli .(KONTROL)
            VisibleControl();
            panelEnterTCNoFileNumber.Visible = true;
            panelEnterTCNoFileNumber.Location = new System.Drawing.Point(392, 164);
            panelEnterTCNoFileNumber.Size = new System.Drawing.Size(415, 230);
        }

        private void btnOkTcNoFileNumber_Click(object sender, EventArgs e)
        {
            // TC No ve dosya numarası girildikten sonra TAMAM butonuna tıklanarak tarih girilme paneline geçilir.
            // TC No ve Dosya Numarası Alınmadan başka adımlara geçilmemeli .(KONTROL)
            VisibleControl();
            panelEnterDate.Visible = true;
            panelEnterDate.Location = new System.Drawing.Point(392, 164);
            panelEnterDate.Size = new System.Drawing.Size(415, 230);

            panelEnd.Visible = true;
            lblTcNoFileNo.Text = txtTcNo.Text + '\t'+  txtFileNumber.Text;
        }

        private void linkLblEnterDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Tarih Girişi için ilgili panel açılır.
            // Tarih girişi yapılmadan sonraki adıma geçilmemeli.(KONTROL)
            VisibleControl();
            panelEnterDate.Visible = true;
            panelEnterDate.Location = new System.Drawing.Point(392, 164);
            panelEnterDate.Size = new System.Drawing.Size(415, 230);
        }

        private void btnOkEnterDate_Click(object sender, EventArgs e)
        {
            // Tarih Girişi alınmadan sonraki adıma geçilmemeli (KONTROL)
            // Tarih bilgisi girildikten sonra TAMAM butonuna tıklanarak ilgili öğretim üyesi girilme paneline geçilir.
            VisibleControl();
            panelEnterFacultyMember.Visible = true;
            panelEnterFacultyMember.Location = new System.Drawing.Point(392, 164);
            panelEnterFacultyMember.Size = new System.Drawing.Size(415, 230);

            lblDate.Text = dateTimePicker.Text;
        }

        private void linkLblEnterFacultyMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // İlgili öğretim üyesinin seçilmesi paneli açılır.
            VisibleControl();
            panelEnterFacultyMember.Visible = true;
            panelEnterFacultyMember.Location = new System.Drawing.Point(392, 164);
            panelEnterFacultyMember.Size = new System.Drawing.Size(415, 230);
        }

        private void btnOkEnterFacultyMember_Click(object sender, EventArgs e)
        {
            // Öğretim üyesi seçildikten sonra TAMAM butonuna tıklanarak Hasta Tanısı paneline geçilir.
            VisibleControl();
            panelFormEnterPatientDiagnosed.Visible = true;
            panelFormEnterPatientDiagnosed.Location = new System.Drawing.Point(392, 164);
            panelFormEnterPatientDiagnosed.Size = new System.Drawing.Size(415, 230);

            if (comboBoxFacultyMember.Text != null)
            {
                lblFacultyMember.Text = comboBoxFacultyMember.Text;
            }
        }

        private void btnSkipEnterFacultyMember_Click(object sender, EventArgs e)
        {
            // İlgili öğretim üyesinin seçilmesi zorunlu bir adım değildir.
            VisibleControl();
            panelFormEnterPatientDiagnosed.Visible = true;
            panelFormEnterPatientDiagnosed.Location = new System.Drawing.Point(392, 164);
            panelFormEnterPatientDiagnosed.Size = new System.Drawing.Size(415, 230);
        }

        private void linkLblEnterPatientDiagnosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hasta Tanısı Giriniz linkine tıklanarak ilgili panel açılır.
            VisibleControl();
            panelFormEnterPatientDiagnosed.Visible = true;
            panelFormEnterPatientDiagnosed.Location = new System.Drawing.Point(392, 164);
            panelFormEnterPatientDiagnosed.Size = new System.Drawing.Size(415, 230);
        }

        private void btnOkEnterPatientDiagnosed_Click(object sender, EventArgs e)
        {
            // Hasta Tanısı seçimi yapıldıktan sonra hasta statusu paneline geçilir.
            // Hasta Tanısı seçimi zorunlu değildir.
            VisibleControl();
            panelFormEnterPatientDiagnosed.Visible = true;
            panelFormEnterPatientDiagnosed.Location = new System.Drawing.Point(392, 164);
            panelFormEnterPatientDiagnosed.Size = new System.Drawing.Size(415, 230);

            if (txtPatientDiagnosed.Text != null)
            {
                lblPatientDiagnostic.Text = txtPatientDiagnosed.Text;
            }
        }

        private void btnSkipEnterPatientDiagnosed_Click(object sender, EventArgs e)
        {
            // Hasta Tanısı seçimi zorunlu değildir.
            VisibleControl();
            panelEnterPatientStatus.Visible = true;
            panelEnterPatientStatus.Location = new System.Drawing.Point(392, 164);
            panelEnterPatientStatus.Size = new System.Drawing.Size(415, 230);
        }

        private void linkLblEnterPatientStatus_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // Hasta statusu seçimi zorunludur. (KONTROL)
            VisibleControl();
            panelEnterPatientStatus.Visible = true;
            panelEnterPatientStatus.Location = new System.Drawing.Point(392, 164);
            panelEnterPatientStatus.Size = new System.Drawing.Size(415, 230);
        }


        private void btnOkEnterPatientStatus_Click(object sender, EventArgs e)
        {
            // Hasta statüsü seçimi yapılır ve tarama sayfasına geçilir.
            // Hasta statüsü seçimi zorunludur.
            if(radioButtonOutpatient.Checked == true)
            {
                lblPatientStatus.Text = "Ayakta Hasta";
            }

            if(radioButtonInpatient.Checked == true)
            {
                lblPatientStatus.Text = "Yatan Hasta";
            }

            linkLblContinue.Visible = true;
        } 

        public void VisibleControl()
        {
            panelEnterDate.Visible = false;
            panelEnterFacultyMember.Visible = false;
            panelEnterTCNoFileNumber.Visible = false;           
            panelEnterPatientStatus.Visible = false;
            panelFormEnterPatientDiagnosed.Visible =false;
        }

        private void linkLblContinue_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            formScanPage scanPage = new formScanPage();
            scanPage.Show();
        }        
    }
}
