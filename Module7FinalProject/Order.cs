using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    /// <summary>
    /// Заказ выбранных товаров
    /// </summary>
    class Order: Customer
    {
        public string PromoCode = "Пятница13";
        public string CancelCode = "ЯЖадина";
        public static void OrderCheck()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("!!!Внимание!!!\nНа этой неделе действует благотворительная акция. 5% от суммы вашего заказа будут перечислены на счета детских домов");
            Console.ForegroundColor = ConsoleColor.Gray;
            Customer.NewOne();
            Console.WriteLine("--------------------");
            Console.WriteLine("Введите промокод (если имеется)");
            double sum = 1.05 * TotalSum.GetSum(0);
            string promo = Console.ReadLine();
            switch (promo)
            {
                case "Пятница13":
                    sum = 0.87 * sum;
                    break;
                case "ЯЖадина":
                    sum = sum / 1.05 - 1500;
                    break;
            }
            Console.WriteLine("--------------------");
            Delivery1.Del(sum, TotalSum.Counter(), DateTime.Today);
            Program.MainMenu();
        }
    }
}
