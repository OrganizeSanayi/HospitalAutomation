using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HospitalAutomation.Model;
namespace HospitalAutomation.Services
{
   public static class AdliSaglikYol
    {
       public static void Persist(string yol)
       {
           var adliSaglikyol = new ADLISAGLIKKURULUYOL()
           {
            AdliSaglikKuruluYolKayit=yol
           };
           using (var contex = new HospitalAutomationEntities())
           {
               contex.ADLISAGLIKKURULUYOL.Add(adliSaglikyol);
               contex.SaveChanges();
           }
       }
    }
}
