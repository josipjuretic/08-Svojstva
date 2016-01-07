using System;

namespace Vsite.CSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Primijeniti svojstva u klasi Osoba prema uputama te provjeriti donjim kodom ispravnost promjena
            // (zakomentirati one naredbe dolje koje će uzrokovati pogrešku pri prevođenju nakon promjena u klasi Osoba)

            Osoba o1 = new Osoba("Oliver", "Mlakar");
            Console.WriteLine("{0} {1}", o1.Ime, o1.Prezime);

            o1.DatumRođenja = new DateTime(1933, 4, 13);

            o1.Ime = "Pero";
            o1.Prezime = "Kvrgić";

            o1.DatumRođenja = new DateTime(2020, 4, 13);
        }
    }
}
