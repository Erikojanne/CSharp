// See https://aka.ms/new-console-template for more information


Console.WriteLine("Tehtävä 8.4 ");
Console.WriteLine();
Console.WriteLine("--------------------");
Console.WriteLine();

// Luodaan taulukko
int Hero;
string[,] nimet = { { ("HERO"), ("Ana"), ("Bastion"), ("Brigette"), ("D.Va (Mech)") },
                  { ("ROLE"), ("Support"), ("Defence"), ("Support"), ("Tank")},
                  { ("HEALTH"), ("200"), ("200"), ("200"), ("400")},
                  { ("AMOR"), ("0"), ("100"), ("50"), ("200") } };
//Tulostusta
Console.WriteLine("HEROt ovat seuraavat :");
Console.WriteLine("(1) Ana ");
Console.WriteLine("(2) Bastion ");
Console.WriteLine("(3) Brigette ");
Console.WriteLine("(4) D.Va (Mech ");

Console.WriteLine();
//Kysytään arvo
Console.Write("Valitse minkä HEROn tiedot haluat nähdä ? ");

//Luetaan arvo muutetaan ja tallennetaan
Hero = int.Parse(Console.ReadLine());


Console.WriteLine();

for (int i = 0; i < 4; i++)
{
    Console.Write(nimet[i,Hero] + " " ); // Tulostetaan rivi kerrallaan
}
Console.WriteLine();






