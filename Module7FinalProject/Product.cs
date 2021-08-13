using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Product
    {
        public string Name { get; set; } //Название товара
        public int ProductId; //Артикул (он же индекс)
        public int Price; //Стоимость
        public string Description; //Небольшое описание (тип продукции/производитель)

    }
    class Catalogue: Product
    {
        public static Product[] data;
        public Catalogue()
        {
            data = new Product[18];
        }
        public Product this[int id]
        {
            get
            {
                return data[id];
            }
            set
            {
                data[id] = value;
            }
        }

        class CellPhones: Catalogue
        {
            private Catalogue cellphones = new Catalogue();
        }


        public static void ShowBuyCellphones()
        {
            Catalogue cellphones = new Catalogue();
            cellphones[0] = new Product { Name = "Apple iPhone 12 128 GB Dark Grey", ProductId = 0, Price = 64990, Description = "Большой OLED дисплей, две потрясающие камеры" };
            cellphones[1] = new Product { Name = "Samsung Galaxy S20 FE 128 GB Fresh Mint ", ProductId = 1, Price = 39990, Description = "Яркие цвета и емкий аккумулятор"};
            cellphones[2] = new Product { Name = "Samsung Galaxy A52 5G 128 GB Royal Red ", ProductId = 2, Price = 32990, Description = "Четыре камеры и поддержка молниеносного 5G интернета" };
            cellphones[3] = new Product { Name = "Oneplus 9 256 GB Violet", ProductId = 3, Price = 49990, Description = "Элегантный дизайн и молниеносная зарядка" };
            cellphones[4] = new Product { Name = "Xiaomi Mi11 Lite 128 GB", ProductId = 4, Price = 22990, Description = "Компактный, минималистичный дизайн и потрясающие возможности камеры по привлекательной цене" };

            foreach (var cellphone in data)
            {
                Console.Write(cellphone?.Name + "|");
                Console.Write(cellphone?.ProductId + "|");
                Console.Write(cellphone?.Price + "|");
                Console.Write(cellphone?.Description);
            }

            Console.WriteLine("Для приобретения смартфона/нескольких смартфонов введите нужный индекс(ы).\nЧтобы завершить выбор нажмите любую другую клавишу");
            
            switch (Console.ReadLine()) //Как сделать так, чтобы при выборе i-того товара в GetSum шла нужная цена?(((
            {
                case "0":
                    TotalSum.GetSum(cellphones[0].Price);
                    break;
                case "1":
                    TotalSum.GetSum(cellphones[1].Price);
                    break;
                case "2":
                    TotalSum.GetSum(cellphones[2].Price);
                    break;
                case "3":
                    TotalSum.GetSum(cellphones[3].Price);
                    break;
                case "4":
                    TotalSum.GetSum(cellphones[4].Price);
                    break;
                default:
                    Program.Shopping();
                    break;
            }
            Console.ReadKey();
        }


        public static void ShowBuyAccessories()
        {
            Catalogue accessories = new Catalogue();
            accessories[0] = new Product { Name = "Apple AirPods Pro", ProductId = 5, Price = 19990, Description = "Активное шумоподавление и длительная работа без подзарядки" };
            accessories[1] = new Product { Name = "Samsung Buds Live", ProductId = 6, Price = 10490, Description = "TWS-наушники с активным шумоподавлением" };
            accessories[2] = new Product { Name = "Xiaomi Mi PowerBank 3 10000 mAh", ProductId = 7, Price = 19990, Description = "Активное шумоподавление и длительная работа без подзарядки" };

        }
    }
}
