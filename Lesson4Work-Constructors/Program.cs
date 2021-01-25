using System;

namespace Lesson4Work_Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer { Id = 1, FirstName = "Furkan", LastName = "Duman", City = "İstanbul" };

            Customer customer3 = new Customer();
            customer3.Id = 3;
            customer3.FirstName = "Furkan";

            Customer customer2 = new Customer(2, "Gürkan", "Duman", "İstanbul");

            Console.WriteLine(customer2.FirstName);

           


        }

       static void Method(int id, string FirstName, string LastName, string City)
        {

        }
    }

    class Customer
    {
        public Customer()
        {

        }
        public Customer(int id, string firstname, string lastname, string city)
        {
            Id = Id;
            FirstName = FirstName;
            LastName = lastname;
            City = city;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
