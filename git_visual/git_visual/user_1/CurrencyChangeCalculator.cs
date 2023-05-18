using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_1
{
    // Класс, реализующий вычисление максимального изменения курса валюты
    public class CurrencyChangeCalculator
    {
        private RichTextBox richTextBox;

        public CurrencyChangeCalculator(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void CalculateCurrencyChange(List<CurrencyData> currencyDataList)
        {
            float maxCurrency1Change = float.MinValue;
            float maxCurrency2Change = float.MinValue;
            DateTime maxCurrency1ChangeDate = DateTime.MinValue;
            DateTime maxCurrency2ChangeDate = DateTime.MinValue;

            foreach (CurrencyData currencyData in currencyDataList)
            {
                if (currencyData.Currency1Rate > maxCurrency1Change)
                {
                    maxCurrency1Change = currencyData.Currency1Rate;
                    maxCurrency1ChangeDate = currencyData.Date;
                }

                if (currencyData.Currency2Rate > maxCurrency2Change)
                {
                    maxCurrency2Change = currencyData.Currency2Rate;
                    maxCurrency2ChangeDate = currencyData.Date;
                }
            }

            richTextBox.Clear();

            richTextBox.AppendText("Максимальное изменение курса валют:\n");
            richTextBox.AppendText($"Валюта 1: {maxCurrency1Change}, Дата: {maxCurrency1ChangeDate.ToShortDateString()}\n");
            richTextBox.AppendText($"Валюта 2: {maxCurrency2Change}, Дата: {maxCurrency2ChangeDate.ToShortDateString()}\n");
        }
    }
}
