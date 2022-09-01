using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructor_Last_Again
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Customer customer = new Customer { Id=1,FirstName="Fayik",LastName="Veznedaroğlu",City="Diyarbakır"};
            Customer customer2 = new Customer(2,"Derin","Demiroğ","Ankara");
            Console.WriteLine(customer2.Id);
            Console.WriteLine(customer2.FirstName);
            Console.WriteLine(customer2.LastName);
        }
        
    }
    class Customer
    {
        //Default Constructor
        public Customer(int id,string firstName,string lastName,string City)
        {
            Id = id;
            FirstName = firstName;
            LastName = LastName;
            this.City = City;
        }
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

    }
}
