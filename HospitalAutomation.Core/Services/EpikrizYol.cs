using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAutomation.Model;
namespace HospitalAutomation.Services
{
    public static class EpikrizYol
    {
        public static void Persist(string yol)
        {
            var epikriz = new MUAYENEEPIKRIZYOL()
            {
                MuayeneEpikrizYolKayit=yol
            };
            using (var contex = new HospitalAutomationEntities())
            {
                contex.MUAYENEEPIKRIZYOL.Add(epikriz);
                contex.SaveChanges();
            }
        }
    }
}
