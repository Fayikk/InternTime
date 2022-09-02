using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    public class EsnafKredisiManager : ICreditManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("İhtiyaç kredi ön bilgilendirmesi yapılmaktadır");
        }

        public void Hesapla()
        {
            Console.WriteLine("Esnaf kredisi ödeme planı hesaplandı");
        }
    }
}
