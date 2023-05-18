using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace git_visual.user_1
{
    // Класс, реализующий вывод информации на экран
    public class RichTextBoxCurrencyDataPrinter : ICurrencyDataPrinter
    {
        private RichTextBox richTextBox;

        public RichTextBoxCurrencyDataPrinter(RichTextBox richTextBox)
        {
            this.richTextBox = richTextBox;
        }

        public void PrintData(List<CurrencyData> currencyDataList)
        {
            richTextBox.Clear();

            richTextBox.AppendText("Информация об изменении курса валют:\n\n");

            foreach (CurrencyData currencyData in currencyDataList)
            {
                richTextBox.AppendText($"Дата: {currencyData.Date.ToShortDateString()}\n");
                richTextBox.AppendText($"Курс Швейцарского франка: {currencyData.Currency1Rate}\n");
                richTextBox.AppendText($"Курс Доллара США: {currencyData.Currency2Rate}\n\n");
            }
        }
    }
}
