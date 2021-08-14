using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Promocodes: TotalSum
    {
        public static void GetPromocodes() //Зона промокодов
        {
            Console.WriteLine("Вы в секретной зоне промокодов");
            Console.WriteLine("Если сумеете ответить на 1 вопрос, то вам откроются 2 действующих промокода");
            Console.WriteLine("Итак вопрос: 2+3=?");
            string key = Console.ReadLine();
            if (key == "5")
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine(@"
1. Пятница13 - введите этот промокод и получите скидку 13% на все товары!
2. ЯЖадина - введите этот промокод и отмените свое участие в благотворительном сборе (5% от общей суммы)!");
                Console.ForegroundColor = ConsoleColor.Gray;
            }
            else
            {
                Program.Shopping();
            }
            Program.Shopping();
        }
    }
}
