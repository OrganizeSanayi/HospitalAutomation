using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HospitalAutomation.Util
{
    class ErrorTracker
    {
        private HashSet<Control> mErrors = new HashSet<Control>();
        private ErrorProvider mProvider;

        public ErrorTracker(ErrorProvider provider)
        {
            mProvider = provider;
            mProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        public void SetError(Control ctl, string text)
        {
            if (string.IsNullOrEmpty(text)) {
                mErrors.Remove(ctl);
            } else if (!mErrors.Contains(ctl)) {
                mErrors.Add(ctl);
            }

            mProvider.SetError(ctl, text);
        }

        public int Count { get { return mErrors.Count; } }
    }
}
