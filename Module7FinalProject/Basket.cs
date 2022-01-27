using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class Basket
    {
        public List<Product> products;
        public double TotalCost { get; set; }
        public Basket()
        {
            products = new List<Product>();
            TotalCost = 0;
        }

        //public void Add(Product product)
        //{
        //    products.Add(product);
        //}

        //public void Delete(int id)
        //{
        //    products.Remove(products.Find(p => p.ProductId == id));
        //}

        public Product this[int index]
        {
            get { return products[index]; }
            set { products[index] = value; }
        }
    }
}
