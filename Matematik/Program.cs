using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matematik
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello my galaxy");
            DortIslem sonuc=new DortIslem();
            Console.WriteLine(sonuc.Topla(10, 2));
            Console.WriteLine(sonuc.Cikar(15, 5));
        }
    }
}
