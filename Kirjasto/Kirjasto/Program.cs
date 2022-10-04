// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

class Kirjasto
{
    //kentät
    private int erapaiva;
    private string nimi;
    private int sivumaara;

    //metodit
    public int Erapaiva()
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
        Console.WriteLine(" Sivumaara metodi ");
        return sivumaara;
    }
    //Oletuskonstruktori
    public Kirjasto()
    {
        erapaiva = 0;
        sivumaara = 0;
        nimi = "";
    }
    //ylikuormitettu konstruktori
    public Kirjasto(int u_erapaiva, int u_sivumaara, string u_nimi)
    {
        erapaiva = u_erapaiva;
        sivumaara = u_sivumaara;
        nimi = u_nimi;
    }
    //ominaisuusfunktio
    private int u_erapaiva
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
        set {nimi = value;}
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
        int erapaiva, sivumaara;
        string nimi;
        
       /* Console.Write("Anna eräpäivä: ");
        erapaiva = int.Parse(Console.ReadLine());
        Console.Write("Anna sivumäära: ");
        sivumaara = int.Parse(Console.ReadLine());
        Console.Write("Anna nimi: ");
        nimi = Console.ReadLine();*/

        Kirjasto tallenne = new Kirjasto();
        erapaiva = tallenne.Erapaiva();
        sivumaara = tallenne.Sivumaara();
        nimi = tallenne.Nimi();

        Console.WriteLine("Eräpäivä:  " + erapaiva + " Sivumäärä: " + sivumaara + " Nimi: " + nimi);

    }
}




