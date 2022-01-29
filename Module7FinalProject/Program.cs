using System;

namespace Module7FinalProject
{
    class Program
    {
        public static Basket basket;
        //public static Delivery delivery;

        public static MainView mainView;
        public static CatalogueView catalogueView;
        public static BasketView basketView;

        static void Main(string[] args)
        {
            basket = new Basket();
            mainView = new MainView();
            catalogueView = new CatalogueView(basket);
            basketView = new BasketView(basket);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
