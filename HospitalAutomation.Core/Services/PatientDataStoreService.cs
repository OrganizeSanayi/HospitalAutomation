using System;
using HospitalAutomation.Model;

namespace HospitalAutomation.Services
{
    public static class PatientDataStoreService
    {
        // TODO: Add method for retrieval
       
        public static void Persist(
            string fileNo, int sectionId, DateTime date, int memberId, int diagnosisId, int stateId, 
            int epicrisisId, int epicrisisPath, 
            int examinationId, int examinationPath, 
            int criminalId, int criminalPath)
        {
            var dosya = new DOSYALAR
            {
                DosyaNo = fileNo,
                BolumID = sectionId,
                Tarih = date,
                OgretimUyeID = memberId,
                TanıID = diagnosisId,
                HastaStatuID = stateId,
                MuayeneEpikrizID = epicrisisId,
                MuayeneEpikrizYolID = epicrisisPath,
                TetkikRaporID = examinationId,
                TetkikRaporYolID = examinationPath,
                AdliSaglikKuruluID = criminalId,
                AdliSaglikKuruluYolID = criminalPath
            };

            using (var contex = new HospitalAutomationEntities())
            {
                contex.DOSYALAR.Add(dosya);
                contex.SaveChanges();
            }
        }
    }
}
