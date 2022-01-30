using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    /// <summary>
    /// Вот хз, что авторы курса так заладили с этой доставкой, и обобщения для нее требовали делать(
    /// Ничего толкового придумать не получилось
    /// </summary>
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;

        public void Confirm()
        {
            Console.WriteLine($"Выбрано {Delivery.basket.products.Count} товаров на сумму: {Delivery.basket.TotalCost} руб");
            Console.WriteLine($"Стоимость доставки: {Delivery.DisplayCost()} руб");
            Console.WriteLine($"Итого к оплате: {Delivery.basket.TotalCost + Delivery.DisplayCost()} руб");
            GreenMessage.Show("Оформить заказ (нажмите 1)");
            YellowMessage.Show("Вернуться в корзину (нажмите 2)");
            RedMessage.Show("Отменить заказ, очистить корзину и выйти (нажмите 3)");
            while (true)
            {
                try
                {
                    var key = Console.ReadLine();
                    if (key == "3")
                        Environment.Exit(0);
                    switch (key)
                    {
                        case "1":
                            var message = "Спасибо за заказ! Ожидайте. Всего доброго :)"; // Баловство, кхе-кхе
                            foreach(var letter in message)
                            {
                                Console.Write(letter);
                                System.Threading.Thread.Sleep(100);
                            }
                            Console.WriteLine();
                            Program.mainView.Show();
                            break;
                        case "2":
                            Program.basketView.Show();
                            break;
                    }
                }
                catch
                {
                    Console.WriteLine("Введено значение неверного формата...");
                }
            }
        }
    }
}
