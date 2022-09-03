using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            Student student = new Student();
            customer.Id = 1;
            customer.FirstName = "Fayik";
            customer.LastName = "Veznedaroglu";
            customer.City = "Diyarbakır";
            Console.WriteLine("-----------");
            student.Id = 2;
            student.FirstName = "Malcolm";
            student.LastName = "X";
            student.Department = "Software Engineer";
            //Farklı bir kullanım şekli olarak;
            Person[] person=new Person[] {customer, student,new Teacher() {Id=10,FirstName="Steve ",LastName= "Jobs",Branch="Marketing" } };
            foreach (var item in person)
            {
                Console.WriteLine(item.FirstName);
            }
        }
    }
    class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    //Aslında soyut olarak düşünecek olursak burada Person sınıfı ile kalıtılan sınıflar
    //Person sınıfnınn child'ıyken,Person sınıfı ie Parent olarak davranacaktır.
    //Bir sınıf birden fazla sınıfı kalıtım ile alamaz.
    //Şöyle düşünebiliriz bir kişinin bir tane babası olabilir mantığıyla hareket edilmelidir.
    class Customer : Person
    {
        public string City { get; set; }
    }
    class Student : Person
    {
        public string Department { get; set; }
    }
    class Teacher:Person
    {
        public string Branch { get; set; }
    }
}
