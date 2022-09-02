using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCenter
{
    public class SalerManager : ILoggerService
    {
        public void Log()
        {
            Console.WriteLine("Loglama işlemi gerçekleştirildi");
        }
    }
}
