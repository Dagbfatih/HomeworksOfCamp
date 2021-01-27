using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class CustomerManager
    {

        public void AddCustomer(ref List<Customer> customers, ref int IDCounter)
        {

            Customer customerCreate = new Customer();

            Console.WriteLine("Name: ");                    // Name
            customerCreate.Name = Console.ReadLine();       
            Console.WriteLine("\nSurname: ");               // Surname
            customerCreate.Surname = Console.ReadLine();
            Console.WriteLine("\nAge: ");                   // Age
            customerCreate.Age = Convert.ToInt32(Console.ReadLine());
            customerCreate.ID = IDCreator(ref IDCounter);   // ID

            customers.Add(customerCreate);
            Console.WriteLine("İtem Added...");
        }

        public void DeleteCustomer(ref List<Customer> customers, ref int IDCounter)
        {
            IDCounter--;
            customers.RemoveAt(customers.Count - 1);
            Console.WriteLine("İtem Deleted...");
        }

        public void ListCustomers(ref List<Customer> customers)
        {
            foreach (Customer customer in customers)
            {
                Console.WriteLine("Name :\t\t" + customer.Name);
                Console.WriteLine("Surname :\t" + customer.Surname);
                Console.WriteLine("Age :\t\t" + customer.Age);
                Console.WriteLine("ID :\t\t" + customer.ID);
                Console.WriteLine();
            }
            Console.ReadKey();
            Console.Clear();
        }

        private string IDCreator(ref int IDCounter)
        {
            IDCounter++;
            string ID = (IDCounter < 10 ? "00" : IDCounter < 100 ? "0" : "") + Convert.ToString(IDCounter);
            return ID;
        }

    }
}
