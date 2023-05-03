namespace EvidencePojistenych1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Evidence evidence = new Evidence();

            bool ukoncit = false;

            while (!ukoncit)
            {
                Console.WriteLine("--------------------------");
                Console.WriteLine("Evidence pojištěných");
                Console.WriteLine("--------------------------");
                Console.WriteLine("1 - Vytvořit pojištěného");
                Console.WriteLine("2 - Zobrazit seznam pojištěných");
                Console.WriteLine("3 - Vyhledat pojištěného");
                Console.WriteLine("4 - Ukončit aplikaci");

                int volba = int.Parse(Console.ReadLine());

                switch (volba)
                {
                    case 1:
                        Console.WriteLine("Zadejte jméno: ");
                        string jmeno = Console.ReadLine().Trim();
                        Console.WriteLine("Zadejte příjmení: ");
                        string prijmeni = Console.ReadLine().Trim();
                        
                        Console.WriteLine("Zadejte věk: ");
                        int vek = int.Parse(Console.ReadLine().Trim());

                        Console.WriteLine("Zadejte telefonní číslo: ");
                        string telefonniCislo = Console.ReadLine().Trim();

                        evidence.VytvorPojisteneho(jmeno, prijmeni, vek, telefonniCislo);

                        Console.WriteLine("Data byla uložena. Pokračujte libovolnou klávesou...");
                        Console.ReadKey();

                        break;

                    case 2:
                        Console.WriteLine("Seznam pojištěných: ");
                        evidence.ZobrazitSeznamPojistenych();
                        Console.WriteLine("Pokračujte libovolnou klávesou...");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.Write("Zadejte jméno: ");
                        jmeno = Console.ReadLine().Trim();
                        Console.Write("Zadejte příjmení: ");
                        prijmeni = Console.ReadLine().Trim();


                        Pojisteny nalezenyPojisteny = evidence.VyhledatPojisteneho(jmeno, prijmeni);
                        if (nalezenyPojisteny != null)
                        {
                            Console.WriteLine("Nalezený pojištěný: " + nalezenyPojisteny.ToString());
                        }
                        else
                        {
                            Console.WriteLine("Pojištěný s daným jménem a příjmením nebyl nalezen. ");
                                }
                        break;
                    case 4:
                        ukoncit = true;
                        break;
                    default:
                        Console.WriteLine("Neplatná volba, zkuste nové zadání.");
                        break;
                }
            }
        }
    }
}