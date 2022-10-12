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
        return paino;

    }

    public string nimenmuutos()

    {

        return nimi;
    }

    public int maaramuutos()

    {

        return maara;

    }
    public int poishyllysta()
    {
       
        return eihyllyssa;
    }
    public int palautahyllyyn()
    {
        
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
        
        //luodaan olio

        //luodaan olio

        //luodaan olio

        int u_maara, u_hyllyssa, u_eihyllyssa;
        string u_nimi, u_paino;
        


        Console.Write("Anna paino: ");

        u_paino = Console.ReadLine();

        Console.Write("Anna määrä: ");

        u_maara = int.Parse(Console.ReadLine());

        Console.Write("Anna nimi: ");

        u_nimi = Console.ReadLine();

        Console.Write("Anna hylly määrä: ");

        u_hyllyssa = int.Parse(Console.ReadLine());
        Console.Write("Pois hyllystä: ");

        u_eihyllyssa = int.Parse(Console.ReadLine());

        Console.WriteLine();



        Varasto tallenne = new Varasto(u_paino, u_maara, u_nimi, u_hyllyssa, u_eihyllyssa);

        u_paino = tallenne.painonmuutos();

        u_maara = tallenne.maaramuutos();

        u_nimi = tallenne.nimenmuutos();
        u_hyllyssa = tallenne.palautahyllyyn();
        u_eihyllyssa = tallenne.poishyllysta();
      

        Console.WriteLine();
        
        Console.WriteLine("Paino: " + u_paino +  " / Määrä: " + u_maara + " / Nimi: " + u_nimi + " / Hyllyssä: " + u_hyllyssa +  " / Eihyllyssä: " + u_eihyllyssa + " / Jotain: " + Varasto.Isolaskuri);

       // Console.WriteLine(+ Varasto.Isolaskuri);

    }

}