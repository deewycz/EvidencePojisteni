using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvidencePojistenych1
{
    internal class Evidence
    {
        private List<Pojisteny> Pojisteni { get; set; }

        public Evidence()
        { 
            Pojisteni = new List<Pojisteny>();
        }

        public void VytvorPojisteneho(string jmeno, string prijmeni, int vek, string telefonniCislo)
        {
            Pojisteny pojisteny = new Pojisteny (jmeno, prijmeni, vek, telefonniCislo);
            Pojisteni.Add(pojisteny);
        }

        public void ZobrazitSeznamPojistenych()
        {
        foreach (Pojisteny p in Pojisteni)
            {
                 Console.WriteLine(p.ToString());
             }
        }

        public Pojisteny VyhledatPojisteneho(string jmeno, string prijmeni) {

            return Pojisteni.FirstOrDefault(p => p.Jmeno == jmeno && p.Prijmeni == prijmeni);
        
        }
    }

}
