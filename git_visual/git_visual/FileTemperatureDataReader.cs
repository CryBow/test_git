using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_2
{
    public class FileTemperatureDataReader : ITemperatureDataReader
    {
        public List<TemperatureData> ReadData(string filePath)
        {
            List<TemperatureData> temperatureDataList = new List<TemperatureData>();

            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    string[] parts = line.Split(';');

                    if (parts.Length == 4)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        double minTemperature = double.Parse(parts[1]);
                        double maxTemperature = double.Parse(parts[2]);
                        double averageTemperature = double.Parse(parts[3]);

                        TemperatureData temperatureData = new TemperatureData(date, minTemperature, maxTemperature, averageTemperature);
                        temperatureDataList.Add(temperatureData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.Message);
            }

            return temperatureDataList;
        }
    }
}
