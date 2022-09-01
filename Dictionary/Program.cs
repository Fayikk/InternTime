using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    public class Program
    {
        static void Main(string[] args)
        {
            var English = new Dictionary<string, string>();
            //Bu yapı sayesinde bilinen sözlük yapısı oluşturuluyor.
            //Burada asıl özellik key and value şeklinde gereklilik sağlamaktadır.
            //Elma'nın key,Amasya elması'nın value olması gibi düşünebilirsiniz.
            //Apple=elma
            English.Add("Apple", "Elma");
            English.Add("Computer", "Bilgisayar");
            English.Add("Bridge", "Köprü");
            English.Add("Table", "Masa");
            English.Add("Phone", "Telefon");
            English.Add("Fridge", "Buzdolabı");

            foreach (var sözlük in English)
            {
                Console.WriteLine(sözlük);
            }
            Console.WriteLine("----------------");
            


        }
    }
}
