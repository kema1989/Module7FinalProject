using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class TotalSum
    {
        private static double sum = 0;
        private static int counter = 0;
        public static double GetSum(double price) //Добавляет стоимость каждого выбранного товара
        {
            sum += price;
            return sum;
        }

        public static int Counter() //Добавляет 1 к счетчику приобретаемых товаров (это учитывается при вычислении стоимости доставки)
        {
            counter++;
            return counter;
        }
    }
}
