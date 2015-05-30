using System.Collections.Generic;
using System.Windows.Forms;

namespace HospitalAutomation.Util
{
    public class ErrorTracker
    {
        private readonly HashSet<Control> _errors = new HashSet<Control>();
        private readonly ErrorProvider _provider;

        public ErrorTracker(ErrorProvider provider)
        {
            _provider = provider;
            _provider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        public void SetError(Control ctl, string text)
        {
            if (string.IsNullOrEmpty(text)) {
                _errors.Remove(ctl);
            } else if (!_errors.Contains(ctl)) {
                _errors.Add(ctl);
            }

            _provider.SetError(ctl, text);
        }

        public int Count => _errors.Count;

        public void Clear()
        {
            _provider.Clear();
            _errors.Clear();
        }
    }
}
