using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace git_visual.user_2
{
    public class GraphicBuilder
    {
        private Chart chart;

        public GraphicBuilder(Chart chart)
        {
            this.chart = chart;
        }

        public void BuildChart(List<TemperatureData> temperatureDataList)
        {
            chart.Series.Clear();

            Series seriesMinTemperature = new Series("Минимальная температура");
            seriesMinTemperature.ChartType = SeriesChartType.Line;
            seriesMinTemperature.Color = Color.Blue;

            Series seriesMaxTemperature = new Series("Максимальная температура");
            seriesMaxTemperature.ChartType = SeriesChartType.Line;
            seriesMaxTemperature.Color = Color.Red;

            foreach (TemperatureData temperatureData in temperatureDataList)
            {
                seriesMinTemperature.Points.AddXY(temperatureData.Date, temperatureData.MinTemperature);
                seriesMaxTemperature.Points.AddXY(temperatureData.Date, temperatureData.MaxTemperature);
            }

            chart.Series.Add(seriesMinTemperature);
            chart.Series.Add(seriesMaxTemperature);
        }
    }
}
