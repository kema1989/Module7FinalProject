using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Order: Customer
    {
        public string PromoCode = "Пятница13";
        public string CancelCode = "ЯЖадина";
        private double sum;

        public static void OrderCheck()
        {
            Console.WriteLine("!!!Внимание!!!\nНа этой неделе действует благотворительная акция. 5% от суммы вашего заказа будут перечислены на счета детских домов");
            Console.WriteLine("Введите промокод (если имеется)");
            double sum = TotalSum.Sum();
            Console.WriteLine("Введите предпочитаемый тип доставки");

            switch (Console.ReadLine())
            {
                case "Пятница13":
                    sum = 0.87 * 1.05 * sum;
                    break;
                case "ЯЖадина":
                    sum = sum - 1500;
                    break;
            }
            Console.WriteLine("Введите предпочитаемый тип доставки\n1 - доставка на дом, 2 - доставка в пункт выдачи, 3 - доставка в розничный магазин");
            Console.WriteLine($"Итого сумма к оплате: {sum}");

        }
    }
}
