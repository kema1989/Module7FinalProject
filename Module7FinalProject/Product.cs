using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public abstract class Product
    {
        public abstract int ProductId { get; set; }
        public abstract string Name { get; set; }
        public abstract int Price { get; set; }
        public abstract string Description { get; set; }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        //Перегрузка операторов, которая не понадобилась
        public static double operator +(Product a, Product b)
        {
            return a.Price + b.Price;
        }
        public static bool operator ==(Product a, Product b)
        {
            return a.Price == b.Price;
        }

        public static bool operator !=(Product a, Product b)
        {
            return a.Price != b.Price;
        }

        public static bool operator <(Product a, Product b)
        {
            return a.Price < b.Price;
        }

        public static bool operator >(Product a, Product b)
        {
            return a.Price > b.Price;
        }
    }

    //Если бы было много товаров, то разделение на категории и создание абстрактного класса было бы оправдано
    public class Cellphone : Product
    {
        public override int ProductId { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }
        public override string Description { get; set; }
    }

    public class Laptop : Product
    {
        public override int ProductId { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }
        public override string Description { get; set; }
    }

    public class Furniture : Product
    {
        public override int ProductId { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }
        public override string Description { get; set; }
    }

    public class Clothes : Product
    {
        public override int ProductId { get; set; }
        public override string Name { get; set; }
        public override int Price { get; set; }
        public override string Description { get; set; }
    }
}
