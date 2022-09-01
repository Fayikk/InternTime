using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            
            MyList<string> isimler = new MyList<string>();//Görüldüğü üzere MyList class'ının tanımalamasını "T" template tipinden ayarladığımız için 
                                                          //İçerisine atama yapmak istediğimiz zaman dışarıda değeri biz belirtebiliyoruz.
            isimler.Add("Fayik");
            Console.WriteLine(isimler.Length);
            isimler.Add("Ahmet");
            Console.WriteLine(isimler.Length);
            isimler.Add("Berivan");
            Console.WriteLine(isimler.Length);

            //İsimleri listesi içerisindeki elemanları yazdıralım.

            foreach (var isim in isimler.Items)
            {
                Console.WriteLine(isim);
            }
        }
    }
}
