// See https://aka.ms/new-console-template for more information

int luku;

Console.Write("Anna luku 1 ja 10 väliltä? ");
luku = int.Parse(Console.ReadLine());

Console.WriteLine();

for (int i = 1; i < 6; i++)
{
    int tulo = i * luku;
    int osamaara = i / luku;
    int jakojaanos = i % luku;
    Console.WriteLine(i + " * "   + luku +  "  =  "   + tulo +  "   "  + i +  " / "    + luku +  "  =  "    + osamaara +   "   "  +  i  +  " % "  + luku +  "  =  " + jakojaanos);
    
   
}

