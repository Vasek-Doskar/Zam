using System;

namespace Zam
{
    public class Zamestnanec
    {
        public Zamestnanec(int id, string jmeno, string prijmeni, DateTime datumNarozeni)
        {
            Id = id;
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            DatumNarozeni = datumNarozeni;
        }

        public int? Id { get; set; }
        public string Jmeno { get;set; }
        public string Prijmeni { get;set; }

        public DateTime DatumNarozeni { get; set; }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni} {DatumNarozeni.ToShortDateString()}";
        }
    }
}
