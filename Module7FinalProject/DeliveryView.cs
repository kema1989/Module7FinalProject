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
        public Delivery DefineDeliveryType()
        {
            YellowMessage.Show("Выберите тип доставки:");
            Console.WriteLine("Доставка курьером на дом (нажмите 1)");
            Console.WriteLine("Доставка в пункт выдачи (нажмите 2)");
            Console.WriteLine("Самовывоз из магазина (нажмите 3)");
            RedMessage.Show("Выйти (нажмите 4)");
            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        return new HomeDelivery();
                }
            }
        }
    }
}
