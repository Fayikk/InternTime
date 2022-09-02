using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    internal class KonutKrediManager : ICreditManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Konut kredi ön bilgilendirmesi yapılmaktadır");

        }

        public void Hesapla()
        {
            Console.WriteLine("Konut kredisi hesaplandı");

        }
    }
}
