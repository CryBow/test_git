using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.DataVisualization.Charting;

namespace git_visual.user_1
{
    // Класс, отвечающий за построение графиков
    public class ChartBuilder
    {
        private Chart chart;

        public ChartBuilder(Chart chart)
        {
            this.chart = chart;
        }

        public void BuildChart(List<CurrencyData> currencyDataList)
        {
            chart.Series.Clear();

            Series seriesCurrency1 = new Series("Валюта 1");
            seriesCurrency1.ChartType = SeriesChartType.Line;

            Series seriesCurrency2 = new Series("Валюта 2");
            seriesCurrency2.ChartType = SeriesChartType.Line;

            foreach (CurrencyData currencyData in currencyDataList)
            {
                seriesCurrency1.Points.AddXY(currencyData.Date, currencyData.Currency1Rate);
                seriesCurrency2.Points.AddXY(currencyData.Date, currencyData.Currency2Rate);
            }

            chart.Series.Add(seriesCurrency1);
            chart.Series.Add(seriesCurrency2);
        }
    }
}
