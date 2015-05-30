using System.Linq;
using HospitalAutomation.Model;

namespace HospitalAutomation
{
    public class DataFillingService
    {
        public OGRETIMUYELERİ[] GatherDoctors()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.OGRETIMUYELERİ
                    select new
                    {
                        p.OgretimUyeid,
                        Isim = p.Unvan + " " + p.Ad + " " + p.Soyad
                    }).ToList()
                    .Select(x => new OGRETIMUYELERİ
                    {
                        OgretimUyeid = x.OgretimUyeid,
                        Ad = x.Isim
                    }).ToArray();
            }
        }

        public BOLUMLER[] GatherSections()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.BOLUMLERs
                    select new
                    {
                        _id = p.BolumId,
                        p.BolumAdi
                    }).ToList()
                    .Select(x => new BOLUMLER
                    {
                        BolumId = x._id,
                        BolumAdi = x.BolumAdi
                    }).ToArray();
            }
        }
    }
}