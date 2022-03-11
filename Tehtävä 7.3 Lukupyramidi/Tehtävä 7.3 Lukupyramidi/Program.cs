// See https://aka.ms/new-console-template for more information

int luku;

Console.Write(" Anna lukupyramidin kerrosten määrä ? ");
 luku = int.Parse(Console.ReadLine());

Console.WriteLine();

int i, j;

for (i = 1; i <= luku; i++)
{
    for (j = 1; j <= i; j++)

    {
        Console.Write(j + " ");
    }
    Console.WriteLine();
}