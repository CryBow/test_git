using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace git_visual.user_1
{
    // Интерфейс для вывода информации о данных об изменении курса валют
    public interface ICurrencyDataPrinter
    {
        void PrintData(List<CurrencyData> currencyDataList);
    }
}
