using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    //T = type
    //item = eleman (değiken olarak tanımladık)
    //count = eleman sayısı
    //ctor = (constructer)bir classta new yaptığımız anda çalışır.
    class MyList<T>
    {
        //Clasın bütün operatörlerinde ulaşabilmesi için metot dışında yazdık.
        T[] items;
        //ctor
        public MyList()
        {
            items = new T[0];
        }
        //items.Length= eleman sayısını verir
        //items.Length+1 = dizinin eleman sayısını 1 arttır.
        public void Add(T item)
        {
            //geciciDizi
            //new yaptığımız an yeni referans numarası alır ve önceki silinir
            //gitmesin diye geçici diziye aktardık
            T[] tempArray = items;
            items = new T[items.Length+1];
            //emanet verdiğim değerleri tekrar kendi üstüme alıyorum
            for (int i = 0; i < tempArray.Length; i++)
            {                
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item;

        }     
    }
}
