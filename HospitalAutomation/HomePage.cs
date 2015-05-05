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

        // Dosya Bilgileri Sayfası İşlemleri
        private void linkLblFileInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            // TC No ve dosya numarasının alınması için ilgili panel açılır.
            // TC No ve Dosya Numarası Alınmadan başka adımlara geçilmemeli .(KONTROL)
            PanelVisibleControl();
            panelFileInformation.Visible = true;
            panelFileInformation.Location = new System.Drawing.Point(395, 165);
            panelFileInformation.Size = new System.Drawing.Size(415, 230);
        }

        private void btnOkFileInformationPage_Click(object sender, EventArgs e)
        {
            // Hasta Dosyasına ait TC No ve Dosya No girilmeden sonraki adıma geçilemez.(KONTROL)
            // Gerekli bilgiler alındıktan sonra Kayıt Bilgisi paneli açılır. ( txtTcNo - txtFileNumber )
            PanelVisibleControl();
            panelRegisterInformation.Visible = true;
            panelRegisterInformation.Location = new System.Drawing.Point(395, 165);
            panelRegisterInformation.Size = new System.Drawing.Size(910, 485);
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
            panelRegisterInformation.Location = new System.Drawing.Point(395, 165);
            panelRegisterInformation.Size = new System.Drawing.Size(910, 485);
        }

        //-- Tarih Seçim İşlemi
        private void linkLblEnterDate_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            monthCalendar.Visible = true;
            monthCalendar.Location = new System.Drawing.Point(210, 66);
        }

        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            this.lblDate.Text = monthCalendar.SelectionRange.Start.Date.ToShortDateString();
        }

        //-- Bölüm Seçim İşlemi
        private void linkLabelEnterSection_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            groupBoxSection.Visible = true;
            groupBoxSection.Location = new System.Drawing.Point(210, 112);
        }

        private void groupBoxSection_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxSection.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        lblSection.Text = radio.Text;
                    }
                }
            }
        }

        //-- İlgili Öğretim Üyesi Seçim İşlemi
        //-- (KONTROL)  İlgili Öğretim Üyesi Seçilmek Zorunda
        private void linkLblEnterFacultyMember_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            groupBoxFacultyMember.Visible = true;
            groupBoxFacultyMember.Location = new System.Drawing.Point(210, 148);
        }

        private void groupFacultyMember_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxFacultyMember.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        lblFacultyMember.Text = radio.Text;
                    }
                }
            }
        }

        //-- Hasta Tanısı Giriş
        //-- (KONTROL)  Hasta Tanısı Seçilmek Zorunda
        private void linkLblPatientDiagnosed_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            RegisterIndformationFormVisibleControl();
            txtPatientDiagnosed.Visible = true;
            txtPatientDiagnosed.Location = new System.Drawing.Point(210, 200);
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
            groupBoxPatientStatus.Location = new System.Drawing.Point(210, 244);
        }

        private void groupBoxPatientStatus_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxPatientStatus.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        lblPatientStatus.Text = radio.Text;
                    }
                }
            }
        }


         //-- Kayıt Bilgisi Visible Kontrolleri
        public void RegisterIndformationFormVisibleControl()
        {
            monthCalendar.Visible = false;
            groupBoxSection.Visible = false;
            groupBoxFacultyMember.Visible = false;
            txtPatientDiagnosed.Visible = false;
            groupBoxPatientStatus.Visible = false;
        }

        public void PanelVisibleControl()
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
            panelReports.Location = new System.Drawing.Point(395, 165);
        }

        private void btnPatientExamination_Click(object sender, EventArgs e)
        {
            groupBoxPatientExamination.Visible = true;
            groupBoxReports.Visible = false;
            radioBtnJudicialReports.Visible = false;
        }

        private void btnReports_Click(object sender, EventArgs e)
        {
            groupBoxReports.Visible = true;
            groupBoxPatientExamination.Visible = false;
            radioBtnJudicialReports.Visible = false;
        }

        private void btnJudicialReports_Click(object sender, EventArgs e)
        {
            radioBtnJudicialReports.Visible = true;
            groupBoxPatientExamination.Visible = false;
            groupBoxReports.Visible = false;
        }

        private void groupBoxPatientExamination_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxPatientExamination.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        lblReports.Text = radio.Text;
                    }
                }
            }
        }

        //groupBoxReports

        private void groupBoxReports_Enter(object sender, EventArgs e)
        {
            foreach (Control control in this.groupBoxReports.Controls)
            {
                if (control is RadioButton)
                {
                    RadioButton radio = control as RadioButton;
                    if (radio.Checked)
                    {
                        lblReports.Text = radio.Text;
                    }
                }
            }
        }

        private void radioBtnJudicialReports_CheckedChanged(object sender, EventArgs e)
        {
            lblReports.Text = radioBtnJudicialReports.Text;
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Tarama İşlemine Geçmek İstiyor musunuz?", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                //do something
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }
        }
      
    }
}

