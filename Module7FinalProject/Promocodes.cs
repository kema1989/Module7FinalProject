using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Promocodes: TotalSum
    {
        public double TotalDiscount;
        private static double Discount5 = 0.13;
        private static double Discount10 = 0.1;
        private static double Discount15 = 0.15;

        public static void GetPromocodes()
        {
            Console.WriteLine("Вы в секретной зоне промокодов");
            Console.WriteLine("Если сумеете ответить на 1 вопрос, то вам откроются 3 действующих промокода");
            Console.WriteLine("Итак вопрос: 2+3=?");
            string key = Console.ReadLine();
            if (key == "5")
            {
                Console.WriteLine(@"
1. Пятница13 - введите этот промокод и получите скидку 13% на все товары!
2. Халява - введите этот промокод и получите Xiaomi Mi PowerBank 3 10000 mAh в подарок к НЕ ПУСТОМУ заказу!
3. ЯЖадина - введите этот промокод и отмените свое участие в благотворительном сборе (5% от общей суммы)!");
            }
            else
            {
                Program.Shopping();
            }
        }
    }
}
