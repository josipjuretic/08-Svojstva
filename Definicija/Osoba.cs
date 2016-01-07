using System;

namespace Vsite.CSharp
{
    class Osoba
    {
        public Osoba(string ime, string prezime)
        {
            Ime = ime;
            Prezime = prezime;
        }

        //  Javno dostupno polje Prezime nadomjestiti svojstvom (property) koje se izvan klase može samo čitati, a mijenjati se može samo iz klase
        private string m_prezime;
        public string Prezime
        {
            get { return m_prezime; }
            set { m_prezime = value; }
        }


        // Javno dostupno polje Ime nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali prilikom zadavanja treba onemogućiti
        // zadavanje praznim znakovnim nizom
        private string m_ime;
        public string Ime
        {
            get
            {
                return m_ime;
            }
            set
            {
                m_ime = value;
            }
        }

        // Javno dostupno polje DatumRođenja nadomjestiti svojstvom (property) koje se izvan klase može čitati i zadavati, ali za slučaj zadavanja
        // datuma većeg od trenutnog treba baciti iznimku tipa ArgumentOutOfRangeException. U pozivajućem kodu staviti odogovarajući kod za hvatanje
        // iznimke koji će u slučaju iznimke ispisati odgovarajuću poruku.
        private DateTime m_datumRođenja;
        public DateTime DatumRođenja
        {
            get { return m_datumRođenja; }
            set
            {
                if (value > DateTime.Now) throw new ArgumentOutOfRangeException
                    ("Datum mora biti manji od trenutnog");
                m_datumRođenja = value;
            }
        }


    }
}
