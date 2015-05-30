using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Services
{
    public class UserService
    {
        public bool isValidLogin(string username, string password)
        {
            using (HospitalAutomationEntities context = new HospitalAutomationEntities())
            {
                var user = context.OTURUMs.Where(p => p.KullaniciAdi == username && p.Sifre == password).FirstOrDefault();
                return user != null;
            }
        }
    }
}
