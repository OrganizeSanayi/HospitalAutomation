using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation.Util
{
    class Validator
    {
        /*
         * Returns false if the passed text is empty
         */
        public static bool isEmpty(String text)
        {
            return text == null || text.Trim() == String.Empty ? true : false;
        }
    }
}
