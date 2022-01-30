using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public abstract class Delivery
    {
        public string Address;
        public Basket basket;
        public abstract double DisplayCost();
        public Delivery(Basket basket)
        {
            this.basket = basket;
        }
    }

    class HomeDelivery : Delivery
    {
        public HomeDelivery(Basket basket):base(basket)
        {
            Console.WriteLine("Введите адрес доставки");
            this.Address = Console.ReadLine();
            this.basket = basket;
        }

        public override double DisplayCost()
        {
            double deliveryCost = 0;
            if (basket.products.Any(p => p is Furniture))
                basket.products.ForEach(p =>
                {
                    deliveryCost += p.Price * 0.05;
                });
            return deliveryCost;
        }
    }

    class PickPointDelivery : Delivery
    {
        public PickPointDelivery(Basket basket):base(basket)
        {
            this.Address = "Пункт выдачи №100500, Энский поселок, ул. Безымянная, 100, оф. 500";
            this.basket = basket;
        }

        public override double DisplayCost()
        {
            if (basket.products.Count() > 5)
                return 1000;
            else
                return 200;
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery(Basket basket):base(basket)
        {
            this.Address = "г. Москва, Цветной Бульвар, 101, бутик 67А";
            this.basket = basket;
        }

        public override double DisplayCost()
        {
            return 0;
        }
    }
}
