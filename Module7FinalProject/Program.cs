using System;

namespace Module7FinalProject
{
    class Program
    {
        public static Basket basket;

        public static MainView mainView;
        public static CatalogueView catalogueView;
        public static BasketView basketView;
        public static DeliveryView deliveryView;

        static void Main(string[] args)
        {
            basket = new Basket();
            mainView = new MainView();
            catalogueView = new CatalogueView(basket);
            basketView = new BasketView(basket);
            deliveryView = new DeliveryView(basket);

            while (true)
            {
                mainView.Show();
            }
        }
    }
}
