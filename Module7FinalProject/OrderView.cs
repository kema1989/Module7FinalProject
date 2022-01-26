using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class OrderView
    {
        Basket basket;
        public OrderView(Basket basket)
        {
            this.basket = basket;
        }

        public void Show()
        {
            Console.WriteLine();
        }
    }
}
