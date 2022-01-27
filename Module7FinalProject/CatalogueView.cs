using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class CatalogueView
    {
        Basket basket;
        public CatalogueView(Basket basket)
        {
            this.basket = basket;
        }
        public void Show()
        {
            YellowMessage.Show("Выберите категорию товаров, которые хотите просмотреть (или мб купить)");
            Console.WriteLine("Мобильные телефоны (нажмите 1)");
            Console.WriteLine("Ноутбуки (нажмите 2)");
            Console.WriteLine("Бытовая техника (нажмите 3)");
            Console.WriteLine("Одежда (нажмите 4)");
            RedMessage.Show("Выйти (нажмите 5)");
        }
    }
}
