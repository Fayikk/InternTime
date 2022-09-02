using System;

namespace OOP2_4Day
{
    //Dosyaya yazma işlemleri is burada gerçekleşmektedir.
    public class FileLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
