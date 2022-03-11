// See https://aka.ms/new-console-template for more information

// Luodaan satunnaislukuolio "luku ja arvotaan luku väliltä 1-12
Random luku = new Random();
int arvottu = luku.Next(1, 12);

// Tulostetaan ohjeistus
Console.Write(" Arvaa luku väliltä 1-12 (max 5 yritystä) ? ");
Console.WriteLine();

//kysyy arvauksen ja tulostaa sen mukaisen tekstin silmukan avulla
for(int i = 1; i<= 5; i++)
{
    //Arvauksen kysely ja luku
    Console.Write(i + ". yritys: Arvaa luku ? ");
    int arvaus = int.Parse(Console.ReadLine());
    Console.WriteLine();

    //Tulostettavan tekstin valinta
    if (arvottu == arvaus)
    {
        Console.WriteLine("Onneksi olkoon, arvasit oikein !");
        i = 5; // Tämä jotta ohjelma ei kysele enää lukua (riittää että isompi kuin 4)
    }
    else
    {
        Console.WriteLine("Arvasit väärin !");
        Console.WriteLine();
        if (i == 5) // tämä jos oli 5 arvaus
        {
            Console.WriteLine(" Se oli viimeinen yrotyksesi!");
            Console.WriteLine();
            Console.WriteLine("Oikea vastaus oli " + arvottu);
        }
    }
    
}