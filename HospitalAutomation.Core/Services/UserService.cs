using System.Data.Entity;
using HospitalAutomation.Model;

namespace HospitalAutomation.Services
{
    public static class UserService
    {
        public static bool IsValidLogin(string username, string password)
        {
            using (var context = new HospitalAutomationEntities())
            {
                var task = context.OTURUM.FirstOrDefaultAsync(p => p.KullaniciAdi == username && p.Sifre == password);
                task.Wait();
                return  task.Result != null;
            }
        }
    }
}
