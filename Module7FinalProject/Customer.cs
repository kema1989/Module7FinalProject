using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module7FinalProject
{
    public class Customer
    {
        private string name;
        private string address;
        private string phonenumber;


        public string Name
        {
            get { return name; }
            set
            {
                if(value == null)
                {
                    Console.WriteLine("Имя не может быть пустым...");
                }
                else
                {
                    name = value;
                }
            }
        }

        public string Address
        {
            get { return address; }
            set
            {
                if(value == null)
                {
                    Console.WriteLine("Адрес не может быть пустым...");
                }
                else
                {
                    address = value;
                }
            }
        }

        public string PhoneNumber
        {
            get { return phonenumber; }
            set
            {
                if(value == null)
                {
                    Console.WriteLine("Номер телефона не может быть пустым...");
                }
                else
                {
                    phonenumber = value;
                }
            }
        }

        public static Customer NewOne() //Сбор данных клиента
        {
            var customer = new Customer();
            Console.WriteLine("Введите ФИО:");
            customer.name = Console.ReadLine();
            Console.WriteLine("Введите ваш адрес");
            customer.address = Console.ReadLine();
            Console.WriteLine("Введите ваш номер телефона");
            customer.phonenumber = Console.ReadLine();
            return customer;
        }
    }
}
