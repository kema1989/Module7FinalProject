using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class DeliveryView
    {
        Basket basket;
        public DeliveryView(Basket basket)
        {
            this.basket = basket;
        }
        public void Show()
        {
            YellowMessage.Show("Выберите тип доставки:");
            Console.WriteLine("Доставка курьером на дом (нажмите 1)");
            Console.WriteLine("Доставка в пункт выдачи (нажмите 2)");
            Console.WriteLine("Самовывоз из магазина (нажмите 3)");
            RedMessage.Show("Выйти (нажмите 4)");
            while (true)
            {
                var key = Console.ReadLine();
                if (key == "4")
                    return;
                switch (key)
                {
                    case "1":
                        var order1 = new Order<HomeDelivery>();
                        order1.Delivery = new HomeDelivery(basket);
                        order1.Confirm();
                        break;
                    case "2":
                        var order2 = new Order<PickPointDelivery>();
                        order2.Delivery = new PickPointDelivery(basket);
                        order2.Confirm();
                        break;
                    case "3":
                        var order3 = new Order<ShopDelivery>();
                        order3.Delivery = new ShopDelivery(basket);
                        order3.Confirm();
                        break;
                }
            }
        }
    }
}
