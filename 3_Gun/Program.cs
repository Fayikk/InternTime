using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Gun
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Sınıfımızdan bir nesne oluşturalım
            //Aynı zamanda örnekleme'de denmektedir.
            Product product1 = new Product();
            Product product2 = new Product { Id = 2, CategoryId = 5, UnitsInStock = 5, ProductName = "Gamepad", UnitPrice = 500 };
            //Yukarıda oluşturulan örnekleme'nin property atamlarını yukarıdaki şekilde atamsını yapmış oluyoruz.
            product1.Id = 1;
            product1.CategoryId = 2;
            product1.ProductName = "Kuantum bilgisayarı";
            product1.UnitPrice = 1200;
            product1.UnitsInStock = 12;

            //Operasyon işlemlerini gerçekleştirmek için,operasyonların buluduğu sınıftan bir örnekelme oluşturup kullanmamız gerekecektir.
            ProductManager productManager=new ProductManager();//bu yapı sayesinde ProductManager sınıfı içerisindeki yapılara erişim sağlayabiliriz.
            //ProductManager productManager;-->Yukarıdaki yapı ile bu yapı arasındaki  fark gözle görülür bir şekilde new operatörü ile bellekte yer tahsis etme özelliğine dayandırılmaktadır.
            //PascalCase=Kelimelerin her daim ilk harflerinin  büyük olduğu anlamına gelmektedir.
            //camelCase=genellikle kullanım alanları 2 kelimeli yapılardan oluşurlar ve ilk kelimenin ilk harfi küçü olurken,2.kelimenin ilk harfi büyük olacaktır.
            //productManager.Add();--->Bu yapı sayesinde gerekli eklemeleri yapmış bulunmaktayız.

            //productManager.Add(product1);
            //productManager.Add(product2);
            //int sayi = 100;
            //productManager.Test(sayi);
            //Console.WriteLine(sayi);//Değer ile çağırma yönteminden dolayı içerideki  değişiklikler dışarıyı hiçbir şekilde etkilemeyecektir.
            ////Yazdırma değeri=100; Olacaktır.
            //Console.WriteLine(product1.ProductName);//Referans ile (Başvuru ile çağırma yönteminde dolayı)
            ////Ekranda yazdırılacak değer="Araba" olacaktır.


            productManager.Topla(12,1);
            productManager.Topla2(12,1);

        }
    }
}
