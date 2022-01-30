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
            YellowMessage.Show("Удалить товар (введите его номер)");
            RedMessage.Show("Выйти в главное меню (введите 0)");
            while (true)
            {
                try
                {
                    var id = Console.ReadLine();
                    if (id == "0")
                        Program.mainView.Show();
                    basket.Remove(basket[Convert.ToInt32(id) - 1]);
                }
                catch (Exception)
                {
                    RedMessage.Show("Введено некорректное значение...");
                }
            }
        }
    }
}
