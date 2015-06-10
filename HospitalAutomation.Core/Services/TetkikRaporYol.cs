using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAutomation.Model;
namespace HospitalAutomation.Services
{
    public static class TetkikRaporYol
    {
        public static void Persist(string yol)
        {
            var tetkikyol = new TETKIKRAPORYOL()
            {
            TetkikRaporYolKayit=yol
            };
            using (var contex = new HospitalAutomationEntities())
            {
                contex.TETKIKRAPORYOL.Add(tetkikyol);
                contex.SaveChanges();
            }
        }
    }
}
