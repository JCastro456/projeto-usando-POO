using System;
using projeto1_dio.src.Entities;

namespace projeto1_dio
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 23, "Knight", 72, 469/749);
            Ninja Wedge = new Ninja("Wedge", 23, "Ninja", 89, 292/574);
            Wizard Jenica = new Wizard("Jenica", 23, "White Wizard", 474/482, 325/601);
            Blackwizard Topapa = new Blackwizard("Topapa", 23, "Black Wizard", 611/641, 106/385);

                Console.WriteLine(Arus.Attack(1));
                Console.WriteLine(Wedge.Attack(6));
                Console.WriteLine(Jenica.Attack(9));
                Console.WriteLine(Topapa.Attack(5));
        }
    }
}
