using System;

namespace Module7FinalProject
{
    class Program
    {
        public static Basket basket;
        public static Delivery delivery;

        static CatalogueView catalogueView;

        static void Main(string[] args)
        {
            
        }
        //public static void MainMenu() //Главное меню
        //{
        //    Console.WriteLine("Вы в главном меню");
        //    Console.WriteLine("Начать шоппинг - введите\"1\", оставить отзыв - \"2\",");
        //    Console.WriteLine("закончить сессию - \"3\"(или любую другую клавишу:-)");
        //    string key = Console.ReadLine();
        //    if (key == "1")
        //    {
        //        Shopping(); //Меню с категориями товаров
        //    }
        //    if(key == "3")
        //    {
        //        Console.WriteLine("Спасибо за посещение интернет-магазина \"Светофор\".\nБудем рады видеть вас вновь, хорошего вам дня.");
        //        //Выход
        //    }
        //    else if (key == "2")
        //    {
        //        Feedback.GiveFeedBack(); //Раздел отзывов и замечаний
        //    }
            
        //}
        //public static void Shopping()
        //{
        //    Console.WriteLine("Выберите нужный вам раздел (введите нужную клавишу):");
        //    Console.WriteLine("Мобильные телефоны - 1");
        //    Console.WriteLine("Аксессуары для мобильных телефонов - 2");
        //    Console.WriteLine("Планшеты - 3");
        //    Console.WriteLine("Ноутбуки - 4");
        //    Console.WriteLine("Акции и сверхсекретные промокоды - 5");
        //    Console.WriteLine("Оформить заказ - 6");
        //    Console.WriteLine("Выйти в главное меню - любая клавиша");
        //    switch (Console.ReadLine())
        //    {
        //        case "1":
        //            Catalogue.ShowBuyCellphones();
        //            break;
        //        case "2":
        //            Catalogue.ShowBuyAccessories();
        //            break;
        //        case "3":
        //            Catalogue.ShowBuyTablets();
        //            break;
        //        case "4":
        //            Catalogue.ShowBuyLaptops();
        //            break;
        //        case "5":
        //            Promocodes.GetPromocodes();
        //            break;
        //        case "6":
        //            Order.OrderCheck();
        //            break;
        //        default:
        //            MainMenu();
        //            break;
        //    }
        //}
    }
}
