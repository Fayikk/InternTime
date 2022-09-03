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
            PersonManager manager1 = new PersonManager ();
            
            Customer customer =new Customer() { CustomerNo=11122,Id=11};
            manager1.Add();//Yukarıda oluşturulan clasım nesnesini Add fonskyionuna direk parametre olarak gönderebiliriz.

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
