using System;
using System.Collections.Generic;
using System.Text;

namespace Mototlar
{
    //product => urun
    class Product
    {
        public int Id { get; set; } //eşsiz değer
        public string Adi { get; set; }
        public double Fiyati { get; set; }
        public string Aciklama { get; set; }
        public int StokAdedi { get; set; }


    }
}
