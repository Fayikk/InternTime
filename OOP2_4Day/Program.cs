using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    //SOLİD 
    //Şuanda yapılan işlemler polymorfizm'e örnek olarak gösterilmektedir.
    public class Program
    {
        static void Main(string[] args)
        {
            IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            
            TasitKrediManager tasitKrediManager = new TasitKrediManager();
            
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            
             BasvuruManager basvuruManager = new BasvuruManager();
             OgrenciKredisiManager ogrenciKredisiManager = new OgrenciKredisiManager();  
             EsnafKredisiManager esnafKredisiManager=new EsnafKredisiManager();
             ILoggerService fileLoggerService = new FileLoggerService();
             ILoggerService dataBaseLoggerService= new DataBaseLoggerService();
             ILoggerService smsLoggerService=new SmsLoggerService();
             ILoggerService oracleLoggerService=new OracleLoggerService();


            //basvuruManager.BasvuruYap(konutKrediManager);
            //basvuruManager.BasvuruYap(tasitKrediManager);
            //basvuruManager.BasvuruYap(ihtiyacKrediManager);

            
            List<ICreditManager> krediler = new List<ICreditManager>() { ihtiyacKrediManager,konutKrediManager,tasitKrediManager };
            List<ILoggerService> servisler = new List<ILoggerService> { new SmsLoggerService(),new FileLoggerService(),new DataBaseLoggerService(),new OracleLoggerService()};
            basvuruManager.KrediOnBilgilendirmesiYap(krediler);
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            Console.WriteLine("----------------------");
            basvuruManager.BasvuruYap(konutKrediManager,new List<ILoggerService>() { oracleLoggerService,fileLoggerService});
            Console.WriteLine("----------------------");
            Console.WriteLine("|||||||||||||||||||||||||");
            basvuruManager.BasvuruYap(tasitKrediManager,servisler);//Burada bütün servisler tarafından hizmet verilmiştir.
            Console.WriteLine("----------------------");
            Console.WriteLine("|||||||||||||||||||||||||");

            basvuruManager.BasvuruYap(esnafKredisiManager, servisler);
            Console.WriteLine("-----------------------");
            Console.WriteLine("--------------------------");
            //basvuruManager.BasvuruYap(ogrenciKredisiManager, servisler);
            basvuruManager.BasvuruYap(ogrenciKredisiManager,new List<ILoggerService>(){dataBaseLoggerService,smsLoggerService });

            

            


        }
    }
}
