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
        protected Basket basket;
        protected abstract double DisplayCost(Basket basket);
    }

    class HomeDelivery : Delivery
    {
        public HomeDelivery(string address, Basket basket)
        {
            this.Address = address;
            this.basket = basket;
        }

        protected override double DisplayCost(Basket basket)
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
        public PickPointDelivery(string address, Basket basket)
        {
            this.Address = address;
            this.basket = basket;
        }

        protected override double DisplayCost(Basket basket)
        {
            if (basket.products.Count() > 5)
                return 1000;
            else
                return 200;
        }
    }

    class ShopDelivery : Delivery
    {
        public ShopDelivery(string address, Basket basket)
        {
            this.Address = address;
            this.basket = basket;
        }

        protected override double DisplayCost(Basket basket)
        {
            if()
        }
    }
}
