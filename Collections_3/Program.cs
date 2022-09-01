using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections_3
{
    public class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "engin", "murat", "kerem", "halil" };
            ////console.writeline(isimler[0]);
            ////console.writeline(isimler[1]);
            ////console.writeline(isimler[2]);
            ////console.writeline(isimler[3]);
            //isimler = new string[5];//bu ifade yazılınca 5 indisli bir elemanı barındırabilecek bir dizi oluşturulur ve bellekte bu alan tutlacaktır.
            ////Ancak  bellekte yeni oluşturulacak alan yüzünden daha önceki değerler'e bu ifadeden sonra ulaşılmak istenirse NULL değeri ataması yapıldığı için boş değer döndürecektir.
            //isimler[4] = "Fayik";
            //Console.WriteLine(isimler[4]);//İndex aşım hatası alacağız
            //Console.WriteLine(isimler[0]);

            //Bu problemleri yenebilmek için kullanılan bir teknoloji vardır.Bu teknoloji koleksiyonlarıdr,generic ifadelerdir.
      
            List<string> isimler = new List<string>() { "Fayik","Süleyman","Yunus","Server","Onur","Berivan","Buse"};
            isimler.Add("Kenan");
            isimler.Add("Kerem");
            isimler.Add("Davut");
            //Yukarıdaki ifade'de olduğu gibi gereklilikleri yerine getirmiş sayılacağız.
            //foreach (var item in isimler)
            //{
            //    Console.WriteLine(item);
            //}
            
        }
    }
}
