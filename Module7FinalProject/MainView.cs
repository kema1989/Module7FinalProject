using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class MainView
    {
        public void Show()
        {
            YellowMessage.Show("Добро пожаловать в ");
            Console.WriteLine("Посмотреть каталог товаров (нажмите 1)");
            Console.WriteLine("Заглянуть в корзину (нажмите 2)");
            Console.WriteLine("Оформить заказ (нажмите 3)");
            RedMessage.Show("Выйти (нажмите 4)");

            switch (Console.ReadLine())
            {
                case "1":
                    Program.catalogueView.Show();
                    break;
                case "2":
                    Program.basketView.Show();
                    break;
                case "3":
                    Program.deliveryView.Show();
                    break;
                case "4":
                    Environment.Exit(0);
                    break;
            }
        }
    }
}
