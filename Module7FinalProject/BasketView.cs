using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class BasketView
    {
        Basket basket;
        public BasketView(Basket basket)
        {
            this.basket = basket;
        }
        public void Show()
        {
            for(int i = 0; i < basket.products.Count; i++)
                Console.WriteLine($"{i + 1}. {basket[i].Name}, {basket[i].Price} руб");
            Console.WriteLine($"Общая сумма без учета доставки: {basket.TotalCost} руб");
            GreenMessage.Show("Выбрать тип доставки и оформить заказ (введите 0)");
            YellowMessage.Show("Удалить товар (введите его номер)");
            RedMessage.Show("Выйти (введите 00)");
            while (true)
            {
                try
                {
                    var id = int.Parse(Console.ReadLine());
                    basket.Remove(basket[id]);
                }
                catch (Exception)
                {
                    RedMessage.Show("Введено некорректное значение...");
                }
            }
        }
    }
}
