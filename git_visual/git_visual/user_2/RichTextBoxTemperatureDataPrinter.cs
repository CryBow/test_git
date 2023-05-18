using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_2
{
    public class RichTextBoxTemperatureDataPrinter : ITemperatureDataPrinter
    {
        public void PrintData(List<TemperatureData> temperatureDataList, RichTextBox richTextBox)
        {
            richTextBox.Clear();
            richTextBox.AppendText("Информация о температуре:\n");

            foreach (TemperatureData temperatureData in temperatureDataList)
            {
                richTextBox.AppendText($"Дата: {temperatureData.Date.ToShortDateString()}\n");
                richTextBox.AppendText($"Минимальная температура: {temperatureData.MinTemperature}\n");
                richTextBox.AppendText($"Максимальная температура: {temperatureData.MaxTemperature}\n");
                richTextBox.AppendText($"Средняя температура: {temperatureData.AverageTemperature}\n");
                richTextBox.AppendText("\n");
            }
        }
    }
}
