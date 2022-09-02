using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    //İnterface'ler genellike Operasyonel metodlar'da kullanılırlar.
    internal class IhtiyacKrediManager : ICreditManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("İhtiyaç kredi ön bilgilendirmesi yapılmaktadır");
        }

        public void Hesapla()
        {
            Console.WriteLine("İhtiyaç kredisi hesaplandı");

        }
    }
}
