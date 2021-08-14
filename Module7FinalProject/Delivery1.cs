using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Delivery1 : Customer
    {
        public static void Del(double sum, int counter, DateTime today)
        {
            Console.WriteLine("Введите предпочитаемый тип доставки\n1 - доставка на дом, 2 - доставка в пункт выдачи");
            string choice = Console.ReadLine();
            if (choice == "1")
            {
                if (TotalSum.GetSum(0) < 20000)
                {
                    sum = TotalSum.GetSum(1500);
                }
                else
                {
                    sum = TotalSum.GetSum(0);
                }
                DateTime deliverytime;
                if (TotalSum.Counter() < 4)
                {
                    deliverytime = today.AddDays(1);
                }
                else
                {
                    deliverytime = today.AddDays(3);
                }
                Console.WriteLine($"Итого к оплате: {sum}");
                Console.WriteLine("Чтобы оплатить, нажмите \"1\", отменить заказ и выйти в главное меню - нажмите любую клавишу");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Заказ №1001\nВремя заказа - {0}", DateTime.Now);
                    Console.WriteLine($"Ваш заказ будет доставлен {deliverytime}");
                    Console.WriteLine("До получения заказа можно связаться с менеджером:\nИванов Иван Иванович, +1 546 7694 66 55, ivan749@gmail.com");
                    Console.WriteLine("Спасибо, за заказ");
                    Console.ReadKey();
                    Program.MainMenu();
                }
                else
                {
                    Program.MainMenu();
                }
            }
            else if (choice == "2")
            {
                if (TotalSum.GetSum(0) < 100000)
                {
                    sum = 1.05 * TotalSum.GetSum(0);
                }
                else
                {
                    sum = 1.02 * TotalSum.GetSum(0);
                }
                DateTime deliverytime;
                if (TotalSum.Counter() < 100)
                {
                    deliverytime = today.AddDays(3);
                }
                else
                {
                    deliverytime = today.AddDays(5);
                }
                GetContacts();
                Console.WriteLine($"Итого к оплате: {sum}");
                Console.WriteLine("Чтобы оплатить, нажмите \"1\", отменить заказ и выйти в главное меню - нажмите любую клавишу");
                if (Console.ReadLine() == "1")
                {
                    Console.WriteLine("Заказ №1001\nВремя заказа - {0}", DateTime.Now);
                    Console.WriteLine($"Ваш заказ будет доставлен {deliverytime}");
                    Console.WriteLine("Спасибо, за заказ");
                    Console.ReadKey();
                    Program.MainMenu();
                }
                else
                {
                    Program.MainMenu();
                }

            }
            else
            {
                Del(sum, counter, today);
            }
        }

        public static void GetContacts()
        {
            Console.WriteLine(@"
Выберите пункт выдачи товаров:
1. г. Бишкек, ул. Киевская, 37а, 3 этаж, 324 офис
2. г. Бишкек, ул. Московская, 67/4, 2 этаж, 203 офис");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("До получения заказа можно связаться с менеджером:\nМаксимов Максим Максимович, +996 546 768855, maks49@gmail.com");
            }
            else if (Console.ReadLine() == "2")
            {
                Console.WriteLine("До получения заказа можно связаться с менеджером:\nИванов Иван Иванович, +1 546 7694 66 55, ivan749@gmail.com");
            }
            else
            {
                GetContacts();
            }
        }
    }
}
