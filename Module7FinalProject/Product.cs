using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    class Product
    {
        public int ProductId; //Артикул (он же индекс)
        public string Name; //Название товара
        public int Price; //Стоимость
        public string Description; //Небольшое описание (рекламное, хехе)

    }
    /// <summary>
    /// Да, знаю, наследовать каталог от продукта глупо, но я там запутался с индексатором и неохота стало что-то менять(
    /// </summary>
    class Catalogue: Product
    {
        public static Product[] data;
        public Catalogue()
        {
            data = new Product[5];
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


        public static void ShowBuyCellphones() //Мобильные телефоны
        {
            Catalogue cellphones = new Catalogue();
            cellphones[0] = new Product { ProductId = 1, Name = "Apple iPhone 12 128 GB Dark Grey", Price = 64990, Description = "Большой OLED дисплей, две потрясающие камеры" };
            cellphones[1] = new Product { ProductId = 2, Name = "Samsung Galaxy S20 FE 128 GB Fresh Mint ", Price = 39990, Description = "Яркие цвета и емкий аккумулятор"};
            cellphones[2] = new Product { ProductId = 3, Name = "Samsung Galaxy A52 5G 128 GB Royal Red ", Price = 32990, Description = "Четыре камеры и поддержка молниеносного 5G интернета" };
            cellphones[3] = new Product { ProductId = 4, Name = "Oneplus 9 256 GB Violet", Price = 49990, Description = "Элегантный дизайн и молниеносная зарядка" };
            cellphones[4] = new Product { ProductId = 5, Name = "Xiaomi Mi11 Lite 128 GB", Price = 22990, Description = "Компактный, минималистичный дизайн и потрясающие возможности камеры по привлекательной цене" };

            foreach (var cellphone in data)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Код: " + cellphone?.ProductId);
                Console.WriteLine("Наименование: " + cellphone?.Name);
                Console.WriteLine("Стоимость: " + cellphone?.Price);
                Console.WriteLine("Описание: " + cellphone?.Description);
                Console.WriteLine("--------------------");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("Для приобретения продукта/продуктов введите нужный индекс(ы).\nЧтобы завершить выбор нажмите любую другую клавишу");
            
            while (true)
            {
                switch (Console.ReadLine()) //Как сделать так, чтобы при выборе i-того товара в GetSum шла нужная цена?(((
                {
                    case "1":
                        TotalSum.GetSum(cellphones[0].Price);
                        TotalSum.Counter();
                        break;
                    case "2":
                        TotalSum.GetSum(cellphones[1].Price);
                        TotalSum.Counter();
                        break;
                    case "3":
                        TotalSum.GetSum(cellphones[2].Price);
                        TotalSum.Counter();
                        break;
                    case "4":
                        TotalSum.GetSum(cellphones[3].Price);
                        TotalSum.Counter();
                        break;
                    case "5":
                        TotalSum.GetSum(cellphones[4].Price);
                        TotalSum.Counter();
                        break;
                    case "0":
                        Program.Shopping();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ввести код товара заново. Для выхода введите \"0\"");
                        break;
                }
            }
        }

        public static void ShowBuyAccessories() //Аксессуары
        {
            Catalogue accessories = new Catalogue();
            accessories[0] = new Product { ProductId = 1, Name = "Apple AirPods Pro", Price = 19990, Description = "Активное шумоподавление и длительная работа без подзарядки" };
            accessories[1] = new Product { ProductId = 2, Name = "Samsung Buds Live", Price = 10490, Description = "TWS-наушники с активным шумоподавлением" };
            accessories[2] = new Product { ProductId = 3, Name = "Xiaomi Mi PowerBank 3 10000 mAh", Price = 19990, Description = "Активное шумоподавление и длительная работа без подзарядки" };
            accessories[3] = new Product { ProductId = 4, Name = "Samsung Wireless Charger 15W", Price = 4490, Description = "Беспроводная зарядка с низким уровнем шума" };
            accessories[4] = new Product { ProductId = 5, Name = "Xiaomi Mi TriPod", Price = 1990, Description = "Умный трипод 3в1" };
            foreach (var accessory in data)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Код: " + accessory?.ProductId);
                Console.WriteLine("Наименование: " + accessory?.Name);
                Console.WriteLine("Стоимость: " + accessory?.Price);
                Console.WriteLine("Описание: " + accessory?.Description);
                Console.WriteLine("--------------------");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("Для приобретения продукта/продуктов введите нужный индекс(ы).\nЧтобы завершить выбор нажмите любую другую клавишу");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        TotalSum.GetSum(accessories[0].Price);
                        TotalSum.Counter();
                        break;
                    case "2":
                        TotalSum.GetSum(accessories[1].Price);
                        TotalSum.Counter();
                        break;
                    case "3":
                        TotalSum.GetSum(accessories[2].Price);
                        TotalSum.Counter();
                        break;
                    case "4":
                        TotalSum.GetSum(accessories[3].Price);
                        TotalSum.Counter();
                        break;
                    case "5":
                        TotalSum.GetSum(accessories[4].Price);
                        TotalSum.Counter();
                        break;
                    case "0":
                        Program.Shopping();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ввести код товара заново. Для выхода введите \"0\"");
                        break;
                }
            }
        }

        public static void ShowBuyTablets() //Планшеты
        {
            Catalogue tablets = new Catalogue();
            tablets[0] = new Product { ProductId = 1, Name = "Apple iPad Air 2020 WiFi 256 GB Green", Price = 59990, Description = "Потрясающий Liquid Retina дисплей и мощнейший процессор A14" };
            tablets[1] = new Product { ProductId = 2, Name = "Samsung Galaxy Tab S7 5G 128 GB Silver", Price = 54990, Description = "Суперплавный дисплей 120 Гц и стилус S Pen в комплекте" };
            tablets[2] = new Product { ProductId = 3, Name = "Xiaomi Mi Pad 5 5G 128 GB Black", Price = 32990, Description = "Поддержка стилуса M-Pen и процессор Snapdragon 870" };
            tablets[3] = new Product { ProductId = 4, Name = "Samsung Galaxy Tab S6 Lite 4G 128 GB Silver", Price = 24990, Description = "Компактный яркий корпус и стилус S Pen" };
            tablets[4] = new Product { ProductId = 5, Name = "Microsoft Surface 7 i7 11th gen 256 GB SSD Silver", Price = 79990, Description = "Совершенно новый тип устройства-трансформера" };
            foreach (var tablet in data)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine($"Код: {tablet?.ProductId}");
                Console.WriteLine("Наименование: " + tablet?.Name);
                Console.WriteLine("Стоимость: " + tablet?.Price);
                Console.WriteLine("Описание: " + tablet?.Description);
                Console.WriteLine("--------------------");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("Для приобретения продукта/продуктов введите нужный индекс(ы).\nЧтобы завершить выбор нажмите любую другую клавишу");

            while (true)
            {
                switch (Console.ReadLine())
                {
                    case "1":
                        TotalSum.GetSum(tablets[0].Price);
                        TotalSum.Counter();
                        break;
                    case "2":
                        TotalSum.GetSum(tablets[1].Price);
                        TotalSum.Counter();
                        break;
                    case "3":
                        TotalSum.GetSum(tablets[2].Price);
                        TotalSum.Counter();
                        break;
                    case "4":
                        TotalSum.GetSum(tablets[3].Price);
                        TotalSum.Counter();
                        break;
                    case "5":
                        TotalSum.GetSum(tablets[4].Price);
                        TotalSum.Counter();
                        break;
                    case "0":
                        Program.Shopping();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ввести код товара заново. Для выхода введите \"0\"");
                        break;
                }
            }
        }

        public static void ShowBuyLaptops() //Ноутбуки
        {
            Catalogue laptops = new Catalogue();
            laptops[0] = new Product { ProductId = 1, Name = "Apple MacBook Pro 13'' M1 512 GB Space Grey", Price = 129990, Description = "Вся мощь процессора M1" };
            laptops[1] = new Product { ProductId = 2, Name = "Apple MacBook Air 13'' M1 256 GB Rose Gold", Price = 99990, Description = "Мощь процессора М1 в тонком корпусе" };
            laptops[2] = new Product { ProductId = 3, Name = "Asus ZenBook Pro Duo 14'' 1 TB SSD Black", Price = 104990, Description = "Два экрана для настоящих профессионалов" };
            laptops[3] = new Product { ProductId = 4, Name = "Acer Swift 3 13'' 256 GB Silver", Price = 54990, Description = "Элегантный металличсекий корпус и долгая автономная работа" };
            laptops[4] = new Product { ProductId = 5, Name = "Lenovo YOGA 730C 13'' 512 GB", Price = 79990, Description = "Сенсорный OLED экран на все 360 градусов" };

            foreach (var laptop in data)
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("Код: " + laptop?.ProductId);
                Console.WriteLine("Наименование: " + laptop?.Name);
                Console.WriteLine("Стоимость: " + laptop?.Price);
                Console.WriteLine("Описание: " + laptop?.Description);
                Console.WriteLine("--------------------");
                Console.BackgroundColor = ConsoleColor.Black;
            }

            Console.WriteLine("Для приобретения продукта/продуктов введите нужный индекс(ы).\nЧтобы завершить выбор нажмите любую другую клавишу");

            while (true)
            {
                switch (Console.ReadLine()) //Как сделать так, чтобы при выборе i-того товара в GetSum шла нужная цена?(((
                {
                    case "1":
                        TotalSum.GetSum(laptops[0].Price);
                        break;
                    case "2":
                        TotalSum.GetSum(laptops[1].Price);
                        break;
                    case "3":
                        TotalSum.GetSum(laptops[2].Price);
                        break;
                    case "4":
                        TotalSum.GetSum(laptops[3].Price);
                        break;
                    case "5":
                        TotalSum.GetSum(laptops[4].Price);
                        break;
                    case "0":
                        Program.Shopping();
                        break;
                    default:
                        Console.WriteLine("Попробуйте ввести код товара заново. Для выхода введите \"0\"");
                        break;
                }
            }
        }
    }
}
