// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Varasto

{

    //kentät

    private string paino;

    private string nimi;

    private int maara;

    private int hyllyssa, eihyllyssa;
    private int laskuri;
    public static int Isolaskuri = 0;

    //metodit

    public string painonmuutos()

    {

        Console.WriteLine(" Erapaiva metodi ");

        return paino;

    }

    public string nimenmuutos()

    {

        Console.WriteLine(" Nimi metodi ");

        return nimi;

    }

    public int maaramuutos()

    {

        Console.WriteLine(" Sivumäärä metodi ");

        return maara;

    }
    public int poishyllysta()
    {
        Console.WriteLine(" Sivumäärä metodi ");
        return eihyllyssa;
    }
    public int palautahyllyyn()
    {
        Console.WriteLine(" Sivumäärä metodi ");
        return hyllyssa;
    }

    //Oletuskonstruktori

    public Varasto()

    {

        paino = "";

        maara = 0;

        nimi = "";

        hyllyssa = 0;

        eihyllyssa = 0;
        Isolaskuri++;
    }

    //ylikuormitettu konstruktori

    public Varasto(string u_paino, int u_maara, string u_nimi, int u_hyllyssa, int u_eihyllyssa)

    {

        paino = u_paino;

        maara = u_maara;

        nimi = u_nimi;

        hyllyssa = u_hyllyssa;

        eihyllyssa = u_eihyllyssa;
        Isolaskuri++;
    }

    //ominaisuusfunktio

    private string u_paino

    {
        set { paino = value; }
        get { return paino; }
    }

    private int u_maara

    {
        set { maara = value; }
        get { return maara; }
    }

    private string u_nimi

    {
        set { nimi = value; }
        get { return nimi; }
    }
    private int u_hyllyssa
    {

        set { hyllyssa = value; }
        get { return hyllyssa; }
    }

    private int u_eihyllyssa
    {
        set { eihyllyssa = value; }
        get { return eihyllyssa; }
    }
    
    




}



class Program

{

    static void Main(string[] args)
        
    {
        
        //luodaan erapaiva-olio

        //luodaan sivumaara-olio

        //luodaan nimi-olio

        int maara, hyllyssa, eihyllyssa;
        string nimi, paino;
        


        Console.Write("Anna paino: ");

        paino = Console.ReadLine();

        Console.Write("Anna määrä: ");

        maara = int.Parse(Console.ReadLine());

        Console.Write("Anna nimi: ");

        nimi = Console.ReadLine();

        Console.Write("Anna hylly määrä: ");

        hyllyssa = int.Parse(Console.ReadLine());
        Console.Write("Pois hyllystä: ");

        eihyllyssa = int.Parse(Console.ReadLine());

        Console.WriteLine();



        Varasto tallenne = new Varasto(paino, maara, nimi, hyllyssa, eihyllyssa);

        paino = tallenne.painonmuutos();

        maara = tallenne.maaramuutos();

        nimi = tallenne.nimenmuutos();
        hyllyssa = tallenne.palautahyllyyn();
        eihyllyssa = tallenne.poishyllysta();


        Console.WriteLine();



        Console.WriteLine("Paino: " + paino + " / Määrä: " + maara + " / Nimi: " + nimi + " / Hyllyssä: " + hyllyssa +  " / Eihyllyssä: " + eihyllyssa);



    }

}