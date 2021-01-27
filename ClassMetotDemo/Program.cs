using System;
using System.Collections.Generic;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int IDCounter = 1;

            Customer customer1 = new Customer();
            customer1.Name = "Fatih";
            customer1.Surname = "Dag";
            customer1.Age = 16;
            customer1.ID = "000"; // 001 - 002 ... 009 - 010 - 011

            Customer customer2 = new Customer();
            customer2.Name = "Ahmet";
            customer2.Surname = "Yilmaz";
            customer2.Age = 56;
            customer2.ID = "001";

            List<Customer> customers = new List<Customer>() { customer1, customer2 }; //Customer[] customers = new Customer[] { customer1, customer2, customer3 };
            CustomerManager customerManager = new CustomerManager();

            while (true)
            {
                
                Console.WriteLine("For Add Customer Press 1, For Delete Customer Press 2, For List Customers Press 3, For Exit Press 4");
                var key = Console.ReadKey().KeyChar;
                Console.Clear();

                if (key == '1')
                {
                    customerManager.AddCustomer(ref customers, ref IDCounter);
                }
                else if (key == '2')
                {
                    customerManager.DeleteCustomer(ref customers, ref IDCounter);
                }
                else if (key == '3')
                {
                    customerManager.ListCustomers(ref customers);
                }
                else if (key == '4')
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Re-press...");
                }
            }
            
        }
    }
}
