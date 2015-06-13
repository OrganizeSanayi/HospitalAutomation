using System;
using System.Windows.Forms;
using HospitalAutomation.Services;

namespace HospitalAutomation.Util
{
    public static class Populater
    {
        public static void Fill<T>(ListControl cb, Func<T[]> gatherFunc)
        {
            var columns = DataFillingService.GetColumns(typeof(T));
            cb.DataSource = gatherFunc();
            cb.ValueMember = columns[0];
            cb.DisplayMember = columns[1];
        }
    }
}
