﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class Product
    {
        //snippet=hazır kodlar
        //UnitPrice=fiyatı
        //Referans anahtarları ikinci sıraya yazılır
        //UnitInStock= Urünün stok adedi
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public string ProductName { get; set; }
        public double UnitPrice { get; set; }
        public int UnitInStock { get; set; }



    }
}
