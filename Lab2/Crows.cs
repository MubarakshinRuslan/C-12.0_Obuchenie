using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab2
{
    /// <summary>
    /// Подсчет ворон на ветке
    /// </summary>
    internal class Crows
    {
        private int _Count;
        public Crows(int count)
        {
            _Count = count;
        }
        /// <summary>
        /// Получение количества ворон сидящих на ветке (в диапазоне от 0 до 9)
        /// </summary>
        /// <returns></returns>
        public string ExGetCount() => _Count switch
            {
                1 => $"На ветке {_Count} ворона",
                >= 2 and < 5 => $"На ветке {_Count} вороны",
                >= 5 and < 10 or 0 => $"На ветке {_Count} ворон",
                _ => "на ветке либо слишком мало либо слишком много ворон (не входит в диапазон от 0 до 9)"
            };
        /// <summary>
        /// Получение количества ворон сидящих на ветке (корректное поведение от 0 до int.MaxValue())
        /// </summary>
        /// <returns>Строка вида: "На ветке n ворон" с правильным склонением слова "ворона" по правилам русского языка</returns>
        public string GetCount()
        {
            int mod100 = _Count % 100;
            int mod10 = _Count % 10;
            return mod100 switch
            {
                0 => $"На ветке {_Count} ворон",
                1 or > 20 when mod10 == 1 => $"На ветке {_Count} ворона",
                >= 2 and < 5 or > 20 when mod10 >= 2 && mod10 < 5 => $"На ветке {_Count} вороны",
                >= 5 and <= 19 => $"На ветке {_Count} ворон", // Хотел подобные в один кейс объединить, но не получилось
                >= 20 when (mod10 >= 5 && mod10 < 19) || mod10 == 0 => $"На ветке {_Count} ворон",
                _ => "что-то пошло не так как задумывалось"
            };
        }


    }
}
