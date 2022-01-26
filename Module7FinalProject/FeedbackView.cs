using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class FeedbackView
    {
        Customer customer;

        public FeedbackView(Customer customer)
        {
            this.customer = customer;
        }
        public void Show()
        {
            Customer.NewOne();
            Console.WriteLine("Приветствуем вас в разделе замечаний и отзывов.\nОставьте любой по содержанию отзыв, для нас это очень важно.");
            Console.ReadLine();
            Console.WriteLine("Спасибо. Для возврата в главное меню нажмите любую клавишу");
            Console.ReadKey();
            Program.MainMenu();
        }
    }
}
