using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych1
{
    internal class Pojisteny
    {
        public string Jmeno { get; set; }
        public string Prijmeni { get; set; }

        public int Vek { get; set; }

        public string TelefonniCislo { get; set; }


        public Pojisteny (string jmeno, string prijmeni, int vek, string telefonniCislo) 
        { 
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
            TelefonniCislo = telefonniCislo;
        }

        public override string ToString()
        {
            return $"{Jmeno} {Prijmeni}\t věk: {Vek}\t telefon: {TelefonniCislo}" ;
        }
    }
}
