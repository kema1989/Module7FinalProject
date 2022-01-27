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
        List<Product> catalogue = new List<Product>()
        {
            new Cellphone{ProductId = 1, Name = "Apple iPhone 13", Description = "Dark Blue 128 Gb", Price = 69990},
            new Cellphone{ProductId = 2, Name = "Oneplus 9", Description = "Violet 256 Gb", Price = 44990},
            new Laptop{ProductId = 3, Name = "Apple Macbook Air 13\"", Description = "Rose Gold 256 Gb", Price = 89990},
            new Furniture{ProductId = 4, Name = "Диван \"София\"", Description = "Морской бриз", Price = 37990},
            new Clothes{ProductId = 5, Name = "Тренч Mango", Description = "Женский, XS", Price = 9990}
        };
        public CatalogueView(Basket basket)
        {
            this.basket = basket;
        }
        public void Show()
        {
            YellowMessage.Show("Чтобы положить товар в корзину введите его номер");
            catalogue.ForEach(p => Console.WriteLine($"{p.ProductId}. {p.Name} {p.Description}|{p.Price} руб"));
            RedMessage.Show("Выйти (нажмите 0)");
            while (true)
            {
                try
                {
                    var id = int.Parse(Console.ReadLine());
                    if (id == 0)
                        return;
                    basket.Add(catalogue[id]);
                    GreenMessage.Show($"Вы успешно добавили {catalogue[id].Name} в корзину!");
                }
                catch (Exception)
                {
                    RedMessage.Show("Введено некорректное значение...");
                }
            }

        }
    }
}
