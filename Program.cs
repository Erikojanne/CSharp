using System;

namespace Tehtävä_10._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tehtävä 10 vaihe 1 ");
            Console.WriteLine();
            Console.WriteLine("---------------------------");
            Console.WriteLine();
           
            Console.WriteLine("Anna kokonaislukuja, niin lasken summan reaaliajassa ");
            int summa = 0;
            int i = 0;
            int luku;
            
            
            while (summa <= 100)
            {
                i++;
                Console.Write("Anna " + i +". luku ? ");
                 luku = int.Parse(Console.ReadLine());
                 summa = summa + luku;
                Console.WriteLine("Summa on nyt " +summa);
               
            }
            Console.WriteLine("Raja on saavutettu");
        }
    }
}
