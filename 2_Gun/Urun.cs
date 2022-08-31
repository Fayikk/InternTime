using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_Gun
{
    //Buradaki public erişim belirteci anlmaına gelmektedir
    public class Urun
    {//prop double tab özelliğine snippet adı verilmektedir.
       
        //property - özellik
        public int Id { get; set; }
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }

    }
}
