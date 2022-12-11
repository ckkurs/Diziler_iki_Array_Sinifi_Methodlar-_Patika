using System;

namespace Diziler_iki_Array_Sinifi_Methodları
{
    class Program
    {
        static void Main(string[] args)
        {
            //Sort //Sıralama
            int[] sayiDizisi={23,12,4,86,72,3,11,17};
            Console.WriteLine("***Sırasız Liste Dizi***");
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine((item));
            }
            Console.WriteLine("*** Sıralı Dizi ***");
            Array.Sort(sayiDizisi);
            foreach (var item in sayiDizisi)
            {
                Console.WriteLine((item));
            }
            //Clear //verdiğimiz indexden başlayarak verdiğimiz eleman sayısı kadar 0 atıyo
              Console.WriteLine("*** Array Clear***");
              Array.Clear(sayiDizisi,2,2);//2.indexden başlıyarak 2 tane elemanı clear et
              foreach (var item in sayiDizisi)
              {
                Console.WriteLine((item));
              }

              Console.WriteLine("*** Array Reverse***");
              //Reverse Diziyi ortadan itibaren aynalıyormuş gibi yer değiştiriyor.ilk elemanı son eleman yapıyo son elemanı ilk eleman yapıyor.
              Array.Reverse(sayiDizisi);
              foreach (var item in sayiDizisi)
              {
                Console.WriteLine((item));
              }

              Console.WriteLine("*** Array Indexof***");
              //Indexof verdiğimiz dizi üzerinde verdiğimiz elemanın eğer içerisinde varsa indexini döner
             
              Console.WriteLine( Array.IndexOf(sayiDizisi,23));
              
              Console.WriteLine("***Array Resize***");
              //Resize = yeniden boyutlandırma yapıyor
              Array.Resize<int>(ref sayiDizisi,9);
              sayiDizisi[8]=99;
              foreach (var item in sayiDizisi)
              {
                Console.WriteLine((item));
              }




            

        }
    }
}
