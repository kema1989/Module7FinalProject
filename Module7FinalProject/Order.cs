using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    /// <summary>
    /// Вот хз, что авторы курса так заладили с этой доставкой, и обобщения для нее требовали делать(
    /// Ничего толкового придумать не получилось
    /// </summary>
    class Order<TDelivery> where TDelivery : Delivery
    {
        public TDelivery Delivery;
        public DeliveryView deliveryView;
        public void DisplayAddress()
        {
            Console.WriteLine();
        }

        public Order(Delivery delivery)
        {
            this.Delivery = delivery;
        }

        public void Confirm()
        {

        }
    }
}
