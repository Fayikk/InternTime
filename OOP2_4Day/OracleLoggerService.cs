using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{
    public class OracleLoggerService : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Oracle servisine loglama işlemi sonlandı");
        }
    }
}
