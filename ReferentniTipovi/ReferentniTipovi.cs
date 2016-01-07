using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Vsite.CSharp
{
    // Primjer promjene članova referentnog tipa preko get metode
    class ReferentniTipovi
    {
        class Smočnica
        {
            public Smočnica()
            {
                Namirnice = new List<string>(new string[] {"kruh", "mlijeko"});
            }


            // Promijeniti get metodu svojstva Namirnice tako da se onemogući promjena sadržaja liste izvan klase (tj. da naredba Debug.Assert u metodi Main ne baci iznimku)
            public List<string> Namirnice { 
                get
                {
                return New List<String>(m_lista);
            }
                private set; 
            {
                m_lista = value;
            }
        }


        static void Main(string[] args)
        {
            Smočnica s = new Smočnica();
            s.Namirnice.Add("špek");
            
            foreach (var a in s.Namirnice)
                Console.WriteLine(a);

            Debug.Assert(s.Namirnice.Count == 2);

            Console.ReadKey();
        }
    
public  object m_lista { get; set; }}
}
