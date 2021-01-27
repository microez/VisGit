using System;

namespace MyDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> elementSirala = new MyDictionary<int, string>();
            elementSirala.Add(1, "Hidrojen");
            elementSirala.Add(2, "Helyum");
            elementSirala.Add(3, "Lityum");
            elementSirala.Add(4, "Berilyum");
            elementSirala.Add(5, "Bor");
            elementSirala.Add(6, "Karbon");
            elementSirala.Add(7, "Azot");
            elementSirala.Add(8, "Oksijen");
            elementSirala.Add(9, "Flor");
            elementSirala.Add(10, "Neon");

            Console.WriteLine(elementSirala.ilk[2]+" "+elementSirala.son[2]);
        }
    }
}
