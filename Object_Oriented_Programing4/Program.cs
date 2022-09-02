using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Oriented_Programing4
{
    public class Program
    {
        static void Main(string[] args)
        {
         GercekMusteri musteri1=new GercekMusteri();
            musteri1.MusteriNo = "12345";
            musteri1.Adi = "Fayik";
            musteri1.Soyadi = "Veznedaroglu";
            musteri1.TcNo = "1111111111";



            TuzelMusteri musteri2=new TuzelMusteri();
            musteri2.MusteriNo = "123445";
            musteri2.Id = 2;
            musteri2.SirketAdi = "SpaceX";
            musteri2.VergiNo = "12345678";


            //Gerçek Müşteri-Tüzel Müşteri
            //SOLID

            Musteri musteri3 = new GercekMusteri();
            Musteri musteri4 = new TuzelMusteri();
            MusteriManager musteriManager = new MusteriManager();
            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

        }
    }
}
