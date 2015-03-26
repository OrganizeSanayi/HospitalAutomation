using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Util
{
    class Logger
    {
        /**
         *  Basic logging tool, it creates a file named logs under bin directory
         * 
         *  Usage:
         * Logger logger = new Logger();
         * logger.log("test");
         */
        public void log (String logMessage){
            System.IO.StreamWriter file = new System.IO.StreamWriter("../logs.txt", true);
            file.WriteLine(logMessage);

            file.Close();
        }
    }
}
