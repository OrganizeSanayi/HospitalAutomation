using System.IO;

namespace HospitalAutomation.Services
{
    public class FileStoreService
    {
        public void Save(string path, byte[] blob)
        {
            File.WriteAllBytes(path, blob);
        }

        public byte[] Read(string path)
        {
            return File.ReadAllBytes(path);
        }
    }
}
