using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "kategori"; //string metinleri tutar
            int ogrenciSayisi = 3200; //int tam sayıları tutar
            double faizOrani = 1.53; //#double ondalıklı sayıları tutar
            bool sistemeGirisYapmisMi = true; //#boolean sorgulama dallandırıp budaklandırma işlemi yapıyor ifle çalışırsa iyi olur.
            double dolarBugun = 7.45;
            double dolarDun = 7.45;

            if (dolarDun>dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (dolarBugun>dolarDun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı");
            }
            else
            {
                Console.WriteLine("Giriş Yap");
            }

           
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
        }
    }
}
