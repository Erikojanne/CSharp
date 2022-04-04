// See https://aka.ms/new-console-template for more information
Console.OutputEncoding = System.Text.Encoding.UTF8;

Console.WriteLine("Tehtävä 8.3");

Console.WriteLine();
Console.WriteLine("-------------------");

Console.WriteLine();
Console.Write("Kuinka monta tuotetta lisätään ? ");


int maara = int.Parse(Console.ReadLine());
string[] nimi = new string[maara];
int[] hinta = new int[maara];
int[] lkm = new int[maara];
int[] tulo = new int[maara];// luodaan taulukko



for (int i = 0; i < maara; i++)
{
    Console.Write("Anna {0}. tuotteen nimi ? ", i + 1);

    nimi[i] = Console.ReadLine();

    Console.Write("Anna {0}. tuotteen hinta ? ", i + 1);

    hinta[i] = int.Parse(Console.ReadLine());

    Console.Write("Anna {0}. tuotteen lukumäärä ? ", i + 1);

    lkm[i] = int.Parse(Console.ReadLine());

    tulo[i] = hinta[i] * lkm[i];
}

        Console.WriteLine();

    for (int i = 0; i < maara; i++)

    {
        Console.WriteLine(nimi[i] + " " + tulo[i] + " € "); // tulostus
    }

