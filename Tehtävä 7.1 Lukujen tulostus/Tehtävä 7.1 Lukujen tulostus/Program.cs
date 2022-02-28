// See https://aka.ms/new-console-template for more information

int luku;

Console.Write("Tehtävä 7.1");
Console.WriteLine();
Console.WriteLine();
Console.Write("---------------");
Console.WriteLine();
Console.WriteLine();
Console.Write("Anna aloitusluku ? ");
luku = int.Parse(Console.ReadLine());



for ( int i = luku;  i > -1; i--)
{
    Console.WriteLine(i);
}
