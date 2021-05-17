using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("tebrikler....Sepete Eklendi: "+urun.Adi);
        }

        public void Ekle2(string urunAdi,string aciklama,double fiyati, int StokAdedi)
        {
            Console.WriteLine("tebrikler....Sepete Eklendi: " +urunAdi);
        }
    }
}
