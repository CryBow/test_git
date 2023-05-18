using git_visual.user_1;
using git_visual.user_2;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace git_visual
{
    public partial class Form1 : Form
    {
        private ICurrencyDataReader dataReader;
        private ICurrencyDataPrinter dataPrinter;
        private ChartBuilder chartBuilder;
        private CurrencyChangeCalculator changeCalculator;
        private List<TemperatureData> temperatureDataList;
        private ITemperatureDataPrinter tempdataPrinter;
        private GraphicBuilder graphicBuilder;
        private TemperatureChangeCalculator tempchangeCalculator;
        public Form1()
        {
            InitializeComponent();
            dataReader = new FileCurrencyDataReader();
            dataPrinter = new RichTextBoxCurrencyDataPrinter(richTextBox1);
            chartBuilder = new ChartBuilder(chart1);
            changeCalculator = new CurrencyChangeCalculator(richTextBox1);
            tempdataPrinter = new RichTextBoxTemperatureDataPrinter();
            graphicBuilder = new GraphicBuilder(chart1);
            tempchangeCalculator = new TemperatureChangeCalculator();
        }

        public string filePath = "";
        private void btn_1_user_Click(object sender, EventArgs e)
        { 

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();
            }


            List<CurrencyData> currencyDataList = dataReader.ReadData(filePath);
            dataPrinter.PrintData(currencyDataList);
            chartBuilder.BuildChart(currencyDataList);
            changeCalculator.CalculateCurrencyChange(currencyDataList);

        }

        private void btn_2_user_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                filePath = openFileDialog1.FileName;

                //Read the contents of the file into a stream
                var fileStream = openFileDialog1.OpenFile();
            }
            LoadTemperatureData();
            graphicBuilder.BuildChart(temperatureDataList);
            tempdataPrinter.PrintData(temperatureDataList, richTextBox1);
            tempchangeCalculator.CalculateTemperatureChange(temperatureDataList, richTextBox1);

        }
        private void LoadTemperatureData()
        {
            ITemperatureDataReader dataReader = new FileTemperatureDataReader();
            temperatureDataList = dataReader.ReadData(filePath);
        }

        private void btn_clr_Click(object sender, EventArgs e)
        {
            richTextBox1.Clear();
            chart1.Series.Clear();
        }
    }

}
