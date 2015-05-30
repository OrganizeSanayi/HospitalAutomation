using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HospitalAutomation.Services;

namespace HospitalAutomation.Util
{
    public class Populater
    {
        public static void Fill<T>(ComboBox cb, Func<T[]> gatherFunc)
        {
            var columns = DataFillingService.GetColumns(typeof(T));
            cb.DataSource = gatherFunc();
            cb.ValueMember = columns[0];
            cb.DisplayMember = columns[1];
        }
    }
}
