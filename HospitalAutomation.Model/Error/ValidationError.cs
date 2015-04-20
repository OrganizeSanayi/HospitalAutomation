using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Model.Error
{
    public class ValidationError
    {
        public Control Control { get; private set; }
        public String Error { get; private set; }
        
        public ValidationError(Control control, String error)
        {
            if (control == null) {
                throw new ArgumentNullException("control");
            }

            if (String.IsNullOrWhiteSpace(error)) {
                throw new ArgumentException("error");
            }

            Control = control;
            Error = error;
        }
    }
}
