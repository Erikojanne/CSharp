// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Kirjasto

{

    //kentät

    private string erapaiva;

    private string nimi;

    private int sivumaara;



    //metodit

    public string Erapaiva()

    {

        Console.WriteLine(" Erapaiva metodi ");

        return erapaiva;

    }

    public string Nimi()

    {

        Console.WriteLine(" Nimi metodi ");

        return nimi;

    }

    public int Sivumaara()

    {

        Console.WriteLine(" Sivumäärä metodi ");

        return sivumaara;

    }

    //Oletuskonstruktori

    public Kirjasto()

    {

        erapaiva = "";

        sivumaara = 0;

        nimi = "";

    }

    //ylikuormitettu konstruktori

    public Kirjasto(string u_erapaiva, int u_sivumaara, string u_nimi)

    {

        erapaiva = u_erapaiva;

        sivumaara = u_sivumaara;

        nimi = u_nimi;

    }

    //ominaisuusfunktio

    private string u_erapaiva

    {

        set { erapaiva = value; }

        get { return erapaiva; }



    }



    private int u_sivumaara

    {

        set { sivumaara = value; }

        get { return sivumaara; }



    }

    private string u_nimi

    {

        set { nimi = value; }

        get { return nimi; }



    }







}



class Program

{

    static void Main(string[] args)

    {

        //luodaan erapaiva-olio

        //luodaan sivumaara-olio

        //luodaan nimi-olio

        int u_sivumaara;

        string u_erapaiva, u_nimi;



        Console.Write("Anna eräpäivä: ");

        u_erapaiva = Console.ReadLine();

        Console.Write("Anna sivumäära: ");

        u_sivumaara = int.Parse(Console.ReadLine());

        Console.Write("Anna nimi: ");

        u_nimi = Console.ReadLine();



        Console.WriteLine();



        Kirjasto tallenne = new Kirjasto(u_erapaiva, u_sivumaara, u_nimi);

        u_erapaiva = tallenne.Erapaiva();

        u_sivumaara = tallenne.Sivumaara();

        u_nimi = tallenne.Nimi();



        Console.WriteLine();



        Console.WriteLine("Eräpäivä: " + u_erapaiva + " / Sivumäärä: " + u_sivumaara + " / Nimi: " + u_nimi);



    }

}