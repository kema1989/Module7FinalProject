using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    /// <summary>
    /// Раздел замечаний и отзывов
    /// </summary>
    class Feedback: Customer
    {
        public static void GiveFeedBack()
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
