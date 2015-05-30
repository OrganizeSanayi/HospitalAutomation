using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects.DataClasses;
using System.Linq;
using HospitalAutomation.Model;

namespace HospitalAutomation.Services
{
    public static class DataFillingService
    {
        public static OGRETIMUYELERİ[] GatherDoctors()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.OGRETIMUYELERİ
                    select new
                    {
                        _id = p.OgretimUyeid,
                        Ad = p.Unvan + " " + p.Ad + " " + p.Soyad
                    }).ToList()
                    .Select(x => new OGRETIMUYELERİ
                    {
                        OgretimUyeid = x._id,
                        Ad = x.Ad
                    }).ToArray();
            }
        }

        public static BOLUMLER[] GatherSections()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.BOLUMLER
                    select new
                    {
                        _id = p.BolumId,
                        Ad = p.BolumAdi
                    }).ToList()
                    .Select(x => new BOLUMLER
                    {
                        BolumId = x._id,
                        BolumAdi = x.Ad
                    }).ToArray();
            }
        }

        public static STATU[] GatherState()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.STATU
                        select new
                        {
                            _id = p.StatuId,
                            Ad = p.Statu
                        }).ToList()
                    .Select(x => new STATU
                    {
                        StatuId = x._id,
                        Statu = x.Ad
                    }).ToArray();
            }
        }

        public static MUAYENEEPIKRIZ[] GatherPatientExaminationEpicrisis()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.MUAYENEEPIKRIZ
                        select new
                        {
                            _id = p.Muayeneid,
                            Ad = p.HastaMuayeneEpikriz
                        }).ToList()
                    .Select(x => new MUAYENEEPIKRIZ
                    {
                        Muayeneid = x._id,
                        HastaMuayeneEpikriz = x.Ad
                    }).ToArray();
            }
        }

        public static TETKIKRAPORLAR[] GatherExaminationAndReports()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.TETKIKRAPORLAR
                        select new
                        {
                            _id = p.TetkikRaporid,
                            Ad = p.TetkikveRapor
                        }).ToList()
                    .Select(x => new TETKIKRAPORLAR
                    {
                        TetkikRaporid = x._id,
                        TetkikveRapor = x.Ad
                    }).ToArray();
            }
        }

        public static ADLISAGLIKKURULU[] GatherCriminalAndMedicalBoard()
        {
            using (var context = new HospitalAutomationEntities())
            {
                return (from p in context.ADLISAGLIKKURULU
                        select new
                        {
                            _id = p.AdliSaglikKuruluID,
                            Ad = p.AdliSaglikKurulu1
                        }).ToList()
                    .Select(x => new ADLISAGLIKKURULU
                    {
                        AdliSaglikKuruluID = x._id,
                        AdliSaglikKurulu1 = x.Ad
                    }).ToArray();
            }
        }

        public static List<string> GetColumns(Type model)
        {
            var colNames = model.GetProperties().Select(a => a.Name).ToList();
            return colNames;
        }
    }
}