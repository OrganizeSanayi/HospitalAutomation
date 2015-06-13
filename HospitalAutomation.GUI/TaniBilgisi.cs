using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using HospitalAutomation.Model;

namespace HospitalAutomation.GUI
{
    public partial class TaniBilgisi : Form
    {
        public TaniBilgisi()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                KayitEkle();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }

        void KayitEkle()
        {
            using (var entity = new HospitalAutomationEntities())
            {
                if (!KayitVarMi(txtIcd10.Text))
                {
                    TANILAR t = new TANILAR();
                    t.TaniAdi = txtTaniAciklama.Text;
                    t.ICD10Kodu = txtIcd10.Text;
                    entity.TANILAR.Add(t);
                    if (entity.SaveChanges() > 0)
                        MessageBox.Show("Tani Kayıt Edildi.");
                    else
                        MessageBox.Show("Kayit Başarısız !");
                }
                else
                {
                    MessageBox.Show(txtIcd10.Text + "   ICD10 kodu sistemde mevcut");
                }
            }
        }
        bool KayitVarMi(string icd10)
        {
            using (var entity=new HospitalAutomationEntities())
            {
                TANILAR tanilar = (from n in entity.TANILAR
                                         where n.ICD10Kodu == icd10
                                         select n).FirstOrDefault();
                if (tanilar == null)
                    return false;
                else
                    return true;
            }
        }
        void ExelKaydet()
        {
            //Exel dosyası içerisindeki bilgileri çek ve veri tabanına kaydet.

            try
            {
                string con =
                              @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icd10.xls;" +
                              @"Extended Properties='Excel 8.0;HDR=Yes;'";
                using (OleDbConnection connection = new OleDbConnection(con))
                {
                    connection.Open();
                    OleDbCommand command = new OleDbCommand("select * from [ICD KOD LİSTESİ$]", connection);
                    using (OleDbDataReader dr = command.ExecuteReader())
                    {
                        using (var entity = new HospitalAutomationEntities())
                        {
                            while (dr.Read())
                            {
                                if (!KayitVarMi(dr[0].ToString()))
                                {
                                    TANILAR t = new TANILAR();
                                    t.ICD10Kodu = dr[0].ToString();
                                    t.TaniAdi = dr[1].ToString();
                                    entity.TANILAR.Add(t);
                                }
                            }
                            if (entity.SaveChanges() > 0)
                                MessageBox.Show("Kayit Başarılı");
                            else
                                MessageBox.Show("Herhangi bir kayıt eklenmedi.");
                        }
                    }
                }
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
            }
        }
    }
}
