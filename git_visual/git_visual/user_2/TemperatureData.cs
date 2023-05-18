using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_visual.user_2
{
    public class TemperatureData
    {
        public DateTime Date { get; }
        public double MinTemperature { get; }
        public double MaxTemperature { get; }
        public double AverageTemperature { get; }

        public TemperatureData(DateTime date, double minTemperature, double maxTemperature, double averageTemperature)
        {
            Date = date;
            MinTemperature = minTemperature;
            MaxTemperature = maxTemperature;
            AverageTemperature = averageTemperature;
        }
    }
}
