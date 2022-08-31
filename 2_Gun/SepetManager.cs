using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Gun
{
    public class SepetManager
    {
        //Bu yordam sayesinde Urun class'ı içerisinde 
        //erişim sağlayabiliyoruz,bunu ise oluşturulan instance sayesinde gerçekleştiriyoruz.
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete ekleme işlemi başarıyla gerçekleştirildi: " + urun.Adi);
        }
        public void EkleAlternatif(string urunAdi,string aciklama,double fiyat,int stokAdedi)
        {
            Console.WriteLine("Tebrikler.Sepete Eklendi" + urunAdi + " "+ aciklama);
        }

    }
}
