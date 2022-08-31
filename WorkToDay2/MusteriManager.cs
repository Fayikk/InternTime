using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkToDay2
{
    public class MusteriManager
    {
        public void MusteriEkle(Musteri musteri)
        {
            Console.WriteLine("Müşteri kişisi eklendi : " + musteri.Ad + " " + musteri.Soyad);

        }
        
        public void Silme(Musteri musteri)
        {
            
            Console.WriteLine(musteri.Id+" "+"Id silindi");
        }

        public void Listele(Musteri musteriler)
        {
            Console.WriteLine(musteriler.Id);
            Console.WriteLine(musteriler.Ad);
            Console.WriteLine(musteriler.Soyad);

            Console.WriteLine("--------------");
        }
    }
}
