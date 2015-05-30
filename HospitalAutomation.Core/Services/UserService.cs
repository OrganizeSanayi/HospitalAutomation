using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Services
{
    public class UserService
    {
        public static bool IsValidLogin(string username, string password)
        {
            using (var context = new HospitalAutomationEntities())
            {
                var task = context.OTURUMs.FirstOrDefaultAsync(p => p.KullaniciAdi == username && p.Sifre == password);
                task.Wait();
                return  task.Result != null;
            }
        }
    }
}
