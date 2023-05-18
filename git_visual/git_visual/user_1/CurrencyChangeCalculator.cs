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
            float maxCurrency1ChangeAmount = 0f;
            float maxCurrency2ChangeAmount = 0f;
            DateTime maxCurrency1ChangeDate = DateTime.MinValue;
            DateTime maxCurrency2ChangeDate = DateTime.MinValue;

            foreach (CurrencyData currencyData in currencyDataList)
            {
                if (currencyData.Currency1Rate > maxCurrency1Change)
                {
                    maxCurrency1ChangeAmount = currencyData.Currency1Rate - maxCurrency1Change;
                    maxCurrency1Change = currencyData.Currency1Rate;
                    maxCurrency1ChangeDate = currencyData.Date;
                }

                if (currencyData.Currency2Rate > maxCurrency2Change)
                {
                    maxCurrency2ChangeAmount = currencyData.Currency2Rate - maxCurrency2Change;
                    maxCurrency2Change = currencyData.Currency2Rate;
                    maxCurrency2ChangeDate = currencyData.Date;
                }
            }

            richTextBox.Clear();

            richTextBox.AppendText("Максимальное изменение курса валют:\n");
            richTextBox.AppendText($"Швейцарский франк: {maxCurrency1Change}, Дата: {maxCurrency1ChangeDate.ToShortDateString()}\n");
            richTextBox.AppendText($"Доллар США: {maxCurrency2Change}, Дата: {maxCurrency2ChangeDate.ToShortDateString()}\n");

            richTextBox.AppendText("\n");

            richTextBox.AppendText("Изменение курса валют:\n");

            foreach (CurrencyData currencyData in currencyDataList)
            {
                richTextBox.AppendText($"Дата: {currencyData.Date.ToShortDateString()}\n");
                richTextBox.AppendText($"Швейцарский франк: {currencyData.Currency1Rate}\n");
                richTextBox.AppendText($"Доллар США: {currencyData.Currency2Rate}\n");
                richTextBox.AppendText("\n");
            }
        }



    }
}
