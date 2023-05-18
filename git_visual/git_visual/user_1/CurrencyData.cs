using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_visual.user_1
{
    // Класс, представляющий данные об изменении курса валюты
    public class CurrencyData
    {
        public DateTime Date { get; }
        public float Currency1Rate { get; }
        public float Currency2Rate { get; }

        public CurrencyData(DateTime date, float currency1Rate, float currency2Rate)
        {
            Date = date;
            Currency1Rate = currency1Rate;
            Currency2Rate = currency2Rate;
        }
    }
}
