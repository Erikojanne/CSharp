// See https://aka.ms/new-console-template for more information

int luku;

Console.Write("Anna luku 1 ja 10 väliltä? ");
luku = int.Parse(Console.ReadLine());

int tulo1 = luku * 1;
int tulo2 = luku * 2;
int tulo3 = luku * 3;
int tulo4 = luku * 4;
int tulo5 = luku * 5;

int osamaara1 = 1 / luku;
int osamaara2 = 2 / luku;
int osamaara3 = 3 / luku;
int osamaara4 = 4 / luku;
int osamaara5 = 5 / luku;

int jakojaanos1 = 1 % luku;
int jakojaanos2 = 2 % luku;
int jakojaanos3 = 3 % luku;
int jakojaanos4 = 4 % luku;
int jakojaanos5 = 5 % luku;


Console.WriteLine("1 * 5 = " + tulo1);
Console.WriteLine("2 * luku = " + tulo2);
Console.WriteLine("3 * luku = " + tulo3);
Console.WriteLine("4 * luku = " + tulo4);
Console.WriteLine("5 * luku = " + tulo5);

Console.WriteLine();

Console.WriteLine("1 / luku = " + osamaara1);
Console.WriteLine("2 / luku = " + osamaara2);
Console.WriteLine("3 / luku = " + osamaara3);
Console.WriteLine("4 / luku = " + osamaara4);
Console.WriteLine("5 / luku = " + osamaara5);

Console.WriteLine();

Console.WriteLine("1 % luku = " + jakojaanos1);
Console.WriteLine("2 % luku = " + jakojaanos2);
Console.WriteLine("3 % luku = " + jakojaanos3);
Console.WriteLine("4 % luku = " + jakojaanos4);
Console.WriteLine("5 % luku = " + jakojaanos5);