using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public class Program
    {
        static void Main(string[] args)
        {
            //InterFacesIntro();
            //Bir interface hiçbir zaman new'lenemez.
            //IPerson person = new IPerson();  ->Buradaki yapının geçerliliği sağlanamaz.Interfaceler new'lenemezler.
            //Demos();
            ICustomerDal[] customerDals=new ICustomerDal[] {new SqlServerCustomerDal(),new OracleCustomerDal(),new MongoDb()};
            //Yukarıda bir ICustomerDal türünden bir array oluşturalım dedik ve bu array'i kullanabilmek için gerekli nesne'nin oluşumunu sağladık.

            foreach (var customer in customerDals)
            {
                customer.Add();
            }
        }


        private static void Demos()
        {
            IPerson person = new Customer();//Burada person nesnesinin oluşumunu görmekteyiz.burada interface' newlemiyoruz ancak Customer nesnesini oluşturuyoruz.

            OracleCustomerDal oracleCustomerDal = new OracleCustomerDal();
            SqlServerCustomerDal sqlServerCustomerDal = new SqlServerCustomerDal();



            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(oracleCustomerDal);
        }

        private static void InterFacesIntro()
        {
            PersonManager manager1 = new PersonManager();

            Customer customer = new Customer() { CustomerNo = 11122, Id = 11 };
            Student student = new Student();

            manager1.Add(student);//Yukarıda oluşturulan clasım nesnesini Add fonskyionuna direk parametre olarak gönderebiliriz.
        }

        interface IPerson
        {
             int Id { get; set; }
        }
        class Customer : IPerson//İnterfaceler içerisindeki metodlar ve property'ler override edilmek zorundadır.
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
            public int CustomerNo { get; set; }//Müşterinin kendine has özelliklerini'de ektra olarak tutabiliirz.Yalnızca interface metodlarını override etmemize gerek yoktur.
        }
        class Student : IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        }
        //Interfacelerin kullanımını evet gördük ancak,bu interface'ler neden var,biz interface'leri neden kullanıyoruz.Birde bunu öğrenelim.
   
        class PersonManager:IPerson
        {
            public int Id { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

            public void Add(IPerson person)//Parametre olark eklemem yapacağım ve bana parametre olarak,Customer clasından bir örnekleme ver anlamına gelmektedir.

            {

            }
         }
    }
}
