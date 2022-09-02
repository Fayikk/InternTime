using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP2_4Day
{//Loglama = kim,ne zaman hangi operasyonları çağırdı vb.
    public class BasvuruManager
    {
        //Krediye başvuru alacağız
        //Burada method injection yapıyoruz.
        public void BasvuruYap(ICreditManager creditManager,List<ILoggerService> loggerServices)
        {
            //Başvuru bilgilerini değerlendirmek için kullanılan operasyonel kod blokları
            creditManager.Hesapla();
            //loggerService.Log(); Loglama işlemi birden fazla loglama alacağı için burayı şimdilik iptal ediyoruz.
            foreach (var loggerService in loggerServices)//Fazladan loglama işlemi gerçekleştirmek için burada kullanılacaktır.
            {
                loggerService.Log();
            }
            
        }
        public void KrediOnBilgilendirmesiYap(List<ICreditManager> krediler)//Bir liste alıyoruz ve bu liste bize CreditManager Interface'ini dönmektedir
        //List<ICreditManager> oluşturulcaktır ve bu yapının nesnesi ile gerekli operasyon blokları burada yazılmaktadır.
        {
            foreach (var kredi in krediler)
            {

                kredi.BiseyYap();
            }
        }
    }
}
