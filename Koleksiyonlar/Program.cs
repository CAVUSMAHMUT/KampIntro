using System;
using System.Collections.Generic;

namespace Koleksiyonlar
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = new string[] { "Engin", "Kerem", "Mahmut", "Hasan" }; //araylerde(dizilerde sonradan birşey eklemeyemezsin. datan veya veriden geldiği için sabittir.)
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "ilker"; //böyle yapınca 5. ilker yazılır fakat yukarıdaki array silinir. ve yanlış fonksiyondur.

            // bunun için aşağıda koleksiyonlar vardır.

            List<string> isimler2 = new List<string> { "Engin", "Kerem", "Mahmut", "Hasan" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("ilker"); // burada list'in koleksiyonu ile add komutunu kullanarak dizi bozulmadan ilkeri ekledik. koleksiyonlada arrayleri kaydedecek bir alt yapı vardır.
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);
        }
    }
}
