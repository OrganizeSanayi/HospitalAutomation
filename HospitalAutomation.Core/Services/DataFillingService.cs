using System.Linq;
using System.Runtime.Remoting.Contexts;

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
                            OgretimUyeid = p.OgretimUyeid,
                            Isim = p.Unvan + " " + p.Ad + " " + p.Soyad,
                        }).ToList()
                        .Select(x => new OGRETIMUYELERİ
                        {
                            OgretimUyeid = x.OgretimUyeid,
                            Ad = x.Isim
                        }).ToArray();
            }
        }
    }
}