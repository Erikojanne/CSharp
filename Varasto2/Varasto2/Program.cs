﻿// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System.Text.Json.Serialization;

class Varasto

{

    //kentät

    private double paino;

    private string nimi;

    private int maara;
    //private int massa;
    private int hyllyssa;
    private int eihyllyssa;
   // public int laskuri;
    public static int Isolaskuri = 0;

    //metodit

    public double painonmuutos()

    {
        Console.Write("Painonmuutos: ");
        paino = paino+ double.Parse(Console.ReadLine());
        return paino;

    }

    public string nimenmuutos()

    {

        Console.Write("Nimenmuutos: ");
        nimi = Console.ReadLine();
        Varasto.Isolaskuri++;
        return "" + nimi;

    }

    public int maaramuutos()

    {
        Console.Write("Määrämuutos: ");
        maara = maara-int.Parse(Console.ReadLine());
        return maara;

    }
    public int poishyllysta()
    {
        Console.Write("Poishyllystä: ");
        eihyllyssa =eihyllyssa+ int.Parse(Console.ReadLine());
        //maara = maara-1;
        return eihyllyssa;
    }
    public int palautahyllyyn()
    {
        Console.Write("Palautahyllyyn: ");
        hyllyssa =hyllyssa- int.Parse(Console.ReadLine());
        //maara = maara+1;
        return hyllyssa;
    }
   


    //Oletuskonstruktori

    public Varasto()

    {

        paino = paino;

        maara = maara;

        nimi = nimi;
        hyllyssa = hyllyssa;
        eihyllyssa = eihyllyssa;
        Isolaskuri++;
    }

    //ylikuormitettu konstruktori()

    /*  public Varasto(int u_paino, int u_maara, string u_nimi, int u_hyllyssa)
      {
          paino = u_paino;
          maara = u_maara;
          nimi = u_nimi;
          hyllyssa = u_hyllyssa;

          Isolaskuri = Isolaskuri++;
      }*/

    //ominaisuusfunktio

    public double varastopaino //{ get; set; }

     {
         set { paino = value; }
         get { return paino; }
     }

    public int varastomaara //{ get; set; }

    {
        set { maara = value; }
        get { return maara; }
    }

    public string varastonimi //{ get; set; }

    {
        set { nimi = value; }
        get { return nimi; }
    }
    public int varastohyllyssa //{ get; set; }
    {
        set { hyllyssa = value; }
        get { return hyllyssa; }
    }


    static void Main(string[] args)

    {

        //luodaan olio


        ///////////////////////////////////////////////////////
        /* Varasto tuote = new Varasto */
        int maara, hyllyssa, eihyllyssa;
        string nimi; double paino;
       /* Console.Write("Anna paino: ");
        paino = double.Parse(Console.ReadLine());
        Console.Write("Anna määrä: ");
        maara = int.Parse(Console.ReadLine());
        Console.Write("Anna nimi: ");
        nimi = Console.ReadLine();
        Console.Write("Anna hyllymäärä: ");
        hyllyssa = int.Parse(Console.ReadLine());
        Console.Write("Pois hyllystä: ");
        eihyllyssa = int.Parse(Console.ReadLine());
        Console.WriteLine();
        Console.WriteLine("Paino: " + paino + " / Määrä: " + maara + " / Nimi: " + nimi + " / Hyllyssä: " + hyllyssa +
            " / Eihyllyssä: " + eihyllyssa + " / Laskuri: " + Varasto.Isolaskuri);
        Console.WriteLine();*/
        ////////////////////////////////////////////////////////
        ///

        Varasto tallenne = new Varasto();

        Console.Write("Varastopaino: ");
        tallenne.varastopaino = double.Parse(Console.ReadLine());
        Console.Write("Varastomäärä: ");
        tallenne.varastomaara = int.Parse(Console.ReadLine());
        Console.Write("Varastonimi: ");
        tallenne.varastonimi = Console.ReadLine();
        Console.Write("Varastohyllyssä: ");
        tallenne.varastohyllyssa = int.Parse(Console.ReadLine());
        Console.WriteLine("Varastopaino: " + tallenne.varastopaino+ " / Varastomäärä: " + tallenne.varastomaara+ " / Varastonimi: "+ tallenne.varastonimi+ " / Varastohyllyssä: "+tallenne.varastohyllyssa+ 
            " / Laskuri: " + Varasto.Isolaskuri);
        Console.WriteLine();

        paino = tallenne.painonmuutos();
        maara = tallenne.maaramuutos();
        nimi = tallenne.nimenmuutos();
        eihyllyssa = tallenne.poishyllysta();
        hyllyssa = tallenne.palautahyllyyn();
        
        
        Console.WriteLine("Painonmuutos: " + paino + "Kg" + " / Määrämuutos: " + maara + " / Nimimuutos: " + nimi + " / Poishyllystä: " + eihyllyssa +
            " / Palautahyllyyn: " + hyllyssa + " / Laskuri: " + Varasto.Isolaskuri);
    }

}
