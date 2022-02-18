using System;

namespace Tehtävä_6
{
    class Program
    {
        static void Main(string[] args)
        {
            string aurinko, vesi, lampotila;
            //string vesi;
            //string lampotila;

            Console.Write("Paistaako aurinko (K/E) ? ");
            aurinko = Console.ReadLine();
            Console.Write("Sataako vettä (K/E) ? ");
            vesi = Console.ReadLine();
            Console.Write("Onko lämpötila >0 (K/E) ? ");
            lampotila = Console.ReadLine();
            vesi = vesi.ToUpper();
            Console.WriteLine();

            if (aurinko == "K" && vesi == "K" && lampotila == "K")
            {
                Console.WriteLine("Aurinko paistaa ja vettä sataa, taitaa tulla kesä.");
            }
            else if (aurinko == "E" && vesi == "K" && lampotila == "K")
            {
                Console.WriteLine("Syksy saapui tuuli vei lehdet mennessään.");
            }
            else if (aurinko == "E" && vesi == "E" && lampotila == "K")
            {
                Console.WriteLine("Jo joutui armas aika ja suvi suloinen.");
            }
            else if (aurinko == "K" && vesi == "E" && lampotila == "E")
            {
                Console.WriteLine("Keväinen talvi kesän tuo.");
            }
            else
            {
                Console.WriteLine("Ompa erikoinen sää !");
            }
        }
    }
}
