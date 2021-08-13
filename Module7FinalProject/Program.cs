using System;

namespace Module7FinalProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Доброго времени суток, вас приветствует\nинтернет-магазин \"Светофор\"");
            
            MainMenu();
        }
        static void MainMenu()
        {
            Console.WriteLine("Вы в главном меню");
            Console.WriteLine("Начать шоппинг - введите\"1\", оставить отзыв - \"2\",");
            Console.WriteLine("закончить сессию - \"3\"(или любую другую клавишу:-)");
            string key = Console.ReadLine();
            if (key == "1")
            {
                Shopping();
            }
            else if (key == "2")
            {

            }
            else
            {
                Console.WriteLine("Спасибо за посещение интернет-магазина \"Светофор\".\nБудем рады видеть вас вновь, хорошего вам дня.");
            }
        }
        public static void Shopping()
        {
            Console.WriteLine("Выберите нужный вам раздел (введите нужную клавишу):");
            Console.WriteLine("Мобильные телефоны - 1");
            Console.WriteLine("Аксессуары для мобильных телефонов - 2");
            Console.WriteLine("Техника для кухни - 3");
            Console.WriteLine("Климатическая техника - 4");
            Console.WriteLine("Акции и сверхсекретные промокоды - 5");
            Console.WriteLine("Оформить заказ - 6");
            Console.WriteLine("Выйти в главное меню - любая клавиша");
            switch (Console.ReadLine())
            {
                case "1":
                    Catalogue.ShowBuyCellphones();

                    break;
                case "2":

                case "5":
                    Promocodes.GetPromocodes();
                    break;
                case "6":
                    Order.OrderCheck();
                    break;
                    
                default:
                    MainMenu();
                    break;
            }
        }
    }
}
