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
            // FIXME: This should use the database instead
            //  var user = db.OTURUMs.Where(p => p.KullaniciAdi == txtUserName.Text && p.Sifre==txtUserPassword.Text).FirstOrDefault();
            return (username == "admin" && password == "admin");
        }
    }
}
