using System;

namespace Vsite.CSharp
{
    // ilustracija kako svojstvo ne može biti tipa void i kako se ne mogu preopterećivati 
    class Preopterećenje
    {
        // TODO: Zadati svojstvo VoidSvojstvo tipa void i pokušati prevesti kod. Sadržaj prozora Output s pogreškom prevoditelja prekopirati u datoteku VoidSvojstvo.txt



        // svojstvo se ne može preopterećivati
        public double PreopterećenoSvojstvo
        {
            get { return Math.PI; }
        }

        // TODO: Dodati novo svojstvo PreopterećenoSvojstvo koje će biti tipa int. Sadržaj prozora Output s pogreškom prevoditelja prekopirati u datoteku PreopterecenoSvojstvo.txt

      //  public int Preopterecenosvojstvo
      //  {
      //      get {  return (int) Math.PI;
      //  }


        static void Main(string[] args)
        {
        }
    }
}
