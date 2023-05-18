using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_2
{
    public interface ITemperatureDataPrinter
    {
        void PrintData(List<TemperatureData> temperatureDataList, RichTextBox richTextBox);
    }
}
