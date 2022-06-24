using System;
using System.Collections.Generic;
using System.Text;

namespace metotlar
{
    class SepetManager
    {

        //naming convention
        //syntax
        public void Ekle(urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!" + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokadedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi!" + urunAdi);
        }
    }
}
