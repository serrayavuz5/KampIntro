﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Mototlar
{
    class SepetManager
    {
        public  void Ekle(Product urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urun.Adi);
        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : " + urunAdi);
        }
    }
    }
}
