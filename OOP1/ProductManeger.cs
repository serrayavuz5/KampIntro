using System;
using System.Collections.Generic;
using System.Text;

namespace OOP1
{
    class ProductManeger
    {
        //add=ekle
        //void = Void belirtilen metotlarda emir kipi kullanılır.değeri döndürmez
        //git,yap,bitir gibi        
        //update=güncelle
        public void Add(Product product)
        {
            Console.WriteLine(product.ProductName + " eklendi.");

        }
        public void Update(Product product)
        {
            Console.WriteLine(product.ProductName + " güncellendi.");
        }

       
    }
}
