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
                Console.WriteLine($"{i + 1}. {basket[i].Name}, {basket[i].Price}");
            Console.WriteLine($"Общая сумма без учета доставки: {basket.TotalCost}");
        }

        public void Add(Product product)
        {
            basket.products.Add(product);
            basket.TotalCost += product.Price;
        }

        public void Remove(Product product)
        {
            basket.products.Remove(product);
            basket.TotalCost -= product.Price;
        }
    }
}
