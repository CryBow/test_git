using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_1
{
    // Класс, реализующий чтение данных из файла
    public class FileCurrencyDataReader : ICurrencyDataReader
    {
        public List<CurrencyData> ReadData(string filePath)
        {
            List<CurrencyData> currencyDataList = new List<CurrencyData>();

            string checkLine = "";
            string[] checkLineArray = { "" };
            try
            {
                string[] lines = File.ReadAllLines(filePath);

                foreach (string line in lines)
                {
                    checkLine = line;
                    string[] parts = line.Split(';');
                    checkLineArray = parts;

                    if (parts.Length == 3)
                    {
                        DateTime date = DateTime.Parse(parts[0]);
                        float currency1Rate = float.Parse(parts[1]);
                        float currency2Rate = float.Parse(parts[2]);

                        CurrencyData currencyData = new CurrencyData(date, currency1Rate, currency2Rate);
                        currencyDataList.Add(currencyData);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при чтении файла: " + ex.StackTrace
                    + "\n\n" + checkLine + "\n" + checkLineArray[0] + "\n" + checkLineArray[1] + "\n" + checkLineArray[2]);
            }

            return currencyDataList;
        }
    }
}
