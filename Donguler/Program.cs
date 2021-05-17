using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kampı";
            string kurs2 = "Proglamlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            string[] kurslar=new string[]{ "Yazılım Geliştirici Yetiştirme Kampı", "Proglamlamaya Başlangıç İçin Temel Kurs" ,"Java","Python","C++"};

            Console.WriteLine("for dongusu ile yapılan");

            for (int i = 0; i <kurslar.Length; i++)//for dongusu
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("---------------------------------------------------");

            Console.WriteLine("foreach dongusu ile yapılan");

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }



            Console.WriteLine("---SAYFA SONU---");
        }
    }
}
