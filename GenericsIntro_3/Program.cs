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
            isimler.Add("Ahmet");
            isimler.Add("Berivan");

        }
    }
}
