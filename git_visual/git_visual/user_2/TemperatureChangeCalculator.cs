using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_2
{
    public class TemperatureChangeCalculator
    {
        public void CalculateTemperatureChange(List<TemperatureData> temperatureDataList, RichTextBox richTextBox)
        {
            double maxTemperatureChange = double.MinValue;
            DateTime maxTemperatureChangeDate = DateTime.MinValue;

            for (int i = 1; i < temperatureDataList.Count; i++)
            {
                double temperatureChange = Math.Abs(temperatureDataList[i].MaxTemperature - temperatureDataList[i - 1].MaxTemperature);

                if (temperatureChange > maxTemperatureChange)
                {
                    maxTemperatureChange = temperatureChange;
                    maxTemperatureChangeDate = temperatureDataList[i].Date;
                }
            }

            richTextBox.AppendText($"Самый сильный перепад температуры: {maxTemperatureChange}\n");
            richTextBox.AppendText($"Дата: {maxTemperatureChangeDate.ToShortDateString()}\n");
        }
    }
}
