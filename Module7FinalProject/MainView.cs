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
            RedMessage.Show("Выйти (нажмите 3)");

            switch (Console.ReadLine())
            {
                case "1":
                    
            }
        }
    }
}
