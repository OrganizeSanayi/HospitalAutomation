using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HospitalAutomation
{
    class ValidationUtil
    {
        /*
         * Returns false if the passed text is empty
         */
        public bool isEmptyString(String text)
        {
            text = text.Trim();
            return text == null || text == String.Empty ? false : true;
        }
    }
}
