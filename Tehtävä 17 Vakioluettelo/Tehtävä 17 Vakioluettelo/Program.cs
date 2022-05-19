// See https://aka.ms/new-console-template for more information
using System;
namespace Vakioluettelo
{
    class Program
    {
        public enum Question
        {
            syotaNimesi = 1,
            lisaaIka = 2,
            naytaNimi = 3,
            naytaIka = 4,
            poistuOhjelmasta = 5       
        }



        static void Main(string[] args)
        
           
        {
            Console.WriteLine("Tervetuloa ohjelmaan. Siirry valikossa valitsemalla numero. ");
            Console.WriteLine("1.   Syötänimesi   ");
            Console.WriteLine("2.   Syötä ikäsi.  ");
            Console.WriteLine("3.   Näytä nimesi. ");
            Console.WriteLine("4.   Näytä ikäsi.  ");
            Console.WriteLine("5.   Poistu ohjelmasta.  ");
            //int luku;
            //string nimi;
            

                Console.Write("> ");
                int vakio = int.Parse(Console.ReadLine());
            
                switch (vakio)
                {
                    case (int)Question.syotaNimesi:
                        Console.Write("Syötä nimesi : " );
                    Console.ReadLine(); //ja arvon tallennus muuttujaan
                        break;
                    case (int)Question.lisaaIka:
                        Console.Write("Syötä ikäsi. ");
                    Console.ReadLine(); //ja arvon tallennus muuttujaan
                        break;
                    case (int)Question.naytaNimi:
                        Console.WriteLine("Nimesi on. " + vakio );
                    Console.ReadLine();
                        break;
                    case (int)Question.naytaIka:
                        Console.WriteLine("Ikäsi on. " + vakio);
                    //Console.ReadLine();
                        break;
                    case (int)Question.poistuOhjelmasta:
                        Console.Write("Antamasi luku ei ole valikossa..... ");
                    Console.ReadLine();
                        break;
                    //default:
                        // code block
                        //break;
                }
            
            
        }


        
        
        

    }
   
}


