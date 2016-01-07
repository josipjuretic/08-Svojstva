
namespace Vsite.CSharp
{
    class Student : Osoba
    {
        public Student(string ime, int godina)
            : base(ime)
        {
            Godina = godina;
        }

        // TODO: Pregaziti (overrideati) svojstvo Identifikacija tako da get metoda vraća znakovni niz oblika: "Pero, 2. godina"

        public override string 
        {
        get
        {
        return string.Format("{0}, {1}, godina", base.Identifikacija, Godina);
    }

    }


        public int Godina { get; set; }
    }
}
