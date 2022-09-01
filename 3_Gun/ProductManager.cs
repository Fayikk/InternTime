using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Gun
{
    public class ProductManager
    {   //Diyelimki bir ürün eklemeyi simüle etmeyi istiyoruz
        //Encapsulation

        //void anahtar kelimesi ne işe yarar.(Emir kipinde çağrılır işini bitirir veri geri döner.
        public Product Add(Product product)
        {

            //product.ProductName = "Araba";
            Console.WriteLine("Eleman eklendi = " + " " + product.ProductName);
            return product;
        }

        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName+" güncellendi. ");
        }

        //public void Test(int sayi)
        //{
        //    sayi = 99;
        //}

        public int Topla(int sayi1,int sayi2)
        {
            return sayi1 + sayi2;
        }

        public void Topla2(int sayi1, int sayi2)
        {
            Console.WriteLine(sayi1 + sayi1);
        }
    }
}
