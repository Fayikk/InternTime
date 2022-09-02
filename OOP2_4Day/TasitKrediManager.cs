using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    internal class TasitKrediManager : ICreditManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Taşıt kredisi ön bilgilendirmesi yapılmaktadır");

        }

        public void Hesapla()
        {
            Console.WriteLine("Tasit kredisi hesaplandı");
        }
    }
}
