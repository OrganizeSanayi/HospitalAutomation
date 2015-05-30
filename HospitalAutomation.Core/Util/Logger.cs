using System.IO;

namespace HospitalAutomation.Util
{
    public static class Logger
    {
        /**
         *  Basic logging tool, it creates a file named logs under bin directory
         * 
         *  Usage:
         * Logger.i("test");
         */
        public static void I(string logMessage)
        {
            var file = new StreamWriter("../logs.txt", true);
            file.WriteLine(logMessage);

            file.Close();
        }
    }
}
