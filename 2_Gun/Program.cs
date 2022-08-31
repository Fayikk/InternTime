using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Classlar aslında 2 farklı görevde kullanılırlar.
//İlk kullanım alanı olarak şimdi bizimde kullandığımzı gibi 
//Özellik tutucu olarak görev yaparken kullanılırlar.
namespace _2_Gun
{
    public class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double Fiyati = 15;
            string aciklama = "Amasya Elması";

            Console.WriteLine("Hello my galaxy");

            Urun urun1 = new Urun();//Burada Urun sınıfından nesne oluşturuyoruz.(elma için örnekleme oluşturuyoruz)
            Urun urun2 = new Urun();    
            Urun urun3=new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 12;
            urun1.Aciklama = "Kırmızı amasya elması";

            urun2.Adi = "Karpuz";
            urun2.Fiyati = 122;
            urun2.Aciklama = "Diyarbakır karpuzu";

            urun3.Adi = "Mandalina";
            urun3.Aciklama = "Mandal mandalina";
            urun3.Fiyati = 10000;

            //Biz nasıl string array oluşturabiliyorsak artık ürün array'de oluşturabiliyoruz
            //Urun içerisindeki ifadeleri tutan yapıdır.
            //Urun bizim veri tipimiz olsun diye kabul edelim.
            //Aşağıda yazılan urunler içerinde (urun1 ve urun2) kısmında normal şartlarda veritabanı verileri olabilir.
            Urun[] urunler = new Urun[] { urun1,urun2,urun3 };

            //Döngü içerisinde dolaşma işlemini gerçekleştirelim.
           
            //Aşağıda var değişken tipini belirtirken yukarıda da dediğimiz gibi
            ////Urun artık bir değişken t ipi olarak tanımlaması yapıldıpı için
           //Unutmayın csharp,Java gibi programlama dilleri type safe(tip güvenlidir).
            foreach (Urun urunum in urunler)
            {
                Console.WriteLine(urunum.Adi);
                Console.WriteLine(urunum.Fiyati);
                Console.WriteLine(urunum.Aciklama);
                Console.WriteLine("*************");
                //Console.ReadKey();
                //Şeklinde gösterimi gerçekleştirilebilecektir.
            }
            Console.WriteLine("----------------");
            Console.WriteLine("Hello My Galaxy");

            //SepetManager class'ından nesne oluşturuyoruz.
            //Ve bu nesne  sayesinde sınıf içerisindeki property yada yordamların
            //Kullanılmasını bu şekilde sağalaybiliriz.
            //Instance (Class örneği)
            SepetManager sepetManager=new SepetManager();
            
            //Burada görüldüğü nesnesini oluşturduğumuz Urun class'ının içerisine urun1 nesnesinin atamsını yapıyoruz.
            //Ve o nesneye ulaşım sağlıyoruz.
            sepetManager.Ekle(urun1);//Ekle metodunu buradan çağırabiliriz.
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);
            //Alternatif olarak ekleme işlemi yapan metoda,oluşturulan nesne ile ulaşım sağlayabilmekteyiz.

            //sepetManager.Ekle();  Reusability(Tekrar kullanım) sayesinde metodu farklı sayfalarda kullanabilme özelliğine erişmiş bulunmaktayız.
            sepetManager.EkleAlternatif("Bilgisayar", "İş bilgisayarı", 15000,100);
            sepetManager.EkleAlternatif("Araba", "Ralli aracı", 155000,1500);
            sepetManager.EkleAlternatif("Ev", "Villa", 788000,8000);

            

        }
    }
}


//Do not youself-DRY-Clean Code
//Best Practice (Doğrulama y-uygulama teknikleri)

