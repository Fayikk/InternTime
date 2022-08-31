using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Deger_Ve_ReferansTipler
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int sayi1=10;
            //int sayi2=30;
            //sayi1 = sayi2;
            //sayi2 = 65;

            //Console.WriteLine(sayi2);
            ////yazdırma cevabı=65
            int[] sayilar1 = new int[] {15,25,35};
            int[] sayilar2 = new int[] {10,20,30};
            sayilar1 = sayilar2;
            sayilar2[0] = 99;
            
            Console.WriteLine(sayilar1[0]);

           //Yazdırma cevabı= 99 
        
        }
    }
}
