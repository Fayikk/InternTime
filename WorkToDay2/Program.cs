using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkToDay2
{
    public class Program
    {
        static void Main(string[] args)
        {


            Musteri musteri1 = new Musteri();
            Musteri musteri2=new Musteri();
            Musteri musteri3 = new Musteri();
            musteri1.Id = 1;
            musteri1.Ad = "Fayik";
            musteri1.Soyad = "Veznedaroglu";

            musteri2.Id = 2;
            musteri2.Ad = "Samet";
            musteri2.Soyad = "Yalçın";

            musteri3.Id = 3;
            musteri3.Ad = "Demir";
            musteri3.Soyad = "Deren";

            //Şimdi sınıfımızda türetilen nesneleri kullanabilmek için Sınıfımız türünden bir nesne üretimi yapacağız.

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3};
            MusteriManager musteriManager= new MusteriManager();

            //Musteriler için ekleme işlemini gerçekleştiriyoruz.
            musteriManager.MusteriEkle(musteri1);
            musteriManager.MusteriEkle(musteri2);
            musteriManager.MusteriEkle(musteri3);
            //Musteriler için silme işlemini gerçekleştirelim.
            //Aynı şekilde yordam'ların içerisinde bulunduğu class'tan metod üretiyoruz
            musteriManager.Silme(musteri1);
            musteriManager.Silme(musteri2);
            musteriManager.Silme(musteri3);


            //Şimdi foreach döngüsü kullanarak müşterilerin gerekli özelliklerini listeleme işlemini gerçekleştiriyoruz.

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);
            musteriManager.Listele(musteri3);


            //foreach (Musteri item in musteriler)
            //{
            //    //Console.WriteLine("Musteriler listeleniyor");
            //    Console.WriteLine(item.Id);
            //    Console.WriteLine(item.Ad);
            //    Console.WriteLine(item.Soyad);
            //    Console.WriteLine("--------");
            //}



        }
    }
}
