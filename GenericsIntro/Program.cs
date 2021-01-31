using System;

namespace GenericsIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //değişken türünü değiştirebilirsin
            MyList<string> isimler = new MyList<string>();
            isimler.Add("Engin");
        }
    }
}
