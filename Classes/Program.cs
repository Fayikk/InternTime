using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            CustomerManager customerManager = new CustomerManager();//classı kullanabilmek için bir örneğini olşturmamız gerekmektedir
            customerManager.Add();
            customerManager.Update();
            Customer customer = new Customer();
            customer.City = "Diyarbakır";
            customer.FirstName = "Fayik";
            customer.LastName = "Veznedaroğlu";
            customer.Id = 1;
            //customer.FirstName = "Rana";
            Console.WriteLine(customer.FirstName);


            Customer customer1 = new Customer { City = "Barcelona", Id = 10, FirstName = "Baran", LastName = "Oruc" };
        }
    }
    class CustomerManager : CustomerManagerBase
    {
    }
}
