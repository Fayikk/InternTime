using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsIntro_3
{
    public class MyList<T>//Buradaki T ifadesinin anlamı bana bir tip ver bende aşağıyı ona göre yapılandıracam anlamına gelmektedir.
    {
        T[] items;//Generic tipinde bir dizi oluşturduk
        //Constructer'a diziyi her seferinde tetiklemek için burada dizi yapımızı
        //Oluşturuyoruz.

        public MyList()//Constructor
        {
            //Class herhangi bir şekilde new'lendiği zaman bu yapı(Constructer)
            //Otomatik olarak tetiklenecek ve çalışacaktır.
            //İçerisinde tanımlanan yordamlar vs bu şekilde tetiklenme gerçekleştirilecektir.
            items = new T[0];
        }

        public void Add(T item)//Buradaki "T" programcı hangi tip'i girmek istiyorsa
        {
            T[] tempArray = items;//Burada geçici dizinin referansı items'ın referansını tutacaktır anlamına gelmektedir.

            items = new T[items.Length + 1];
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];//Burada tempArray geçici değişkenine yazılan değerlerimizi items'a geri aktarma işlemini gerçekleştiriyoruz.
            }
            items[items.Length - 1] = item;
        }
        public int Length//Bu yordam sayesinde listedeki elemanın uzunluğunu bulabilmekteyiz
        {
            get { return items.Length; }
        }
        //Elemanları görmek istersek eğer 
        public T[] Items
        {
            get { return items; }
        }
    }
}
