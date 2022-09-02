using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    public class OgrenciKredisiManager : ICreditManager
    {
        public void BiseyYap()
        {
            Console.WriteLine("Öğrenci Kredisi ön bilgilendirmesi yapılacaktır");

        }

        public void Hesapla()
        {
            Console.WriteLine("Öğrenci kredisi hesaplandı");
        }
    }
}
