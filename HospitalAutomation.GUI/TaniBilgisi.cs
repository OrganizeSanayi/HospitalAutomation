using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
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
                    var t = new TANILAR
                    {
                        TaniAdi = txtTaniAciklama.Text,
                        ICD10Kodu = txtIcd10.Text.ToUpper()
                    };
                    entity.TANILAR.Add(t);
                    MessageBox.Show(entity.SaveChanges() > 0 ? "Tani Kayıt Edildi." : "Kayit Başarısız !");
                }
                else
                {
                    MessageBox.Show(txtIcd10.Text + @" ICD10 kodu sistemde mevcut");
                }
            }
        }

        static bool KayitVarMi(string icd10)
        {
            using (var entity=new HospitalAutomationEntities())
            {
                var tanilar = (from n in entity.TANILAR
                                         where n.ICD10Kodu == icd10
                                         select n).FirstOrDefault();
                return tanilar != null;
            }
        }
        void ExelKaydet()
        {
            //Exel dosyası içerisindeki bilgileri çek ve veri tabanına kaydet.

            try
            {
                const string con = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=icd10.xls;" +
                                   @"Extended Properties='Excel 8.0;HDR=Yes;'";
                using (var connection = new OleDbConnection(con))
                {
                    connection.Open();
                    var command = new OleDbCommand("select * from [ICD KOD LİSTESİ$]", connection);
                    using (var dr = command.ExecuteReader())
                    {
                        using (var entity = new HospitalAutomationEntities())
                        {
                            if (dr == null)
                            {
                                throw new IOException("Dosya bulunamadı.");
                            }

                            while (dr.Read())
                            {
                                if (KayitVarMi(dr[0].ToString())) continue;

                                var t = new TANILAR
                                {
                                    ICD10Kodu = dr[0].ToString(),
                                    TaniAdi = dr[1].ToString()
                                };

                                entity.TANILAR.Add(t);
                            }
                            MessageBox.Show(entity.SaveChanges() > 0
                                ? "Kayit Başarılı"
                                : "Herhangi bir kayıt eklenmedi.");
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
