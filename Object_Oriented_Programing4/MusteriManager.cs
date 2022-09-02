using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programing4
{   //Yönetim buradan yapılacaktır
    //İş sınıfları(Business classies)
    public class MusteriManager
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine("Başarıyla eklendi" + musteri.MusteriNo);
        }
    }
}
