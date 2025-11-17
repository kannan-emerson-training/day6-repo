using CustomerInheritanceApp.Domain;
using System;

namespace CustomerInheritanceApp
{
     class Program
    {
        static void Main(string[] args)
        {

            Customer c1 = new Customer("C2001", "Hemang");

            Console.WriteLine(c1);
            Console.WriteLine(c1.ToString());
            Console.WriteLine(c1.GetType());
           



        }
        static void CaseStudy1() {

            PrintInfo(new Customer("C2001", "Hemang"));
            PrintInfo(new Customer("C3001", "Preeti", "Delhi"));
        }
        static void PrintInfo(Customer customer)
        {
            Console.WriteLine("id :"+customer.Id);
            Console.WriteLine("name :"+customer.Name);
            Console.WriteLine("location :" + customer.Location);
        }
    }
}
